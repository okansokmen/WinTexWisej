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

namespace Wisej.Web.Ext.DevExtreme
{
	/// <summary>
	/// The DateBox is a widget that displays a date and time in a specified format, and enables a user to pick or type in the required date/time value.
	/// </summary>
	public class dxDropDownButton : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxDropDownButton"/> class.
		/// </summary>
		public dxDropDownButton() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxDropDownButton"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxDropDownButton(object options) : base("dxDropDownButton", options)
		{
			this.WiredEvents = new[] {
				"itemClick",
				"buttonClick"
			};
		}

		/// <summary>
		/// Specifies the text of the DropDownButton
		/// </summary>
		public override string Text
		{
			get { return this.Options.text ?? ""; }
			set { this.Options.text = value ?? ""; }
		}
	}
}
