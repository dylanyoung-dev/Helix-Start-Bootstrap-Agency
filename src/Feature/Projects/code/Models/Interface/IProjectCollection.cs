using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Projects.Models.Interface
{
    [SitecoreType(TemplateId = Constants.ProjectCollection.TemplateIdString)]
    public interface IProjectCollection
    {
        [SitecoreField(FieldName = Constants.ProjectCollection.ProjectsName)]
        IEnumerable<IProject> Projects { get; set; }
    }
}