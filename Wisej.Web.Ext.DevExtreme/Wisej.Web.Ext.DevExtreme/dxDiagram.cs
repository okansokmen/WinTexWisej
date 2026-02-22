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
	/// The Diagram widget provides a visual interface to help you design new and modify existing diagrams.
	/// </summary>
	public class dxDiagram : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxDiagram"/> class.
		/// </summary>
		public dxDiagram() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxDiagram"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxDiagram(object options) : base("dxDiagram", options)
		{				
			this.WiredEvents = new[]
			{
				"itemClick",
				"dataChanged",
				"itemDblClick",
				"selectionChanged"
			};
		}

	}
}
