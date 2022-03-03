<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Administrator.Master" AutoEventWireup="true" CodeBehind="Add_Asset.aspx.cs" Inherits="AssetTracking_v1.Admin.Add_Asset" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Add Asset</h1>
    <div class="row">
        <div class="col-lg-12">
           <div class="panel panel-default">
                <div class="panel-heading">
                    Asset Creation Panel
                </div>
               <div class="panel-body">
                   <div class="row">
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="AssetID" class="col-sm-1 control-label">Asset Number:</label>
                               <div class="col-sm-4">
                                   <asp:TextBox ID="AssetIDTextBox" CssClass="form-control" runat="server" Enabled="false" />
                               </div>
                               <label for="LblDateCreated" class="col-sm-1 control-label">Date Created</label>
                               <div class="col-sm-4">
                                   <asp:TextBox ID="DateCreatedTxtBox" CssClass="form-control" runat="server" TextMode="DateTime" Enabled="false" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="LblRoomNumber" class="col-sm-1 control-label">Room Number:</label>
                               <div class="col-sm-4">
                                   <asp:TextBox ID="RoomNumberTxtBox" CssClass="form-control" runat="server" />
                               </div>
                               <label for="LblCustodian" class="col-sm-1 control-label">Asset Holder</label>
                               <div class="col-sm-4">
                                   <asp:TextBox ID="CustodianTxtBox" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="AssetName" class="col-sm-1 control-label">Asset Name:</label>
                               <div class="col-sm-10">
                                   <asp:TextBox ID="AssetNameTxtBox" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="lblManufacturer" class="col-sm-1 control-label">Manufacturer</label>
                               <div class="col-sm-10">
                                   <asp:TextBox ID="ManufacturerTxtBox" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="LblSerialNumber" class="col-sm-1 control-label">Serial Number (Optional):</label>
                               <div class="col-sm-10">
                                   <asp:TextBox ID="SerialNumberTxtBox" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="ModelNumberTxtBox" class="col-sm-1 control-label">Model Number (If Available):</label>
                               <div class="col-sm-10">
                                   <asp:TextBox ID="ModelNumberTxtBox" TextMode="Number" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="Landingcost" class="col-sm-1 control-label">Landing Cost</label>
                               <div class="col-sm-10">
                                   <asp:TextBox ID="txtLandingCost" TextMode="Number" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="Quantity" class="col-sm-1 control-label">Quantity</label>
                               <div class="col-sm-10">
                                   <asp:TextBox ID="txtQuantity" TextMode="Number" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div>
                       <hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="lblSource0ffund" class="col-sm-1 control-label">Source of Funds</label>
                               <div class="col-sm-6">
                                   <asp:DropDownList ID="drpSourceoffunds" AutoPostBack="true" CssClass="form-control" runat="server" 
                                       OnSelectedIndexChanged="drpSourceoffunds_SelectedIndexChanged">
                                       <asp:ListItem Selected="True" Text="SELECT SOURCE OF FUND(S)" />
                                       <asp:ListItem Text="GOVERNMENT" />
                                       <asp:ListItem Text="DONOR" />
                                       <asp:ListItem Text="OTHER" />
                                   </asp:DropDownList>
                               </div>
                               <div class="col-sm-4">
                                   <input id="txtOthersource" class="form-control" visible="false" placeholder="Enter source of funds" runat="server">
                               </div>
                           </div>
                       </div>
                       <hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label class="col-sm-1 control-label">District</label>
                               <div class="col-sm-2">
                                   <asp:DropDownList ID="DistrictCtDropDownList" runat="server" CssClass="form-control" AutoPostBack="True" 
                                       AppendDataBoundItems="True" DataTextField="Name" DataValueField="DistrictId" OnSelectedIndexChanged="DistrictCtDropDownList_SelectedIndexChanged" />
                               </div>
                               <label for="LblDesignatedOffice" class="col-sm-1 control-label">Designated Office</label>
                               <div class="col-sm-3">
                                   <asp:DropDownList ID="DesignatedOfficeTxtBox" CssClass="form-control" runat="server" AppendDataBoundItems="True" AutoPostBack="True" />
                               </div>
                               <label for="DateAcquired" class="col-sm-1 control-label">Date Acquired</label>
                               <div class="col-sm-3">
                                   <asp:TextBox TextMode="Date" ID="AcquiredDateCalendar" CssClass="form-control" runat="server" />
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="LblDesignatedDepartment" class="col-sm-1 control-label">Designated Department:</label>
                               <div class="col-sm-10">
                                   <asp:DropDownList ID="DesignatedDepartmentTxtBox" CssClass="form-control" runat="server">
                                       <asp:ListItem Selected="True" Text="SELECT ASSIGNED DEPARTMENT" />
                                       <asp:ListItem Text="ADMINISTRATION & HUMAN RESOURCE" />
                                       <asp:ListItem Text="ICT" />
                                       <asp:ListItem Text="CIVIC" />
                                       <asp:ListItem Text="ACCOUNTS AND FINANCE" />
                                       <asp:ListItem Text="CRVS" />
                                       <asp:ListItem Text="ID" />
                                   </asp:DropDownList>
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="LblStatus" class="col-sm-1 control-label">Status</label>
                               <div class="col-sm-10">
                                   <asp:DropDownList ID="StatusTxtBox" CssClass="form-control" runat="server">
                                       <asp:ListItem Text="SELECT ASSET STATUS" Selected="True" />
                                       <asp:ListItem Text="WORKING" />
                                       <asp:ListItem Text="NOT WORKING" />
                                   </asp:DropDownList>
                               </div>
                           </div>
                       </div><hr /><br />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <label for="LblComment" class="col-sm-1 control-label">Comment(s)</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="CommentTxtBox" CssClass="form-control" runat="server" />
                        </div>
                           </div>
                       </div>
                       <hr />
                       <div class="col-lg-12">
                           <div class="form-group">
                               <center>
                                <asp:Label ID="MsgLabel" runat="server" Font-Size="X-Large" Style="font-size: small" />
                            </center>
                           </div>
                       </div>
                       <div class="col-lg-12">
                           <div class="form-group">
                               <div class="col-sm-offset-1 col-sm-10">
                            <asp:Button ID="CreateBtn" CssClass="btn btn-primary pull-right" runat="server" Text="Submit" OnClick="CreateBtn_Click" />
                        </div>
                           </div>
                       </div>
                   </div>
               </div>
           </div>
                <%-- 
                    <div class="form-group">
                        
                    </div>
                </div>
            </div>--%>
        </div>
    </div>
</asp:Content>
