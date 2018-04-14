using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Navigation.Models
{
    [SitecoreType(TemplateId = Constants.NavigationItem.TemplateIdString)]
    public interface INavigationItem
    {
        [SitecoreField(FieldName = Constants.NavigationItem.TitleName)]
        string Title { get; set; }

        [SitecoreField(FieldName = Constants.NavigationItem.LinkName)]
        Link Link { get; set; }
    }
}