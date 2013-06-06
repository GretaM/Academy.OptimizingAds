﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiClient.CampaignService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="IdCollection", Namespace="http://www.adform.com/api/2010/06", ItemName="Id")]
    [System.SerializableAttribute()]
    public class IdCollection : System.Collections.Generic.List<int> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CodeCollection", Namespace="http://www.adform.com/api/2010/06", ItemName="Code")]
    [System.SerializableAttribute()]
    public class CodeCollection : System.Collections.Generic.List<string> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Campaign", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class Campaign : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AdvertiserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ResponsibleUserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> CoResponsibleUserIdField;
        
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
        public System.Nullable<int> Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public System.Nullable<int> AdvertiserId {
            get {
                return this.AdvertiserIdField;
            }
            set {
                if ((this.AdvertiserIdField.Equals(value) != true)) {
                    this.AdvertiserIdField = value;
                    this.RaisePropertyChanged("AdvertiserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public System.Nullable<int> ResponsibleUserId {
            get {
                return this.ResponsibleUserIdField;
            }
            set {
                if ((this.ResponsibleUserIdField.Equals(value) != true)) {
                    this.ResponsibleUserIdField = value;
                    this.RaisePropertyChanged("ResponsibleUserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=7)]
        public System.Nullable<int> CoResponsibleUserId {
            get {
                return this.CoResponsibleUserIdField;
            }
            set {
                if ((this.CoResponsibleUserIdField.Equals(value) != true)) {
                    this.CoResponsibleUserIdField = value;
                    this.RaisePropertyChanged("CoResponsibleUserId");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FaultDetails", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class FaultDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApiClient.CampaignService.Error[] ErrorsField;
        
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
        public ApiClient.CampaignService.Error[] Errors {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCampaignsData", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class GetCampaignsData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> AdvertiserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApiClient.CampaignService.IdCollection IdsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApiClient.CampaignService.CodeCollection CodesField;
        
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
        public System.Nullable<int> AdvertiserId {
            get {
                return this.AdvertiserIdField;
            }
            set {
                if ((this.AdvertiserIdField.Equals(value) != true)) {
                    this.AdvertiserIdField = value;
                    this.RaisePropertyChanged("AdvertiserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ApiClient.CampaignService.IdCollection Ids {
            get {
                return this.IdsField;
            }
            set {
                if ((object.ReferenceEquals(this.IdsField, value) != true)) {
                    this.IdsField = value;
                    this.RaisePropertyChanged("Ids");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public ApiClient.CampaignService.CodeCollection Codes {
            get {
                return this.CodesField;
            }
            set {
                if ((object.ReferenceEquals(this.CodesField, value) != true)) {
                    this.CodesField = value;
                    this.RaisePropertyChanged("Codes");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CreateCampaignData", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class CreateCampaignData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApiClient.CampaignService.Campaign CampaignField;
        
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
        public ApiClient.CampaignService.Campaign Campaign {
            get {
                return this.CampaignField;
            }
            set {
                if ((object.ReferenceEquals(this.CampaignField, value) != true)) {
                    this.CampaignField = value;
                    this.RaisePropertyChanged("Campaign");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateCampaignData", Namespace="http://www.adform.com/api/2010/06")]
    [System.SerializableAttribute()]
    public partial class UpdateCampaignData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ApiClient.CampaignService.Campaign CampaignField;
        
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
        public ApiClient.CampaignService.Campaign Campaign {
            get {
                return this.CampaignField;
            }
            set {
                if ((object.ReferenceEquals(this.CampaignField, value) != true)) {
                    this.CampaignField = value;
                    this.RaisePropertyChanged("Campaign");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.adform.com/api/2010/06", ConfigurationName="CampaignService.ICampaignService")]
    public interface ICampaignService {
        
        // CODEGEN: Generating message contract since the operation GetCampaigns is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/GetCampaigns", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/GetCampaignsResponse")]
        ApiClient.CampaignService.GetCampaignsResponse GetCampaigns(ApiClient.CampaignService.GetCampaignsData1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/GetCampaigns", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/GetCampaignsResponse")]
        System.Threading.Tasks.Task<ApiClient.CampaignService.GetCampaignsResponse> GetCampaignsAsync(ApiClient.CampaignService.GetCampaignsData1 request);
        
        // CODEGEN: Generating message contract since the operation CreateCampaign is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/CreateCampaign", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/CreateCampaignResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApiClient.CampaignService.FaultDetails), Action="http://www.adform.com/api/2010/06/ICampaignService/CreateCampaignFaultDetailsFaul" +
            "t", Name="FaultDetails")]
        ApiClient.CampaignService.CreateCampaignResponse CreateCampaign(ApiClient.CampaignService.CreateCampaignData1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/CreateCampaign", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/CreateCampaignResponse")]
        System.Threading.Tasks.Task<ApiClient.CampaignService.CreateCampaignResponse> CreateCampaignAsync(ApiClient.CampaignService.CreateCampaignData1 request);
        
        // CODEGEN: Generating message contract since the operation UpdateCampaign is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/UpdateCampaign", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/UpdateCampaignResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApiClient.CampaignService.FaultDetails), Action="http://www.adform.com/api/2010/06/ICampaignService/UpdateCampaignFaultDetailsFaul" +
            "t", Name="FaultDetails")]
        ApiClient.CampaignService.UpdateCampaignResponse UpdateCampaign(ApiClient.CampaignService.UpdateCampaignData1 request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/UpdateCampaign", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/UpdateCampaignResponse")]
        System.Threading.Tasks.Task<ApiClient.CampaignService.UpdateCampaignResponse> UpdateCampaignAsync(ApiClient.CampaignService.UpdateCampaignData1 request);
        
        // CODEGEN: Generating message contract since the operation DeleteCampaign is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/DeleteCampaign", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/DeleteCampaignResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ApiClient.CampaignService.FaultDetails), Action="http://www.adform.com/api/2010/06/ICampaignService/DeleteCampaignFaultDetailsFaul" +
            "t", Name="FaultDetails")]
        ApiClient.CampaignService.DeleteCampaignResponse DeleteCampaign(ApiClient.CampaignService.DeleteCampaignData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.adform.com/api/2010/06/ICampaignService/DeleteCampaign", ReplyAction="http://www.adform.com/api/2010/06/ICampaignService/DeleteCampaignResponse")]
        System.Threading.Tasks.Task<ApiClient.CampaignService.DeleteCampaignResponse> DeleteCampaignAsync(ApiClient.CampaignService.DeleteCampaignData request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCampaignsData1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.adform.com/api/2010/06")]
        public string Ticket;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.CampaignService.GetCampaignsData GetCampaignsData;
        
        public GetCampaignsData1() {
        }
        
        public GetCampaignsData1(string Ticket, ApiClient.CampaignService.GetCampaignsData GetCampaignsData) {
            this.Ticket = Ticket;
            this.GetCampaignsData = GetCampaignsData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCampaignsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.CampaignService.Campaign[] Campaigns;
        
        public GetCampaignsResponse() {
        }
        
        public GetCampaignsResponse(ApiClient.CampaignService.Campaign[] Campaigns) {
            this.Campaigns = Campaigns;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateCampaignData1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.adform.com/api/2010/06")]
        public string Ticket;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.CampaignService.CreateCampaignData CreateCampaignData;
        
        public CreateCampaignData1() {
        }
        
        public CreateCampaignData1(string Ticket, ApiClient.CampaignService.CreateCampaignData CreateCampaignData) {
            this.Ticket = Ticket;
            this.CreateCampaignData = CreateCampaignData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateCampaignResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.CampaignService.Campaign Campaign;
        
        public CreateCampaignResponse() {
        }
        
        public CreateCampaignResponse(ApiClient.CampaignService.Campaign Campaign) {
            this.Campaign = Campaign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCampaignData1 {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.adform.com/api/2010/06")]
        public string Ticket;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.CampaignService.UpdateCampaignData UpdateCampaignData;
        
        public UpdateCampaignData1() {
        }
        
        public UpdateCampaignData1(string Ticket, ApiClient.CampaignService.UpdateCampaignData UpdateCampaignData) {
            this.Ticket = Ticket;
            this.UpdateCampaignData = UpdateCampaignData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateCampaignResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public ApiClient.CampaignService.Campaign Campaign;
        
        public UpdateCampaignResponse() {
        }
        
        public UpdateCampaignResponse(ApiClient.CampaignService.Campaign Campaign) {
            this.Campaign = Campaign;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteCampaignData", WrapperNamespace="http://www.adform.com/api/2010/06", IsWrapped=true)]
    public partial class DeleteCampaignData {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://www.adform.com/api/2010/06")]
        public string Ticket;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.adform.com/api/2010/06", Order=0)]
        public int Id;
        
        public DeleteCampaignData() {
        }
        
        public DeleteCampaignData(string Ticket, int Id) {
            this.Ticket = Ticket;
            this.Id = Id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DeleteCampaignResponse {
        
        public DeleteCampaignResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICampaignServiceChannel : ApiClient.CampaignService.ICampaignService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CampaignServiceClient : System.ServiceModel.ClientBase<ApiClient.CampaignService.ICampaignService>, ApiClient.CampaignService.ICampaignService {
        
        public CampaignServiceClient() {
        }
        
        public CampaignServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CampaignServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CampaignServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CampaignServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApiClient.CampaignService.GetCampaignsResponse ApiClient.CampaignService.ICampaignService.GetCampaigns(ApiClient.CampaignService.GetCampaignsData1 request) {
            return base.Channel.GetCampaigns(request);
        }
        
        public ApiClient.CampaignService.Campaign[] GetCampaigns(string Ticket, ApiClient.CampaignService.GetCampaignsData GetCampaignsData) {
            ApiClient.CampaignService.GetCampaignsData1 inValue = new ApiClient.CampaignService.GetCampaignsData1();
            inValue.Ticket = Ticket;
            inValue.GetCampaignsData = GetCampaignsData;
            ApiClient.CampaignService.GetCampaignsResponse retVal = ((ApiClient.CampaignService.ICampaignService)(this)).GetCampaigns(inValue);
            return retVal.Campaigns;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApiClient.CampaignService.GetCampaignsResponse> ApiClient.CampaignService.ICampaignService.GetCampaignsAsync(ApiClient.CampaignService.GetCampaignsData1 request) {
            return base.Channel.GetCampaignsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApiClient.CampaignService.GetCampaignsResponse> GetCampaignsAsync(string Ticket, ApiClient.CampaignService.GetCampaignsData GetCampaignsData) {
            ApiClient.CampaignService.GetCampaignsData1 inValue = new ApiClient.CampaignService.GetCampaignsData1();
            inValue.Ticket = Ticket;
            inValue.GetCampaignsData = GetCampaignsData;
            return ((ApiClient.CampaignService.ICampaignService)(this)).GetCampaignsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApiClient.CampaignService.CreateCampaignResponse ApiClient.CampaignService.ICampaignService.CreateCampaign(ApiClient.CampaignService.CreateCampaignData1 request) {
            return base.Channel.CreateCampaign(request);
        }
        
        public ApiClient.CampaignService.Campaign CreateCampaign(string Ticket, ApiClient.CampaignService.CreateCampaignData CreateCampaignData) {
            ApiClient.CampaignService.CreateCampaignData1 inValue = new ApiClient.CampaignService.CreateCampaignData1();
            inValue.Ticket = Ticket;
            inValue.CreateCampaignData = CreateCampaignData;
            ApiClient.CampaignService.CreateCampaignResponse retVal = ((ApiClient.CampaignService.ICampaignService)(this)).CreateCampaign(inValue);
            return retVal.Campaign;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApiClient.CampaignService.CreateCampaignResponse> ApiClient.CampaignService.ICampaignService.CreateCampaignAsync(ApiClient.CampaignService.CreateCampaignData1 request) {
            return base.Channel.CreateCampaignAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApiClient.CampaignService.CreateCampaignResponse> CreateCampaignAsync(string Ticket, ApiClient.CampaignService.CreateCampaignData CreateCampaignData) {
            ApiClient.CampaignService.CreateCampaignData1 inValue = new ApiClient.CampaignService.CreateCampaignData1();
            inValue.Ticket = Ticket;
            inValue.CreateCampaignData = CreateCampaignData;
            return ((ApiClient.CampaignService.ICampaignService)(this)).CreateCampaignAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApiClient.CampaignService.UpdateCampaignResponse ApiClient.CampaignService.ICampaignService.UpdateCampaign(ApiClient.CampaignService.UpdateCampaignData1 request) {
            return base.Channel.UpdateCampaign(request);
        }
        
        public ApiClient.CampaignService.Campaign UpdateCampaign(string Ticket, ApiClient.CampaignService.UpdateCampaignData UpdateCampaignData) {
            ApiClient.CampaignService.UpdateCampaignData1 inValue = new ApiClient.CampaignService.UpdateCampaignData1();
            inValue.Ticket = Ticket;
            inValue.UpdateCampaignData = UpdateCampaignData;
            ApiClient.CampaignService.UpdateCampaignResponse retVal = ((ApiClient.CampaignService.ICampaignService)(this)).UpdateCampaign(inValue);
            return retVal.Campaign;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApiClient.CampaignService.UpdateCampaignResponse> ApiClient.CampaignService.ICampaignService.UpdateCampaignAsync(ApiClient.CampaignService.UpdateCampaignData1 request) {
            return base.Channel.UpdateCampaignAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApiClient.CampaignService.UpdateCampaignResponse> UpdateCampaignAsync(string Ticket, ApiClient.CampaignService.UpdateCampaignData UpdateCampaignData) {
            ApiClient.CampaignService.UpdateCampaignData1 inValue = new ApiClient.CampaignService.UpdateCampaignData1();
            inValue.Ticket = Ticket;
            inValue.UpdateCampaignData = UpdateCampaignData;
            return ((ApiClient.CampaignService.ICampaignService)(this)).UpdateCampaignAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ApiClient.CampaignService.DeleteCampaignResponse ApiClient.CampaignService.ICampaignService.DeleteCampaign(ApiClient.CampaignService.DeleteCampaignData request) {
            return base.Channel.DeleteCampaign(request);
        }
        
        public void DeleteCampaign(string Ticket, int Id) {
            ApiClient.CampaignService.DeleteCampaignData inValue = new ApiClient.CampaignService.DeleteCampaignData();
            inValue.Ticket = Ticket;
            inValue.Id = Id;
            ApiClient.CampaignService.DeleteCampaignResponse retVal = ((ApiClient.CampaignService.ICampaignService)(this)).DeleteCampaign(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ApiClient.CampaignService.DeleteCampaignResponse> ApiClient.CampaignService.ICampaignService.DeleteCampaignAsync(ApiClient.CampaignService.DeleteCampaignData request) {
            return base.Channel.DeleteCampaignAsync(request);
        }
        
        public System.Threading.Tasks.Task<ApiClient.CampaignService.DeleteCampaignResponse> DeleteCampaignAsync(string Ticket, int Id) {
            ApiClient.CampaignService.DeleteCampaignData inValue = new ApiClient.CampaignService.DeleteCampaignData();
            inValue.Ticket = Ticket;
            inValue.Id = Id;
            return ((ApiClient.CampaignService.ICampaignService)(this)).DeleteCampaignAsync(inValue);
        }
    }
}