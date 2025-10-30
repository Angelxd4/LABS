<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="AppPruebaGit.Vista.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CRUD Usuarios</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" />

</head>
<body class="container mt-4">
    <form runat="server">
        <h2 class="mb-3">Gestion de Usuarios</h2>
        <div class="row mb-3">
            <div class="col"><asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control" placeholder="Documento" /></div>
            <div class="col"><asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Nombre" /></div>
            <div class="col"><asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Apellido" /></div>
            <div class="col"><asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" /></div>      
        </div>

        <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-success" Text="Registrar" OnClick="btnRegistrar_Click" />
        <asp:Button ID="btnEditar" runat="server" CssClass="btn btn-warning" Text="Editar" OnClick="btnEditar_Click" />
        <asp:Button ID="btnEliminar" runat="server" CssClass="btn btn-danger" Text="Eliminar" OnClick="btnEliminar_Click" />
        <asp:Button ID="btnBuscar" runat="server" CssClass="btn btn-info" Text="Buscar" OnClick="btnBuscar_Click" />

        <hr />
        <asp:GridView ID="gvUsuarios" runat="server" CssClass="table table-bordered mt-3"></asp:GridView>
    
    </form>
</body>
</html>
