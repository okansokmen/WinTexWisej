namespace Wisej.RealTimeBarcodeScanner
{
	partial class Page1
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
            this.components = new System.ComponentModel.Container();
            this.automaticButton = new Wisej.Web.Button();
            this.onceButton = new Wisej.Web.Button();
            this.manualButton = new Wisej.Web.Button();
            this.resetButton = new Wisej.Web.Button();
            this.camera1 = new Wisej.Web.Ext.Camera.Camera();
            this.barcodeReader1 = new Wisej.Web.Ext.Barcode.BarcodeReader(this.components);
            this.SuspendLayout();
            // 
            // automaticButton
            // 
            this.automaticButton.Location = new System.Drawing.Point(85, 190);
            this.automaticButton.Name = "automaticButton";
            this.automaticButton.Size = new System.Drawing.Size(100, 41);
            this.automaticButton.TabIndex = 1;
            this.automaticButton.Text = "Automatic";
            this.automaticButton.Click += new System.EventHandler(this.automaticButton_Click);
            // 
            // onceButton
            // 
            this.onceButton.Location = new System.Drawing.Point(85, 237);
            this.onceButton.Name = "onceButton";
            this.onceButton.Size = new System.Drawing.Size(100, 41);
            this.onceButton.TabIndex = 3;
            this.onceButton.Text = "AutomaticOnce";
            this.onceButton.Click += new System.EventHandler(this.onceButton_Click);
            // 
            // manualButton
            // 
            this.manualButton.Location = new System.Drawing.Point(85, 284);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(100, 41);
            this.manualButton.TabIndex = 4;
            this.manualButton.Text = "Manual";
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(85, 331);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 41);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // camera1
            // 
            this.camera1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.camera1.Location = new System.Drawing.Point(306, 98);
            this.camera1.Name = "camera1";
            this.camera1.Size = new System.Drawing.Size(897, 388);
            this.camera1.TabIndex = 2;
            this.camera1.Text = "camera1";
            // 
            // barcodeReader1
            // 
            this.barcodeReader1.Camera = this.camera1;
            // 
            // Page1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.onceButton);
            this.Controls.Add(this.camera1);
            this.Controls.Add(this.automaticButton);
            this.Name = "Page1";
            this.Size = new System.Drawing.Size(1508, 585);
            this.Text = "Page1";
            this.Load += new System.EventHandler(this.Page1_Load);
            this.ResumeLayout(false);

		}

		#endregion
		private Web.Button automaticButton;
		private Web.Ext.Camera.Camera camera1;
		private Web.Button onceButton;
		private Web.Button manualButton;
		private Web.Button resetButton;
		private Web.Ext.Barcode.BarcodeReader barcodeReader1;
	}
}

