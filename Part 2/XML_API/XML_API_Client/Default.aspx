<%@ Page Title="XML APIs" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XML_API_Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="serviceTitle" runat="server" HorizontalAlign="Center">
        <h1><b>XML APIs Service Page</b></h1>
    </asp:Panel>

    <asp:Panel runat="server" ID="serviceInfo" CssClass="jumbotron" BorderWidth="3">
        <h3>XML Service Information</h3>
        <hr />
        <h4>This service has been implmented for CSE 445: Homework 4 - Part 2. This service will call two APIs from a related REST service. The first API is for 
            XML validation, given valid XML (.xml) and schema (.xsd) files. The second API will perform an XPath search of the given XML (.xml) document and a search query.
        </h4>
        <br />
        <h4>To use this service, enter the URL of any XML (.xml) file and related schema (.xsd), a valid XML (.xml) file URL and valid search term, or use one of the 
            sample 'Test Cases' included with this service.
        </h4>
    </asp:Panel>

    <asp:Panel runat="server" ID="verificationInput" CssClass="jumbotron" BorderWidth="3">
        <h3>XML Verification API:</h3>
        <hr />
        <asp:Label Text="Option 1: " runat="server" Font-Bold="True" />
        <asp:Label Text="Copy & paste vaid XML (.xml) & schema (.xsd) URLs below:" runat="server" />
        <br />
        <asp:Label Text="Enter XML URL here: " runat="server" />
        <asp:TextBox ID="xmlUrlInput" Width="1200" runat="server" />
        <br />
        <asp:Label Text="Enter XSD URL here: " runat="server" />
        <asp:TextBox ID="xsdUrlInput" Width="800" runat="server" />
        <br />
        <asp:Button ID="verifyBtn" Text="Verify" OnClick="verifyBtn_Click" runat="server" />
        <br />
        <br />
        <asp:Label Text="Option 2: " runat="server" Font-Bold="True" />
        <asp:Label Text="Run one of the various test cases below:" runat="server" />
        <br />
        <asp:Button ID="tc1Btn" Text="Test Case 1" OnClick="tc1btn_Click" runat="server" />
        <asp:Button ID="tc2Btn" Text="Test Case 2" OnClick="tc2btn_Click" runat="server" />
        <asp:Button ID="tc3Btn" Text="Test Case 3" OnClick="tc3btn_Click" runat="server" />
        <br />
        <br />
        
    </asp:Panel>

    <asp:Panel runat="server" ID="verificationOutput" CssClass="jumbotron" BorderWidth="3">
        <h3>XML Verification Results:</h3>
        <hr />
        <asp:Label ID="resultsText" Text="Verification Results" runat="server" />
    </asp:Panel>

    <asp:Panel runat="server" ID="xpathInput" CssClass="jumbotron" BorderWidth="3">
        <h3>XML XPath Search API:</h3>
        <hr />
        <asp:Label Text="Option 1: " runat="server" Font-Bold="True" />
        <asp:Label Text="Copy & paste a vaid XML (.xml) URL below, and enter a valid search query:" runat="server" />
        <br />
        <asp:Label Text="Enter XML URL here: " runat="server" />
        <asp:TextBox ID="xmlSearchUrl" Width="1200" runat="server" />
        <br />
        <asp:Label Text="Enter Search Query here: " runat="server" />
        <asp:TextBox ID="searchTerm" Width="800" runat="server" />
        <br />
        <asp:Button ID="searchBtn" Text="Search" OnClick="searchBtn_Click" runat="server" />
        <br />
        <br />
        <asp:Label Text="Option 2: " runat="server" Font-Bold="True" />
        <asp:Label Text="Run one of the various test cases below:" runat="server" />
        <br />
        <asp:Button ID="searchTC1" Text="Test Case 1" OnClick="searchTC1_Click" runat="server" />
        <asp:Button ID="searchTC2" Text="Test Case 2" OnClick="searchTC2_Click" runat="server" />
        <asp:Button ID="searchTC3" Text="Test Case 3" OnClick="searchTC3_Click" runat="server" />
        <br />
        <br />
    </asp:Panel>

    <asp:Panel runat="server" ID="xpathOutput" CssClass="jumbotron" BorderWidth="3">
        <h3>XML XPath Search Results:</h3>
        <hr />
        <asp:Label ID="queryOutput" Text="query results" runat="server" />
    </asp:Panel>
    
    <br />
    <br />
    <hr />
    
    <asp:Panel runat="server" ID="authorInfo" CssClass="jumbotron" BorderWidth="3">
        <h3>About This Service:</h3>
        <hr />
        <h4>Author: Carter Chamberlin</h4>
        <h4>Class: CSE 445</h4>
        <h4>Assignment: Homework 4 - Part 2</h4>
        <h4>Date: 17th April 2019</h4>
    </asp:Panel>

</asp:Content>
