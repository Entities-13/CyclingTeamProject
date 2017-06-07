<%@ Page Title="Home" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Cycling.Web.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
    <div class="well well-sm">
        <br />
        <asp:Button ID="ButtonAddJsonData" runat="server" Text="Load Cyclists Data From Json" OnClick="ButtonAddJsonData_Click" CssClass="btn btn-warning" />
    </div>
</asp:Content>
