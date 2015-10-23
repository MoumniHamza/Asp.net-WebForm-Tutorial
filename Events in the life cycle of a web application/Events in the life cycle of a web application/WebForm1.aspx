<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Events_in_the_life_cycle_of_a_web_application.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
        <asp:TextBox ID="TextBox1" runat="server" MaxLength="10" TextMode="MultiLine"></asp:TextBox>
    
    </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
