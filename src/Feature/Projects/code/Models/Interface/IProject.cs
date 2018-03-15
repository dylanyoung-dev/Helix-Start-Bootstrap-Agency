using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Helix.Feature.Projects.Models.Interface
{
    public interface IProject
    {
        [SitecoreField]
        string Name { get; set; }

        string Summary { get; set; }

        string FullText { get; set; }

        Image ThumbImage { get; set; }

        Image PrimaryImage { get; set; }
    }
}