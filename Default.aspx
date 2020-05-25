<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PaginaWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <br />
        <table class="nav-justified" style="height: 191px; margin-top: 0px;">
            <tr>
                <td style="width: 151px">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                    </asp:DropDownList>
                </td>
                <td style="width: 164px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="130px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Guardar" runat="server" Text="GUARDAR" />
                </td>
            </tr>
            <tr>
                <td style="width: 151px">&nbsp;</td>
                <td style="width: 164px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 151px">&nbsp;</td>
                <td style="width: 164px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <br />
    </div>

</asp:Content>
