﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WSClienteSoap")]
    public interface WSClienteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarAutor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAutorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarAutor(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAutorAsync(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AgregarAutor(string codAutor, string nombres, string apellidos, string nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAutorAsync(string codAutor, string nombres, string apellidos, string nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] ActualizarAutor(string codAutor, string nombres, string apellidos, string nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAutorAsync(string codAutor, string nombres, string apellidos, string nacionalidad);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarAutor", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EliminarAutor(string codautor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarAutor", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAutorAsync(string codautor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarLibro();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarLibroAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarLibro(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarLibroAsync(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AgregarLibro(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarLibroAsync(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] ActualizarLibro(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ActualizarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarLibroAsync(string codLibro, string titulo, string editorial);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarLibro", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EliminarLibro(string codlibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarLibro", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarLibroAsync(string codlibro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarPrestamo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarPrestamo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarPrestamo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarPrestamoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarPrestamo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet BuscarPrestamo(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/BuscarPrestamo", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarPrestamoAsync(string busqueda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarPrestamo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] AgregarPrestamo(string codAutor, string codLibro, string fechaPrestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarPrestamo", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarPrestamoAsync(string codAutor, string codLibro, string fechaPrestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPrestamo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] EliminarPrestamo(string codAutor, string codLibro, string fechaPrestamo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarPrestamo", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarPrestamoAsync(string codAutor, string codLibro, string fechaPrestamo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSClienteSoapChannel : ConsoleClient.ServiceReference1.WSClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSClienteSoapClient : System.ServiceModel.ClientBase<ConsoleClient.ServiceReference1.WSClienteSoap>, ConsoleClient.ServiceReference1.WSClienteSoap {
        
        public WSClienteSoapClient() {
        }
        
        public WSClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet ListarAutor() {
            return base.Channel.ListarAutor();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAutorAsync() {
            return base.Channel.ListarAutorAsync();
        }
        
        public System.Data.DataSet BuscarAutor(string busqueda) {
            return base.Channel.BuscarAutor(busqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAutorAsync(string busqueda) {
            return base.Channel.BuscarAutorAsync(busqueda);
        }
        
        public string[] AgregarAutor(string codAutor, string nombres, string apellidos, string nacionalidad) {
            return base.Channel.AgregarAutor(codAutor, nombres, apellidos, nacionalidad);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAutorAsync(string codAutor, string nombres, string apellidos, string nacionalidad) {
            return base.Channel.AgregarAutorAsync(codAutor, nombres, apellidos, nacionalidad);
        }
        
        public string[] ActualizarAutor(string codAutor, string nombres, string apellidos, string nacionalidad) {
            return base.Channel.ActualizarAutor(codAutor, nombres, apellidos, nacionalidad);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAutorAsync(string codAutor, string nombres, string apellidos, string nacionalidad) {
            return base.Channel.ActualizarAutorAsync(codAutor, nombres, apellidos, nacionalidad);
        }
        
        public string[] EliminarAutor(string codautor) {
            return base.Channel.EliminarAutor(codautor);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAutorAsync(string codautor) {
            return base.Channel.EliminarAutorAsync(codautor);
        }
        
        public System.Data.DataSet ListarLibro() {
            return base.Channel.ListarLibro();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarLibroAsync() {
            return base.Channel.ListarLibroAsync();
        }
        
        public System.Data.DataSet BuscarLibro(string busqueda) {
            return base.Channel.BuscarLibro(busqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarLibroAsync(string busqueda) {
            return base.Channel.BuscarLibroAsync(busqueda);
        }
        
        public string[] AgregarLibro(string codLibro, string titulo, string editorial) {
            return base.Channel.AgregarLibro(codLibro, titulo, editorial);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarLibroAsync(string codLibro, string titulo, string editorial) {
            return base.Channel.AgregarLibroAsync(codLibro, titulo, editorial);
        }
        
        public string[] ActualizarLibro(string codLibro, string titulo, string editorial) {
            return base.Channel.ActualizarLibro(codLibro, titulo, editorial);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarLibroAsync(string codLibro, string titulo, string editorial) {
            return base.Channel.ActualizarLibroAsync(codLibro, titulo, editorial);
        }
        
        public string[] EliminarLibro(string codlibro) {
            return base.Channel.EliminarLibro(codlibro);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarLibroAsync(string codlibro) {
            return base.Channel.EliminarLibroAsync(codlibro);
        }
        
        public System.Data.DataSet ListarPrestamo() {
            return base.Channel.ListarPrestamo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarPrestamoAsync() {
            return base.Channel.ListarPrestamoAsync();
        }
        
        public System.Data.DataSet BuscarPrestamo(string busqueda) {
            return base.Channel.BuscarPrestamo(busqueda);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarPrestamoAsync(string busqueda) {
            return base.Channel.BuscarPrestamoAsync(busqueda);
        }
        
        public string[] AgregarPrestamo(string codAutor, string codLibro, string fechaPrestamo) {
            return base.Channel.AgregarPrestamo(codAutor, codLibro, fechaPrestamo);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarPrestamoAsync(string codAutor, string codLibro, string fechaPrestamo) {
            return base.Channel.AgregarPrestamoAsync(codAutor, codLibro, fechaPrestamo);
        }
        
        public string[] EliminarPrestamo(string codAutor, string codLibro, string fechaPrestamo) {
            return base.Channel.EliminarPrestamo(codAutor, codLibro, fechaPrestamo);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarPrestamoAsync(string codAutor, string codLibro, string fechaPrestamo) {
            return base.Channel.EliminarPrestamoAsync(codAutor, codLibro, fechaPrestamo);
        }
    }
}