
using System;
using Wisej.Web;
using Wisej.Web.Ext.Barcode;

namespace Wisej.RealTimeBarcodeScanner
{
	public partial class Page1 : Page
	{
		BarcodeReader reader;

		public Page1()
		{
			InitializeComponent();
		}

		private void Page1_Load(object sender, EventArgs e)
		{
			this.reader = this.barcodeReader1;

			reader.ScanMode = ScanMode.AutomaticOnce;

			reader.Camera = this.camera1;
			reader.ScanSuccess += Reader_ScanSuccess;
			reader.ScanError += Reader_ScanError;
		}

		private void Reader_ScanError(object sender, ScanEventArgs e)
		{
			AlertBox.Show($"ERROR { e.Data }");
		}

		private void Reader_ScanSuccess(object sender, ScanEventArgs e)
		{
			AlertBox.Show(e.Data);
		}

		private void manualButton_Click(object sender, EventArgs e)
		{
			this.reader.ScanMode = ScanMode.Manual;
			this.reader.ScanImage();
		}

		private void onceButton_Click(object sender, EventArgs e)
		{
			this.reader.ScanMode = ScanMode.AutomaticOnce;
		}

		private void automaticButton_Click(object sender, EventArgs e)
		{
			this.reader.ScanMode = ScanMode.Automatic;
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			this.reader.ResetScanner();
		}
	}
}
