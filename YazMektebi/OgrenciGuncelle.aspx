<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="OgrenciGuncelle.aspx.cs" Inherits="OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">

    <form id="Form1" runat="server">
        <div class="form-group">

            <div>
                <strong>
                <asp:Label for="txtid" runat="server" Text="Telebe ID  :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control" style="margin-left: 96px" Height="33px" Width="576px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtad" runat="server" Text="Telebe Adi  :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtad" runat="server" CssClass="form-control" style="margin-left: 82px" Height="33px" Width="576px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtsoyad" runat="server" Text="Telebe Soyadi  :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control" Height="33px" style="margin-left: 54px" Width="576px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtnomre" runat="server" Text="Telebe Nomresi  :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtnomre" runat="server" CssClass="form-control" Height="33px" style="margin-left: 43px" Width="576px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtsifre" runat="server" Text="Telebe Sifresi  :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsifre" runat="server" CssClass="form-control" Height="33px" style="margin-left: 60px" Width="576px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="txtsekil" runat="server" Text="Telebe Sekli  :"></asp:Label>
                </strong>
                <asp:TextBox ID="txtsekil" runat="server" CssClass="form-control" Height="33px" style="margin-left: 70px" Width="576px"></asp:TextBox>
                <br />
                <br />
            </div>


        </div>

        <asp:Button ID="Button1" runat="server" Text="Guncelle" Font-Size ="XX-Large" ForeColor ="White" BorderStyle ="Groove" BorderWidth ="5px" BackColor="#336600" CssClass ="btn fa-btc" Height="79px" style="margin-left: 393px; background-color: #3399FF;" Width="178px" OnClick="Button1_Click"/>
    </form>
</asp:Content>



