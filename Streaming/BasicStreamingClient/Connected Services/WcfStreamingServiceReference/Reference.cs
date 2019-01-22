﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasicStreamingClient.WcfStreamingServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfStreamingServiceReference.IStreamService")]
    public interface IStreamService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamService/GetLargeObject", ReplyAction="http://tempuri.org/IStreamService/GetLargeObjectResponse")]
        System.IO.Stream GetLargeObject();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamService/GetLargeObject", ReplyAction="http://tempuri.org/IStreamService/GetLargeObjectResponse")]
        System.Threading.Tasks.Task<System.IO.Stream> GetLargeObjectAsync();
        
        // CODEGEN: Generating message contract since the operation UploadFile is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamService/UploadFile", ReplyAction="http://tempuri.org/IStreamService/UploadFileResponse")]
        BasicStreamingClient.WcfStreamingServiceReference.UploadFileResponse UploadFile(BasicStreamingClient.WcfStreamingServiceReference.ResponseFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamService/UploadFile", ReplyAction="http://tempuri.org/IStreamService/UploadFileResponse")]
        System.Threading.Tasks.Task<BasicStreamingClient.WcfStreamingServiceReference.UploadFileResponse> UploadFileAsync(BasicStreamingClient.WcfStreamingServiceReference.ResponseFile request);
        
        // CODEGEN: Generating message contract since the wrapper name (RequestFile) of message RequestFile does not match the default value (DownloadFile)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamService/DownloadFile", ReplyAction="http://tempuri.org/IStreamService/DownloadFileResponse")]
        BasicStreamingClient.WcfStreamingServiceReference.ResponseFile DownloadFile(BasicStreamingClient.WcfStreamingServiceReference.RequestFile request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStreamService/DownloadFile", ReplyAction="http://tempuri.org/IStreamService/DownloadFileResponse")]
        System.Threading.Tasks.Task<BasicStreamingClient.WcfStreamingServiceReference.ResponseFile> DownloadFileAsync(BasicStreamingClient.WcfStreamingServiceReference.RequestFile request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResponseFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ResponseFile {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long ByteStart;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string FileName;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public long Length;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.IO.Stream FileByteStream;
        
        public ResponseFile() {
        }
        
        public ResponseFile(long ByteStart, string FileName, long Length, System.IO.Stream FileByteStream) {
            this.ByteStart = ByteStart;
            this.FileName = FileName;
            this.Length = Length;
            this.FileByteStream = FileByteStream;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileResponse {
        
        public UploadFileResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RequestFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class RequestFile {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public long ByteStart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string FileName;
        
        public RequestFile() {
        }
        
        public RequestFile(long ByteStart, string FileName) {
            this.ByteStart = ByteStart;
            this.FileName = FileName;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStreamServiceChannel : BasicStreamingClient.WcfStreamingServiceReference.IStreamService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StreamServiceClient : System.ServiceModel.ClientBase<BasicStreamingClient.WcfStreamingServiceReference.IStreamService>, BasicStreamingClient.WcfStreamingServiceReference.IStreamService {
        
        public StreamServiceClient() {
        }
        
        public StreamServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StreamServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StreamServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StreamServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.IO.Stream GetLargeObject() {
            return base.Channel.GetLargeObject();
        }
        
        public System.Threading.Tasks.Task<System.IO.Stream> GetLargeObjectAsync() {
            return base.Channel.GetLargeObjectAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BasicStreamingClient.WcfStreamingServiceReference.UploadFileResponse BasicStreamingClient.WcfStreamingServiceReference.IStreamService.UploadFile(BasicStreamingClient.WcfStreamingServiceReference.ResponseFile request) {
            return base.Channel.UploadFile(request);
        }
        
        public void UploadFile(long ByteStart, string FileName, long Length, System.IO.Stream FileByteStream) {
            BasicStreamingClient.WcfStreamingServiceReference.ResponseFile inValue = new BasicStreamingClient.WcfStreamingServiceReference.ResponseFile();
            inValue.ByteStart = ByteStart;
            inValue.FileName = FileName;
            inValue.Length = Length;
            inValue.FileByteStream = FileByteStream;
            BasicStreamingClient.WcfStreamingServiceReference.UploadFileResponse retVal = ((BasicStreamingClient.WcfStreamingServiceReference.IStreamService)(this)).UploadFile(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BasicStreamingClient.WcfStreamingServiceReference.UploadFileResponse> BasicStreamingClient.WcfStreamingServiceReference.IStreamService.UploadFileAsync(BasicStreamingClient.WcfStreamingServiceReference.ResponseFile request) {
            return base.Channel.UploadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<BasicStreamingClient.WcfStreamingServiceReference.UploadFileResponse> UploadFileAsync(long ByteStart, string FileName, long Length, System.IO.Stream FileByteStream) {
            BasicStreamingClient.WcfStreamingServiceReference.ResponseFile inValue = new BasicStreamingClient.WcfStreamingServiceReference.ResponseFile();
            inValue.ByteStart = ByteStart;
            inValue.FileName = FileName;
            inValue.Length = Length;
            inValue.FileByteStream = FileByteStream;
            return ((BasicStreamingClient.WcfStreamingServiceReference.IStreamService)(this)).UploadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BasicStreamingClient.WcfStreamingServiceReference.ResponseFile BasicStreamingClient.WcfStreamingServiceReference.IStreamService.DownloadFile(BasicStreamingClient.WcfStreamingServiceReference.RequestFile request) {
            return base.Channel.DownloadFile(request);
        }
        
        public long DownloadFile(ref long ByteStart, ref string FileName, out System.IO.Stream FileByteStream) {
            BasicStreamingClient.WcfStreamingServiceReference.RequestFile inValue = new BasicStreamingClient.WcfStreamingServiceReference.RequestFile();
            inValue.ByteStart = ByteStart;
            inValue.FileName = FileName;
            BasicStreamingClient.WcfStreamingServiceReference.ResponseFile retVal = ((BasicStreamingClient.WcfStreamingServiceReference.IStreamService)(this)).DownloadFile(inValue);
            ByteStart = retVal.ByteStart;
            FileName = retVal.FileName;
            FileByteStream = retVal.FileByteStream;
            return retVal.Length;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BasicStreamingClient.WcfStreamingServiceReference.ResponseFile> BasicStreamingClient.WcfStreamingServiceReference.IStreamService.DownloadFileAsync(BasicStreamingClient.WcfStreamingServiceReference.RequestFile request) {
            return base.Channel.DownloadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<BasicStreamingClient.WcfStreamingServiceReference.ResponseFile> DownloadFileAsync(long ByteStart, string FileName) {
            BasicStreamingClient.WcfStreamingServiceReference.RequestFile inValue = new BasicStreamingClient.WcfStreamingServiceReference.RequestFile();
            inValue.ByteStart = ByteStart;
            inValue.FileName = FileName;
            return ((BasicStreamingClient.WcfStreamingServiceReference.IStreamService)(this)).DownloadFileAsync(inValue);
        }
    }
}
