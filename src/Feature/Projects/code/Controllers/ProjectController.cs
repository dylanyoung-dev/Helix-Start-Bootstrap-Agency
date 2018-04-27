using Helix.Feature.Projects.Models.Interface;
using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Projects.Controllers
{
    public class ProjectController : BaseController
    {
        public ActionResult Listing()
        {
            IProjectCollection datasource = this.GetDataSourceItem<IProjectCollection>();

            return View(datasource);
        }
    }
}