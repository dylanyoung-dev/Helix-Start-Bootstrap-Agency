using Sitecore.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace Helix.Foundation.Urls.Configuration
{
    public class LinkManager : LinkProvider
    {
        public override string GetItemUrl(Item item, UrlOptions options)
        {
            return base.GetItemUrl(item, options);
        }
    }
}