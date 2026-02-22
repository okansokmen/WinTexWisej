namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxSlideOut
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxSlideOut));
			this.dxSlideOut1 = new Wisej.Web.Ext.DevExtreme.dxSlideOut();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/SlideOut/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxSlideOut/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxSlideOut1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Slideout/Overview/jQuery/Ligh" +
    "t/";
			// 
			// dxSlideOut1
			// 
			this.dxSlideOut1.Location = new System.Drawing.Point(-1, -1);
			this.dxSlideOut1.Name = "dxSlideOut1";
			this.dxSlideOut1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxSlideOut1.Options"))));
			this.dxSlideOut1.Size = new System.Drawing.Size(183, 315);
			this.dxSlideOut1.TabIndex = 0;
			this.dxSlideOut1.Text = "dxSlideOut1";
			// 
			// dxSlideOut
			// 
			this.Name = "dxSlideOut";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxSlideOut dxSlideOut1;
	}
}
