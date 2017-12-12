using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;
using WebApplication1.Models;

namespace WebApplication1
{
	/// <summary>
	/// Handler1 的摘要说明
	/// </summary>
	public class Handler1 : IHttpHandler
	{
		private static Dictionary<string, WebSocket> CONNECT_POOL = new Dictionary<string, WebSocket>();//用户连接池
		public void ProcessRequest(HttpContext context)
		{
			if (context.IsWebSocketRequest)
			{
				context.AcceptWebSocketRequest(ProcessChat);
			}
		}

		private async Task ProcessChat(AspNetWebSocketContext context)
		{
			WebSocket ws = context.WebSocket;
			string user = context.QueryString["user"].ToString();

			try
			{
				if (!CONNECT_POOL.ContainsKey(user))
				{
					CONNECT_POOL.Add(user, ws);
				}
				else
				{
					if(ws != CONNECT_POOL[user])
					{
						CONNECT_POOL[user] = ws;
					}
				}

				string descUser = string.Empty;

				while (true)
				{
					if(ws.State == WebSocketState.Open)
					{
						ArraySegment<byte> buffer = new ArraySegment<byte>(new byte[2048]);
						WebSocketReceiveResult result = await ws.ReceiveAsync(buffer, CancellationToken.None);

						if(ws.State != WebSocketState.Open)
						{
							if (CONNECT_POOL.ContainsKey(user))
							{
								CONNECT_POOL.Remove(user);
								break;
							}
						}



						var userMsg = Encoding.UTF8.GetString(buffer.Array, 0, result.Count);//发送过来的消息
						userMsg = $"服务器返回{userMsg}";

						QueueHelper.Instance.SetMsg(userMsg);

						if (CONNECT_POOL.ContainsKey(user))
						{
							var socket = CONNECT_POOL[user];

							QueueHelper.Instance.SetSocket(socket);
							//await socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
						}

						//string[] msgList = userMsg.Split('|');
						//if(msgList.Length == 2)
						//{
						//	if(msgList[0].Trim().Length > 0)
						//	{
						//		descUser = msgList[0].Trim();//记录消息目的用户
						//	}

						//	buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(msgList[1]));
						//}
						//else
						//{
						//	buffer = new ArraySegment<byte>(Encoding.UTF8.GetBytes(userMsg));
						//}

						//if (CONNECT_POOL.ContainsKey(descUser))
						//{
						//	WebSocket socket = CONNECT_POOL[descUser];
						//	if(socket != null && socket.State == WebSocketState.Open)
						//	{
						//		await socket.SendAsync(buffer, WebSocketMessageType.Text, true, CancellationToken.None);
						//	}
						//}


					}
					else
					{
						break;
					}
				}
			}
			catch(Exception ex)
			{
				if (CONNECT_POOL.ContainsKey(user))
				{
					CONNECT_POOL.Remove(user);
				}
			}

		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}