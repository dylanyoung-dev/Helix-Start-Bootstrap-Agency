using Helix.Feature.Metadata.Models;
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
            IMetadata meta = SitecoreContext.GetCurrentItem<IMetadata>();

            if (meta == null)
                return new EmptyResult();

            return View(meta);
        }
    }
}