﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Dersler.aspx.cs" Inherits="Dersler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Dersi Secin:"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="mydropdownlist"></asp:DropDownList>
        </div>
        <br />
         <div>
            <asp:Label ID="Label2" runat="server" Text="Telebe ID:"></asp:Label>
             <asp:DropDownList ID="DropDownList2" runat="server" CssClass="mydropdownlist"></asp:DropDownList>
        </div>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Ders Telebi Yarat" CssClass ="simplebutton1" OnClick="Button1_Click"/>

    </form>
</asp:Content>

