using Helix.Feature.Navigation.Models;
using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Navigation.Controllers
{
    public class NavigationController : BaseController
    {
        public ActionResult MainNavigation()
        {
            INavigation navigationDatasource = this.GetDataSourceItem<INavigation>();

            return View(navigationDatasource);
        }

        public ActionResult FooterNavigation()
        {
            INavigation navigationDatasource = this.GetDataSourceItem<INavigation>();

            return View(navigationDatasource);
        }
    }
}