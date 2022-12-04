<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Hotel.WebForm1" %>
<!DOCTYPE html>

<html>

<head>

<meta name="viewport" content="width=device-width, initial-scale=1">

<style>

* {

  box-sizing: border-box;

  font-family:arial;

}

 

/* Create two equal columns that floats next to each other */

.column {

  float: left;

  width: 20%;

  padding: 10px;

}

.columna {

  float: left;

  width: 80%;

  padding: 10px;

}

/* Clear floats after the columns */

.row:after {

  content: "";

  display: table;

  clear: both;

}

</style>

</head>

<body>

 

    <form id="form1" runat="server">

 

<h2>Arizona Desert Inn</h2>

 

<div class="row">

  <div class="column">

    <h2>Menu</h2>
      <p>
          <a href="HomePage.aspx" >Home</a>
      </p>
      <p>
        <a href="Employee.aspx" >Employee</a>
      </p>
      <p>
          <a href="Rooms.aspx">Rooms</a>
      </p>
      <p>
          <a href="Member.aspx">Members</a>
      </p>

  </div>

  <div class="columna" style="background-color:#bbb;">
      <h1>Rooms Search</h1>
      <br />
      Rooms #:
      <asp:TextBox ID="RoomNumTB" runat="server"></asp:TextBox>
      <asp:Button ID="RoomNumSearch" runat="server" Text="Search" OnCLick="RoomNumSearch_Click"/>
      <br />
      <asp:GridView ID="RoomNumGrid" runat="server">
      </asp:GridView>
      <br />
      <h1>Member Search</h1>
      <br />
      Member #:
      <asp:TextBox ID="MemberNumTB" runat="server"></asp:TextBox>
      <asp:Button ID="MemberNumSearch" runat="server" Text="Search" OnClick="MemberNumSearch_Click"/>
      <br />
      <asp:GridView ID="MemberNumGrid" runat="server">
      </asp:GridView>
      <br />
      
      <head runat="server">
    <title></title>
</head>
<body>
</body>


  </div>

</div>

 

    </form>

 

</body>

</html>


</head>

 
