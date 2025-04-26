<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsRedis.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>
        <p><asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
       <asp:Label ID="Lbl" runat="server" Text="Email"></asp:Label>
  <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
        <asp:Button Text="Save" ID="BtnSave" runat="server" OnClick="BtnSave_Click" />
        <asp:Button Text="Get Data" ID="BtnGetData" runat="server" OnClick="BtnGetData_Click" />

        </p>
        <p>
            Name: <asp:Label ID="LblNameShow" runat="server"></asp:Label><br />
            Email:<asp:Label ID="LblEmailShow" runat="server"></asp:Label>

        </p>
    </main>
</asp:Content>
