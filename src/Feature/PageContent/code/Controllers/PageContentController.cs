using Helix.Feature.PageContent.Models;
using Helix.Foundation.ORM.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helix.Feature.PageContent.Controllers
{
    public class PageContentController : BaseController
    {

        public ActionResult Hero()
        {
            IHero hero = this.GetDataSourceItem<IHero>();

            if (hero == null)
                return View();

            return View(hero);
        }

        public ActionResult SectionHeader()
        {
            ISectionHeader header = this.GetDataSourceItem<ISectionHeader>();

            if (header == null)
                return new EmptyResult();

            return View(header);
        }
    }
}