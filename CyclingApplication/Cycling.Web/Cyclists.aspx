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
              <asp:Button ID="ButtonAddNewCyclicst" runat="server" Text="Add New Cyclist" CssClass="btn btn-warning" OnClick="ButtonAddNewCyclicst_Click" />
          </div>
      </div>
</asp:Content>
