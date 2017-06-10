<%@ Page Title="Cyclists" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="Cyclists.aspx.cs" Inherits="Cycling.Web.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
      <div class="well well-sm">
          <asp:GridView ID="GridViewCyclists" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="820px" >
              <FooterStyle BackColor="White" ForeColor="#000066" />
              <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
              <RowStyle ForeColor="#000066" />
              <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
              <SortedAscendingCellStyle BackColor="#F1F1F1" />
              <SortedAscendingHeaderStyle BackColor="#007DBB" />
              <SortedDescendingCellStyle BackColor="#CAC9C9" />
              <SortedDescendingHeaderStyle BackColor="#00547E" />
          </asp:GridView>
      </div>
</asp:Content>
