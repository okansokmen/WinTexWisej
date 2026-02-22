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
	/// The ColorBox is a widget that allows an end user to enter a color or pick it out from the drop-down editor.
	/// </summary>
	public class dxColorBox : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxColorBox"/> class.
		/// </summary>
		public dxColorBox() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxColorBox"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxColorBox(object options) : base("dxColorBox", options)
		{
			this.WiredEvents = new[] {
				"cut",
				"copy",
				"paste",
				"keyUp",
				"opened",
				"change",
				"closed",
				"keyDown",
				"enterKey",
				"valueChanged",
				"optionChanged"
			};
		}
	}
}
