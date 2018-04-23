using Helix.Feature.Members.Models;
using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Members.Controllers
{
    public class MembersController : BaseController
    {
        public ActionResult Listing()
        {
            IMemberCollection dataSourceCollection = this.GetDataSourceItem<IMemberCollection>();

            return View(dataSourceCollection);
        }
    }
}