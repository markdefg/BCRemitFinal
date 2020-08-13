<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LandingPage.aspx.vb" Inherits="BCRemitAssignment.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>

        .navbar {
  overflow: hidden;
  background-color: #4CAF50;
  position: sticky;
  position: -webkit-sticky;
  top: 0;
}
        .navbar a {
  float: left;
  display: block;
  color: white;
  text-align: center;
  padding: 14px 20px;
  text-decoration: none;
}
        .navbar a.right {
  float: right;
}
        .navbar a:hover {
  background-color: #ddd;
  color: black;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="navbar">
                <a href="Signup.aspx" class="right">Register</a>
              <a href="Login.aspx" class="right">Login</a>

            </div>
                   <div>
                       <h1 style="text-align:center"> Welcome to my Assignment!</h1>
                       <span style="font-size:20px"> Please register and log-in to know who is registered to this site!</span>
                   </div>
        
        </div>
    </form>
</body>
</html>
