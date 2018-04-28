
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ReSharper disable All


namespace Helix.Feature.Navigation.Models
{
    using System;
	using System.CodeDom.Compiler;
	using System.Collections.Generic;
    using Helix.Foundation.ORM.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Fields;

	/// <summary>Controls the appearance of the inheriting template in site navigation.</summary>
	///[RepresentsSitecoreTemplateAttribute("{23b12a9f-5c28-4ca8-9777-61b4a1cbf87a}", "", "Feature.Navigation")]
    [SitecoreType(TemplateId = Helix.Feature.Navigation.Templates.Navigation.TemplateIdString)]
	public partial interface INavigation : IGlassBase
	{
		
		/// <summary>Represents the  field (94135a89-0cf8-4b10-9c17-024957cffe40).</summary>
        [SitecoreField(FieldName = Helix.Feature.Navigation.Templates.Navigation.Fields.LinkClasses_FieldName)]
		string LinkClasses { get; }

		/// <summary>Represents the  field (e8d6913a-ca8e-47bc-9978-4c1d2c325b21).</summary>
        [SitecoreField(FieldName = Helix.Feature.Navigation.Templates.Navigation.Fields.WrapperClassId_FieldName)]
		string WrapperClassId { get; }

		/// <summary>Represents the  field (1dfef422-2120-4b35-b900-b3a9e728946c).</summary>
        [SitecoreField(FieldName = Helix.Feature.Navigation.Templates.Navigation.Fields.WrapperClasses_FieldName)]
		string WrapperClasses { get; }

		/// <summary>Represents the  field (17bca445-4bae-4709-8a4d-155232a76174).</summary>
        [SitecoreField(FieldName = Helix.Feature.Navigation.Templates.Navigation.Fields.WrapperTag_FieldName)]
		string WrapperTag { get; }

	}

}

namespace Helix.Feature.Navigation.Models
{
    using System;
	using System.CodeDom.Compiler;
	using System.Collections.Generic;
    using Helix.Foundation.ORM.Models;
    using Glass.Mapper.Sc.Configuration.Attributes;
    using Glass.Mapper.Sc.Fields;

	/// <summary>Controls the appearance of the inheriting template in site navigation.</summary>
	///[RepresentsSitecoreTemplateAttribute("{955bac9c-13c6-4258-9a26-376da8f30592}", "", "Feature.Navigation")]
    [SitecoreType(TemplateId = Helix.Feature.Navigation.Templates.NavigationItem.TemplateIdString)]
	public partial interface INavigationItem : IGlassBase
	{
		
		/// <summary>Represents the  field (e22f0bb7-afcf-4d51-89c6-8df0ed2c9cdf).</summary>
        [SitecoreField(FieldName = Helix.Feature.Navigation.Templates.NavigationItem.Fields.Link_FieldName)]
		Link Link { get; }

		/// <summary>Represents the  field (b2c838f2-e270-425d-a06a-9cf94b565ecb).</summary>
        [SitecoreField(FieldName = Helix.Feature.Navigation.Templates.NavigationItem.Fields.Title_FieldName)]
		string Title { get; }

	}

}




namespace Helix.Feature.Navigation
{
	using global::Sitecore.Data;

	public struct Templates
	{
		
		public struct Navigation
		{
            public const string TemplateIdString = "23b12a9f-5c28-4ca8-9777-61b4a1cbf87a";
			public static readonly ID TemplateId = new ID(TemplateIdString);

			
			public struct Fields
			{
				public static readonly ID LinkClasses = new ID("94135a89-0cf8-4b10-9c17-024957cffe40");
				public const string LinkClasses_FieldName = "LinkClasses";

				public static readonly ID WrapperClassId = new ID("e8d6913a-ca8e-47bc-9978-4c1d2c325b21");
				public const string WrapperClassId_FieldName = "WrapperClassId";

				public static readonly ID WrapperClasses = new ID("1dfef422-2120-4b35-b900-b3a9e728946c");
				public const string WrapperClasses_FieldName = "WrapperClasses";

				public static readonly ID WrapperTag = new ID("17bca445-4bae-4709-8a4d-155232a76174");
				public const string WrapperTag_FieldName = "WrapperTag";

			}
		}

		public struct NavigationItem
		{
            public const string TemplateIdString = "955bac9c-13c6-4258-9a26-376da8f30592";
			public static readonly ID TemplateId = new ID(TemplateIdString);

			
			public struct Fields
			{
				public static readonly ID Link = new ID("e22f0bb7-afcf-4d51-89c6-8df0ed2c9cdf");
				public const string Link_FieldName = "Link";

				public static readonly ID Title = new ID("b2c838f2-e270-425d-a06a-9cf94b565ecb");
				public const string Title_FieldName = "Title";

			}
		}

	}
}

// Helix.Feature.Navigation.Navigation (/sitecore/templates/feature/navigation/_Navigation 23b12a9f-5c28-4ca8-9777-61b4a1cbf87a)
	// LinkClasses (94135a89-0cf8-4b10-9c17-024957cffe40)
		// Type: Single-Line Text
		// Section: Navigation Information
		// Sort Order: 400
		// Source: 
	// WrapperClassId (e8d6913a-ca8e-47bc-9978-4c1d2c325b21)
		// Type: Single-Line Text
		// Section: Navigation Information
		// Sort Order: 200
		// Source: 
	// WrapperClasses (1dfef422-2120-4b35-b900-b3a9e728946c)
		// Type: Single-Line Text
		// Section: Navigation Information
		// Sort Order: 300
		// Source: 
	// WrapperTag (17bca445-4bae-4709-8a4d-155232a76174)
		// Type: Single-Line Text
		// Section: Navigation Information
		// Sort Order: 100
		// Source: 

// Helix.Feature.Navigation.NavigationItem (/sitecore/templates/feature/navigation/_NavigationItem 955bac9c-13c6-4258-9a26-376da8f30592)
	// Link (e22f0bb7-afcf-4d51-89c6-8df0ed2c9cdf)
		// Type: General Link
		// Section: Navigation Information
		// Sort Order: 200
		// Source: 
	// Title (b2c838f2-e270-425d-a06a-9cf94b565ecb)
		// Type: Single-Line Text
		// Section: Navigation Information
		// Sort Order: 100
		// Source: 

