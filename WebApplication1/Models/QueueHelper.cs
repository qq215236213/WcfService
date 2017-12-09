using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Web;

namespace WebApplication1.Models
{
	public class QueueHelper
	{
		public readonly static QueueHelper Instance = new QueueHelper();

		private QueueHelper() { }
		private Queue<string> msgList = new Queue<string>();
		private WebSocket socket = null;

		public void SetSocket(WebSocket socket)
		{
			this.socket = socket;
		}
		public void SetMsg(string msg)
		{
			msgList.Enqueue(msg);
		}

		public void Start()
		{
			Thread thread = new Thread(ThreadStart);
			thread.IsBackground = true;
			thread.Start();
		}

		private void ThreadStart()
		{
			while (true)
			{
				if(msgList.Count > 0)
				{
					try
					{
						ScanQueue();
					}
					catch(Exception ex)
					{
						throw new Exception(ex.Message);
					}
				}
				else
				{
					Thread.Sleep(3000);
				}
			}
		}

		private void ScanQueue()
		{
			while(msgList.Count > 0)
			{
				try
				{
					//获取队列中的消息
					string msg = msgList.Dequeue();
					var buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msg));
					this.socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
				}
				catch(Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}
		}
	}
}