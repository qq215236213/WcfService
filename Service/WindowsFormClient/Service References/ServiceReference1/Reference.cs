﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddInt", ReplyAction="http://tempuri.org/IService/AddIntResponse")]
        int AddInt(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AddInt", ReplyAction="http://tempuri.org/IService/AddIntResponse")]
        System.Threading.Tasks.Task<int> AddIntAsync(int a, int b);
        
        // CODEGEN: 消息 TransferFileMessage 的包装名称(TransferFileMessage)以后生成的消息协定与默认值(UpLoadFile)不匹配
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpLoadFile", ReplyAction="http://tempuri.org/IService/UpLoadFileResponse")]
        WindowsFormClient.ServiceReference1.ResultMessage UpLoadFile(WindowsFormClient.ServiceReference1.TransferFileMessage request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/UpLoadFile", ReplyAction="http://tempuri.org/IService/UpLoadFileResponse")]
        System.Threading.Tasks.Task<WindowsFormClient.ServiceReference1.ResultMessage> UpLoadFileAsync(WindowsFormClient.ServiceReference1.TransferFileMessage request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="TransferFileMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class TransferFileMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string File_Name;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream File_Stream;
        
        public TransferFileMessage() {
        }
        
        public TransferFileMessage(string File_Name, System.IO.Stream File_Stream) {
            this.File_Name = File_Name;
            this.File_Stream = File_Stream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResultMessage", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ResultMessage {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string ErrorMsg;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool IsSuccessed;
        
        public ResultMessage() {
        }
        
        public ResultMessage(string ErrorMsg, bool IsSuccessed) {
            this.ErrorMsg = ErrorMsg;
            this.IsSuccessed = IsSuccessed;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WindowsFormClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WindowsFormClient.ServiceReference1.IService>, WindowsFormClient.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddInt(int a, int b) {
            return base.Channel.AddInt(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddIntAsync(int a, int b) {
            return base.Channel.AddIntAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormClient.ServiceReference1.ResultMessage WindowsFormClient.ServiceReference1.IService.UpLoadFile(WindowsFormClient.ServiceReference1.TransferFileMessage request) {
            return base.Channel.UpLoadFile(request);
        }
        
        public string UpLoadFile(string File_Name, System.IO.Stream File_Stream, out bool IsSuccessed) {
            WindowsFormClient.ServiceReference1.TransferFileMessage inValue = new WindowsFormClient.ServiceReference1.TransferFileMessage();
            inValue.File_Name = File_Name;
            inValue.File_Stream = File_Stream;
            WindowsFormClient.ServiceReference1.ResultMessage retVal = ((WindowsFormClient.ServiceReference1.IService)(this)).UpLoadFile(inValue);
            IsSuccessed = retVal.IsSuccessed;
            return retVal.ErrorMsg;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormClient.ServiceReference1.ResultMessage> WindowsFormClient.ServiceReference1.IService.UpLoadFileAsync(WindowsFormClient.ServiceReference1.TransferFileMessage request) {
            return base.Channel.UpLoadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormClient.ServiceReference1.ResultMessage> UpLoadFileAsync(string File_Name, System.IO.Stream File_Stream) {
            WindowsFormClient.ServiceReference1.TransferFileMessage inValue = new WindowsFormClient.ServiceReference1.TransferFileMessage();
            inValue.File_Name = File_Name;
            inValue.File_Stream = File_Stream;
            return ((WindowsFormClient.ServiceReference1.IService)(this)).UpLoadFileAsync(inValue);
        }
    }
}
