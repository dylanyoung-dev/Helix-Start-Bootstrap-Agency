using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Members.Models
{
    [SitecoreType(TemplateId = "")]
    public interface IMemberCollection
    {
        [SitecoreField]
        IEnumerable<IMember> Members { get; set; }
    }
}