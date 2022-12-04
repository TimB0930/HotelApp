<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="Hotel.WebForm3" %>
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

 

<h2>Arizona Desert Inn</h2>

 

<div class="row">

  <div class="column">

    <h2>Menu</h2>
      <p>
          <a href="HomePage.aspx" >Home</a>
      </p>
      <p>
        <a href="Employee.aspx">Employee</a>
      </p>
      <p>
          <a href="Rooms.aspx">Rooms</a>
      </p>
      <p>
          <a href="Member.aspx">Members</a>
      </p>

  </div>

  <div class="columna" style="background-color:#bbb;">
      <head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="margin-left: 320px">Members</h1>
            <br />
            Guest ID:&nbsp;
            <asp:TextBox ID="GuestIdTB" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Payment Type:
            <asp:TextBox ID="Payment_TypeTB" runat="server"></asp:TextBox>
            <br />
            <br />
            Payment:
            <asp:TextBox ID="PaymentTB" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Status:
            <asp:TextBox ID="StatusTB" runat="server"></asp:TextBox>
            <br />
            <br />
            First Name:
            <asp:TextBox ID="FNTB" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Middle Name:
            <asp:TextBox ID="MNTB" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last Name:
            <asp:TextBox ID="LNTB" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;Date Signed:
            <asp:TextBox ID="DateSignedTB" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Points:&nbsp;
            <asp:TextBox ID="PointsTB" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="InsertButton" runat="server" Text="Insert" Width="33%"  OnClick="InsertButton_Click" />
            <asp:Button ID="UpdateButton" runat="server" Text="Update" Width="33%" OnClick="UpdateButton_Click"/>
            <asp:Button ID="DeleteButton" runat="server" Text="Delete" Width="33%" OnClick="DeleteButton_Click"/>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>


  </div>

</div>

 

</body>

</html>


</head>
