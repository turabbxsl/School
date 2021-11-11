<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Ogrencilistesi.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <table class="table" aria-hidden="False" aria-readonly="True" border="2" style="width: 1522px; height: 170px" align="center">
        <thead>
            <tr>
                <th style="height: 29px">Telebe ID</th>
                <th style="height: 29px">Telebe Adi</th>
                <th style="height: 29px">Telebe Soyadi</th>
                <th style="height: 29px">Telebe Nomresi</th>
                <th style="height: 29px">Telebe Sekli</th>
                <th style="height: 29px">Telebe Sifresi</th>
                <th style="height: 29px; width: 180px;">Telebe Bakiye</th>
                <th style="height: 29px; width: 278px;">Emeliyyatlar</th>
            </tr>
        </thead>
        <tbody>
            <asp:repeater id="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th style="height: 28px"><%# Eval("ID") %></th>
                        <td style="height: 28px; text-align: center"><%# Eval("AD") %></td>
                        <td style="height: 28px; text-align: center"><%# Eval("SOYAD") %></td>
                        <td style="height: 28px; text-align: center"><%# Eval("NOMRE") %></td>
                        <td style="height: 28px; text-align: center"><%# Eval("SEKIl") %></td>
                        <td style="height: 28px; text-align: center"><%# Eval("SIFRE") %></td>
                        <td style="height: 28px; text-align: center"><%# Eval("BAKIYE") %></td>       
                        <td>
                         <a href ="OgrenciSil.aspx?TELEBEID=<%# Eval("Id") %>"   <asp:HyperLink BorderStyle ="Groove"  Width ="100px" ToolTip ="SILMEK"  BorderWidth ="5px" Font-Size ="20px" ForeColor ="Red"  runat="server">___Sil____</asp:HyperLink></a>

                            <a href ="OgrenciGuncelle.aspx?TELEBEID=<%# Eval("Id") %>" <asp:HyperLink ID="HyperLink2" BorderStyle ="Groove" Width ="152px" ToolTip ="Yenile"  BorderWidth ="5px" Font-Size ="20px" ForeColor ="MidnightBlue"  runat="server">___Guncelle____</asp:HyperLink>
                            
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:repeater>
        </tbody>
    </table>


</asp:Content>

