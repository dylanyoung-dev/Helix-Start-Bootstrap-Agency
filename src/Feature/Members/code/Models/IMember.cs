using Glass.Mapper.Sc.Configuration.Attributes;
using Helix.Foundation.ORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Helix.Feature.Members.Models
{
    [SitecoreType(TemplateId = Constants.Member.TemplateIdString)]
    public interface IMember : IGlassBase
    {
        [SitecoreField(FieldName = Constants.Member.NameName)]
        string Name { get; set; }

        [SitecoreField(FieldName = Constants.Member.PositionName)]
        string Position { get; set; }

        [SitecoreField(FieldName = Constants.Member.TwitterUrlName)]
        string TwitterUrl { get; set; }

        [SitecoreField(FieldName = Constants.Member.FacebookUrlName)]
        string FacebookUrl { get; set; }

        [SitecoreField(FieldName = Constants.Member.LinkedInUrlName)]
        string LinkedInUrl { get; set; }

        [SitecoreField(FieldName = Constants.Member.ThumbnailName)]
        Image Thumbnail { get; set; }
    }
}