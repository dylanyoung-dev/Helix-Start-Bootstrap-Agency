using Helix.Feature.Structural.Models.Parameters;
using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Structural.Controllers
{
    public class StructuralController : BaseController
    {

        public ActionResult Section()
        {
            IGridSettings settings = this.GetRenderingParameters<IGridSettings>();

            return View(settings);
        }

        public ActionResult Container()
        {
            IGridSettings settings = this.GetRenderingParameters<IGridSettings>();

            return View(settings);
        }
    }
}