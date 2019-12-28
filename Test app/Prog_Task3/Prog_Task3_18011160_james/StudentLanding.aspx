<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentLanding.aspx.cs" Inherits="Prog_Task3_18011160_james.StudentLanding" %>

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
            <asp:Button ID="BtLogout" runat="server" style="margin-top: 1px; position: absolute; top: 131px; left: 49px;" Text="Logout" OnClick="BtLogout_Click" />
            <br />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Pnstyle" runat="server" Style="position: absolute; top: 23px; left: 170px; height: 394px; width: 731px;" BackColor="#000099">
            <asp:Panel ID="PnDisplay" runat="server" BackColor="White" Height="377px" Width="714px" Style="position: absolute">
                <asp:GridView ID="GwDisplayMarks" runat="server" Style="position: absolute; top: 42px; left: 31px; height: 228px; width: 539px;" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField HeaderText="ID" DataField="ID" />
                        <asp:BoundField HeaderText="Test" DataField="Test" />
                        <asp:BoundField HeaderText="ActualAnswer" DataField="ActualAnswer" />
                        <asp:BoundField HeaderText="TheirAnswer" DataField="TheirAnswer" />
                        <asp:BoundField HeaderText="Question" DataField="Question" />
                        <asp:BoundField HeaderText="StudentId" DataField="StudentId" />
                    </Columns>
                </asp:GridView>
                <asp:Button ID="BtMarks" runat="server" Text="Check marks" Style="position: absolute; top: 282px; left: 589px;" OnClick="BtMarks_Click" />
                <br />
                <asp:Button ID="BtTakeTest" runat="server" Text="Take Test" Style="position: absolute; top: 329px; left: 608px;" OnClick="BtTakeTest_Click"/>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
