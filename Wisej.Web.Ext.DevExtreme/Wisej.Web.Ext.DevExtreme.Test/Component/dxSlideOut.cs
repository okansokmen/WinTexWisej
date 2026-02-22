using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxSlideOut : TestBase
	{
		public dxSlideOut()
		{
			InitializeComponent();

			this.dxSlideOut1.Instance.itemClick += new WidgetEventHandler(dxSlideOut1_WidgetEvent);
		}

		private void dxSlideOut1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
