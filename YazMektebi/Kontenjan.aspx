<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Kontenjan.aspx.cs" Inherits="Kontenjan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <table class="table" aria-hidden="False" aria-readonly="True" border="2" style="width: 1522px; height: 170px" align="center">
        <thead>
            <tr>
                <th style="height: 29px">Dersin Adi</th>
                <th style="height: 29px">Minimum Kontenjan</th>
                <th style="height: 29px">Maksimum Kontenjan</th>
                <th style="height: 29px">Basvurular</th>
            </tr>
            <tbody>
            <asp:repeater id="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <th style="height: 28px"><%# Eval("") %></th>                     
                    </tr>
                </ItemTemplate>
            </asp:repeater>
        </tbody>
        </thead>
    </table>
</asp:Content>

