﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationMVC.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Goods", Namespace="http://schemas.datacontract.org/2004/07/WcfService")]
    [System.SerializableAttribute()]
    public partial class Goods : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IServiceRepositoryOf_Goods")]
    public interface IServiceRepositoryOf_Goods {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/GetAll", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/GetAllResponse")]
        WebApplicationMVC.ServiceReference.Goods[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/GetAll", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/GetAllResponse")]
        System.Threading.Tasks.Task<WebApplicationMVC.ServiceReference.Goods[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Get", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/GetResponse")]
        WebApplicationMVC.ServiceReference.Goods Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Get", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/GetResponse")]
        System.Threading.Tasks.Task<WebApplicationMVC.ServiceReference.Goods> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Find", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/FindResponse")]
        WebApplicationMVC.ServiceReference.Goods[] Find(System.Func<WebApplicationMVC.ServiceReference.Goods, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Find", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/FindResponse")]
        System.Threading.Tasks.Task<WebApplicationMVC.ServiceReference.Goods[]> FindAsync(System.Func<WebApplicationMVC.ServiceReference.Goods, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Create", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/CreateResponse")]
        void Create(WebApplicationMVC.ServiceReference.Goods item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Create", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/CreateResponse")]
        System.Threading.Tasks.Task CreateAsync(WebApplicationMVC.ServiceReference.Goods item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Update", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/UpdateResponse")]
        void Update(WebApplicationMVC.ServiceReference.Goods item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Update", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(WebApplicationMVC.ServiceReference.Goods item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Delete", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/DeleteResponse")]
        void Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceRepositoryOf_Goods/Delete", ReplyAction="http://tempuri.org/IServiceRepositoryOf_Goods/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceRepositoryOf_GoodsChannel : WebApplicationMVC.ServiceReference.IServiceRepositoryOf_Goods, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceRepositoryOf_GoodsClient : System.ServiceModel.ClientBase<WebApplicationMVC.ServiceReference.IServiceRepositoryOf_Goods>, WebApplicationMVC.ServiceReference.IServiceRepositoryOf_Goods {
        
        public ServiceRepositoryOf_GoodsClient() {
        }
        
        public ServiceRepositoryOf_GoodsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceRepositoryOf_GoodsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceRepositoryOf_GoodsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceRepositoryOf_GoodsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApplicationMVC.ServiceReference.Goods[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<WebApplicationMVC.ServiceReference.Goods[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public WebApplicationMVC.ServiceReference.Goods Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<WebApplicationMVC.ServiceReference.Goods> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public WebApplicationMVC.ServiceReference.Goods[] Find(System.Func<WebApplicationMVC.ServiceReference.Goods, bool> predicate) {
            return base.Channel.Find(predicate);
        }
        
        public System.Threading.Tasks.Task<WebApplicationMVC.ServiceReference.Goods[]> FindAsync(System.Func<WebApplicationMVC.ServiceReference.Goods, bool> predicate) {
            return base.Channel.FindAsync(predicate);
        }
        
        public void Create(WebApplicationMVC.ServiceReference.Goods item) {
            base.Channel.Create(item);
        }
        
        public System.Threading.Tasks.Task CreateAsync(WebApplicationMVC.ServiceReference.Goods item) {
            return base.Channel.CreateAsync(item);
        }
        
        public void Update(WebApplicationMVC.ServiceReference.Goods item) {
            base.Channel.Update(item);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(WebApplicationMVC.ServiceReference.Goods item) {
            return base.Channel.UpdateAsync(item);
        }
        
        public void Delete(int id) {
            base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}