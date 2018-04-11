using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Members.Constants
{
    public class Member
    {
        // Templates
        public const string TemplateIdString = "{6CD1C785-C4D2-4C0A-A34C-BF4E6F01CB16}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string NameName = "Name";
        public readonly ID NameId = new ID("{2BD94AC0-F867-440F-A908-88B686F5A3EB}");

        public const string PositionName = "Position";
        public readonly ID PositionId = new ID("{65F99714-E05D-489C-A939-70B31F3A0616}");

        public const string TwitterUrlName = "TwitterUrl";
        public readonly ID TwitterUrlId = new ID("{A4D04CF8-F6CA-4606-AF15-4D2E2DCFE2CD}");

        public const string FacebookUrlName = "FacebookUrl";
        public readonly ID FacebookUrlId = new ID("{34D9F40C-8F1A-4129-8E00-763B4C088DE5}");

        public const string LinkedInUrlName = "LinkedInUrl";
        public readonly ID LinkedInUrlId = new ID("{9E414380-F718-4CA8-8CD3-728193A3D0DD}");

        public const string ThumbnailName = "Thumbnail";
        public readonly ID ThumbnailId = new ID("{97299C06-4BCE-4BA5-9781-4C61EDC2CA9D}");
    }
}