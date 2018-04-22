using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helix.Feature.Metadata.Constants
{
    public class Metadata
    {
        // Templates
        public const string TemplateIdString = "{82A8EEC9-A4C6-48B3-9B43-7BC18DDD9E5E}";
        public readonly ID TemplateId = new ID(TemplateIdString);

        // Fields
        public const string MetaTitleName = "MetaTitle";
        public readonly ID MetaTitleId = new ID("{C55FD8C7-F030-40C0-83AB-C046244A7689}");

        public const string MetaDescriptionName = "MetaDescription";
        public readonly ID MetaDescriptionId = new ID("{1983A8F5-7D6B-45BE-8F9E-968E94C63753}");

        public const string MetaKeywordsName = "MetaKeywords";
        public readonly ID MetaKeywordId = new ID("{4536C633-7F18-445F-9BBF-71DA9ABA2D54}");

        public const string MetaNoIndexName = "MetaNoIndex";
        public readonly ID MetaNoIndexId = new ID("{864E298F-05C3-482F-8FBF-25B0D781F718}");
    }
}