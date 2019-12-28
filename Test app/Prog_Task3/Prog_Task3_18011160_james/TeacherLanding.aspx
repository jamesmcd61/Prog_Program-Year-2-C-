<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherLanding.aspx.cs" Inherits="Prog_Task3_18011160_james.TeacherLanding" %>

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
            <asp:Button ID="BtLogout" runat="server" Text="Logout" Style="position: absolute; top: 134px; left: 42px;" OnClick="BtLogout_Click"/>
            <br />
        </asp:Panel>
    
    </div>
        <asp:Panel ID="Pnstyle" runat="server" Style="position: absolute; top: 23px; left: 170px; height: 394px; width: 731px;" BackColor="#000099">
            <asp:Panel ID="PnDisplay" runat="server" BackColor="White" Height="377px" Width="714px">
                <asp:Button ID="BtStudentmakrs" runat="server" Text="Check Student Marks" Style="position: absolute; top: 291px; left: 516px;" OnClick="BtStudentmakrs_Click"/>
                <br />
                <asp:Button ID="BtCreateTest" runat="server" Text="Create Test Question" Style="position: absolute; top: 335px; left: 516px;" OnClick="BtCreateTest_Click"/>
                <asp:GridView ID="GwDisplayMarks" runat="server" AutoGenerateColumns="False" Style="position: absolute; top: 29px; left: 28px; height: 228px; width: 539px;">
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" />
                        <asp:BoundField DataField="Test" HeaderText="Test" />
                        <asp:BoundField DataField="ActualAnswer" HeaderText="ActualAnswer" />
                        <asp:BoundField DataField="TheirAnswer" HeaderText="TheirAnswer" />
                        <asp:BoundField DataField="Question" HeaderText="Question" />
                        <asp:BoundField DataField="StudentId" HeaderText="StudentId" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
