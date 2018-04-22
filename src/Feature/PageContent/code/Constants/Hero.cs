using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.PageContent.Constants
{
    public class Hero
    {
        // Templates
        public const string TemplateIdString = "{059F8915-49A2-45DF-AE13-DEB58F60AE4B}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string LeadInTitleName = "LeadInTitle";
        public readonly ID LeadInTitleId = new ID("{C6EC5294-F154-4842-AAE4-131AA6BCCDBE}");

        public const string HeadingName = "HeaderDescription";
        public readonly ID HeadingId = new ID("{42581A24-37B1-4F71-B6D7-ACF88125580E}");

        public const string ButtonName = "Button";
        public readonly ID ButtonId = new ID("{951B21E4-450F-44F8-81DC-233B3FC9C548}");
    }
}