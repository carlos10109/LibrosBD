﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrosSW.Cliente.LibrosServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Libro", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Libro : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdLibroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaLanzamientoField;
        
        private int AutorField;
        
        private int CategoriaField;
        
        private int EditorialField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdiomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
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
        public int IdLibro {
            get {
                return this.IdLibroField;
            }
            set {
                if ((this.IdLibroField.Equals(value) != true)) {
                    this.IdLibroField = value;
                    this.RaisePropertyChanged("IdLibro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Titulo {
            get {
                return this.TituloField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloField, value) != true)) {
                    this.TituloField = value;
                    this.RaisePropertyChanged("Titulo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string FechaLanzamiento {
            get {
                return this.FechaLanzamientoField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaLanzamientoField, value) != true)) {
                    this.FechaLanzamientoField = value;
                    this.RaisePropertyChanged("FechaLanzamiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public int Autor {
            get {
                return this.AutorField;
            }
            set {
                if ((this.AutorField.Equals(value) != true)) {
                    this.AutorField = value;
                    this.RaisePropertyChanged("Autor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((this.CategoriaField.Equals(value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public int Editorial {
            get {
                return this.EditorialField;
            }
            set {
                if ((this.EditorialField.Equals(value) != true)) {
                    this.EditorialField = value;
                    this.RaisePropertyChanged("Editorial");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Idioma {
            get {
                return this.IdiomaField;
            }
            set {
                if ((object.ReferenceEquals(this.IdiomaField, value) != true)) {
                    this.IdiomaField = value;
                    this.RaisePropertyChanged("Idioma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LibrosServiceReference.LibrosWebServiceSoap")]
    public interface LibrosWebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponse HelloWorld(LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponse> HelloWorldAsync(LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetLibrosResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLibros", ReplyAction="*")]
        LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponse GetLibros(LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLibros", ReplyAction="*")]
        System.Threading.Tasks.Task<LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponse> GetLibrosAsync(LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLibrosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLibros", Namespace="http://tempuri.org/", Order=0)]
        public LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequestBody Body;
        
        public GetLibrosRequest() {
        }
        
        public GetLibrosRequest(LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetLibrosRequestBody {
        
        public GetLibrosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetLibrosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetLibrosResponse", Namespace="http://tempuri.org/", Order=0)]
        public LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponseBody Body;
        
        public GetLibrosResponse() {
        }
        
        public GetLibrosResponse(LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetLibrosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public LibrosSW.Cliente.LibrosServiceReference.Libro[] GetLibrosResult;
        
        public GetLibrosResponseBody() {
        }
        
        public GetLibrosResponseBody(LibrosSW.Cliente.LibrosServiceReference.Libro[] GetLibrosResult) {
            this.GetLibrosResult = GetLibrosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LibrosWebServiceSoapChannel : LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LibrosWebServiceSoapClient : System.ServiceModel.ClientBase<LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap>, LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap {
        
        public LibrosWebServiceSoapClient() {
        }
        
        public LibrosWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LibrosWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibrosWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LibrosWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponse LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap.HelloWorld(LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest inValue = new LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest();
            inValue.Body = new LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequestBody();
            LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponse retVal = ((LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponse> LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap.HelloWorldAsync(LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<LibrosSW.Cliente.LibrosServiceReference.HelloWorldResponse> HelloWorldAsync() {
            LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest inValue = new LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequest();
            inValue.Body = new LibrosSW.Cliente.LibrosServiceReference.HelloWorldRequestBody();
            return ((LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponse LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap.GetLibros(LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest request) {
            return base.Channel.GetLibros(request);
        }
        
        public LibrosSW.Cliente.LibrosServiceReference.Libro[] GetLibros() {
            LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest inValue = new LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest();
            inValue.Body = new LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequestBody();
            LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponse retVal = ((LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap)(this)).GetLibros(inValue);
            return retVal.Body.GetLibrosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponse> LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap.GetLibrosAsync(LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest request) {
            return base.Channel.GetLibrosAsync(request);
        }
        
        public System.Threading.Tasks.Task<LibrosSW.Cliente.LibrosServiceReference.GetLibrosResponse> GetLibrosAsync() {
            LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest inValue = new LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequest();
            inValue.Body = new LibrosSW.Cliente.LibrosServiceReference.GetLibrosRequestBody();
            return ((LibrosSW.Cliente.LibrosServiceReference.LibrosWebServiceSoap)(this)).GetLibrosAsync(inValue);
        }
    }
}
