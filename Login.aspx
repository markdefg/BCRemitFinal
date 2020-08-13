<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="BCRemitAssignment.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
body {font-family: Arial, Helvetica, sans-serif;}
form {border: 3px solid #f1f1f1;}

input[type=text], input[type=password], input[type=email] {
  width: 100%;
  padding: 12px 20px;
  margin: 8px 0;
  display: inline-block;
  border: 1px solid #ccc;
  box-sizing: border-box;
}
.loginbtn {
  background-color: #4CAF50;
  color: white;
  padding: 14px 20px;
  margin: 8px 0;
  border: none;
  cursor: pointer;
  width: 100%;
}
.loginbtn:hover {
  opacity: 0.8;
}
.container {
  padding: 16px;
}


@media screen and (max-width: 300px) {
}
</style>
</head>
<body>
    <form id="form1" runat="server">
<div>
            <h2>Login Form</h2>

<form>

  <div class="container">
    <label for="email"><b>Email</b></label>
    <asp:TextBox type="email" ID="email" name="email" runat="server" placeholder="Enter Email Address" required></asp:TextBox>

    <label for="psw"><b>Password</b></label>
    <asp:TextBox type="password" ID="psw" name="psw" runat="server" placeholder="Enter Password" required></asp:TextBox>
        
    <asp:Button type="submit" ID="submit" CssClass="loginbtn" runat="server" Text="Login" />

 <%--<span><a href="#">Forgot password?</a></span>--%>
      </div>
</form>

    <div class="container register">
    <p>You dont have an account? <a href="Signup.aspx">Sign up</a>.</p>
    </div> 
</div>


</form>
      
    
</body>
</html>