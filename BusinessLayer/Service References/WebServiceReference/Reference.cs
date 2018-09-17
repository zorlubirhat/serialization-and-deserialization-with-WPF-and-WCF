﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLayer.WebServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceReference.IItemService")]
    public interface IItemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getFiles", ReplyAction="http://tempuri.org/IItemService/getFilesResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<ItemCatalog.Items>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ItemCatalog.Items))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ItemCatalog.ItemCatalog))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<object>))]
        System.Collections.Generic.List<object> getFiles(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getFiles", ReplyAction="http://tempuri.org/IItemService/getFilesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<object>> getFilesAsync(string filename);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getItems", ReplyAction="http://tempuri.org/IItemService/getItemsResponse")]
        System.Collections.Generic.List<ItemCatalog.Items> getItems(string bodyFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getItems", ReplyAction="http://tempuri.org/IItemService/getItemsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<ItemCatalog.Items>> getItemsAsync(string bodyFile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/createNewItem", ReplyAction="http://tempuri.org/IItemService/createNewItemResponse")]
        void createNewItem(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items newbook);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/createNewItem", ReplyAction="http://tempuri.org/IItemService/createNewItemResponse")]
        System.Threading.Tasks.Task createNewItemAsync(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items newbook);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/editItem", ReplyAction="http://tempuri.org/IItemService/editItemResponse")]
        void editItem(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items book, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/editItem", ReplyAction="http://tempuri.org/IItemService/editItemResponse")]
        System.Threading.Tasks.Task editItemAsync(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items book, int index);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IItemServiceChannel : BusinessLayer.WebServiceReference.IItemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<BusinessLayer.WebServiceReference.IItemService>, BusinessLayer.WebServiceReference.IItemService {
        
        public ItemServiceClient() {
        }
        
        public ItemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<object> getFiles(string filename) {
            return base.Channel.getFiles(filename);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<object>> getFilesAsync(string filename) {
            return base.Channel.getFilesAsync(filename);
        }
        
        public System.Collections.Generic.List<ItemCatalog.Items> getItems(string bodyFile) {
            return base.Channel.getItems(bodyFile);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<ItemCatalog.Items>> getItemsAsync(string bodyFile) {
            return base.Channel.getItemsAsync(bodyFile);
        }
        
        public void createNewItem(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items newbook) {
            base.Channel.createNewItem(xml, catalog, newbook);
        }
        
        public System.Threading.Tasks.Task createNewItemAsync(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items newbook) {
            return base.Channel.createNewItemAsync(xml, catalog, newbook);
        }
        
        public void editItem(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items book, int index) {
            base.Channel.editItem(xml, catalog, book, index);
        }
        
        public System.Threading.Tasks.Task editItemAsync(string xml, ItemCatalog.ItemCatalog catalog, ItemCatalog.Items book, int index) {
            return base.Channel.editItemAsync(xml, catalog, book, index);
        }
    }
}
