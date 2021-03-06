﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class MovieModel : MovieService.BaseModel
    {
        
        private System.DateTime DateAddedField;
        
        private string DescriptionField;
        
        private MovieService.MovieExtraPropertyModel[] MovieExtraPropertiesField;
        
        private string NameField;
        
        private string PathField;
        
        private bool PathChangedField;
        
        private MovieService.PersonModel[] PeopleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded
        {
            get
            {
                return this.DateAddedField;
            }
            set
            {
                this.DateAddedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.MovieExtraPropertyModel[] MovieExtraProperties
        {
            get
            {
                return this.MovieExtraPropertiesField;
            }
            set
            {
                this.MovieExtraPropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PathChanged
        {
            get
            {
                return this.PathChangedField;
            }
            set
            {
                this.PathChangedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.PersonModel[] People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MovieService.MovieExtraPropertyModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MovieService.PersonModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MovieService.PhotoModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MovieService.PhotoExtraPropertyModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(MovieService.MovieModel))]
    public partial class BaseModel : object
    {
        
        private int IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieExtraPropertyModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class MovieExtraPropertyModel : MovieService.BaseModel
    {
        
        private MovieService.MovieModel MovieField;
        
        private string PropertyNameField;
        
        private string PropertyValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.MovieModel Movie
        {
            get
            {
                return this.MovieField;
            }
            set
            {
                this.MovieField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName
        {
            get
            {
                return this.PropertyNameField;
            }
            set
            {
                this.PropertyNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyValue
        {
            get
            {
                return this.PropertyValueField;
            }
            set
            {
                this.PropertyValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PersonModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class PersonModel : MovieService.BaseModel
    {
        
        private MovieService.MovieModel MovieField;
        
        private string NameField;
        
        private MovieService.PhotoModel PhotoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.MovieModel Movie
        {
            get
            {
                return this.MovieField;
            }
            set
            {
                this.MovieField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.PhotoModel Photo
        {
            get
            {
                return this.PhotoField;
            }
            set
            {
                this.PhotoField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class PhotoModel : MovieService.BaseModel
    {
        
        private System.DateTime DateAddedField;
        
        private string DescriptionField;
        
        private string EventField;
        
        private string PathField;
        
        private bool PathChangedField;
        
        private MovieService.PersonModel[] PeopleField;
        
        private MovieService.PhotoExtraPropertyModel[] PhotoExtraPropertiesField;
        
        private string PlaceField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded
        {
            get
            {
                return this.DateAddedField;
            }
            set
            {
                this.DateAddedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Event
        {
            get
            {
                return this.EventField;
            }
            set
            {
                this.EventField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool PathChanged
        {
            get
            {
                return this.PathChangedField;
            }
            set
            {
                this.PathChangedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.PersonModel[] People
        {
            get
            {
                return this.PeopleField;
            }
            set
            {
                this.PeopleField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.PhotoExtraPropertyModel[] PhotoExtraProperties
        {
            get
            {
                return this.PhotoExtraPropertiesField;
            }
            set
            {
                this.PhotoExtraPropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Place
        {
            get
            {
                return this.PlaceField;
            }
            set
            {
                this.PlaceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PhotoExtraPropertyModel", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    public partial class PhotoExtraPropertyModel : MovieService.BaseModel
    {
        
        private MovieService.PhotoModel PhotoField;
        
        private string PropertyNameField;
        
        private string PropertyValueField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MovieService.PhotoModel Photo
        {
            get
            {
                return this.PhotoField;
            }
            set
            {
                this.PhotoField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyName
        {
            get
            {
                return this.PropertyNameField;
            }
            set
            {
                this.PropertyNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PropertyValue
        {
            get
            {
                return this.PropertyValueField;
            }
            set
            {
                this.PropertyValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieFilter", Namespace="http://schemas.datacontract.org/2004/07/Models.Filters")]
    public partial class MovieFilter : object
    {
        
        private System.Nullable<int> IdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieService.IMovieService")]
    public interface IMovieService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseServiceOf_MovieModel_MovieFilter/GetAll", ReplyAction="http://tempuri.org/IBaseServiceOf_MovieModel_MovieFilter/GetAllResponse")]
        System.Threading.Tasks.Task<MovieService.MovieModel[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBaseServiceOf_MovieModel_MovieFilter/GetByFilter", ReplyAction="http://tempuri.org/IBaseServiceOf_MovieModel_MovieFilter/GetByFilterResponse")]
        System.Threading.Tasks.Task<MovieService.MovieModel[]> GetByFilterAsync(MovieService.MovieFilter filter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMovieServiceChannel : MovieService.IMovieService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MovieServiceClient : System.ServiceModel.ClientBase<MovieService.IMovieService>, MovieService.IMovieService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MovieServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MovieServiceClient.GetBindingForEndpoint(endpointConfiguration), MovieServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MovieServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MovieServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MovieServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<MovieService.MovieModel[]> GetAllAsync()
        {
            return base.Channel.GetAllAsync();
        }
        
        public System.Threading.Tasks.Task<MovieService.MovieModel[]> GetByFilterAsync(MovieService.MovieFilter filter)
        {
            return base.Channel.GetByFilterAsync(filter);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IMovieService))
            {
                System.ServiceModel.NetTcpBinding result = new System.ServiceModel.NetTcpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMovieService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.NetTcpBinding_IMovieService))
            {
                return new System.ServiceModel.EndpointAddress("net.tcp://localhost:1238/API/MovieService");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMovieService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:1239/API/MovieService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            NetTcpBinding_IMovieService,
            
            BasicHttpBinding_IMovieService,
        }
    }
}
