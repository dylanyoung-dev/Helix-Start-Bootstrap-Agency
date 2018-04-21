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
        public const string TemplateIdString = "{6C04B521-7BEA-438F-98F0-390BDF658704}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string ServicesName = "Title";
        public readonly ID ServicesId = new ID("{625A3008-6BC4-4AEC-AAB5-0198E90DD316}");
    }
}