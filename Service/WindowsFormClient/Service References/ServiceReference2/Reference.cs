﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormClient.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IMyService_1", CallbackContract=typeof(WindowsFormClient.ServiceReference2.IMyService_1Callback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IMyService_1 {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMyService_1/SetValue")]
        void SetValue(int n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMyService_1/SetValue")]
        System.Threading.Tasks.Task SetValueAsync(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService_1/GetValue", ReplyAction="http://tempuri.org/IMyService_1/GetValueResponse")]
        int GetValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMyService_1/GetValue", ReplyAction="http://tempuri.org/IMyService_1/GetValueResponse")]
        System.Threading.Tasks.Task<int> GetValueAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMyService_1/CallServiceOp")]
        void CallServiceOp();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMyService_1/CallServiceOp")]
        System.Threading.Tasks.Task CallServiceOpAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IMyService_1/End")]
        void End();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, IsTerminating=true, IsInitiating=false, Action="http://tempuri.org/IMyService_1/End")]
        System.Threading.Tasks.Task EndAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyService_1Callback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMyService_1/CallClient")]
        void CallClient(int v);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMyService_1Channel : WindowsFormClient.ServiceReference2.IMyService_1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyService_1Client : System.ServiceModel.DuplexClientBase<WindowsFormClient.ServiceReference2.IMyService_1>, WindowsFormClient.ServiceReference2.IMyService_1 {
        
        public MyService_1Client(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public MyService_1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public MyService_1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MyService_1Client(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public MyService_1Client(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void SetValue(int n) {
            base.Channel.SetValue(n);
        }
        
        public System.Threading.Tasks.Task SetValueAsync(int n) {
            return base.Channel.SetValueAsync(n);
        }
        
        public int GetValue() {
            return base.Channel.GetValue();
        }
        
        public System.Threading.Tasks.Task<int> GetValueAsync() {
            return base.Channel.GetValueAsync();
        }
        
        public void CallServiceOp() {
            base.Channel.CallServiceOp();
        }
        
        public System.Threading.Tasks.Task CallServiceOpAsync() {
            return base.Channel.CallServiceOpAsync();
        }
        
        public void End() {
            base.Channel.End();
        }
        
        public System.Threading.Tasks.Task EndAsync() {
            return base.Channel.EndAsync();
        }
    }
}
