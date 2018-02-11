using Glass.Mapper.Sc.Configuration.Attributes;
using Helix.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Feature.Metadata.Models
{
    [SitecoreType]
    public interface IMetadata : IGlassBase
    {
        [SitecoreField]
        string MetaTitle { get; set; }

        [SitecoreField]
        string MetaDescription { get; set; }

        [SitecoreField]
        string MetaKeywords { get; set; }

        [SitecoreField]
        Boolean NoIndex { get; set; }
    }
}
