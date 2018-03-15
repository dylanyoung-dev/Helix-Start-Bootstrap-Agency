using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Projects.Constants
{
    public class ProjectCollection
    {
        // Templates
        public const string TemplateIdString = "{51E1374A-C4A6-45DB-B431-CD2A7C57C1C6}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string ProjectsName = "{13A331F7-E588-4768-B2AA-A140DE6335B6}";
        public readonly ID ProjectsId = new ID(ProjectsName);
    }
}