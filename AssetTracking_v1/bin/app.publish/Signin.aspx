<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Signin.aspx.cs" Inherits="AssetTracking_v1.Signin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Please Sign In</h3>
                    </div>
                    <div class="panel-body">
                        <fieldset>
                            <div class="form-group">
                                <input id="usernametxtbox" class="form-control" placeholder="Username" runat="server">
                            </div>
                            <div class="form-group">
                                <input id="passwdtxtbox" class="form-control" placeholder="Password" name="password" type="password" value="" runat="server">
                            </div>
                            <asp:Label ID="MSGLabel" runat="server" Text="" />
                            <!-- Change this to a button or input when using this as a form -->
                           <asp:Button ID="btnLogin" Text="Login" runat="server" CssClass="btn btn-lg btn-success btn-block" OnClick="btnLogin_Click" />
                            
                            <%--<a href="index.html" class="btn btn-lg btn-success btn-block">Login</a>--%>
                        </fieldset>

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
