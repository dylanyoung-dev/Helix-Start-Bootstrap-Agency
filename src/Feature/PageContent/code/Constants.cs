using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.PageContent
{
    public class Constants
    {
        // Templates
        public const string TemplateIdString = "{0AEC13F0-984E-4C21-86F7-18BD23D4300B}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string TitleName = "SectionHeaderTitle";
        public readonly ID TitleId = new ID("{B3004AC2-1513-4134-ABED-B9BD55C45DF6}");

        public const string DescriptionName = "SectionHeaderDescription";
        public readonly ID DescriptionId = new ID("{8320BC26-E1FC-4DC2-9A5C-278C47AE4D03}");
    }
}