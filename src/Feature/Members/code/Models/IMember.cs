using Glass.Mapper.Sc.Configuration.Attributes;
using Helix.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Members.Models
{
    [SitecoreType(TemplateId = Constants.Member.TemplateIdString)]
    public interface IMember : IGlassBase
    {
        [SitecoreField]
        string Name { get; set; }

        [SitecoreField]
        string Position { get; set; }

        [SitecoreField]
        string TwitterUrl { get; set; }

        [SitecoreField]
        string FacebookUrl { get; set; }

        [SitecoreField]
        string LinkedInUrl { get; set; }
    }
}