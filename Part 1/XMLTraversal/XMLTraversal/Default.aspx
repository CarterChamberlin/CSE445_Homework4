<%@ Page Title="XML Traversal" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XMLTraversal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <asp:Panel ID="serviceTitle" runat="server" HorizontalAlign="Center">
        <h1><b>XML Traversal Service Page</b></h1>
    </asp:Panel>

    <asp:Panel runat="server" ID="serviceInfo" CssClass="jumbotron" BorderWidth="3">
        <h3>XML Service Information</h3>
        <hr />
        <h4>This service has been implmented for CSE 445: Homework 4 - Part 1. This service will traverse any given XML document in a "pre-order" method.</h4>
        <h4>To use this service, enter the URL of any XML (.xml) file; or use the example XML (Hotels.xml) given.</h4>
    </asp:Panel>

    <asp:Panel runat="server" ID="inputPanel" CssClass="jumbotron" BorderWidth="3">
        <h3>XML Document Selector:</h3>
        <hr />
        <asp:Label Text="Option 1: " runat="server" Font-Bold="True" />
        <asp:Label Text="Copy & paste a vaid XML (.xml) URL below:" runat="server" />
        <br />
        <asp:Label Text="Option 2: " runat="server" Font-Bold="True" />
        <asp:Button ID="hotelBtn" Text="Run Hotels.xml Example" OnClick="hotelBtn_Click" runat="server" />
        <br />
        <br />
        <asp:TextBox ID="urlInput" Width="800" runat="server" />
        <asp:Button ID="submitBtn" OnClick="submitBtn_Click" Text="Submit" runat="server" />
    </asp:Panel>

    <asp:Panel runat="server" ID="outputPanel" CssClass="jumbotron" BorderWidth="3">
        <h3>XML Data Information:</h3>
        <hr />
        <h4>XML Pre-order:</h4>
        <br />
        <asp:Label ID="preText" Text="preorder" runat="server" />
        <hr />
        <h4>XML Post-order:</h4>
        <br />
        <asp:Label ID="postText" Text="postorder" runat="server" />
    </asp:Panel>
    
    <br />
    <br />
    <hr />
    
    <asp:Panel runat="server" ID="authorInfo" CssClass="jumbotron" BorderWidth="3">
        <h3>About This Service:</h3>
        <hr />
        <h4>Author: Carter Chamberlin</h4>
        <h4>Class: CSE 445</h4>
        <h4>Assignment: Homework 4 - Part 1</h4>
        <h4>Date: 17th April 2019</h4>
    </asp:Panel>

</asp:Content>
