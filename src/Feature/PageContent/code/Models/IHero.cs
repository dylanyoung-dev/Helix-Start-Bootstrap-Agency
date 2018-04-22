using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.PageContent.Models
{
    [SitecoreType(TemplateId = Constants.Hero.TemplateIdString)]
    public interface IHero
    {
        [SitecoreField(FieldName = Constants.Hero.LeadInTitleName)]
        string LeadInTitle { get; set; }

        [SitecoreField(FieldName = Constants.Hero.HeadingName)]
        string Heading { get; set; }

        [SitecoreField(FieldName = Constants.Hero.ButtonName)]
        Link Button { get; set; }
    }
}