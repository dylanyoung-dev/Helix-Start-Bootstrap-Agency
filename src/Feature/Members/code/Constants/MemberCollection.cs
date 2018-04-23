using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Members.Constants
{
    public class MemberCollection
    {
        // Templates
        public const string TemplateIdString = "{D7915809-474A-4F03-8EBE-6F0A1063E7F6}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string MembersName = "Members";
        public readonly ID MembersId = new ID("{94196FCE-A936-41D3-8A68-E1280A2CAA3E}");
    }
}