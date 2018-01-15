
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="WebApplication.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delivery Macana Software</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center" style="margin-top: 2cm">
            
           <h1> <asp:Label ID="LabelNombreComercial" runat="server"></asp:Label><br /></h1>
           <h2><small> <asp:Label ID="LabelDescripcion" runat="server"></asp:Label><br /></h2></small>
            <h3><small><asp:Label ID="LabelDomicilio" runat="server"></asp:Label><br /></small></h3>
            <h2><asp:Label ID="LabelTelefonoContacto" runat="server"></asp:Label><br /></h2>
            <dl><asp:Label ID="LabelHorarioAtencion" runat="server"></asp:Label><br /></dl>
        </div>
         <div align="center" style="margin-top: 2cm">
        <asp:GridView ID="GridViewProductos" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSourceProductos">
            <Columns>
                <asp:BoundField DataField="Prod_Cod" HeaderText="Prod_Cod" ReadOnly="True" SortExpression="Prod_Cod" />
                <asp:BoundField DataField="Prod_Desc" HeaderText="Prod_Desc" ReadOnly="True" SortExpression="Prod_Desc" />
                <asp:BoundField DataField="Prod_Precio" HeaderText="Prod_Precio" ReadOnly="True" SortExpression="Prod_Precio" />
            </Columns>
        </asp:GridView>

        <asp:LinqDataSource ID="LinqDataSourceProductos" runat="server" ContextTypeName="Database.DataClassesDataContext" EntityTypeName="" Select="new (Prod_Cod, Prod_Desc, Prod_Precio)" TableName="Productos" Where="Prod_Web == @Prod_Web">
            <WhereParameters>
                <asp:Parameter DefaultValue="true" Name="Prod_Web" Type="Boolean" />
            </WhereParameters>
        </asp:LinqDataSource>
             </div>
    </form>
</body>
</html>
