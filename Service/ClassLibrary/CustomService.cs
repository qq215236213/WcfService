using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [ServiceContract]
    public interface ICustomService
    {
        [OperationContract]
        void PostMessage(CarMessage msg);
        [OperationContract]
        Person GetPerson();
        [OperationContract]
        ResponseMessage CheckRenpin(RequestMessage requestMessage);
        [OperationContract]
        void SetWorkerInformation(Worker wk);
    }
    public class CustomService : ICustomService
    {
        public ResponseMessage CheckRenpin(RequestMessage requestMessage)
        {
            ResponseMessage responseMessage = new ResponseMessage();
            Random rnd = new Random();
            responseMessage.CheckResult = rnd.Next(requestMessage.MaxNum);
            responseMessage.Name = requestMessage.CheckName;
            return responseMessage;
        }

        public Person GetPerson()
        {
            return new Person
            {
                Address = "非洲",
                Age = 107,
                Email = "haha@163.com",
                Name = "飞人",
                Zip = "100041"
            };
        }

        public void PostMessage(CarMessage msg)
        {
            Console.WriteLine($"车子名字:{msg.CarName}");
        }

        public void SetWorkerInformation(Worker wk)
        {
            Console.WriteLine("工作名字：{0}", wk.WorkerName);
            ArtistInfo info = wk.WorkerArtist;
            Console.WriteLine("工人作品创建时间：{0}", info.CreateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("工人作品名字：{0}", info.ArtistName);
        }
    }
}
