<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssetTracking_v1.Admin.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="page-header">Dashboard</h1>
    <div class="row">
        <div class="col-lg-10">
            <div class="panel panel-default">
                <div class="panel-heading">
                   Asset Details
                </div>
                <div class="panel-body">
                    
                    <div class="form-group">
                        <div>
                            <asp:GridView ID="AssetListGrid" CssClass="Context Classes" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>