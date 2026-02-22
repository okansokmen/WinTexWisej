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
	/// The List is a widget that represents a collection of items in a scrollable list.
	/// </summary>
	public class dxList : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxList"/> class.
		/// </summary>
		public dxList() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxList"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxList(object options) : base("dxList", options)
		{
			this.WiredEvents = new[] {
				"itemClick",
				"itemSwipe",
				"pullRefresh",
				"itemDeleted",
				"itemDeleting",
				"selectAllValueChanged"
			};
		}
	}
}
