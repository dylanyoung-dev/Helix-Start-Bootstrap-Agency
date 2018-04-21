using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Helix.Feature.Services.Models
{
    [SitecoreType(TemplateId = Constants.Service.TemplateIdString)]
    public interface IService
    {
        [SitecoreField(FieldName = Constants.Service.TitleName)]
        string Title { get; set; }

        [SitecoreField(FieldName = Constants.Service.SummaryName)]
        string Summary { get; set; }

        [SitecoreField(FieldName = Constants.Service.ThumbnailName)]
        Image Thumbnail { get; set; }
    }
}
