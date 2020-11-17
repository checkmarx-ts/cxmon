﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Klaatu.Jobs.CxWsDataSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CxWsDataSvc.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Initialize", ReplyAction="http://tempuri.org/IService/InitializeResponse")]
        bool Initialize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Initialize", ReplyAction="http://tempuri.org/IService/InitializeResponse")]
        System.Threading.Tasks.Task<bool> InitializeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetActiveScans", ReplyAction="http://tempuri.org/IService/GetActiveScansResponse")]
        string GetActiveScans();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetActiveScans", ReplyAction="http://tempuri.org/IService/GetActiveScansResponse")]
        System.Threading.Tasks.Task<string> GetActiveScansAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNonAuditorUsersWhoCanMarkNotExploitable", ReplyAction="http://tempuri.org/IService/GetNonAuditorUsersWhoCanMarkNotExploitableResponse")]
        string GetNonAuditorUsersWhoCanMarkNotExploitable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNonAuditorUsersWhoCanMarkNotExploitable", ReplyAction="http://tempuri.org/IService/GetNonAuditorUsersWhoCanMarkNotExploitableResponse")]
        System.Threading.Tasks.Task<string> GetNonAuditorUsersWhoCanMarkNotExploitableAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTeamName", ReplyAction="http://tempuri.org/IService/GetTeamNameResponse")]
        string GetTeamName(string teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetTeamName", ReplyAction="http://tempuri.org/IService/GetTeamNameResponse")]
        System.Threading.Tasks.Task<string> GetTeamNameAsync(string teamId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCustomFields", ReplyAction="http://tempuri.org/IService/GetCustomFieldsResponse")]
        string GetCustomFields(long projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetCustomFields", ReplyAction="http://tempuri.org/IService/GetCustomFieldsResponse")]
        System.Threading.Tasks.Task<string> GetCustomFieldsAsync(long projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetScanFailEmail", ReplyAction="http://tempuri.org/IService/GetScanFailEmailResponse")]
        string GetScanFailEmail(long projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetScanFailEmail", ReplyAction="http://tempuri.org/IService/GetScanFailEmailResponse")]
        System.Threading.Tasks.Task<string> GetScanFailEmailAsync(long projectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetUserCantMarkNotExploitable", ReplyAction="http://tempuri.org/IService/SetUserCantMarkNotExploitableResponse")]
        bool SetUserCantMarkNotExploitable(long userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SetUserCantMarkNotExploitable", ReplyAction="http://tempuri.org/IService/SetUserCantMarkNotExploitableResponse")]
        System.Threading.Tasks.Task<bool> SetUserCantMarkNotExploitableAsync(long userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Klaatu.Jobs.CxWsDataSvc.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Klaatu.Jobs.CxWsDataSvc.IService>, Klaatu.Jobs.CxWsDataSvc.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public bool Initialize() {
            return base.Channel.Initialize();
        }
        
        public System.Threading.Tasks.Task<bool> InitializeAsync() {
            return base.Channel.InitializeAsync();
        }
        
        public string GetActiveScans() {
            return base.Channel.GetActiveScans();
        }
        
        public System.Threading.Tasks.Task<string> GetActiveScansAsync() {
            return base.Channel.GetActiveScansAsync();
        }
        
        public string GetNonAuditorUsersWhoCanMarkNotExploitable() {
            return base.Channel.GetNonAuditorUsersWhoCanMarkNotExploitable();
        }
        
        public System.Threading.Tasks.Task<string> GetNonAuditorUsersWhoCanMarkNotExploitableAsync() {
            return base.Channel.GetNonAuditorUsersWhoCanMarkNotExploitableAsync();
        }
        
        public string GetTeamName(string teamId) {
            return base.Channel.GetTeamName(teamId);
        }
        
        public System.Threading.Tasks.Task<string> GetTeamNameAsync(string teamId) {
            return base.Channel.GetTeamNameAsync(teamId);
        }
        
        public string GetCustomFields(long projectId) {
            return base.Channel.GetCustomFields(projectId);
        }
        
        public System.Threading.Tasks.Task<string> GetCustomFieldsAsync(long projectId) {
            return base.Channel.GetCustomFieldsAsync(projectId);
        }
        
        public string GetScanFailEmail(long projectId) {
            return base.Channel.GetScanFailEmail(projectId);
        }
        
        public System.Threading.Tasks.Task<string> GetScanFailEmailAsync(long projectId) {
            return base.Channel.GetScanFailEmailAsync(projectId);
        }
        
        public bool SetUserCantMarkNotExploitable(long userId) {
            return base.Channel.SetUserCantMarkNotExploitable(userId);
        }
        
        public System.Threading.Tasks.Task<bool> SetUserCantMarkNotExploitableAsync(long userId) {
            return base.Channel.SetUserCantMarkNotExploitableAsync(userId);
        }
    }
}
