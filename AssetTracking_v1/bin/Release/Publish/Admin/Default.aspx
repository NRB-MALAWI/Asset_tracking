<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AssetTracking_v1.Admin.Default" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=15.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="page-header">Dashboard</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                   Asset Details
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-4">
                            <div class="panel panel-default">
                                <div class="panel-heading">
                                    Asset Group
                                </div>
                                <div class="panel-body">
                                    <div class="form-group">
                                        <asp:GridView ID="GridView1" CssClass="table table-hover" runat="server" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>