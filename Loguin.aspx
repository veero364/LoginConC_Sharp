<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loguin.aspx.cs" Inherits="DEMO.Loguin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style type="text/css">
        .style1
        {
            font-size: xx-large;
            text-decoration: underline;
        }
        .auto-style1 {
            width: 347px;
            height: 21px;
        }
    </style>
       <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <!--  <link href="generic_datos/todoPaginas1.css" rel="stylesheet" />-->
    <!-- <link rel='stylesheet prefetch' href='http://fonts.googleapis.com/css?family=Open+Sans'/> -->

     <link rel="stylesheet" href="css/style.css"/>
</head>
<body>
    
    <div class="cont">
  <div class="demo">
        <form class="demo" id="form2" runat="server">

    <div class="login">
      <div class="login__check"></div>
      <div class="login__form">
        <div class="login__row">
          <svg class="login__icon name svg-icon" viewBox="0 0 20 20">
            <path d="M0,20 a10,8 0 0,1 20,0z M10,0 a4,4 0 0,1 0,8 a4,4 0 0,1 0,-8" />
          </svg>
          <asp:TextBox type="text" runat="server" class="login__input name" id="TxtNomUsu"  placeholder="Username"/>
        </div>
        <div class="login__row">
          <svg class="login__icon pass svg-icon" viewBox="0 0 20 20">
            <path d="M0,20 20,20 20,8 0,8z M10,13 10,16z M4,8 a6,8 0 0,1 12,0" />
          </svg>
             
          <asp:TextBox type="password" runat="server" class="login__input pass"  id="TxtPassUsu" placeholder="Password"/>
        </div>
           <asp:Label  ID="LblError" runat="server" style="color: darkred; font-size: 1.5rem;"></asp:Label>
                <asp:Button type="button" runat="server" class="login__submit" onclick="BtnLogueo_Click" Text="Sign in"/>
          
        <p class="login__signup">Don't have an account? &nbsp;<a>Sign up</a></p>
      </div>
         <label id="Label1" runat="server"></label>
       
    </div>

        </form>
     
  </div>
</div>
  
    <script src='https://code.jquery.com/jquery-3.6.0.min.js'></script>

        <script src="JS/index.js"></script>
   







     
</body>
</html>
