<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditFieldsascx.ascx.cs" Inherits="MusicApp.EditFieldsascx" %>
<%@ Register TagPrefix="ctl" TagName="Fields" Src="~/ctlFields.ascx" %>

<ctl:Fields ID="ctlId" runat="server" Label="ID" ReadOnly="true" />
<ctl:Fields ID="ctlTrack" runat="server" Label="Track" />
<ctl:Fields ID="ctlArtist" runat="server" Label="Artist" />
<ctl:Fields ID="ctlAlbum" runat="server" Label="Album" />
<ctl:Fields ID="ctlGenre" runat="server" Label="Genre" />
<ctl:Fields ID="ctlDuration" runat="server" Label="Duration" />
