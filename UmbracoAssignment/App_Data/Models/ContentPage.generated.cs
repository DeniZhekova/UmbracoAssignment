//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.5.4
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
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Content Page</summary>
	[PublishedModel("contentPage")]
	public partial class ContentPage : PublishedContentModel, IContentBase, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new const string ModelTypeAlias = "contentPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentPage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Grid Layout
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("gridLayout")]
		public global::Newtonsoft.Json.Linq.JToken GridLayout => this.Value<global::Newtonsoft.Json.Linq.JToken>("gridLayout");

		///<summary>
		/// Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("bodyText")]
		public global::Newtonsoft.Json.Linq.JToken BodyText => global::Umbraco.Web.PublishedModels.ContentBase.GetBodyText(this);

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => global::Umbraco.Web.PublishedModels.ContentBase.GetPageTitle(this);

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("keywords")]
		public global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Web.PublishedModels.NavigationBase.GetKeywords(this);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription => global::Umbraco.Web.PublishedModels.NavigationBase.GetSeoMetaDescription(this);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.5.4")]
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide => global::Umbraco.Web.PublishedModels.NavigationBase.GetUmbracoNavihide(this);
	}
}
