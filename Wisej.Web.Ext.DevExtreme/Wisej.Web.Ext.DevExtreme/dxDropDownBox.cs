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
	/// The DropDownBox is a widget that consists of a text field, which displays the current value, and a drop-down field, which can contain any UI element.
	/// </summary>
	public class dxDropDownBox : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxDropDownBox"/> class.
		/// </summary>
		public dxDropDownBox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxDropDownBox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxDropDownBox(object options) : base("dxDropDownBox", options)
		{
			this.WiredEvents = new[] {
				"cut",
				"input",
				"change",
				"closed",
				"keyPress",
				"enterKey",
				"valueChanged",
				"optionChanged"
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
		/// Specifies the selected item in the DropDownBox.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Value
		{
			get { return this.Options.text ?? ""; }
			set { this.Options.text = value ?? ""; }
		}
	}
}
