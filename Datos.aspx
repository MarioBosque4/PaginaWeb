<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Datos.aspx.cs" Inherits="PaginaWeb.Datos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%; height: 185px;">
    <tr>
        <td style="width: 109px">
            <asp:Button ID="Mostrar" runat="server" OnClick="Mostrar_Click" Text="MOSTRAR" />
        </td>
        <td style="width: 241px">
            <asp:GridView ID="data" runat="server">
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 109px">
            <asp:Button ID="Prom" runat="server" OnClick="Prom_Click" Text="PROMEDIO" />
        </td>
        <td style="width: 241px">
            <asp:Label ID="LabelProm" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 109px">&nbsp;</td>
        <td style="width: 241px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
