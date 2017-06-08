<%@ Page Title="Add Cyclist" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="AddCyclist.aspx.cs" Inherits="Cycling.Web.AddCyclist" %>

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
            <br />
            <asp:Label ID="LabelAge" runat="server" Text="Age:"></asp:Label>
            <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelTour" runat="server" Text="Tour de France Wins:"></asp:Label>
            <asp:TextBox ID="TextBoxTour" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelGiro" runat="server" Text="Giro d'Italia Wins:"></asp:Label>
            <asp:TextBox ID="TextBoxGiro" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelVuelta" runat="server" Text="Vuelta a Espana Wins:"></asp:Label>
            <asp:TextBox ID="TextBoxVuelta" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="LabelTeam" runat="server" Text="Current Team:"></asp:Label>
            <asp:TextBox ID="TextBoxTeam" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="ButtonAddNewCyclicst" runat="server" Text="Add New Cyclist" CssClass="btn btn-warning" OnClick="ButtonAddNewCyclicst_Click" />
    </div>
</asp:Content>
