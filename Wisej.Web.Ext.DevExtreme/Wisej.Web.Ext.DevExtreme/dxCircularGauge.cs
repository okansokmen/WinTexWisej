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
	/// The CircularGauge is a widget that indicates values on a circular numeric scale.
	/// </summary>
	public class dxCircularGauge : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxCircularGauge"/> class.
		/// </summary>
		public dxCircularGauge() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxCircularGauge"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxCircularGauge(object options) : base("dxCircularGauge", options)
		{
			this.WiredEvents = new[] {
				"exported",
				"exporting",
				"fileSaving",
				"optionChanged"
			};
		}

		/// <summary>
		/// Specifies the main value on a gauge.
		/// </summary>
		public int Value
		{
			get
			{
				try
				{
					return this.Options.value ?? 0;
				}
				catch { return 0; }
			}
			set
			{
				try
				{
					this.Options.value = value;
				}
				catch { }
			}
		}

	}
}
