//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyServices.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UploadService", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class UploadService : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.UploadService1Soap")]
    public interface UploadService1Soap {
        
        // CODEGEN: Generating message contract since element name fileName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FileToByteArray", ReplyAction="*")]
        MyServices.ServiceReference2.FileToByteArrayResponse FileToByteArray(MyServices.ServiceReference2.FileToByteArrayRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FileToByteArray", ReplyAction="*")]
        System.Threading.Tasks.Task<MyServices.ServiceReference2.FileToByteArrayResponse> FileToByteArrayAsync(MyServices.ServiceReference2.FileToByteArrayRequest request);
        
        // CODEGEN: Generating message contract since element name fileName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadFile", ReplyAction="*")]
        MyServices.ServiceReference2.UploadFileResponse UploadFile(MyServices.ServiceReference2.UploadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UploadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<MyServices.ServiceReference2.UploadFileResponse> UploadFileAsync(MyServices.ServiceReference2.UploadFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FileToByteArrayRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FileToByteArray", Namespace="http://tempuri.org/", Order=0)]
        public MyServices.ServiceReference2.FileToByteArrayRequestBody Body;
        
        public FileToByteArrayRequest() {
        }
        
        public FileToByteArrayRequest(MyServices.ServiceReference2.FileToByteArrayRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FileToByteArrayRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fileName;
        
        public FileToByteArrayRequestBody() {
        }
        
        public FileToByteArrayRequestBody(string fileName) {
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FileToByteArrayResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FileToByteArrayResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyServices.ServiceReference2.FileToByteArrayResponseBody Body;
        
        public FileToByteArrayResponse() {
        }
        
        public FileToByteArrayResponse(MyServices.ServiceReference2.FileToByteArrayResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FileToByteArrayResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyServices.ServiceReference2.UploadService FileToByteArrayResult;
        
        public FileToByteArrayResponseBody() {
        }
        
        public FileToByteArrayResponseBody(MyServices.ServiceReference2.UploadService FileToByteArrayResult) {
            this.FileToByteArrayResult = FileToByteArrayResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFile", Namespace="http://tempuri.org/", Order=0)]
        public MyServices.ServiceReference2.UploadFileRequestBody Body;
        
        public UploadFileRequest() {
        }
        
        public UploadFileRequest(MyServices.ServiceReference2.UploadFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fileName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public byte[] byteArr;
        
        public UploadFileRequestBody() {
        }
        
        public UploadFileRequestBody(string fileName, byte[] byteArr) {
            this.fileName = fileName;
            this.byteArr = byteArr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UploadFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public MyServices.ServiceReference2.UploadFileResponseBody Body;
        
        public UploadFileResponse() {
        }
        
        public UploadFileResponse(MyServices.ServiceReference2.UploadFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UploadFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MyServices.ServiceReference2.UploadService UploadFileResult;
        
        public UploadFileResponseBody() {
        }
        
        public UploadFileResponseBody(MyServices.ServiceReference2.UploadService UploadFileResult) {
            this.UploadFileResult = UploadFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface UploadService1SoapChannel : MyServices.ServiceReference2.UploadService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UploadService1SoapClient : System.ServiceModel.ClientBase<MyServices.ServiceReference2.UploadService1Soap>, MyServices.ServiceReference2.UploadService1Soap {
        
        public UploadService1SoapClient() {
        }
        
        public UploadService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UploadService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UploadService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UploadService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyServices.ServiceReference2.FileToByteArrayResponse MyServices.ServiceReference2.UploadService1Soap.FileToByteArray(MyServices.ServiceReference2.FileToByteArrayRequest request) {
            return base.Channel.FileToByteArray(request);
        }
        
        public MyServices.ServiceReference2.UploadService FileToByteArray(string fileName) {
            MyServices.ServiceReference2.FileToByteArrayRequest inValue = new MyServices.ServiceReference2.FileToByteArrayRequest();
            inValue.Body = new MyServices.ServiceReference2.FileToByteArrayRequestBody();
            inValue.Body.fileName = fileName;
            MyServices.ServiceReference2.FileToByteArrayResponse retVal = ((MyServices.ServiceReference2.UploadService1Soap)(this)).FileToByteArray(inValue);
            return retVal.Body.FileToByteArrayResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyServices.ServiceReference2.FileToByteArrayResponse> MyServices.ServiceReference2.UploadService1Soap.FileToByteArrayAsync(MyServices.ServiceReference2.FileToByteArrayRequest request) {
            return base.Channel.FileToByteArrayAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyServices.ServiceReference2.FileToByteArrayResponse> FileToByteArrayAsync(string fileName) {
            MyServices.ServiceReference2.FileToByteArrayRequest inValue = new MyServices.ServiceReference2.FileToByteArrayRequest();
            inValue.Body = new MyServices.ServiceReference2.FileToByteArrayRequestBody();
            inValue.Body.fileName = fileName;
            return ((MyServices.ServiceReference2.UploadService1Soap)(this)).FileToByteArrayAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MyServices.ServiceReference2.UploadFileResponse MyServices.ServiceReference2.UploadService1Soap.UploadFile(MyServices.ServiceReference2.UploadFileRequest request) {
            return base.Channel.UploadFile(request);
        }
        
        public MyServices.ServiceReference2.UploadService UploadFile(string fileName, byte[] byteArr) {
            MyServices.ServiceReference2.UploadFileRequest inValue = new MyServices.ServiceReference2.UploadFileRequest();
            inValue.Body = new MyServices.ServiceReference2.UploadFileRequestBody();
            inValue.Body.fileName = fileName;
            inValue.Body.byteArr = byteArr;
            MyServices.ServiceReference2.UploadFileResponse retVal = ((MyServices.ServiceReference2.UploadService1Soap)(this)).UploadFile(inValue);
            return retVal.Body.UploadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MyServices.ServiceReference2.UploadFileResponse> MyServices.ServiceReference2.UploadService1Soap.UploadFileAsync(MyServices.ServiceReference2.UploadFileRequest request) {
            return base.Channel.UploadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<MyServices.ServiceReference2.UploadFileResponse> UploadFileAsync(string fileName, byte[] byteArr) {
            MyServices.ServiceReference2.UploadFileRequest inValue = new MyServices.ServiceReference2.UploadFileRequest();
            inValue.Body = new MyServices.ServiceReference2.UploadFileRequestBody();
            inValue.Body.fileName = fileName;
            inValue.Body.byteArr = byteArr;
            return ((MyServices.ServiceReference2.UploadService1Soap)(this)).UploadFileAsync(inValue);
        }
    }
}
