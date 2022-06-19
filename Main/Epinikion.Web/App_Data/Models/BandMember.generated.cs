//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.2
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
	/// <summary>Band Member</summary>
	[PublishedModel("bandMember")]
	public partial class BandMember : PublishedContentModel, IBandMemberControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public new const string ModelTypeAlias = "bandMember";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BandMember, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BandMember(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Instrument: Enter the instrument
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("instrument")]
		public virtual string Instrument => global::Umbraco.Web.PublishedModels.BandMemberControls.GetInstrument(this);

		///<summary>
		/// Introduction text: Enter an introduction text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("introductionText")]
		public virtual string IntroductionText => global::Umbraco.Web.PublishedModels.BandMemberControls.GetIntroductionText(this);

		///<summary>
		/// Member name: Enter the name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("memberName")]
		public virtual string MemberName => global::Umbraco.Web.PublishedModels.BandMemberControls.GetMemberName(this);

		///<summary>
		/// Nationality: Enter the nationality
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("nationality")]
		public virtual string Nationality => global::Umbraco.Web.PublishedModels.BandMemberControls.GetNationality(this);

		///<summary>
		/// Photo: Enter the photo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("photo")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops Photo => global::Umbraco.Web.PublishedModels.BandMemberControls.GetPhoto(this);
	}
}