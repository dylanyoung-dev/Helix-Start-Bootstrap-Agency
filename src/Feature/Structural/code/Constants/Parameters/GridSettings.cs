using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Structural.Constants.Parameters
{
    public class GridSettings
    {
        // Templates
        public const string TemplateIdString = "{A6D260BE-E659-46BD-9F28-19D198E962C2}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string ElementIdName = "ElementId";
        public readonly ID ElementId = new ID("");

        public const string ClassesName = "Classes";
        public readonly ID ClassesId = new ID("");
    }
}