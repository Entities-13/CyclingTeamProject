<%@ Page Title="Cyclists" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="Cyclists.aspx.cs" Inherits="Cycling.Web.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
    this is the cyclist page
      <div class="well well-sm">
          <asp:GridView ID="GridViewCyclists" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="Id">
              <Columns>
                  <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                  <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                  <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                  <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                  <asp:BoundField DataField="TourDeFranceWins" HeaderText="TourDeFranceWins" SortExpression="TourDeFranceWins" />
                  <asp:BoundField DataField="GiroDItaliaWins" HeaderText="GiroDItaliaWins" SortExpression="GiroDItaliaWins" />
                  <asp:BoundField DataField="VueltaEspanaWins" HeaderText="VueltaEspanaWins" SortExpression="VueltaEspanaWins" />
                  <asp:BoundField DataField="CurrentTeam" HeaderText="CurrentTeam" SortExpression="CurrentTeam" />
              </Columns>
          </asp:GridView>
          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CyclingConnectionString %>" SelectCommand="SELECT * FROM [Cyclists]"></asp:SqlDataSource>
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
      </div>
</asp:Content>
