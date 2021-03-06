//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD.CRUDService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int StudentIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        private bool GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImageUrlField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((this.StudentIDField.Equals(value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public bool Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string ImageUrl {
            get {
                return this.ImageUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageUrlField, value) != true)) {
                    this.ImageUrlField = value;
                    this.RaisePropertyChanged("ImageUrl");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRUDService.StudentServiceSoap")]
    public interface StudentServiceSoap {
        
        // CODEGEN: Generating message contract since element name obj from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        CRUD.CRUDService.InsertResponse Insert(CRUD.CRUDService.InsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert", ReplyAction="*")]
        System.Threading.Tasks.Task<CRUD.CRUDService.InsertResponse> InsertAsync(CRUD.CRUDService.InsertRequest request);
        
        // CODEGEN: Generating message contract since element name obj from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        CRUD.CRUDService.UpdateResponse Update(CRUD.CRUDService.UpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Update", ReplyAction="*")]
        System.Threading.Tasks.Task<CRUD.CRUDService.UpdateResponse> UpdateAsync(CRUD.CRUDService.UpdateRequest request);
        
        // CODEGEN: Generating message contract since element name GetAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        CRUD.CRUDService.GetAllResponse GetAll(CRUD.CRUDService.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAll", ReplyAction="*")]
        System.Threading.Tasks.Task<CRUD.CRUDService.GetAllResponse> GetAllAsync(CRUD.CRUDService.GetAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        bool Delete(int studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int studentId);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert", Namespace="http://tempuri.org/", Order=0)]
        public CRUD.CRUDService.InsertRequestBody Body;
        
        public InsertRequest() {
        }
        
        public InsertRequest(CRUD.CRUDService.InsertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CRUD.CRUDService.Student obj;
        
        public InsertRequestBody() {
        }
        
        public InsertRequestBody(CRUD.CRUDService.Student obj) {
            this.obj = obj;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class InsertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="InsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public CRUD.CRUDService.InsertResponseBody Body;
        
        public InsertResponse() {
        }
        
        public InsertResponse(CRUD.CRUDService.InsertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class InsertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int InsertResult;
        
        public InsertResponseBody() {
        }
        
        public InsertResponseBody(int InsertResult) {
            this.InsertResult = InsertResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Update", Namespace="http://tempuri.org/", Order=0)]
        public CRUD.CRUDService.UpdateRequestBody Body;
        
        public UpdateRequest() {
        }
        
        public UpdateRequest(CRUD.CRUDService.UpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CRUD.CRUDService.Student obj;
        
        public UpdateRequestBody() {
        }
        
        public UpdateRequestBody(CRUD.CRUDService.Student obj) {
            this.obj = obj;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public CRUD.CRUDService.UpdateResponseBody Body;
        
        public UpdateResponse() {
        }
        
        public UpdateResponse(CRUD.CRUDService.UpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool UpdateResult;
        
        public UpdateResponseBody() {
        }
        
        public UpdateResponseBody(bool UpdateResult) {
            this.UpdateResult = UpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAll", Namespace="http://tempuri.org/", Order=0)]
        public CRUD.CRUDService.GetAllRequestBody Body;
        
        public GetAllRequest() {
        }
        
        public GetAllRequest(CRUD.CRUDService.GetAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllRequestBody {
        
        public GetAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public CRUD.CRUDService.GetAllResponseBody Body;
        
        public GetAllResponse() {
        }
        
        public GetAllResponse(CRUD.CRUDService.GetAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CRUD.CRUDService.Student[] GetAllResult;
        
        public GetAllResponseBody() {
        }
        
        public GetAllResponseBody(CRUD.CRUDService.Student[] GetAllResult) {
            this.GetAllResult = GetAllResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface StudentServiceSoapChannel : CRUD.CRUDService.StudentServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceSoapClient : System.ServiceModel.ClientBase<CRUD.CRUDService.StudentServiceSoap>, CRUD.CRUDService.StudentServiceSoap {
        
        public StudentServiceSoapClient() {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CRUD.CRUDService.InsertResponse CRUD.CRUDService.StudentServiceSoap.Insert(CRUD.CRUDService.InsertRequest request) {
            return base.Channel.Insert(request);
        }
        
        public int Insert(CRUD.CRUDService.Student obj) {
            CRUD.CRUDService.InsertRequest inValue = new CRUD.CRUDService.InsertRequest();
            inValue.Body = new CRUD.CRUDService.InsertRequestBody();
            inValue.Body.obj = obj;
            CRUD.CRUDService.InsertResponse retVal = ((CRUD.CRUDService.StudentServiceSoap)(this)).Insert(inValue);
            return retVal.Body.InsertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CRUD.CRUDService.InsertResponse> CRUD.CRUDService.StudentServiceSoap.InsertAsync(CRUD.CRUDService.InsertRequest request) {
            return base.Channel.InsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<CRUD.CRUDService.InsertResponse> InsertAsync(CRUD.CRUDService.Student obj) {
            CRUD.CRUDService.InsertRequest inValue = new CRUD.CRUDService.InsertRequest();
            inValue.Body = new CRUD.CRUDService.InsertRequestBody();
            inValue.Body.obj = obj;
            return ((CRUD.CRUDService.StudentServiceSoap)(this)).InsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CRUD.CRUDService.UpdateResponse CRUD.CRUDService.StudentServiceSoap.Update(CRUD.CRUDService.UpdateRequest request) {
            return base.Channel.Update(request);
        }
        
        public bool Update(CRUD.CRUDService.Student obj) {
            CRUD.CRUDService.UpdateRequest inValue = new CRUD.CRUDService.UpdateRequest();
            inValue.Body = new CRUD.CRUDService.UpdateRequestBody();
            inValue.Body.obj = obj;
            CRUD.CRUDService.UpdateResponse retVal = ((CRUD.CRUDService.StudentServiceSoap)(this)).Update(inValue);
            return retVal.Body.UpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CRUD.CRUDService.UpdateResponse> CRUD.CRUDService.StudentServiceSoap.UpdateAsync(CRUD.CRUDService.UpdateRequest request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<CRUD.CRUDService.UpdateResponse> UpdateAsync(CRUD.CRUDService.Student obj) {
            CRUD.CRUDService.UpdateRequest inValue = new CRUD.CRUDService.UpdateRequest();
            inValue.Body = new CRUD.CRUDService.UpdateRequestBody();
            inValue.Body.obj = obj;
            return ((CRUD.CRUDService.StudentServiceSoap)(this)).UpdateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CRUD.CRUDService.GetAllResponse CRUD.CRUDService.StudentServiceSoap.GetAll(CRUD.CRUDService.GetAllRequest request) {
            return base.Channel.GetAll(request);
        }
        
        public CRUD.CRUDService.Student[] GetAll() {
            CRUD.CRUDService.GetAllRequest inValue = new CRUD.CRUDService.GetAllRequest();
            inValue.Body = new CRUD.CRUDService.GetAllRequestBody();
            CRUD.CRUDService.GetAllResponse retVal = ((CRUD.CRUDService.StudentServiceSoap)(this)).GetAll(inValue);
            return retVal.Body.GetAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CRUD.CRUDService.GetAllResponse> CRUD.CRUDService.StudentServiceSoap.GetAllAsync(CRUD.CRUDService.GetAllRequest request) {
            return base.Channel.GetAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<CRUD.CRUDService.GetAllResponse> GetAllAsync() {
            CRUD.CRUDService.GetAllRequest inValue = new CRUD.CRUDService.GetAllRequest();
            inValue.Body = new CRUD.CRUDService.GetAllRequestBody();
            return ((CRUD.CRUDService.StudentServiceSoap)(this)).GetAllAsync(inValue);
        }
        
        public bool Delete(int studentId) {
            return base.Channel.Delete(studentId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int studentId) {
            return base.Channel.DeleteAsync(studentId);
        }
    }
}
