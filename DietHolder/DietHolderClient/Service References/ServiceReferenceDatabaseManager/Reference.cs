﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DietHolderClient.ServiceReferenceDatabaseManager {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Products", Namespace="http://schemas.datacontract.org/2004/07/DietHolderServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Products : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.DataTable ProductsDataTableField;
        
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
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.DataTable ProductsDataTable {
            get {
                return this.ProductsDataTableField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductsDataTableField, value) != true)) {
                    this.ProductsDataTableField = value;
                    this.RaisePropertyChanged("ProductsDataTable");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataToInteractWithDatabase", Namespace="http://schemas.datacontract.org/2004/07/DietHolderServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class DataToInteractWithDatabase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TableNameField;
        
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
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TableName {
            get {
                return this.TableNameField;
            }
            set {
                if ((object.ReferenceEquals(this.TableNameField, value) != true)) {
                    this.TableNameField = value;
                    this.RaisePropertyChanged("TableName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/DietHolderServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProductCarboValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProductFatValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProductProteinValueField;
        
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
        public double ProductCarboValue {
            get {
                return this.ProductCarboValueField;
            }
            set {
                if ((this.ProductCarboValueField.Equals(value) != true)) {
                    this.ProductCarboValueField = value;
                    this.RaisePropertyChanged("ProductCarboValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProductFatValue {
            get {
                return this.ProductFatValueField;
            }
            set {
                if ((this.ProductFatValueField.Equals(value) != true)) {
                    this.ProductFatValueField = value;
                    this.RaisePropertyChanged("ProductFatValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProductProteinValue {
            get {
                return this.ProductProteinValueField;
            }
            set {
                if ((this.ProductProteinValueField.Equals(value) != true)) {
                    this.ProductProteinValueField = value;
                    this.RaisePropertyChanged("ProductProteinValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDatabaseManager.IDatabaseManager")]
    public interface IDatabaseManager {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/ShowAllPositionsFromTableProducts", ReplyAction="http://tempuri.org/IDatabaseManager/ShowAllPositionsFromTableProductsResponse")]
        DietHolderClient.ServiceReferenceDatabaseManager.Products ShowAllPositionsFromTableProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/ShowAllPositionsFromTableProducts", ReplyAction="http://tempuri.org/IDatabaseManager/ShowAllPositionsFromTableProductsResponse")]
        System.Threading.Tasks.Task<DietHolderClient.ServiceReferenceDatabaseManager.Products> ShowAllPositionsFromTableProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/SearchProduct", ReplyAction="http://tempuri.org/IDatabaseManager/SearchProductResponse")]
        System.Data.DataTable SearchProduct(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase interactWithDatabase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/SearchProduct", ReplyAction="http://tempuri.org/IDatabaseManager/SearchProductResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> SearchProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase interactWithDatabase);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/InsertProduct", ReplyAction="http://tempuri.org/IDatabaseManager/InsertProductResponse")]
        void InsertProduct(DietHolderClient.ServiceReferenceDatabaseManager.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/InsertProduct", ReplyAction="http://tempuri.org/IDatabaseManager/InsertProductResponse")]
        System.Threading.Tasks.Task InsertProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/UpdateProduct", ReplyAction="http://tempuri.org/IDatabaseManager/UpdateProductResponse")]
        void UpdateProduct(DietHolderClient.ServiceReferenceDatabaseManager.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/UpdateProduct", ReplyAction="http://tempuri.org/IDatabaseManager/UpdateProductResponse")]
        System.Threading.Tasks.Task UpdateProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.Product product);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/DeleteProduct", ReplyAction="http://tempuri.org/IDatabaseManager/DeleteProductResponse")]
        void DeleteProduct(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase dataToInteract);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDatabaseManager/DeleteProduct", ReplyAction="http://tempuri.org/IDatabaseManager/DeleteProductResponse")]
        System.Threading.Tasks.Task DeleteProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase dataToInteract);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDatabaseManagerChannel : DietHolderClient.ServiceReferenceDatabaseManager.IDatabaseManager, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DatabaseManagerClient : System.ServiceModel.ClientBase<DietHolderClient.ServiceReferenceDatabaseManager.IDatabaseManager>, DietHolderClient.ServiceReferenceDatabaseManager.IDatabaseManager {
        
        public DatabaseManagerClient() {
        }
        
        public DatabaseManagerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DatabaseManagerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseManagerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DatabaseManagerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DietHolderClient.ServiceReferenceDatabaseManager.Products ShowAllPositionsFromTableProducts() {
            return base.Channel.ShowAllPositionsFromTableProducts();
        }
        
        public System.Threading.Tasks.Task<DietHolderClient.ServiceReferenceDatabaseManager.Products> ShowAllPositionsFromTableProductsAsync() {
            return base.Channel.ShowAllPositionsFromTableProductsAsync();
        }
        
        public System.Data.DataTable SearchProduct(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase interactWithDatabase) {
            return base.Channel.SearchProduct(interactWithDatabase);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> SearchProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase interactWithDatabase) {
            return base.Channel.SearchProductAsync(interactWithDatabase);
        }
        
        public void InsertProduct(DietHolderClient.ServiceReferenceDatabaseManager.Product product) {
            base.Channel.InsertProduct(product);
        }
        
        public System.Threading.Tasks.Task InsertProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.Product product) {
            return base.Channel.InsertProductAsync(product);
        }
        
        public void UpdateProduct(DietHolderClient.ServiceReferenceDatabaseManager.Product product) {
            base.Channel.UpdateProduct(product);
        }
        
        public System.Threading.Tasks.Task UpdateProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.Product product) {
            return base.Channel.UpdateProductAsync(product);
        }
        
        public void DeleteProduct(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase dataToInteract) {
            base.Channel.DeleteProduct(dataToInteract);
        }
        
        public System.Threading.Tasks.Task DeleteProductAsync(DietHolderClient.ServiceReferenceDatabaseManager.DataToInteractWithDatabase dataToInteract) {
            return base.Channel.DeleteProductAsync(dataToInteract);
        }
    }
}