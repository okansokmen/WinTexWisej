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
	/// The NavBar is a widget that navigates the application views.
	/// </summary>
	public class dxNavBar : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxNavBar"/> class.
		/// </summary>
		public dxNavBar() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxNavBar"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxNavBar(object options) : base("dxNavBar", options)
		{
			this.WiredEvents = new[] {
				"itemHold",
				"itemClick",
				"optionChanged",
				"selectionChanged",
			};
		}

		/// <summary>
		/// The selected item object.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string SelectedItem
		{
			get { return this.Options.selectedItem ?? ""; }
			set { this.Options.selectedItem = value ?? ""; }
		}
	}
}
