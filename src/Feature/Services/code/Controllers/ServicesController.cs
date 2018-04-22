using Helix.Feature.Services.Models;
using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Services.Controllers
{
    public class ServicesController : BaseController
    {
        public ActionResult Listing()
        {
            IServiceCollection datasourceCollection = this.GetDataSourceItem<IServiceCollection>();

            return View(datasourceCollection);
        }
    }
}