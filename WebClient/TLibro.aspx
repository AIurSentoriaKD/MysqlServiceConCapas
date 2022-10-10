<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TLibro.aspx.cs" Inherits="WebClient.TLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <center>
    <h3>Mantenimiento Libros</h3>
     <p>
        Codigo Libro: <asp:TextBox runat="server" ID="txtCodLibro" />
    </p>
    <p>
        Titulo Libro: <asp:TextBox runat="server" ID="txtTitulo" />
    </p>
    <p>
        Editorial Libro: <asp:TextBox runat="server" ID="txtEditorial" />
    </p>

    <p> 
        <asp:Button Text="Agregar" runat="server" Id="btnAgregar" OnClick="btnAgregar_Click" />
        <asp:Button Text="Eliminar" runat="server" Id="btnEliminar" OnClick="btnEliminar_Click" />
        <asp:Button Text="Actualizar" runat="server" Id="btnActualizar" OnClick="btnActualizar_Click" />
        
    </p>
    <p>
        Buscar: <asp:TextBox runat="server" ID="txtbuscarLibro" />
    </p>
        <p>
            <asp:Button Text="Buscar" runat="server" Id="btnBuscarLibro" OnClick="btnBuscarLibro_Click" />
        </p>
    <p> 
        <asp:GridView runat="server" ID="gvLibros"></asp:GridView>
    </p>
        </center>


</asp:Content>
