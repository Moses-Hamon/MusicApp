﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicApp.MusicServiceProxy {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Music", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Music : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TrackField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArtistField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AlbumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DurationField;
        
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
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Track {
            get {
                return this.TrackField;
            }
            set {
                if ((object.ReferenceEquals(this.TrackField, value) != true)) {
                    this.TrackField = value;
                    this.RaisePropertyChanged("Track");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Artist {
            get {
                return this.ArtistField;
            }
            set {
                if ((object.ReferenceEquals(this.ArtistField, value) != true)) {
                    this.ArtistField = value;
                    this.RaisePropertyChanged("Artist");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Album {
            get {
                return this.AlbumField;
            }
            set {
                if ((object.ReferenceEquals(this.AlbumField, value) != true)) {
                    this.AlbumField = value;
                    this.RaisePropertyChanged("Album");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Duration {
            get {
                return this.DurationField;
            }
            set {
                if ((object.ReferenceEquals(this.DurationField, value) != true)) {
                    this.DurationField = value;
                    this.RaisePropertyChanged("Duration");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MusicServiceProxy.MusicServiceSoap")]
    public interface MusicServiceSoap {
        
        // CODEGEN: Generating message contract since element name SelectAllResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectAll", ReplyAction="*")]
        MusicApp.MusicServiceProxy.SelectAllResponse SelectAll(MusicApp.MusicServiceProxy.SelectAllRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectAll", ReplyAction="*")]
        System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SelectAllResponse> SelectAllAsync(MusicApp.MusicServiceProxy.SelectAllRequest request);
        
        // CODEGEN: Generating message contract since element name id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectOne", ReplyAction="*")]
        MusicApp.MusicServiceProxy.SelectOneResponse SelectOne(MusicApp.MusicServiceProxy.SelectOneRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SelectOne", ReplyAction="*")]
        System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SelectOneResponse> SelectOneAsync(MusicApp.MusicServiceProxy.SelectOneRequest request);
        
        // CODEGEN: Generating message contract since element name record from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Save", ReplyAction="*")]
        MusicApp.MusicServiceProxy.SaveResponse Save(MusicApp.MusicServiceProxy.SaveRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Save", ReplyAction="*")]
        System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SaveResponse> SaveAsync(MusicApp.MusicServiceProxy.SaveRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectAllRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectAll", Namespace="http://tempuri.org/", Order=0)]
        public MusicApp.MusicServiceProxy.SelectAllRequestBody Body;
        
        public SelectAllRequest() {
        }
        
        public SelectAllRequest(MusicApp.MusicServiceProxy.SelectAllRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class SelectAllRequestBody {
        
        public SelectAllRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectAllResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectAllResponse", Namespace="http://tempuri.org/", Order=0)]
        public MusicApp.MusicServiceProxy.SelectAllResponseBody Body;
        
        public SelectAllResponse() {
        }
        
        public SelectAllResponse(MusicApp.MusicServiceProxy.SelectAllResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectAllResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MusicApp.MusicServiceProxy.Music[] SelectAllResult;
        
        public SelectAllResponseBody() {
        }
        
        public SelectAllResponseBody(MusicApp.MusicServiceProxy.Music[] SelectAllResult) {
            this.SelectAllResult = SelectAllResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectOneRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectOne", Namespace="http://tempuri.org/", Order=0)]
        public MusicApp.MusicServiceProxy.SelectOneRequestBody Body;
        
        public SelectOneRequest() {
        }
        
        public SelectOneRequest(MusicApp.MusicServiceProxy.SelectOneRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectOneRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string id;
        
        public SelectOneRequestBody() {
        }
        
        public SelectOneRequestBody(string id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SelectOneResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SelectOneResponse", Namespace="http://tempuri.org/", Order=0)]
        public MusicApp.MusicServiceProxy.SelectOneResponseBody Body;
        
        public SelectOneResponse() {
        }
        
        public SelectOneResponse(MusicApp.MusicServiceProxy.SelectOneResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SelectOneResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MusicApp.MusicServiceProxy.Music SelectOneResult;
        
        public SelectOneResponseBody() {
        }
        
        public SelectOneResponseBody(MusicApp.MusicServiceProxy.Music SelectOneResult) {
            this.SelectOneResult = SelectOneResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Save", Namespace="http://tempuri.org/", Order=0)]
        public MusicApp.MusicServiceProxy.SaveRequestBody Body;
        
        public SaveRequest() {
        }
        
        public SaveRequest(MusicApp.MusicServiceProxy.SaveRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MusicApp.MusicServiceProxy.Music record;
        
        public SaveRequestBody() {
        }
        
        public SaveRequestBody(MusicApp.MusicServiceProxy.Music record) {
            this.record = record;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SaveResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SaveResponse", Namespace="http://tempuri.org/", Order=0)]
        public MusicApp.MusicServiceProxy.SaveResponseBody Body;
        
        public SaveResponse() {
        }
        
        public SaveResponse(MusicApp.MusicServiceProxy.SaveResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SaveResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MusicApp.MusicServiceProxy.Music SaveResult;
        
        public SaveResponseBody() {
        }
        
        public SaveResponseBody(MusicApp.MusicServiceProxy.Music SaveResult) {
            this.SaveResult = SaveResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MusicServiceSoapChannel : MusicApp.MusicServiceProxy.MusicServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MusicServiceSoapClient : System.ServiceModel.ClientBase<MusicApp.MusicServiceProxy.MusicServiceSoap>, MusicApp.MusicServiceProxy.MusicServiceSoap {
        
        public MusicServiceSoapClient() {
        }
        
        public MusicServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MusicServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MusicServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusicApp.MusicServiceProxy.SelectAllResponse MusicApp.MusicServiceProxy.MusicServiceSoap.SelectAll(MusicApp.MusicServiceProxy.SelectAllRequest request) {
            return base.Channel.SelectAll(request);
        }
        
        public MusicApp.MusicServiceProxy.Music[] SelectAll() {
            MusicApp.MusicServiceProxy.SelectAllRequest inValue = new MusicApp.MusicServiceProxy.SelectAllRequest();
            inValue.Body = new MusicApp.MusicServiceProxy.SelectAllRequestBody();
            MusicApp.MusicServiceProxy.SelectAllResponse retVal = ((MusicApp.MusicServiceProxy.MusicServiceSoap)(this)).SelectAll(inValue);
            return retVal.Body.SelectAllResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SelectAllResponse> MusicApp.MusicServiceProxy.MusicServiceSoap.SelectAllAsync(MusicApp.MusicServiceProxy.SelectAllRequest request) {
            return base.Channel.SelectAllAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SelectAllResponse> SelectAllAsync() {
            MusicApp.MusicServiceProxy.SelectAllRequest inValue = new MusicApp.MusicServiceProxy.SelectAllRequest();
            inValue.Body = new MusicApp.MusicServiceProxy.SelectAllRequestBody();
            return ((MusicApp.MusicServiceProxy.MusicServiceSoap)(this)).SelectAllAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusicApp.MusicServiceProxy.SelectOneResponse MusicApp.MusicServiceProxy.MusicServiceSoap.SelectOne(MusicApp.MusicServiceProxy.SelectOneRequest request) {
            return base.Channel.SelectOne(request);
        }
        
        public MusicApp.MusicServiceProxy.Music SelectOne(string id) {
            MusicApp.MusicServiceProxy.SelectOneRequest inValue = new MusicApp.MusicServiceProxy.SelectOneRequest();
            inValue.Body = new MusicApp.MusicServiceProxy.SelectOneRequestBody();
            inValue.Body.id = id;
            MusicApp.MusicServiceProxy.SelectOneResponse retVal = ((MusicApp.MusicServiceProxy.MusicServiceSoap)(this)).SelectOne(inValue);
            return retVal.Body.SelectOneResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SelectOneResponse> MusicApp.MusicServiceProxy.MusicServiceSoap.SelectOneAsync(MusicApp.MusicServiceProxy.SelectOneRequest request) {
            return base.Channel.SelectOneAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SelectOneResponse> SelectOneAsync(string id) {
            MusicApp.MusicServiceProxy.SelectOneRequest inValue = new MusicApp.MusicServiceProxy.SelectOneRequest();
            inValue.Body = new MusicApp.MusicServiceProxy.SelectOneRequestBody();
            inValue.Body.id = id;
            return ((MusicApp.MusicServiceProxy.MusicServiceSoap)(this)).SelectOneAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MusicApp.MusicServiceProxy.SaveResponse MusicApp.MusicServiceProxy.MusicServiceSoap.Save(MusicApp.MusicServiceProxy.SaveRequest request) {
            return base.Channel.Save(request);
        }
        
        public MusicApp.MusicServiceProxy.Music Save(MusicApp.MusicServiceProxy.Music record) {
            MusicApp.MusicServiceProxy.SaveRequest inValue = new MusicApp.MusicServiceProxy.SaveRequest();
            inValue.Body = new MusicApp.MusicServiceProxy.SaveRequestBody();
            inValue.Body.record = record;
            MusicApp.MusicServiceProxy.SaveResponse retVal = ((MusicApp.MusicServiceProxy.MusicServiceSoap)(this)).Save(inValue);
            return retVal.Body.SaveResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SaveResponse> MusicApp.MusicServiceProxy.MusicServiceSoap.SaveAsync(MusicApp.MusicServiceProxy.SaveRequest request) {
            return base.Channel.SaveAsync(request);
        }
        
        public System.Threading.Tasks.Task<MusicApp.MusicServiceProxy.SaveResponse> SaveAsync(MusicApp.MusicServiceProxy.Music record) {
            MusicApp.MusicServiceProxy.SaveRequest inValue = new MusicApp.MusicServiceProxy.SaveRequest();
            inValue.Body = new MusicApp.MusicServiceProxy.SaveRequestBody();
            inValue.Body.record = record;
            return ((MusicApp.MusicServiceProxy.MusicServiceSoap)(this)).SaveAsync(inValue);
        }
    }
}
