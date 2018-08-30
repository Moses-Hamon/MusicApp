<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MusicApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Track List </h1>

            <a href="Edit.aspx">Create New Track</a>
            <br />

            <asp:GridView ID="gvList" runat="server" OnSelectedIndexChanged="gvList_SelectedIndexChanged">
                <EmptyDataTemplate>
                    <span>No data to display.</span>
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
