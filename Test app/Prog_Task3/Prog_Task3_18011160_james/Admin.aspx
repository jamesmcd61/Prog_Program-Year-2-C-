<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Prog_Task3_18011160_james.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="PnNav" runat="server" Width="155px" Style="position: absolute; top: 22px; left: 16px; height: 396px;" BackColor="#0033CC">
            <asp:Panel ID="PnUser" runat="server" BackColor="#000066" Style="position: absolute; top: 6px; left: 0px; height: 102px; width: 154px;">
                <asp:Label ID="LblUser" runat="server" Text="Label" Style="position: absolute; top: 21px; left: 27px; height: 57px; width: 96px;" ForeColor="White"></asp:Label>
            </asp:Panel>
            <asp:Button ID="BtLogout" runat="server" Text="Logout" Style="position: absolute; top: 126px; left: 44px;"/>
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Pnstyle" runat="server" Style="position: absolute; top: 23px; left: 170px; height: 394px; width: 731px;" BackColor="#000099">
            <asp:Panel ID="PnDisplay" runat="server" BackColor="White" Height="377px" Width="714px">
                <asp:Button ID="TbCreate" runat="server" Text="Create user" Style="position: absolute; top: 163px; left: 100px;" OnClick="TbCreate_Click"/>
                <asp:RadioButton ID="RbTeacher" runat="server" Text="Teacher" Style="position: absolute; top: 37px; left: 107px;" />
                <asp:RadioButton ID="RbStudent" runat="server" Text="Student" Style="position: absolute; top: 74px; left: 107px;"/>
                <asp:GridView ID="GvUsers" runat="server" Style="position: absolute; top: 91px; left: 270px;">
                </asp:GridView>
                <asp:TextBox ID="TbPassword" runat="server" Style="position: absolute; top: 115px; left: 89px; height: 20px;"></asp:TextBox>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
