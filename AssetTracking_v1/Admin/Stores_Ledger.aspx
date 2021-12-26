<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Stores_Ledger.aspx.cs" Inherits="AssetTracking_v1.Admin.Stores_Ledger" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Stores Ledger</h1>
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
                                    <input type="text" id="txtAssetName" class="form-control" placeholder="Search for Asset Name...">
                                    <span class="input-group-btn">
                                        <asp:Button Text="Search" runat="server" ID="btnSearchAssetName" CssClass="btn btn-primary" />
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-bell fa-fw"></i>Asset Details
                </div>
                <div class="panel-body">
                    <div class="panel-body">
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
