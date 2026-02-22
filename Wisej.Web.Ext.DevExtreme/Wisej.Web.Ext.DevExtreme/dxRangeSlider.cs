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
	/// The RangeSlider is a widget that allows an end user to choose a range of numeric values.
	/// </summary>
	public class dxRangeSlider : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxRangeSlider"/> class.
		/// </summary>
		public dxRangeSlider() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxRangeSlider"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxRangeSlider(object options) : base("dxRangeSlider", options)
		{
			this.WiredEvents = new[] {
				"valueChanged"
			};
		}

		/// <summary>
		/// The left edge of the interval currently selected using the range slider.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double Start
		{
			get { return this.Options.start ?? 0; }
			set { this.Options.start = value; }
		}

		/// <summary>
		/// The right edge of the interval currently selected using the range slider.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double End
		{
			get { return this.Options.end ?? 0; }
			set { this.Options.end = value; }
		}

		/// <summary>
		/// The minimum value the widget can accept.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double Min
		{
			get { return this.Options.min ?? 0; }
			set { this.Options.min = value; }
		}

		/// <summary>
		/// The maximum value the widget can accept.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public double Max
		{
			get { return this.Options.max ?? 0; }
			set { this.Options.max = value; }
		}
	}
}
