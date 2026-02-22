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
	/// HtmlEditor is a WYSIWYG editor that allows you to format textual and visual content and to output it in HTML or Markdown.
	/// </summary>
	public class dxHtmlEditor : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxHtmlEditor"/> class.
		/// </summary>
		public dxHtmlEditor() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxHtmlEditor"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxHtmlEditor(object options) : base("dxHtmlEditor", options)
		{
			this.WiredEvents = new[] {
				"valueChanged",
				"optionChanged"
			};
		}

		/// <summary>
		/// Specifies the editor's value.
		/// </summary>
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public string Value
		{
			get { return this.Options.value ?? ""; }
			set { this.Options.value = value ?? ""; }
		}
	}
}
