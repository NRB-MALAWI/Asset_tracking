<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Transfer_Assets.aspx.cs" Inherits="AssetTracking_v1.Admin.Transfer_Assets" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Transfer Asset</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-lg-6">
                            <div class="form-group">
                                <div class="input-group custom-search-form">
                                    <input type="text" class="form-control" placeholder="Search for Asset Number...">
                                    <span class="input-group-btn">
                                        <button class="btn btn-primary" type="button" runat="server">
                                            <i class="fa fa-search"></i>
                                        </button>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-6">
                            <div class="form-group">
                               <div class="input-group custom-search-form">
                                    <asp:DropDownList ID="txtAssetName" AutoPostBack="true" CssClass="form-control" runat="server" DataTextField="Asset_Name" DataValueField="Asset_Name" OnSelectedIndexChanged="txtAssetName_SelectedIndexChanged" />
                                    <span class="input-group-btn">
                                        <asp:Button Text="Search" Visible="true" runat="server" ID="btnSearchAssetName" CssClass="btn btn-primary" OnClick="btnSearchAssetName_Click" />
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
                            <asp:GridView ID="AssetGridview" runat="server" CssClass="table table-striped table-bordered table-hover">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="true" />
                                </Columns>
                            </asp:GridView>
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
                            <label>Asset Name</label>
                            <input type="text" id="" class="form-control" placeholder="Asset Name">
                        </div>
                        <div class="form-group">
                            <label>Asset Current District Location</label>
                            <input type="text" id="" class="form-control" placeholder="Asset Location">
                        </div>
                        <div class="form-group">
                            <label>Asset Current Office Location</label>
                            <input type="text" id="" class="form-control" placeholder="Asset Location">
                        </div>
                        <div class="form-group">
                            <label>Quantity in stock</label>
                            <input type="text" id="" class="form-control" placeholder="Quantity">
                        </div>
                        <div class="form-group">
                            <label>Current Custodian</label>
                            <input type="text" id="" class="form-control" placeholder="Custodian">
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-6">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i class="fa fa-bell fa-fw"></i>Transfer Details
                </div>
                <div class="panel-body">
                    <div class="panel-body">
                        <div class="form-group">
                            <label>Date Transfered</label>
                            <input type="date" id="" class="form-control" placeholder="Date issued" disabled="disabled">
                        </div>
                        <div class="form-group">
                            <label>Relocate to</label>
                            <%--<input type="text" id="" class="form-control" placeholder="Issued to">--%>
                            <asp:DropDownList ID="drpDistrictTansfer" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Office to Relocate</label>
                            <%--<input type="text" id="" class="form-control" placeholder="Issued to">--%>
                            <asp:DropDownList ID="drpDesignatedOffice" runat="server" CssClass="form-control" />
                        </div>
                        <div class="form-group">
                            <label>Quantity</label>
                            <input type="text" id="" class="form-control" placeholder="Quantity">
                        </div>
                        <div class="form-group">
                            <label>Custodian</label>
                            <input type="text" id="" class="form-control" placeholder="Custodian">
                        </div>
                        <div class="form-group">
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="btn btn-primary" />
                            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success pull-right" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
