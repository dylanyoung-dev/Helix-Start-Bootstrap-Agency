using Helix.Feature.Structural.Models;
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
            IParametersTemplateGridSettings settings = this.GetRenderingParameters<IParametersTemplateGridSettings>();

            return View(settings);
        }

        public ActionResult Container()
        {
            IParametersTemplateGridSettings settings = this.GetRenderingParameters<IParametersTemplateGridSettings>();

            return View(settings);
        }
    }
}