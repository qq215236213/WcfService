using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	/// <summary>
	/// 插入终结点的 Behavior
	/// </summary>
	public class MyEndPointBehavior : IEndpointBehavior
	{
		public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
		{
			
		}

		public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
		{
			// 植入“偷听器”客户端
			clientRuntime.ClientMessageInspectors.Add(new MyMessageInspector());
		}

		public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
		{
			// 植入“偷听器” 服务器端
			endpointDispatcher.DispatchRuntime.MessageInspectors.Add(new MyMessageInspector());
		}

		public void Validate(ServiceEndpoint endpoint)
		{
			
		}
	}
}
