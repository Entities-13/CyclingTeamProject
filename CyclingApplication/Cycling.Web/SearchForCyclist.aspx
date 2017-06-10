<%@ Page Title="" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="SearchForCyclist.aspx.cs" Inherits="Cycling.Web.SearchForCyclist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
    <div class="well well-sm">
        <div class="well well-sm">
            <asp:Label ID="LabelInfo" runat="server" Text="Search For Cyclist"></asp:Label>
        </div>
        <div class="well well-sm">
            <asp:Label ID="LabelId" runat="server" Text="Enter Cyclist Id:"></asp:Label>
            <asp:TextBox ID="TextBoxId" runat="server"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="ButtonDisplayCyclist" runat="server" Text="Display Cyclist Info" CssClass="btn btn-warning" OnClick="ButtonDisplayCyclist_Click" />
        <br />
        <br />
        <div class="well well-sm">
            <asp:GridView ID="GridViewResult" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="820px">
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
    </div>
</asp:Content>
