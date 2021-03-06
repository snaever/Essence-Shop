//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IBanner
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Image
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerImage(this); }
		}

		///<summary>
		/// CTA Button
		///</summary>
		[ImplementPropertyType("cTAButton")]
		public string CTabutton
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetCTabutton(this); }
		}

		///<summary>
		/// CTA Button Link
		///</summary>
		[ImplementPropertyType("cTAButtonLink")]
		public string CTabuttonLink
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetCTabuttonLink(this); }
		}

		///<summary>
		/// Large Title
		///</summary>
		[ImplementPropertyType("largeTitle")]
		public string LargeTitle
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetLargeTitle(this); }
		}

		///<summary>
		/// Small Heading
		///</summary>
		[ImplementPropertyType("smallheading")]
		public string Smallheading
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetSmallheading(this); }
		}
	}
}
