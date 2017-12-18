using System;

namespace WindowsFormClient
{
	public class MessageContent
	{
		public string NickName { get; set; }
		public string Message { get; set; }
		public DateTime Time { get; set; }
		public bool IsMe { get; set; }
	}
}