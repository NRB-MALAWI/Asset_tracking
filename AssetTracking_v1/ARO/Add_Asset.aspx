<%@ Page Title="" Language="C#" MasterPageFile="~/ARO/ARO.Master" AutoEventWireup="true" CodeBehind="Add_Asset.aspx.cs" Inherits="AssetTracking_v1.ARO.Add_Asset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1 class="page-header">Add Asset</h1>
    <div class="row">
        <div class="col-lg-12">
            <div class="panel panel-default">
                <div class="panel-heading">
                    <i></i>Asset Creation Panel
                    <div class="pull-right">
                        <div class="btn-group">
                        </div>
                    </div>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label for="AssetID" class="col-sm-2 control-label">Asset Number:</label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="AssetIDTextBox" CssClass="form-control" runat="server" Enabled="false" />
                        </div>
                        <label for="LblDateCreated" class="col-sm-2 control-label">Date Created</label>
                        <div class="col-sm-4">
                            <asp:TextBox ID="DateCreatedTxtBox" CssClass="form-control" runat="server" TextMode="DateTime" Enabled="false" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <label for="AssetName" class="col-sm-2 control-label">Asset Name:</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="AssetNameTxtBox" CssClass="form-control" runat="server" />
                        </div>

                        <br />
                        <br />
                        <br />
                        <label for="lblManufacturer" class="col-sm-2 control-label">Manufacturer</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="ManufacturerTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <label for="LblSerialNumber" class="col-sm-2 control-label">Serial Number (Optional):</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="SerialNumberTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <label for="ModelNumberTxtBox" class="col-sm-2 control-label">Model Number (If Available):</label>
                        <div class="col-sm-8">
                            <asp:TextBox ID="ModelNumberTxtBox" TextMode="Number" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <label for="Landingcost" class="col-sm-2 control-label">Landing Cost</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtLandingCost" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="form-group">
                            <label class="col-sm-2 control-label">District</label>
                            <div class="col-sm-2">
                                <asp:DropDownList OnSelectedIndexChanged="DistrictCtDropDownList_SelectedIndexChanged" ID="DistrictCtDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" AppendDataBoundItems="True" DataTextField="Name" DataValueField="DistrictId" />

                            </div>
                            <label for="LblDesignatedOffice" class="col-sm-1 control-label">Designated Office</label>
                            <div class="col-sm-3">
                                <asp:DropDownList ID="DesignatedOfficeTxtBox" CssClass="form-control" runat="server" AppendDataBoundItems="True" AutoPostBack="True" />
                            </div>
                            <label for="DateAcquired" class="col-sm-1 control-label">Date Acquired</label>
                            <div class="col-sm-3">
                                <asp:TextBox TextMode="Date" ID="AcquiredDateCalendar" CssClass="form-control" runat="server" />
                                <%--<asp:Calendar ID="AcquiredDateCalendar" runat="server" CssClass="form-control" />--%>
                                <%--<input type="date" autocomplete="on" class="form-control" id="AcquiredDateCalendar" runat="server" />--%>
                            </div>
                            <br />
                            <br />
                        </div>


                        <label for="LblDesignatedDepartment" class="col-sm-2 control-label">Designated Department:</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="DesignatedDepartmentTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />

                        <label for="LblRoomNumber" class="col-sm-2 control-label">Room Number:</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="RoomNumberTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />

                        <label for="LblCustodian" class="col-sm-2 control-label">Custodian</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="CustodianTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <label for="LblStatus" class="col-sm-2 control-label">Status</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="StatusTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />
                        <label for="LblComment" class="col-sm-2 control-label">Comment(s)</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="CommentTxtBox" CssClass="form-control" runat="server" />
                        </div>
                        <br />
                        <br />
                        <br />


                    </div>
                    <div class="form-group">
                        <div>
                            <center>
                                <asp:Label ID="MsgLabel" runat="server" Font-Size="X-Large" Style="font-size: small"></asp:Label>
                            </center>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <asp:Button ID="CreateBtn" CssClass="btn btn-primary" runat="server" Text="Submit" />
                        </div>
                        <div>
                            <center>
                                <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Style="font-size: small"></asp:Label>
                            </center>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>