<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="VirtualTeachingAssistant.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Virtual Teaching Assistant</title>

     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-icons/1.10.5/font/bootstrap-icons.min.css" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Inter:wght@400;600;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="style/loginPage.css" />
</head>
<body>
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                      <h2>Welcome to Temple's Virtual Teaching Assistant!</h2>
                        <form method="post">

                            <label for="loginEmail">Username</label>
                            <input type="email" class="form-control" id="loginEmail" placeholder="Email" />

                            <label for="loginPassword">Password</label>
                            <input type="password" class="form-control" id="loginPassword" placeholder="Password" required />



                            <div class="btnLogin" style="padding-top: 10px;">
                                <button type="submit" id="btnLogin" style="font-size: 18px;" class="btn custom-btn">Login</button>
                            </div>
                        </form>

                        <div>
                             <a href="SignUp.aspx" class="link-underline-primary">Don't have an account? Click here!</a>
                        </div>
                        </div>
                        
                </div>
            </div>
        </div>
    </div>
</body>
</html>
