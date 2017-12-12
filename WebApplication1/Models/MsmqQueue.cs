using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Web;

namespace WebApplication1.Models
{
	public class MsmqQueue
	{
		private MsmqQueue() { }
		private static string _msmqPath = @".\private$\test";
		private static MessageQueue _instance = null;
		public static string MsmqPath
		{
			set
			{
				if (!string.IsNullOrWhiteSpace(value))
				{
					_msmqPath = value;
				}
			}
		}
		public static MessageQueue Instance
		{
			get
			{
				if (_instance != null)
					return _instance;
				else
				{
					return new MessageQueue(_msmqPath);
				}
			}
		}
	}
}