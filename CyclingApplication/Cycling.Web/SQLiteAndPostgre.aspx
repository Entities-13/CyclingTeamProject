<%@ Page Title="SQLite And Postgre" Language="C#" MasterPageFile="~/Cycling.Master" AutoEventWireup="true" CodeBehind="SQLiteAndPostgre.aspx.cs" Inherits="Cycling.Web.SQLiteAndPostgre" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderCycling" runat="server">
     <div class="well well-sm">
        <br />
        <asp:Button ID="ButtonFillSQLite" runat="server" Text="Fill SQLite With Data" CssClass="btn btn-warning" OnClick="ButtonFillSQLite_Click" />
        <asp:Button ID="ButtonFillPostgre" runat="server" Text="Fill PostgreSQL With Data" CssClass="btn btn-warning" OnClick="ButtonFillPostgre_Click" />    
     </div>
</asp:Content>
