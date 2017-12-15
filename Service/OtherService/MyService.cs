using ClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OtherService
{
	[ServiceContract]
	public interface IService
	{
		[OperationContract]
		int AddInt(int a, int b);

		
		bool UpLoadFile(Stream streamInput);

        [OperationContract]
        ResultMessage UpLoadFile(TransferFileMessage tMsg);
	}
	public class MyService : IService
	{
		public int AddInt(int a, int b)
		{
			return a + b;
		}

		public bool UpLoadFile(Stream streamInput)
		{
			bool isSuccess = false;
			try
			{
				using(var outputStream = new FileStream("haha.jpg", FileMode.OpenOrCreate, FileAccess.Write))
				{
					streamInput.CopyTo(outputStream);
					outputStream.Flush();
					isSuccess = true;
					Console.WriteLine("在{0}接收到客户端发送的流，已保存到haha.jpg。", DateTime.Now.ToLongTimeString());
				}
			}
			catch(Exception ex)
			{
				isSuccess = false;
			}


			return isSuccess;
		}

        public ResultMessage UpLoadFile(TransferFileMessage tMsg)
        {
            var result = new ResultMessage();
            if(tMsg == null || tMsg.File_Stream == null)
            {
                result.IsSuccessed = false;
                result.ErrorMsg = "传入的参数无效。";
                return result;
            }

            try
            {
                using(FileStream fs = new FileStream(tMsg.File_Name, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    tMsg.File_Stream.CopyTo(fs);
                    fs.Flush();
                    result.IsSuccessed = true;
                    Console.WriteLine("在{0}接收到客户端发送的流，已保存到{1}。", DateTime.Now.ToLongTimeString(), tMsg.File_Name);
                }
            }
            catch(Exception ex)
            {
                result.IsSuccessed = false;
                result.ErrorMsg = ex.Message;
            }

            return result;
        }
    }
}
