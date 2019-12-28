<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Prog_Task3_18011160_james.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body style="text-align: center" >
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Panel ID="PnLogin" runat="server" Height="351px" Width="323px" Style="left: 40%;position: absolute" BackColor="#66CCFF"  >
            <asp:Image ID="ImgUser" runat="server" Height="112px" ImageUrl="~/icons8-workspace-100.png" Width="140px" />
            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="44px" ImageUrl="~/icons8-user-50.png" Width="51px" />
            <asp:TextBox ID="TbUserName" runat="server" BorderStyle="None" BackColor="#66CCFF" placeholder ="UserName"></asp:TextBox>
            <br />
            <br />
            <asp:Image ID="Image2" runat="server" Height="44px" ImageUrl="~/icons8-password-50.png" Width="51px" />
            <asp:TextBox ID="TbPassWord" runat="server" BorderStyle="None" BackColor="#66CCFF" placeholder ="PassWord"></asp:TextBox>
            <br />
            <br />
            <br />
&nbsp;
            <asp:Button ID="BtLogin" runat="server" Text="Login" OnClick="BtLogin_Click" />
        </asp:Panel>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
