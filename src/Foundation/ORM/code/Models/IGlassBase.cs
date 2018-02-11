using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Foundation.ORM.Models
{
    public interface IGlassBase
    {
        [SitecoreId]
        Guid Id { get; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        string Language { get; set; }
    }
}
