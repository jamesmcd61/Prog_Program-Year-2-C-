<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teacher.aspx.cs" Inherits="Prog_Task3_18011160_james.Teacher" %>

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
            <asp:Button ID="BtHome" runat="server" Text="Home" Style="position: absolute; top: 133px; left: 48px;" OnClick="BtHome_Click"/>
            <asp:Button ID="BtLogout" runat="server" Text="LogOut" Style="position: absolute; top: 180px; left: 42px;" OnClick="BtLogout_Click"/>
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Pnstyle" runat="server" Style="position: absolute; top: 23px; left: 170px; height: 394px; width: 731px;" BackColor="#000099">
            <asp:Panel ID="PnDisplay" runat="server" BackColor="White" Height="377px" Width="714px">
                <asp:Label ID="LblQuestion" runat="server" Text="Question" Style="position: absolute; top: 33px; left: 37px; height: 22px; width: 102px;"></asp:Label>
                <asp:TextBox ID="TbQuestion" runat="server" Style="position: absolute; top: 35px; left: 120px; width: 294px;"></asp:TextBox>
                <br />
                <asp:Label ID="LblA" runat="server" Text="Answer A" Style="position: absolute; top: 82px; left: 34px;"></asp:Label>
                <asp:TextBox ID="TbA" runat="server" Style="position: absolute; top: 82px; left: 119px; width: 303px;"></asp:TextBox>
                <asp:CheckBox ID="CbA" runat="server" Text="A" Style="position: absolute; top: 83px; left: 450px;" />
                <br />
                <asp:Label ID="LblB" runat="server" Text="Answer B" Style="position: absolute; top: 119px; left: 34px;"></asp:Label>
                <asp:TextBox ID="TbB" runat="server" Style="position: absolute; top: 118px; left: 118px; width: 303px;"></asp:TextBox>
                <asp:CheckBox ID="CbB" runat="server" Text="B" Style="position: absolute; top: 118px; left: 448px;" />
                <br />
                <asp:Label ID="LblC" runat="server" Text="Answer C" Style="position: absolute; top: 162px; left: 32px; height: 37px; width: 67px;"></asp:Label>
                <asp:TextBox ID="TbC" runat="server" Style="position: absolute; top: 160px; left: 116px; width: 305px;"></asp:TextBox>
                <asp:CheckBox ID="CbC" runat="server" Text="C" Style="position: absolute; top: 159px; left: 448px;" />
                <br />
                <asp:Label ID="LblD" runat="server" Text="Answer D" Style="position: absolute; top: 208px; left: 33px;"></asp:Label>
                <asp:TextBox ID="TbD" runat="server" Style="position: absolute; top: 203px; left: 116px; width: 305px;"></asp:TextBox>
                <asp:CheckBox ID="CbD" runat="server" Text="D"  Style="position: absolute; top: 203px; left: 446px;"/>
                <br />
                <asp:Label ID="LblTestNO" runat="server" Text="Test Number" Style="position: absolute; top: 267px; left: 25px;"></asp:Label>
                <asp:TextBox ID="TbTestNO" runat="server" Style="position: absolute; top: 260px; left: 120px; width: 202px;"></asp:TextBox>
                <br />
                <asp:Button ID="BtCreate" runat="server" Text="Create" Style="position: absolute; top: 325px; left: 591px;" OnClick="BtCreate_Click" />
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
