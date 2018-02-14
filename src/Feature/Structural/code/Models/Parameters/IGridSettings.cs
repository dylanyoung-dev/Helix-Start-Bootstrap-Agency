using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Structural.Models.Parameters
{
    public interface IGridSettings
    {
        [SitecoreField]
        string ElementId { get; set; }

        [SitecoreField]
        string Classes { get; set; }
    }
}