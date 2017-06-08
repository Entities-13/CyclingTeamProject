<%@ Page Title="Remove Cyclist" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="DeleteCyclist.aspx.cs" Inherits="Cycling.Web.DeleteCyclist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
    <div class="well well-sm">
        <div class="well well-sm">
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelLastName" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="ButtonRemoveCyclicst" runat="server" Text="Remove Cyclist" CssClass="btn btn-warning" OnClick="ButtonRemoveCyclicst_Click"/>
    </div>
</asp:Content>
