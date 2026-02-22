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
	/// The LinearGauge is a widget that indicates values on a linear numeric scale.
	/// </summary>
	public class dxLinearGauge : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxLinearGauge"/> class.
		/// </summary>
		public dxLinearGauge() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxLinearGauge"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxLinearGauge(object options) : base("dxLinearGauge", options)
		{
			this.WiredEvents = new[] {
				"exported",
				"exporting",
				"fileSaving",
				"optionChanged",
				"incidentOccured",
			};
		}

		/// <summary>
		/// Specifies the main value on the gauge.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Value
		{
			get { return this.Options.value ?? ""; }
			set { this.Options.value = value ?? ""; }
		}
	}
}
