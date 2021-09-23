<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="sitiosconexion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Direccion&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Telefono&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Edad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Altura<br />
            <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="txttelefono" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
&nbsp;<asp:TextBox ID="txtaltura" runat="server"></asp:TextBox>
            <br />
&nbsp;
            <br />
            <asp:GridView ID="gdmostrar" runat="server">
            </asp:GridView>
            <br />
            <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Mostrar " />
&nbsp;&nbsp;
            <asp:Button ID="btninsertar" runat="server" OnClick="btninsertar_Click" Text="Insertar" />
&nbsp;&nbsp;
            <asp:Button ID="btnmodificar" runat="server" OnClick="btnmodificar_Click" Text="Modificar" />
&nbsp;
            <asp:Button ID="btneliminar" runat="server" Text="Eliminar" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
