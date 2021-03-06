﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace SocioboardDataScheduler.Api.InstagramAccount {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="InstagramAccountSoap", Namespace="http://tempuri.org/")]
    public partial class InstagramAccount : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllInstagramAccountsOperationCompleted;
        
        private System.Threading.SendOrPostCallback UserInformationOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteInstagramAccountOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public InstagramAccount() {
            this.Url = global::SocioboardDataScheduler.Properties.Settings.Default.SocioboardDataScheduler_Api_InstagramAccount_InstagramAccount;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAllInstagramAccountsCompletedEventHandler GetAllInstagramAccountsCompleted;
        
        /// <remarks/>
        public event UserInformationCompletedEventHandler UserInformationCompleted;
        
        /// <remarks/>
        public event DeleteInstagramAccountCompletedEventHandler DeleteInstagramAccountCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllInstagramAccounts", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllInstagramAccounts(string Userid) {
            object[] results = this.Invoke("GetAllInstagramAccounts", new object[] {
                        Userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllInstagramAccountsAsync(string Userid) {
            this.GetAllInstagramAccountsAsync(Userid, null);
        }
        
        /// <remarks/>
        public void GetAllInstagramAccountsAsync(string Userid, object userState) {
            if ((this.GetAllInstagramAccountsOperationCompleted == null)) {
                this.GetAllInstagramAccountsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllInstagramAccountsOperationCompleted);
            }
            this.InvokeAsync("GetAllInstagramAccounts", new object[] {
                        Userid}, this.GetAllInstagramAccountsOperationCompleted, userState);
        }
        
        private void OnGetAllInstagramAccountsOperationCompleted(object arg) {
            if ((this.GetAllInstagramAccountsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllInstagramAccountsCompleted(this, new GetAllInstagramAccountsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UserInformation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UserInformation(string UserId, string LinkedinId) {
            object[] results = this.Invoke("UserInformation", new object[] {
                        UserId,
                        LinkedinId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UserInformationAsync(string UserId, string LinkedinId) {
            this.UserInformationAsync(UserId, LinkedinId, null);
        }
        
        /// <remarks/>
        public void UserInformationAsync(string UserId, string LinkedinId, object userState) {
            if ((this.UserInformationOperationCompleted == null)) {
                this.UserInformationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUserInformationOperationCompleted);
            }
            this.InvokeAsync("UserInformation", new object[] {
                        UserId,
                        LinkedinId}, this.UserInformationOperationCompleted, userState);
        }
        
        private void OnUserInformationOperationCompleted(object arg) {
            if ((this.UserInformationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UserInformationCompleted(this, new UserInformationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteInstagramAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteInstagramAccount(string UserId, string ProfileId, string GroupId) {
            object[] results = this.Invoke("DeleteInstagramAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteInstagramAccountAsync(string UserId, string ProfileId, string GroupId) {
            this.DeleteInstagramAccountAsync(UserId, ProfileId, GroupId, null);
        }
        
        /// <remarks/>
        public void DeleteInstagramAccountAsync(string UserId, string ProfileId, string GroupId, object userState) {
            if ((this.DeleteInstagramAccountOperationCompleted == null)) {
                this.DeleteInstagramAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteInstagramAccountOperationCompleted);
            }
            this.InvokeAsync("DeleteInstagramAccount", new object[] {
                        UserId,
                        ProfileId,
                        GroupId}, this.DeleteInstagramAccountOperationCompleted, userState);
        }
        
        private void OnDeleteInstagramAccountOperationCompleted(object arg) {
            if ((this.DeleteInstagramAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteInstagramAccountCompleted(this, new DeleteInstagramAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetAllInstagramAccountsCompletedEventHandler(object sender, GetAllInstagramAccountsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllInstagramAccountsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllInstagramAccountsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void UserInformationCompletedEventHandler(object sender, UserInformationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UserInformationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UserInformationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteInstagramAccountCompletedEventHandler(object sender, DeleteInstagramAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteInstagramAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteInstagramAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591