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
	/// The RangeSelector is a widget that allows a user to select a range of values on a scale.
	/// </summary>
	public class dxRangeSelector : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxRangeSelector"/> class.
		/// </summary>
		public dxRangeSelector() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxRangeSelector"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxRangeSelector(object options) : base("dxRangeSelector", options)
		{
			this.WiredEvents = new[] {
				"valueChanged",
				"optionChanged",
			};
		}

		/// <summary>
		/// The range's start value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string StartValue
		{
			get { return this._startValue; }
			set {
				this._startValue = value;
				this.Options.value = new { startValue = value, endValue = this._endValue };
			}
		}
		private string _startValue = "";

		/// <summary>
		/// The range's end value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string EndValue
		{
			get { return this._endValue; }
			set
			{
				this._endValue = value;
				this.Options.value = new { startValue = _startValue, endValue = value };
			}
		}
		private string _endValue = "";

		/// <summary>
		/// Configures the Range Selector's title
		/// </summary>
		/// 
		/// <remarks>
		/// Make sure your widget satisfies the minimum height and width requirement for the title.
		/// </remarks>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Title
		{
			get { return this.Options.title ?? ""; }
			set { this.Options.title = value ?? ""; }
		}
	}
}
