using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helix.Feature.Navigation.Models
{
    public partial interface INavigation
    {
        [SitecoreChildren]
        IEnumerable<INavigationItem> Links { get; set; }
    }
}
