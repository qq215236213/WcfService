﻿using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	class Program
	{
		static void Main(string[] args)
		{
			var host = new ServiceHost(typeof(MyService));
            var host1 = new ServiceHost(typeof(CustomService));
            host.Opened += (sender, e) => {
				Console.WriteLine("服务已启动");
			};

			host.Open();

            host1.Opened += (sender, e) =>
            {
                Console.WriteLine("CustomService 服务已启动");
            };
            host1.Open();

            while (true)
            {
                var input = Console.ReadKey();
                if(input.Key == ConsoleKey.A)
                {
                    break;
                }
            }

			host.Close();
            host1.Close();
		}
	}
}
