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
	/// The SlideOut widget is a classic slide-out menu paired with a view. An end user opens the menu by swiping away the view.
	/// </summary>
	public class dxSlideOut : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxSlideOut"/> class.
		/// </summary>
		public dxSlideOut() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxSlideOut"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxSlideOut(object options) : base("dxSlideOut", options)
		{
			this.WiredEvents = new[] {
				"itemHold",
				"itemClick",
			};
		}
	}
}
