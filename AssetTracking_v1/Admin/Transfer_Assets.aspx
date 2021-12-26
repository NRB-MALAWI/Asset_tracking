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
                                    <input type="text" class="form-control" placeholder="Search for Asset Name...">
                                    <span class="input-group-btn">
                                        <button class="btn btn-primary" type="button" runat="server">
                                            <i class="fa fa-search"></i>
                                        </button>
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
                            <asp:GridView ID="AssetGridview" runat="server" />
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
                        <label>Asset Location</label>
                        <input type="text" id="" class="form-control" placeholder="Asset Location">
                        </div>
                        <div class="form-group">
                         <label>Quantity in stock</label>
                        <input type="text" id="" class="form-control" placeholder="Quantity">
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
                        <input type="date" id="" class="form-control" placeholder="Date issued" disabled="disabled">
                        </div>
                        <div class="form-group">
                         <label>Issued to</label>
                        <input type="text" id="" class="form-control" placeholder="Issued to">
                        </div>
                        <div class="form-group">
                         <label>Quantity</label>
                        <input type="text" id="" class="form-control" placeholder="Quantity">
                        </div>
                        <div class="form-group">
                         <label>Custodian</label>
                        <input type="text" id="" class="form-control" placeholder="Quantity">
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
