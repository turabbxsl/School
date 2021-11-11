<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label for="txtad" runat="server" Text="Telebe Adi  :"></asp:Label>
                <asp:TextBox ID="txtad" runat="server" CssClass="form-control" style="margin-left: 0px"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtsoyad" runat="server" Text="Telebe Soyadi  :"></asp:Label>
                <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtnomre" runat="server" Text="Telebe Nomresi  :"></asp:Label>
                <asp:TextBox ID="txtnomre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtsifre" runat="server" Text="Telebe Sifresi  :"></asp:Label>
                <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="txtsekil" runat="server" Text="Telebe Sekli  :"></asp:Label>
                <asp:TextBox ID="txtsekil" runat="server" CssClass="form-control"></asp:TextBox>
            </div>


        </div>

        <asp:Button ID="Button1" runat="server" Text="Saxla" OnClick="Button1_Click" BorderStyle ="Groove" BorderWidth ="14px"/>
    </form>
</asp:Content>

