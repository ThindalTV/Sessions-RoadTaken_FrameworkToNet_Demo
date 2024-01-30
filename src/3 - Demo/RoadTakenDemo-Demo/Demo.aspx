<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Demo.aspx.cs" Inherits="RoadTakenDemoTemplate.Demo" %>

<html>
<head>
    <title>DEMO time</title>
</head>
<body>
    <h1>ASP.NET Webforms</h1>
    <form runat="server">
        <asp:Literal ID="litFirstNumber" runat="server" />
        +
        <asp:TextBox ID="txtSecondNumber" runat="server" />
        =
        <asp:Literal ID="litResult" runat="server" />
        <br />
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
    </form>
</body>
</html>

