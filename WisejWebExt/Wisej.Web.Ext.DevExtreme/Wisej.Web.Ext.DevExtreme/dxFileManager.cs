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
	/// The FileManager widget allows users to manage files and folders.
	/// </summary>
	public class dxFileManager : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxFileManager"/> class.
		/// </summary>
		public dxFileManager() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxFileManager"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxFileManager(object options) : base("dxFileManager", options)
		{
			this.WiredEvents = new[] {
				"selectedFileOpened",
				"currentDirectoryChanged",
			};
		}
	}
}
