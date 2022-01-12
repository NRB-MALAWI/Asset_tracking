<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Asset_Sheet.aspx.cs" Inherits="AssetTracking_v1.Admin.Asset_Sheet" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <h1 class="page-header">Issue Asset</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-lg-4">
                            <div class="form-group">
                                <div class="input-group custom-search-form">
                                    <input type="text" class="form-control" id="txtAssetNumber" runat="server" placeholder="Search for Asset Number...">
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnSearchAssetNumber" Text="Search" runat="server" CssClass="btn btn-primary" OnClick="btnSearchAssetNumber_Click" />
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">
                                <div class="input-group custom-search-form">
                                    <asp:DropDownList ID="txtAssetName" AutoPostBack="true" CssClass="form-control" runat="server" DataTextField="Asset_Name" DataValueField="Asset_Name"  />
                                    <%--<input type="text" id="txtAssetName" class="form-control" placeholder="Search for Asset Name...">--%>
                                    <span class="input-group-btn">
                                        <asp:Button Text="Search" Visible="true" runat="server" ID="btnSearchAssetName" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4">
                            <div class="form-group">
                                <div class="input-group custom-search-form">
                                    <asp:DropDownList ID="drpSearchAssetbyDistrict" CssClass="form-control" runat="server" AutoPostBack="true" 
                                        AppendDataBoundItems="True" DataTextField="Name" DataValueField="Name" />
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnSearchbyDistrict" Text="Search" runat="server" 
                                            CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                    </div>
                    <div class="form-group">
                        <div>
                            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="50%"></rsweb:ReportViewer>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
