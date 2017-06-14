<%@ Page Title="Home" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Cycling.Web.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
    <div class="well well-sm">
        <br />
        <asp:Button ID="ButtonAddJsonData" runat="server" Text="Load Cyclists Data From Json" OnClick="ButtonAddJsonData_Click" CssClass="btn btn-warning" />
        <asp:Button ID="ButtonAddBicycleData" runat="server" Text="Load Bicycles Data From Json" CssClass="btn btn-warning" OnClick="ButtonAddBicycleData_Click" />
        <asp:Button ID="ButtonAddXmlData" runat="server" Text="Load Data From Xml" CssClass="btn btn-warning" OnClick="ButtonAddXmlData_Click" />
        <asp:Button ID="ButtonGeneratePDF" runat="server" Text="Generate PDF Report" CssClass="btn btn-warning" OnClick="ButtonGeneratePDF_Click" />
    </div>
</asp:Content>
