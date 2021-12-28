<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Issue_Asset.aspx.cs" Inherits="AssetTracking_v1.Admin.Issue_Asset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Issue Asset</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <div class="input-group custom-search-form">
                                    <input type="text" class="form-control" id="txtAssetNumber" placeholder="Search for Asset Number...">
                                    <span class="input-group-btn">
                                        <asp:Button ID="btnSearchAssetNumber" Text="Search" runat="server" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                                <div class="input-group custom-search-form">
                                    <asp:DropDownList ID="txtAssetName" CssClass="form-control" runat="server" DataTextField="Asset_Name" DataValueField="Asset_Name" OnSelectedIndexChanged="txtAssetName_SelectedIndexChanged" />
                                    <%--<input type="text" id="txtAssetName" class="form-control" placeholder="Search for Asset Name...">--%>
                                    <span class="input-group-btn">
                                        <asp:Button Text="Search" runat="server" ID="btnSearchAssetName" CssClass="btn btn-primary" OnClick="btnSearchAssetName_Click" />
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
                            <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-6">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-bell fa-fw"></i>Asset Details
                </div>
                <div class="panel-body">
                    <div class="panel-body">
                        <div class="form-group">
                         <label>Asset Number</label>
                        <input type="text" id="txtAssetNo" class="form-control" placeholder="Asset Number" runat="server">
                        </div>
                        <div class="form-group">
                         <label>Asset Name</label>
                        <input type="text" id="txtAsset_name" class="form-control" placeholder="Asset Name" runat="server">
                        </div>
                        <div class="form-group">
                        <label>Asset Location</label>
                        <input type="text" id="txtAsset_Location" class="form-control" placeholder="Asset Location" runat="server">
                        </div>
                        <div class="form-group">
                         <label>Quantity in stock</label>
                        <input type="text" id="txtQuantity" runat="server" class="form-control" placeholder="Quantity">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-6">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-bell fa-fw"></i>Personal Details
                </div>
                <div class="panel-body">
                    <div class="panel-body">
                        <div class="form-group">
                         <label>Date issued</label>
                        <input type="date" id="" class="form-control"  placeholder="Date issued" disabled="disabled">
                        </div>
                        <div class="form-group">
                         <label>Issued to</label>
                        <input type="text" id="txtIssued_to" runat="server" class="form-control" placeholder="Issued to">
                        </div>
                        <div class="form-group">
                         <label>Quantity</label>
                        <input type="text" id="txtQuanityIssue" runat="server" class="form-control" placeholder="Quantity">
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnSave" Text="Submit" CssClass="btn btn-primary pull-right" runat="server" />
                            <asp:Button ID="btnCancel" Text="Cancel" CssClass="btn btn-primary pull-left" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
