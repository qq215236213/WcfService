using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class MessageInspectorExtensionElement : BehaviorExtensionElement
	{
		public override Type BehaviorType
		{
			get
			{
				return typeof(MyEndPointBehavior);
			}
		}

		protected override object CreateBehavior()
		{
			return new MyEndPointBehavior();
		}
	}
}
