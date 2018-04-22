using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Services.Constants
{
    public class ServiceCollection
    {
        // Templates
        public const string TemplateIdString = "{80CC9251-6A08-4008-A18F-5EEC17105A7A}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string ServicesName = "Services";
        public readonly ID ServicesId = new ID("{ABC6E742-74A9-41B2-8B1F-BC2E2956CDFC}");
    }
}