using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Projects.Models.Interface
{
    public interface IProjectCollection
    {
        IEnumerable<IProject> Projects { get; set; }
    }
}