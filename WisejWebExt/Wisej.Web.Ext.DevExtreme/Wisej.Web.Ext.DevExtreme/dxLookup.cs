///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

using System.ComponentModel;

namespace Wisej.Web.Ext.DevExtreme
{
	/// <summary>
	/// The Lookup is a widget that allows an end user to search for an item in a collection shown in a drop-down menu.
	/// </summary>
	public class dxLookup : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxLookup"/> class.
		/// </summary>
		public dxLookup() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxLookup"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxLookup(object options) : base("dxLookup", options)
		{
			this.WiredEvents = new[] {
				"scroll",
				"itemClick",
				"pullRefresh",
				"pageLoading",
				"valueChanged",
				"selectionChanged"
			};
		}

		/// <summary>
		/// Specifies the currently selected value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Value
		{
			get { return this.Options.value ?? ""; }
			set { this.Options.value = value ?? ""; }
		}
	}
}
