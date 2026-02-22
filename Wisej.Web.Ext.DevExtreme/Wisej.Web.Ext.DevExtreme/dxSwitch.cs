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
	/// The Switch is a widget that can be in two states: "On" and "Off".
	/// </summary>
	public class dxSwitch : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxSwitch"/> class.
		/// </summary>
		public dxSwitch() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxSwitch"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxSwitch(object options) : base("dxSwitch", options)
		{
			this.WiredEvents = new[] {
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
		/// Specifies the checked state of the Switch
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public bool Checked
		{
			get { return this.Options.value ?? false; }
			set { this.Options.value = value; }
		}
	}
}
