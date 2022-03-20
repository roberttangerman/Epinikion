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
	// Mixin Content Type with alias "showControls"
	/// <summary>Show Controls</summary>
	public partial interface IShowControls : IPublishedContent
	{
		/// <summary>City</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		string City { get; }

		/// <summary>Country</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		string Country { get; }

		/// <summary>Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		global::System.DateTime Date { get; }

		/// <summary>Tickets link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		global::Umbraco.Web.Models.Link TicketsLink { get; }

		/// <summary>Venue link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		global::Umbraco.Web.Models.Link VenueLink { get; }

		/// <summary>Venue name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		string VenueName { get; }
	}

	/// <summary>Show Controls</summary>
	[PublishedModel("showControls")]
	public partial class ShowControls : PublishedContentModel, IShowControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public new const string ModelTypeAlias = "showControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ShowControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ShowControls(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// City: Enter the city of the show
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("city")]
		public virtual string City => GetCity(this);

		/// <summary>Static getter for City</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static string GetCity(IShowControls that) => that.Value<string>("city");

		///<summary>
		/// Country: Enter the country code (for exampe: NL)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("country")]
		public virtual string Country => GetCountry(this);

		/// <summary>Static getter for Country</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static string GetCountry(IShowControls that) => that.Value<string>("country");

		///<summary>
		/// Date: Select the date of the show
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("date")]
		public virtual global::System.DateTime Date => GetDate(this);

		/// <summary>Static getter for Date</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static global::System.DateTime GetDate(IShowControls that) => that.Value<global::System.DateTime>("date");

		///<summary>
		/// Tickets link: Enter the link to the tickets
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("ticketsLink")]
		public virtual global::Umbraco.Web.Models.Link TicketsLink => GetTicketsLink(this);

		/// <summary>Static getter for Tickets link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static global::Umbraco.Web.Models.Link GetTicketsLink(IShowControls that) => that.Value<global::Umbraco.Web.Models.Link>("ticketsLink");

		///<summary>
		/// Venue link: Enter the link to the venue
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("venueLink")]
		public virtual global::Umbraco.Web.Models.Link VenueLink => GetVenueLink(this);

		/// <summary>Static getter for Venue link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static global::Umbraco.Web.Models.Link GetVenueLink(IShowControls that) => that.Value<global::Umbraco.Web.Models.Link>("venueLink");

		///<summary>
		/// Venue name: Enter the name of the venue
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		[ImplementPropertyType("venueName")]
		public virtual string VenueName => GetVenueName(this);

		/// <summary>Static getter for Venue name</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.2")]
		public static string GetVenueName(IShowControls that) => that.Value<string>("venueName");
	}
}
