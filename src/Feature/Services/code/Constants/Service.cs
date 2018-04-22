using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Services.Constants
{
    public class Service
    {
        // Templates
        public const string TemplateIdString = "{6C04B521-7BEA-438F-98F0-390BDF658704}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string TitleName = "Title";
        public readonly ID TitleId = new ID("{625A3008-6BC4-4AEC-AAB5-0198E90DD316}");

        public const string SummaryName = "Summary";
        public readonly ID SummaryId = new ID("{BFEF580B-29A9-4272-92B5-BCBD6A2CC40E}");

        public const string ThumbnailName = "Thumbnail";
        public readonly ID ThumbnailId = new ID("{163077CE-3D6A-4C31-B186-0DF86977F56D}");
    }
}