﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace Cliente.EstacionService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EstacionSoap11Binding", Namespace="http://master")]
    public partial class Estacion : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback setPantallaOperationCompleted;
        
        private System.Threading.SendOrPostCallback logOperationCompleted;
        
        private System.Threading.SendOrPostCallback setTemperaturaOperationCompleted;
        
        private System.Threading.SendOrPostCallback getHumedadOperationCompleted;
        
        private System.Threading.SendOrPostCallback setLuminosidadOperationCompleted;
        
        private System.Threading.SendOrPostCallback getLuminosidadOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPantallaOperationCompleted;
        
        private System.Threading.SendOrPostCallback setEncriptadoOperationCompleted;
        
        private System.Threading.SendOrPostCallback getTemperaturaOperationCompleted;
        
        private System.Threading.SendOrPostCallback suscribirAEstacionOperationCompleted;
        
        private System.Threading.SendOrPostCallback setHumedadOperationCompleted;
        
        private System.Threading.SendOrPostCallback MainOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Estacion() {
            this.Url = global::Cliente.Properties.Settings.Default.Cliente_EstacionService_Estacion;
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
        public event setPantallaCompletedEventHandler setPantallaCompleted;
        
        /// <remarks/>
        public event logCompletedEventHandler logCompleted;
        
        /// <remarks/>
        public event setTemperaturaCompletedEventHandler setTemperaturaCompleted;
        
        /// <remarks/>
        public event getHumedadCompletedEventHandler getHumedadCompleted;
        
        /// <remarks/>
        public event setLuminosidadCompletedEventHandler setLuminosidadCompleted;
        
        /// <remarks/>
        public event getLuminosidadCompletedEventHandler getLuminosidadCompleted;
        
        /// <remarks/>
        public event getPantallaCompletedEventHandler getPantallaCompleted;
        
        /// <remarks/>
        public event setEncriptadoCompletedEventHandler setEncriptadoCompleted;
        
        /// <remarks/>
        public event getTemperaturaCompletedEventHandler getTemperaturaCompleted;
        
        /// <remarks/>
        public event suscribirAEstacionCompletedEventHandler suscribirAEstacionCompleted;
        
        /// <remarks/>
        public event setHumedadCompletedEventHandler setHumedadCompleted;
        
        /// <remarks/>
        public event MainCompletedEventHandler MainCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setPantalla", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setPantalla([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string pantalla, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string encript) {
            object[] results = this.Invoke("setPantalla", new object[] {
                        pantalla,
                        encript});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setPantallaAsync(string pantalla, string encript) {
            this.setPantallaAsync(pantalla, encript, null);
        }
        
        /// <remarks/>
        public void setPantallaAsync(string pantalla, string encript, object userState) {
            if ((this.setPantallaOperationCompleted == null)) {
                this.setPantallaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetPantallaOperationCompleted);
            }
            this.InvokeAsync("setPantalla", new object[] {
                        pantalla,
                        encript}, this.setPantallaOperationCompleted, userState);
        }
        
        private void OnsetPantallaOperationCompleted(object arg) {
            if ((this.setPantallaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setPantallaCompleted(this, new setPantallaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:log", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string log([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string user, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string ip, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string UTC, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string operacion, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string elemento) {
            object[] results = this.Invoke("log", new object[] {
                        user,
                        ip,
                        UTC,
                        operacion,
                        elemento});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void logAsync(string user, string ip, string UTC, string operacion, string elemento) {
            this.logAsync(user, ip, UTC, operacion, elemento, null);
        }
        
        /// <remarks/>
        public void logAsync(string user, string ip, string UTC, string operacion, string elemento, object userState) {
            if ((this.logOperationCompleted == null)) {
                this.logOperationCompleted = new System.Threading.SendOrPostCallback(this.OnlogOperationCompleted);
            }
            this.InvokeAsync("log", new object[] {
                        user,
                        ip,
                        UTC,
                        operacion,
                        elemento}, this.logOperationCompleted, userState);
        }
        
        private void OnlogOperationCompleted(object arg) {
            if ((this.logCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.logCompleted(this, new logCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setTemperatura", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setTemperatura([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string temperatura, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string encript) {
            object[] results = this.Invoke("setTemperatura", new object[] {
                        temperatura,
                        encript});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setTemperaturaAsync(string temperatura, string encript) {
            this.setTemperaturaAsync(temperatura, encript, null);
        }
        
        /// <remarks/>
        public void setTemperaturaAsync(string temperatura, string encript, object userState) {
            if ((this.setTemperaturaOperationCompleted == null)) {
                this.setTemperaturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetTemperaturaOperationCompleted);
            }
            this.InvokeAsync("setTemperatura", new object[] {
                        temperatura,
                        encript}, this.setTemperaturaOperationCompleted, userState);
        }
        
        private void OnsetTemperaturaOperationCompleted(object arg) {
            if ((this.setTemperaturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setTemperaturaCompleted(this, new setTemperaturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getHumedad", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getHumedad() {
            object[] results = this.Invoke("getHumedad", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getHumedadAsync() {
            this.getHumedadAsync(null);
        }
        
        /// <remarks/>
        public void getHumedadAsync(object userState) {
            if ((this.getHumedadOperationCompleted == null)) {
                this.getHumedadOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetHumedadOperationCompleted);
            }
            this.InvokeAsync("getHumedad", new object[0], this.getHumedadOperationCompleted, userState);
        }
        
        private void OngetHumedadOperationCompleted(object arg) {
            if ((this.getHumedadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getHumedadCompleted(this, new getHumedadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setLuminosidad", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setLuminosidad([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string luminosidad, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string encript) {
            object[] results = this.Invoke("setLuminosidad", new object[] {
                        luminosidad,
                        encript});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setLuminosidadAsync(string luminosidad, string encript) {
            this.setLuminosidadAsync(luminosidad, encript, null);
        }
        
        /// <remarks/>
        public void setLuminosidadAsync(string luminosidad, string encript, object userState) {
            if ((this.setLuminosidadOperationCompleted == null)) {
                this.setLuminosidadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetLuminosidadOperationCompleted);
            }
            this.InvokeAsync("setLuminosidad", new object[] {
                        luminosidad,
                        encript}, this.setLuminosidadOperationCompleted, userState);
        }
        
        private void OnsetLuminosidadOperationCompleted(object arg) {
            if ((this.setLuminosidadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setLuminosidadCompleted(this, new setLuminosidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getLuminosidad", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getLuminosidad() {
            object[] results = this.Invoke("getLuminosidad", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getLuminosidadAsync() {
            this.getLuminosidadAsync(null);
        }
        
        /// <remarks/>
        public void getLuminosidadAsync(object userState) {
            if ((this.getLuminosidadOperationCompleted == null)) {
                this.getLuminosidadOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetLuminosidadOperationCompleted);
            }
            this.InvokeAsync("getLuminosidad", new object[0], this.getLuminosidadOperationCompleted, userState);
        }
        
        private void OngetLuminosidadOperationCompleted(object arg) {
            if ((this.getLuminosidadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getLuminosidadCompleted(this, new getLuminosidadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getPantalla", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getPantalla() {
            object[] results = this.Invoke("getPantalla", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getPantallaAsync() {
            this.getPantallaAsync(null);
        }
        
        /// <remarks/>
        public void getPantallaAsync(object userState) {
            if ((this.getPantallaOperationCompleted == null)) {
                this.getPantallaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPantallaOperationCompleted);
            }
            this.InvokeAsync("getPantalla", new object[0], this.getPantallaOperationCompleted, userState);
        }
        
        private void OngetPantallaOperationCompleted(object arg) {
            if ((this.getPantallaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPantallaCompleted(this, new getPantallaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setEncriptado", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void setEncriptado([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string encriptado) {
            this.Invoke("setEncriptado", new object[] {
                        encriptado});
        }
        
        /// <remarks/>
        public void setEncriptadoAsync(string encriptado) {
            this.setEncriptadoAsync(encriptado, null);
        }
        
        /// <remarks/>
        public void setEncriptadoAsync(string encriptado, object userState) {
            if ((this.setEncriptadoOperationCompleted == null)) {
                this.setEncriptadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetEncriptadoOperationCompleted);
            }
            this.InvokeAsync("setEncriptado", new object[] {
                        encriptado}, this.setEncriptadoOperationCompleted, userState);
        }
        
        private void OnsetEncriptadoOperationCompleted(object arg) {
            if ((this.setEncriptadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setEncriptadoCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getTemperatura", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string getTemperatura() {
            object[] results = this.Invoke("getTemperatura", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getTemperaturaAsync() {
            this.getTemperaturaAsync(null);
        }
        
        /// <remarks/>
        public void getTemperaturaAsync(object userState) {
            if ((this.getTemperaturaOperationCompleted == null)) {
                this.getTemperaturaOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetTemperaturaOperationCompleted);
            }
            this.InvokeAsync("getTemperatura", new object[0], this.getTemperaturaOperationCompleted, userState);
        }
        
        private void OngetTemperaturaOperationCompleted(object arg) {
            if ((this.getTemperaturaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getTemperaturaCompleted(this, new getTemperaturaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:suscribirAEstacion", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string suscribirAEstacion([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string IP, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string puerto, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string prop, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string min, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string max) {
            object[] results = this.Invoke("suscribirAEstacion", new object[] {
                        IP,
                        puerto,
                        prop,
                        min,
                        max});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void suscribirAEstacionAsync(string IP, string puerto, string prop, string min, string max) {
            this.suscribirAEstacionAsync(IP, puerto, prop, min, max, null);
        }
        
        /// <remarks/>
        public void suscribirAEstacionAsync(string IP, string puerto, string prop, string min, string max, object userState) {
            if ((this.suscribirAEstacionOperationCompleted == null)) {
                this.suscribirAEstacionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsuscribirAEstacionOperationCompleted);
            }
            this.InvokeAsync("suscribirAEstacion", new object[] {
                        IP,
                        puerto,
                        prop,
                        min,
                        max}, this.suscribirAEstacionOperationCompleted, userState);
        }
        
        private void OnsuscribirAEstacionOperationCompleted(object arg) {
            if ((this.suscribirAEstacionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.suscribirAEstacionCompleted(this, new suscribirAEstacionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:setHumedad", RequestNamespace="http://master", ResponseNamespace="http://master", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public string setHumedad([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string humedad, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string encript) {
            object[] results = this.Invoke("setHumedad", new object[] {
                        humedad,
                        encript});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void setHumedadAsync(string humedad, string encript) {
            this.setHumedadAsync(humedad, encript, null);
        }
        
        /// <remarks/>
        public void setHumedadAsync(string humedad, string encript, object userState) {
            if ((this.setHumedadOperationCompleted == null)) {
                this.setHumedadOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsetHumedadOperationCompleted);
            }
            this.InvokeAsync("setHumedad", new object[] {
                        humedad,
                        encript}, this.setHumedadOperationCompleted, userState);
        }
        
        private void OnsetHumedadOperationCompleted(object arg) {
            if ((this.setHumedadCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.setHumedadCompleted(this, new setHumedadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:Main", RequestNamespace="http://master", OneWay=true, Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Main([System.Xml.Serialization.XmlElementAttribute("args", IsNullable=true)] string[] args) {
            this.Invoke("Main", new object[] {
                        args});
        }
        
        /// <remarks/>
        public void MainAsync(string[] args) {
            this.MainAsync(args, null);
        }
        
        /// <remarks/>
        public void MainAsync(string[] args, object userState) {
            if ((this.MainOperationCompleted == null)) {
                this.MainOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMainOperationCompleted);
            }
            this.InvokeAsync("Main", new object[] {
                        args}, this.MainOperationCompleted, userState);
        }
        
        private void OnMainOperationCompleted(object arg) {
            if ((this.MainCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MainCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void setPantallaCompletedEventHandler(object sender, setPantallaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setPantallaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setPantallaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void logCompletedEventHandler(object sender, logCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class logCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal logCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void setTemperaturaCompletedEventHandler(object sender, setTemperaturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setTemperaturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setTemperaturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void getHumedadCompletedEventHandler(object sender, getHumedadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getHumedadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getHumedadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void setLuminosidadCompletedEventHandler(object sender, setLuminosidadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setLuminosidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setLuminosidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void getLuminosidadCompletedEventHandler(object sender, getLuminosidadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getLuminosidadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getLuminosidadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void getPantallaCompletedEventHandler(object sender, getPantallaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPantallaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPantallaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void setEncriptadoCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void getTemperaturaCompletedEventHandler(object sender, getTemperaturaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getTemperaturaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getTemperaturaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void suscribirAEstacionCompletedEventHandler(object sender, suscribirAEstacionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class suscribirAEstacionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal suscribirAEstacionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void setHumedadCompletedEventHandler(object sender, setHumedadCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class setHumedadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal setHumedadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3190.0")]
    public delegate void MainCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591