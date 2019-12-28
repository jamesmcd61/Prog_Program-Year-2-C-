<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="Prog_Task3_18011160_james.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="PnNav" runat="server" Width="155px" Style="position: absolute; top: 22px; left: 16px; height: 396px;" BackColor="#0033CC">
            <asp:Panel ID="PnUser" runat="server" BackColor="#000066" Style="position: absolute; top: 8px; left: 0px; height: 102px; width: 154px;">
                <asp:Label ID="LblUser" runat="server" Text="Label" Style="position: absolute; top: 15px; left: 26px; height: 57px; width: 96px;" ForeColor="White"></asp:Label>
            </asp:Panel>
            <asp:Button ID="BtHome" runat="server" OnClick="Button1_Click" Text="Home" Style="position: absolute; top: 127px; left: 47px;" />
            <asp:Button ID="BtLogout" runat="server" Text="Logout"  Style="position: absolute; top: 170px; left: 43px;" OnClick="BtLogout_Click"/>
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Pnstyle" runat="server" Style="position: absolute; top: 23px; left: 170px; height: 394px; width: 731px;" BackColor="#000099">
            <asp:Panel ID="PnDisplay" runat="server" BackColor="White" Height="377px" Width="714px">
                <br />
                <asp:ListBox ID="LBQuestions" runat="server" Height="294px" style="margin-right: 10px; position: absolute; top: 49px; left: 21px;" Width="180px" OnSelectedIndexChanged="LBQuestions_SelectedIndexChanged" OnLoad="LBQuestions_Load"></asp:ListBox>
                <br />
                <asp:RadioButton ID="RbA" runat="server" Height="30px" Text="A" Style="position: absolute; top: 119px; left: 246px;" />
                <asp:RadioButton ID="RbB" runat="server" Height="30px" Text="B"  Style="position: absolute; top: 121px; left: 525px;"/>
                <asp:RadioButton ID="RbC" runat="server" Height="30px" Text="C" Style="position: absolute; top: 245px; left: 243px;"/>
                <asp:RadioButton ID="RbD" runat="server" Height="30px" Text="D" Style="position: absolute; top: 246px; left: 518px;"/>
                <asp:Label ID="LblQuestion" runat="server" Text="Question" Style="position: absolute; top: 47px; left: 378px;"></asp:Label>
                <br />
                <asp:Button ID="BtSubmit" runat="server" Text="Submit" Style="position: absolute; top: 330px; left: 614px;" OnClick="BtSubmit_Click"/>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
