using System;
using System.Text.RegularExpressions;
using Sitecore.Data.Items;
using Sitecore.Events;

namespace Helix.Foundation.Urls.Configuration
{
    public class ItemHandler
    {
        protected void OnItemAdded(object sender, EventArgs args)
        {
            Item item = (Item)Event.ExtractParameter(args, 0);

            SetFriendlyItemName(item);

        }

        protected void OnItemRenamed(object sender, EventArgs args)
        {
            Item item = (Item)Event.ExtractParameter(args, 0);

            SetFriendlyItemName(item);
        }

        private void SetFriendlyItemName(Item item)
        {
            string processedName = item.Name;
            processedName = Regex.Replace(processedName, @"[^0-9a-zA-Z -\\*]+", string.Empty).Replace(' ', '-').Replace("--", "-");

            if (item.Database.Name != "master" || !item.Paths.Path.StartsWith("/sitecore/content/")
                || (item.Appearance.DisplayName == item.DisplayName && item.Name == processedName.ToLower()))
                return;

            item.Editing.BeginEdit();
            try
            {
                item.Appearance.DisplayName = item.Name;
                item.Name = processedName.ToLower();
            }
            finally
            {
                item.Editing.EndEdit();
            }
        }
    }
}