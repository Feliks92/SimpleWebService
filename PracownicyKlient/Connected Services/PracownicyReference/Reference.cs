﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracownicyKlient.PracownicyReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pracownik", Namespace="http://schemas.datacontract.org/2004/07/pracownicy")]
    [System.SerializableAttribute()]
    public partial class Pracownik : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NazwiskoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PESELField;
        
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
        public string Imie {
            get {
                return this.ImieField;
            }
            set {
                if ((object.ReferenceEquals(this.ImieField, value) != true)) {
                    this.ImieField = value;
                    this.RaisePropertyChanged("Imie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nazwisko {
            get {
                return this.NazwiskoField;
            }
            set {
                if ((object.ReferenceEquals(this.NazwiskoField, value) != true)) {
                    this.NazwiskoField = value;
                    this.RaisePropertyChanged("Nazwisko");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PESEL {
            get {
                return this.PESELField;
            }
            set {
                if ((object.ReferenceEquals(this.PESELField, value) != true)) {
                    this.PESELField = value;
                    this.RaisePropertyChanged("PESEL");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PracownicyReference.IServicePracownicy")]
    public interface IServicePracownicy {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/DodajPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/DodajPracownikaResponse")]
        int DodajPracownika(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/DodajPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/DodajPracownikaResponse")]
        System.Threading.Tasks.Task<int> DodajPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/WczytajPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/WczytajPracownikaResponse")]
        string WczytajPracownika(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/WczytajPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/WczytajPracownikaResponse")]
        System.Threading.Tasks.Task<string> WczytajPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/SprawdzPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/SprawdzPracownikaResponse")]
        int SprawdzPracownika(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/SprawdzPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/SprawdzPracownikaResponse")]
        System.Threading.Tasks.Task<int> SprawdzPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/UsunPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/UsunPracownikaResponse")]
        int UsunPracownika(PracownicyKlient.PracownicyReference.Pracownik p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePracownicy/UsunPracownika", ReplyAction="http://tempuri.org/IServicePracownicy/UsunPracownikaResponse")]
        System.Threading.Tasks.Task<int> UsunPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePracownicyChannel : PracownicyKlient.PracownicyReference.IServicePracownicy, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePracownicyClient : System.ServiceModel.ClientBase<PracownicyKlient.PracownicyReference.IServicePracownicy>, PracownicyKlient.PracownicyReference.IServicePracownicy {
        
        public ServicePracownicyClient() {
        }
        
        public ServicePracownicyClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePracownicyClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePracownicyClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePracownicyClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int DodajPracownika(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.DodajPracownika(p);
        }
        
        public System.Threading.Tasks.Task<int> DodajPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.DodajPracownikaAsync(p);
        }
        
        public string WczytajPracownika(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.WczytajPracownika(p);
        }
        
        public System.Threading.Tasks.Task<string> WczytajPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.WczytajPracownikaAsync(p);
        }
        
        public int SprawdzPracownika(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.SprawdzPracownika(p);
        }
        
        public System.Threading.Tasks.Task<int> SprawdzPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.SprawdzPracownikaAsync(p);
        }
        
        public int UsunPracownika(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.UsunPracownika(p);
        }
        
        public System.Threading.Tasks.Task<int> UsunPracownikaAsync(PracownicyKlient.PracownicyReference.Pracownik p) {
            return base.Channel.UsunPracownikaAsync(p);
        }
    }
}
