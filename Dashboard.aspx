<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Dashboard.aspx.vb" Inherits="BCRemitAssignment.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container{
            text-align:center;
            background-color: #4CAF50;
            
        }
        .tableview{
            text-align: center;
            margin-left: 550px;
            
        }
        .logoutbtn {
              background-color: #4CAF50;
              color: white;
              padding: 14px 20px;
              margin: 8px 0;
              border: none;
              cursor: pointer;
              width: 100%;
        }
            .logoutbtn:hover {
              opacity: 0.8;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div class="container">
               <h1>Welcome to my Dashboard</h1>
                <p>The table below shows who registered to this website.</p>
                  <hr/>
              </div>
        </div>
            <div class="tableview">
                <asp:GridView ID="GridView1" runat="server" Height="249px" style="margin-left: 0px" Width="568px">
                </asp:GridView>
            </div>
                <div>
                    <asp:Button type="submit" ID="submit" CssClass="logoutbtn" runat="server" Text="LOGOUT" />
                </div>

    </form>
</body>
</html>
