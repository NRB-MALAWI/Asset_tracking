<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Add_User.aspx.cs" Inherits="AssetTracking_v1.Admin.Add_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="page-header">Add User</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i></i>User Creation Page
                    <div class="pull-right">
                        <div class="btn-group">
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="form-group">

                        <label for="firstname" class="col-sm-2 control-label">Firstname</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="txtfirstname" CssClass="form-control" runat="server" />
                        </div>
                        <label for="surname" class="col-sm-2 control-label">Othername</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="txtOthernames" CssClass="form-control" runat="server" />
                        </div>
                        <label for="username" class="col-sm-2 control-label">Surnames</label>
                        <div class="col-sm-2">
                            <asp:TextBox ID="txtSurname" CssClass="form-control" runat="server" />
                        </div>

                        <br />
                        <br />
                        <br />
                        <label for="username" class="col-sm-2 control-label">Username</label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="txtusername" CssClass="form-control" runat="server" />
                        </div>

                        <br />
                        <br />
                        <br />

                        <label for="password" class="col-sm-2 control-label">Password</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />

                        <label for="LblRoomNumber" class="col-sm-2 control-label">Activate User</label>
                        <asp:CheckBox ID="ActivateUserchk" runat="server" />

                        <br />
                        <br />

                        <label for="LblRoomNumber" class="col-sm-2 control-label">User Roles</label>
                        <asp:RadioButton Text="Admin" ID="rdAdmin" GroupName="ROles" runat="server" />
                        <asp:RadioButton Text="PRO" ID="rdPRO" GroupName="ROles" runat="server" />
                        <asp:RadioButton Text="ARO" ID="rdARO" GroupName="ROles" runat="server" />

                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                    <asp:Button ID="CreateBtn" CssClass="btn btn-primary" runat="server" Text="Create User" OnClick="CreateBtn_Click" />
                </div>
                        <div>
                            <center>
                                <asp:Label ID="MsgLabel" runat="server" Font-Size="X-Large" Style="font-size: small"></asp:Label>
                            </center>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>