<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MusicApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Track List </h1>

            <a href="Edit.aspx">Create New Track</a> <br />

            <asp:GridView ID="gvList" runat="server" OnSelectedIndexChanged="gvList_SelectedIndexChanged">
                <EmptyDataTemplate>
                    <span>No data to display.</span>
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
