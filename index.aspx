<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="puso.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <br /> <br /> <br />
        <center>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="To Delete and Update Input ID Number"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="UPDATE" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="DELETE" OnClick="Button3_Click" />
        <asp:Label ID="Label2" runat="server" Text="PLS ENTER YOUR ORDER"></asp:Label>
        </center><br /> <br /> <br />
        <asp:GridView ID="GridView1" runat="server" CssClass="table table-dark"></asp:GridView>
    </div>
    </form>
</body>
</html>
