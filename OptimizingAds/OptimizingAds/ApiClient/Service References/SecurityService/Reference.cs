﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiClient.SecurityService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultDetails", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class FaultDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApiClient.SecurityService.Error[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RefNoField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApiClient.SecurityService.Error[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RefNo {
            get {
                return this.RefNoField;
            }
            set {
                if ((object.ReferenceEquals(this.RefNoField, value) != true)) {
                    this.RefNoField = value;
                    this.RaisePropertyChanged("RefNo");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Error", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class Error : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldPathField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string FieldPath {
            get {
                return this.FieldPathField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldPathField, value) != true)) {
                    this.FieldPathField = value;
                    this.RaisePropertyChanged("FieldPath");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginData", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class LoginData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.adform.com/api/2010/06", ConfigurationName="SecurityService.ISecurityService")]
    public interface ISecurityService {
        
        // CODEGEN: Generating message contract since the operation Login is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ISecurityService/Login", ReplyAction="http://www.adform.com/api/2010/06/ISecurityService/LoginResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApiClient.SecurityService.FaultDetails), Action="http://www.adform.com/api/2010/06/ISecurityService/LoginFaultDetailsFault", Name="FaultDetails")]
        ApiClient.SecurityService.LoginResponse Login(ApiClient.SecurityService.LoginData1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ISecurityService/Login", ReplyAction="http://www.adform.com/api/2010/06/ISecurityService/LoginResponse")]
        System.Threading.Tasks.Task<ApiClient.SecurityService.LoginResponse> LoginAsync(ApiClient.SecurityService.LoginData1 request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginData1 {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.SecurityService.LoginData LoginData;
        
        public LoginData1() {
        }
        
        public LoginData1(ApiClient.SecurityService.LoginData LoginData) {
            this.LoginData = LoginData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public string Ticket;
        
        public LoginResponse() {
        }
        
        public LoginResponse(string Ticket) {
            this.Ticket = Ticket;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISecurityServiceChannel : ApiClient.SecurityService.ISecurityService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SecurityServiceClient : System.ServiceModel.ClientBase<ApiClient.SecurityService.ISecurityService>, ApiClient.SecurityService.ISecurityService {
        
        public SecurityServiceClient() {
        }
        
        public SecurityServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SecurityServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SecurityServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApiClient.SecurityService.LoginResponse ApiClient.SecurityService.ISecurityService.Login(ApiClient.SecurityService.LoginData1 request) {
            return base.Channel.Login(request);
        }
        
        public string Login(ApiClient.SecurityService.LoginData LoginData) {
            ApiClient.SecurityService.LoginData1 inValue = new ApiClient.SecurityService.LoginData1();
            inValue.LoginData = LoginData;
            ApiClient.SecurityService.LoginResponse retVal = ((ApiClient.SecurityService.ISecurityService)(this)).Login(inValue);
            return retVal.Ticket;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApiClient.SecurityService.LoginResponse> ApiClient.SecurityService.ISecurityService.LoginAsync(ApiClient.SecurityService.LoginData1 request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApiClient.SecurityService.LoginResponse> LoginAsync(ApiClient.SecurityService.LoginData LoginData) {
            ApiClient.SecurityService.LoginData1 inValue = new ApiClient.SecurityService.LoginData1();
            inValue.LoginData = LoginData;
            return ((ApiClient.SecurityService.ISecurityService)(this)).LoginAsync(inValue);
        }
    }
}
