using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Feature.Services.Models
{
    [SitecoreType(TemplateId = Constants.ServiceCollection.TemplateIdString)]
    public interface IServiceCollection
    {
        [SitecoreField(FieldName = Constants.ServiceCollection.ServicesName)]
        IEnumerable<IService> Services { get; set; }
    }
}
