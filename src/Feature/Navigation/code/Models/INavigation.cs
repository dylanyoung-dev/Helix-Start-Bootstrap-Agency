using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Feature.Navigation.Models
{
    [SitecoreType(TemplateId = Constants.Navigation.TemplateIdString)]
    public interface INavigation
    {
        [SitecoreChildren]
        IEnumerable<INavigationItem> Links { get; set; }
    }
}
