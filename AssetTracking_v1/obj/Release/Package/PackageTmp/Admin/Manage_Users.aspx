<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Manage_Users.aspx.cs" Inherits="AssetTracking_v1.Admin.Manage_Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">User Management</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i></i>User Management Panel
                    <div class="pull-right">
                        <div class="btn-group">
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                       
                    </div>
                    <div class="form-group">
                        <div>
                            <asp:GridView ID="GridView1" CssClass="table" runat="server">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="true" SelectText="View" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
