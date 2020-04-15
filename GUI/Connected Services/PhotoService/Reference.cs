﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.PhotoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class PhotoModel : GUI.PhotoService.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAddedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EventField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PathChangedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.PersonModel[] PeopleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.PhotoExtraPropertyModel[] PhotoExtraPropertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlaceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded {
            get {
                return this.DateAddedField;
            }
            set {
                if ((this.DateAddedField.Equals(value) != true)) {
                    this.DateAddedField = value;
                    this.RaisePropertyChanged("DateAdded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event {
            get {
                return this.EventField;
            }
            set {
                if ((object.ReferenceEquals(this.EventField, value) != true)) {
                    this.EventField = value;
                    this.RaisePropertyChanged("Event");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path {
            get {
                return this.PathField;
            }
            set {
                if ((object.ReferenceEquals(this.PathField, value) != true)) {
                    this.PathField = value;
                    this.RaisePropertyChanged("Path");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PathChanged {
            get {
                return this.PathChangedField;
            }
            set {
                if ((this.PathChangedField.Equals(value) != true)) {
                    this.PathChangedField = value;
                    this.RaisePropertyChanged("PathChanged");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.PersonModel[] People {
            get {
                return this.PeopleField;
            }
            set {
                if ((object.ReferenceEquals(this.PeopleField, value) != true)) {
                    this.PeopleField = value;
                    this.RaisePropertyChanged("People");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.PhotoExtraPropertyModel[] PhotoExtraProperties {
            get {
                return this.PhotoExtraPropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoExtraPropertiesField, value) != true)) {
                    this.PhotoExtraPropertiesField = value;
                    this.RaisePropertyChanged("PhotoExtraProperties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place {
            get {
                return this.PlaceField;
            }
            set {
                if ((object.ReferenceEquals(this.PlaceField, value) != true)) {
                    this.PlaceField = value;
                    this.RaisePropertyChanged("Place");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUI.PhotoService.PersonModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUI.PhotoService.MovieModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUI.PhotoService.MovieExtraPropertyModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUI.PhotoService.PhotoExtraPropertyModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUI.PhotoService.PhotoModel))]
    public partial class BaseModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class PersonModel : GUI.PhotoService.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.MovieModel MovieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.PhotoModel PhotoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.MovieModel Movie {
            get {
                return this.MovieField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieField, value) != true)) {
                    this.MovieField = value;
                    this.RaisePropertyChanged("Movie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.PhotoModel Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class MovieModel : GUI.PhotoService.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAddedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.MovieExtraPropertyModel[] MovieExtraPropertiesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PathField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool PathChangedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.PersonModel[] PeopleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded {
            get {
                return this.DateAddedField;
            }
            set {
                if ((this.DateAddedField.Equals(value) != true)) {
                    this.DateAddedField = value;
                    this.RaisePropertyChanged("DateAdded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.MovieExtraPropertyModel[] MovieExtraProperties {
            get {
                return this.MovieExtraPropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieExtraPropertiesField, value) != true)) {
                    this.MovieExtraPropertiesField = value;
                    this.RaisePropertyChanged("MovieExtraProperties");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path {
            get {
                return this.PathField;
            }
            set {
                if ((object.ReferenceEquals(this.PathField, value) != true)) {
                    this.PathField = value;
                    this.RaisePropertyChanged("Path");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PathChanged {
            get {
                return this.PathChangedField;
            }
            set {
                if ((this.PathChangedField.Equals(value) != true)) {
                    this.PathChangedField = value;
                    this.RaisePropertyChanged("PathChanged");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.PersonModel[] People {
            get {
                return this.PeopleField;
            }
            set {
                if ((object.ReferenceEquals(this.PeopleField, value) != true)) {
                    this.PeopleField = value;
                    this.RaisePropertyChanged("People");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieExtraPropertyModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class MovieExtraPropertyModel : GUI.PhotoService.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.MovieModel MovieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.MovieModel Movie {
            get {
                return this.MovieField;
            }
            set {
                if ((object.ReferenceEquals(this.MovieField, value) != true)) {
                    this.MovieField = value;
                    this.RaisePropertyChanged("Movie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName {
            get {
                return this.PropertyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyNameField, value) != true)) {
                    this.PropertyNameField = value;
                    this.RaisePropertyChanged("PropertyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyValue {
            get {
                return this.PropertyValueField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyValueField, value) != true)) {
                    this.PropertyValueField = value;
                    this.RaisePropertyChanged("PropertyValue");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoExtraPropertyModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class PhotoExtraPropertyModel : GUI.PhotoService.BaseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUI.PhotoService.PhotoModel PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PropertyValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUI.PhotoService.PhotoModel Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName {
            get {
                return this.PropertyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyNameField, value) != true)) {
                    this.PropertyNameField = value;
                    this.RaisePropertyChanged("PropertyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyValue {
            get {
                return this.PropertyValueField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertyValueField, value) != true)) {
                    this.PropertyValueField = value;
                    this.RaisePropertyChanged("PropertyValue");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoFilter", Namespace="http://schemas.datacontract.org/2004/07/Models.Filters")]
    [System.SerializableAttribute()]
    public partial class PhotoFilter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> IdField;
        
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PhotoService.IPhotoService")]
    public interface IPhotoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetAll", ReplyAction="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetAllResponse")]
        GUI.PhotoService.PhotoModel[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetAll", ReplyAction="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetAllResponse")]
        System.Threading.Tasks.Task<GUI.PhotoService.PhotoModel[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetByFilter", ReplyAction="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetByFilterResponse")]
        GUI.PhotoService.PhotoModel[] GetByFilter(GUI.PhotoService.PhotoFilter filter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetByFilter", ReplyAction="http://tempuri.org/IBaseServiceOf_PhotoModel_PhotoFilter/GetByFilterResponse")]
        System.Threading.Tasks.Task<GUI.PhotoService.PhotoModel[]> GetByFilterAsync(GUI.PhotoService.PhotoFilter filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPhotoServiceChannel : GUI.PhotoService.IPhotoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PhotoServiceClient : System.ServiceModel.ClientBase<GUI.PhotoService.IPhotoService>, GUI.PhotoService.IPhotoService {
        
        public PhotoServiceClient() {
        }
        
        public PhotoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PhotoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhotoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhotoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GUI.PhotoService.PhotoModel[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<GUI.PhotoService.PhotoModel[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public GUI.PhotoService.PhotoModel[] GetByFilter(GUI.PhotoService.PhotoFilter filter) {
            return base.Channel.GetByFilter(filter);
        }
        
        public System.Threading.Tasks.Task<GUI.PhotoService.PhotoModel[]> GetByFilterAsync(GUI.PhotoService.PhotoFilter filter) {
            return base.Channel.GetByFilterAsync(filter);
        }
    }
}
