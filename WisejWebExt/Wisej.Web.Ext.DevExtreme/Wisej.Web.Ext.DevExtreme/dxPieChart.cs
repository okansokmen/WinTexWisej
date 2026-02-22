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
	/// The PieChart is a widget that visualizes data as a circle divided into sectors that each represents a portion of the whole.
	/// </summary>
	public class dxPieChart : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxPieChart"/> class.
		/// </summary>
		public dxPieChart() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxPieChart"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxPieChart(object options) : base("dxPieChart", options)
		{
			this.WiredEvents = new[] {
				"pointClick",
				"legendClick"
			};
		}

		/// <summary>
		/// The current number box value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double Value
		{
			get { return this.Options.value ?? 0; }
			set { this.Options.value = value; }
		}
	}
}
