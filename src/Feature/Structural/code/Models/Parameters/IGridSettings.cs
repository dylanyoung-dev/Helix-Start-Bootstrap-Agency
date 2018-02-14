using Glass.Mapper.Sc.Configuration.Attributes;
using Helix.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Structural.Models.Parameters
{
    [SitecoreType(TemplateId = Constants.Parameters.GridSettings.TemplateIdString)]
    public interface IGridSettings : IGlassBase
    {
        [SitecoreField]
        string ElementId { get; set; }

        [SitecoreField]
        string Classes { get; set; }
    }
}