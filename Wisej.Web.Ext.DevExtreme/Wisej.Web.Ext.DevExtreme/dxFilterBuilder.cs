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
	/// The FilterBuilder widget allows a user to build complex filter expressions with an unlimited number of filter conditions using the UI.
	/// </summary>
	public class dxFilterBuilder : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxFilterBuilder"/> class.
		/// </summary>
		public dxFilterBuilder() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxFilterBuilder"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxFilterBuilder(object options) : base("dxFilterBuilder", options)
		{
			this.WiredEvents = new[] {
				"valueChanged",
				"editorPrepared",
				"editorPreparing",
			};
		}

		/// <summary>
		/// Not applicable for this control
		/// </summary>
		[Browsable(false)]
		[EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string Text { get => base.Text; set => base.Text = value; }

		/// <summary>
		/// Specifies the filter
		/// </summary>
		public string Value
		{
			get { return this.Options.value ?? ""; }
			set { this.Options.value = value ?? ""; }
		}
	}
}
