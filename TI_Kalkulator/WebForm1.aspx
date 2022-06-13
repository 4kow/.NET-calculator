<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TI_Kalkulator.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="359px" style="margin-bottom: 6px; margin-right: 5px;" Width="300px">
        <asp:TextBox ID="Screen" runat="server" Height="64px" Width="255px"></asp:TextBox>
        <asp:Button ID="CE" runat="server" Text="CE" Width="61px" OnClick="Button" />
        <asp:Button ID="jedenprzezx" runat="server" Text="1/x" Width="61px" OnClick="Button" />
        <asp:Button ID="sqrt" runat="server" Text="sqrt" Width="61px" OnClick="Button" />
        <asp:Button ID="mnożenie" runat="server" Text="*" Width="61px" OnClick="Button" />
        <asp:Button ID="Siedem" runat="server" Text="7" OnClick="Button" Width="61px" />
        <asp:Button ID="Osiem" runat="server" Text="8" OnClick="Button" Width="61px" />
        <asp:Button ID="Dziewięć" runat="server" Text="9" OnClick="Button" Width="61px" />
        <asp:Button ID="dzielenie" runat="server" Text="/" Width="61px" OnClick="Button" />
        <asp:Button ID="Cztery" runat="server" OnClick="Button" Text="4" Width="61px" />
        <asp:Button ID="Pięć" runat="server" Text="5" OnClick="Button" Width="61px" />
        <asp:Button ID="Sześć" runat="server" Text="6" OnClick="Button" Width="61px" />
        <asp:Button ID="Minus" runat="server" Text="-" OnClick="Button" Width="61px" />
        <asp:Button ID="Jeden" runat="server" Text="1" OnClick="Button" Width="61px" />
        <asp:Button ID="Dwa" runat="server" Text="2" OnClick="Button" Width="61px" />
        <asp:Button ID="Trzy" runat="server" Text="3" OnClick="Button" Width="61px" />
        <asp:Button ID="plus" runat="server" Text="+" OnClick="Button" Width="61px" />
        <asp:Button ID="Zero" runat="server" Text="0" Width="126px" OnClick="Button" />
        <asp:Button ID="przecinek" runat="server" OnClick="Button" Text="," Width="61px" />
        <asp:Button ID="Rownasie" runat="server" Text="=" Width="61px" OnClick="Button" />
        <asp:Table ID="Table1" runat="server" Width="229px" Visible="False">
        </asp:Table>
        <asp:TextBox ID="TextBox3" runat="server" Width="229px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Visible="False" Width="225px"></asp:TextBox>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" Visible="False" Width="224px"></asp:TextBox>
    </asp:Panel>
</asp:Content>
