using Glass.Mapper.Sc.Configuration.Attributes;
using Helix.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Feature.PageContent.Models
{
    [SitecoreType(TemplateId = Constants.TemplateIdString)]
    public interface ISectionHeader : IGlassBase
    {
        [SitecoreField(FieldName = Constants.TitleName)]
        string Title { get; set; }

        [SitecoreField(FieldName = Constants.DescriptionName)]
        string Description { get; set; }
    }
}
