using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.Metadata.Controllers
{
    public class MetadataController : BaseController
    {
        public ActionResult RenderMetadata()
        {
            return View();
        }
    }
}