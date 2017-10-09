<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MovieAdvice._Default" %>


<form id="form1" runat="server">
    <asp:HiddenField ID="hf_cookie" runat="server" />
    <asp:CheckBoxList ID="cbl_genre" runat="server" RepeatColumns="4">
        <asp:ListItem Value="1">Action</asp:ListItem>
        <asp:ListItem Value="2">Adult</asp:ListItem>
        <asp:ListItem Value="3">Adventure</asp:ListItem>
        <asp:ListItem Value="4">Animation</asp:ListItem>
        <asp:ListItem Value="5">Biography</asp:ListItem>
        <asp:ListItem Value="6">Comedy</asp:ListItem>
        <asp:ListItem Value="7">Crime</asp:ListItem>
        <asp:ListItem Value="8">Documentary</asp:ListItem>
        <asp:ListItem Value="9">Drama</asp:ListItem>
        <asp:ListItem Value="10">Family</asp:ListItem>
        <asp:ListItem Value="11">Fantasy</asp:ListItem>
        <asp:ListItem Value="12">Film noir</asp:ListItem>
        <asp:ListItem Value="13">Game show</asp:ListItem>
        <asp:ListItem Value="14">History</asp:ListItem>
        <asp:ListItem Value="15">Horror</asp:ListItem>
        <asp:ListItem Value="16">Music</asp:ListItem>
        <asp:ListItem Value="17">Musical</asp:ListItem>
        <asp:ListItem Value="18">Mystery</asp:ListItem>
        <asp:ListItem Value="19">News</asp:ListItem>
        <asp:ListItem Value="20">Reality tv</asp:ListItem>
        <asp:ListItem Value="21">Romance</asp:ListItem>
        <asp:ListItem Value="22">Sci fi</asp:ListItem>
        <asp:ListItem Value="23">Sport</asp:ListItem>
        <asp:ListItem Value="24">Talk show</asp:ListItem>
        <asp:ListItem Value="25">Thriller</asp:ListItem>
        <asp:ListItem Value="26">War</asp:ListItem>
        <asp:ListItem Value="27">Western</asp:ListItem>
    </asp:CheckBoxList>
    <br />
    <asp:Label ID="l_type" runat="server" Text="Yapım türü : "></asp:Label>
    <asp:DropDownList ID="ddl_Type" runat="server">
        <asp:ListItem Value="Documentary">Documentary</asp:ListItem>
        <asp:ListItem Value="Feature Film" Selected="True">Feature Film</asp:ListItem>
        <asp:ListItem Value="Mini-Series">Mini-Series</asp:ListItem>
        <asp:ListItem Value="Short Film">Short Film</asp:ListItem>
        <asp:ListItem Value="TV Episode">TV Episode</asp:ListItem>
        <asp:ListItem Value="TV Movie">TV Movie</asp:ListItem>
        <asp:ListItem Value="TV Series">TV Series</asp:ListItem>
        <asp:ListItem Value="TV Special">TV Special</asp:ListItem>
        <asp:ListItem Value="Video">Video</asp:ListItem>
        <asp:ListItem Value="Video Game">Video Game</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="l_Year" runat="server" Text="Yıl : "></asp:Label>
    <asp:TextBox ID="tb_Year1" runat="server" MaxLength="4" TextMode="Number">1910</asp:TextBox>
    <asp:TextBox ID="tb_Year2" runat="server" MaxLength="4" TextMode="Number">2017</asp:TextBox>
    <br />
    <br />
    <asp:Label ID="l_userid" runat="server" Text="IMDB kodunuz : "></asp:Label>
    <asp:TextBox ID="tb_userid" runat="server"></asp:TextBox>
    <asp:Button ID="bt_getir" runat="server" OnClick="Button1_Click" Text="Getir" />
    <br />
    <br />
    <asp:Label ID="l_result" runat="server"></asp:Label>
</form>



    