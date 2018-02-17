using Glass.Mapper.Sc.Configuration.Attributes;
using Helix.Feature.PageContent.Constants;
using Helix.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Feature.PageContent.Models
{
    [SitecoreType(TemplateId = SectionHeader.TemplateIdString)]
    public interface ISectionHeader : IGlassBase
    {
        [SitecoreField(FieldName = SectionHeader.TitleName)]
        string Title { get; set; }

        [SitecoreField(FieldName = SectionHeader.DescriptionName)]
        string Description { get; set; }
    }
}
