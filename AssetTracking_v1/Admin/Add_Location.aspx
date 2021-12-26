<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Add_Location.aspx.cs" Inherits="AssetTracking_v1.Admin.Add_Location" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="page-header">Add Location</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i></i>Add Location Panel
                    <div class="pull-right">
                        <div class="btn-group">
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">District</label>
                        <div class="col-sm-2">
                            <asp:DropDownList ID="DistrictCtDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="Name" DataValueField="DistrictId" />

                        </div>
                        <label for="LblDesignatedOffice" class="col-sm-1 control-label">Location Name</label>
                        <div class="col-sm-3">
                            <asp:TextBox ID="txtPlace" CssClass="form-control" runat="server" />
                        </div>
                        <asp:Button ID="btnCreateLocation" CssClass="btn btn-primary" runat="server" Text="Create Location" OnClick="btnCreateLocation_Click" />
                    </div>
                    <div class="form-group">
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