<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="VIsta.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <div class="form">
    <h1 class="titulo_form">Gestión de Departaentos</h1>
    <br />    
    <asp:HiddenField runat="server" ID="hf_id" />
   
    <br /> 
     <asp:Label runat="server" Text="nombre :" ID="lbl_cedula" CssClass="label" ></asp:Label> 
   <br />
   <asp:TextBox runat="server" ID="txt_nombre" CssClass="text"  ></asp:TextBox>
 <br />
 
     <asp:Label runat="server" Text="descripcion :" ID="Label2" CssClass="label" ></asp:Label> 
   <br />
   <asp:TextBox runat="server" ID="txt_descripcion"  CssClass="text" ></asp:TextBox>
 <br />
 
     <asp:Label runat="server" Text="marca :" ID="Label4" CssClass="label"></asp:Label> 
   <br />
   <asp:TextBox runat="server" ID="txt_marca" CssClass="text"></asp:TextBox>
 <br />
 
     <asp:Label runat="server" Text="precio :" ID="Label5" CssClass="label" ></asp:Label> 
   <br />
   <asp:TextBox runat="server" ID="txt_precio" CssClass="text" ></asp:TextBox>
 <br />
 
     <asp:Label runat="server" Text="stock :" ID="Label6" CssClass="label"></asp:Label> 
   <br />
   <asp:TextBox runat="server" ID="txt_stock" CssClass="text" ></asp:TextBox>
 <asp:Label Text="" ID="lbl_error" runat="server"></asp:Label>
 <br />
    <asp:Button Text="ELIMINAR" ID="btn_eliminar"  runat="server" CssClass="boton_form" OnClick="btn_eliminar_Click" />
    <br />
    <br />
    <asp:Button Text="GUARDAR" ID="btn_guardar"  runat="server" CssClass="boton_form" OnClick="btn_guardar_Click" />
    
    <br />
    <asp:GridView ID="GrvEmpleados" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="CODIGO" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />                    
                    <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />  
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />  
                    <asp:BoundField DataField="Precio" HeaderText="Precio" />  
                    <asp:BoundField DataField="Stock" HeaderText="Stock" />                                       
                    <asp:TemplateField HeaderText="Accion">
                        <ItemTemplate>
                            <asp:LinkButton ID="linkVer" runat="server" CommandArgument='<%# Eval("Nombre")%>' OnClick="linkVer_Click" >VER</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    <div class="image">
    &nbsp;</div>
    
    </form>
</body>
</html>
