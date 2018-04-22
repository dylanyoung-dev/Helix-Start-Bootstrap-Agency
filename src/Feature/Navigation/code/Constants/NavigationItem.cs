using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Navigation.Constants
{
    public class NavigationItem
    {
        // Templates
        public const string TemplateIdString = "{955BAC9C-13C6-4258-9A26-376DA8F30592}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string TitleName = "Title";
        public readonly ID TitleId = new ID("{B2C838F2-E270-425D-A06A-9CF94B565ECB}");

        public const string LinkName = "Link";
        public readonly ID LinkId = new ID("{E22F0BB7-AFCF-4D51-89C6-8DF0ED2C9CDF}");
    }
}