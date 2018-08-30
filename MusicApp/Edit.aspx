<%@ Page Title="Edit Page" Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="MusicApp.Edit" %>
<%@ Register TagPrefix="ctl" TagName="Editfields" Src="~/EditFieldsascx.ascx" %>
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
    <form id="frmEdit" runat="server">
        <div class="container">
            <ctl:EditFields ID="ctlFields" runat="server" Label="fields" />
            <asp:Button ID="btnAdd" runat="server" Font-Size="Medium" CssClass="btn" Text="Add" OnClick="btnAdd_Click" />
        </div>
    </form>
</body>
</html>
