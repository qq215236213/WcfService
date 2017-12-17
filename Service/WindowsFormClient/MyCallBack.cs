using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormClient
{
	public class MyCallBack : ServiceReference2.IMyService_1Callback
	{
		public void CallClient(int v)
		{
			if(this.ValueCallbacked != null)
			{
				this.ValueCallbacked(this, v);
			}
		}

		/// <summary>
		/// 回调引发该事件
		/// </summary>
		public event EventHandler<int> ValueCallbacked;
	}
}
