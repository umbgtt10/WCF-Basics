﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleHost.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.MultiplicationService")]
    public interface MultiplicationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplicationService/Multiply", ReplyAction="http://tempuri.org/MultiplicationService/MultiplyResponse")]
        int Multiply(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MultiplicationService/Multiply", ReplyAction="http://tempuri.org/MultiplicationService/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MultiplicationServiceChannel : ConsoleHost.ServiceReference1.MultiplicationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MultiplicationServiceClient : System.ServiceModel.ClientBase<ConsoleHost.ServiceReference1.MultiplicationService>, ConsoleHost.ServiceReference1.MultiplicationService {
        
        public MultiplicationServiceClient() {
        }
        
        public MultiplicationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MultiplicationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplicationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MultiplicationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Multiply(int a, int b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int a, int b) {
            return base.Channel.MultiplyAsync(a, b);
        }
    }
}
