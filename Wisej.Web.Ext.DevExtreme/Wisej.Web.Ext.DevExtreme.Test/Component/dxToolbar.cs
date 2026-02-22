using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxToolbar : TestBase
	{
		public dxToolbar()
		{
			InitializeComponent();

			this.dxToolbar1.Instance.itemClick += new WidgetEventHandler(dxToolbar1_WidgetEvent);
		}

		private void dxToolbar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxToolbar1.Options.hoverStateEnabled = this.checkBox1.Checked;
			this.dxToolbar1.Options.rtlEnabled = this.checkBox2.Checked;

			this.dxToolbar1.Update();
		}
	}
}
