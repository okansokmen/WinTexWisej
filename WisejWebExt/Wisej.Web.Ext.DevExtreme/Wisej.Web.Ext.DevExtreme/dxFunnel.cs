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
	/// The Funnel is a widget that visualizes a value at different stages in the form of a funnel.
	/// </summary>
	public class dxFunnel : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxFunnel"/> class.
		/// </summary>
		public dxFunnel() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxFunnel"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxFunnel(object options) : base("dxFunnel", options)
		{
			this.WiredEvents = new[] {
				"exported",
				"itemClick",
				"exporting",
				"fileSaving",
				"legendClick",
				"hoverChanged",
				"selectionChanged"
			};
		}
	}
}
