<%@ Page Title="" Language="C#" MasterPageFile="~/GLY/管理员母版.Master" AutoEventWireup="true" CodeBehind="系别列表.aspx.cs" Inherits="web.GLY.系别列表" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%-- 
    <div class="row">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="rptCategoryList_ItemDataBound">
            <ItemTemplate>
                <div class="col-sm-6" style="float: left">

                    <div class="card">
                        <div class="card-header" style="font-weight: 500">
                            <%#Eval("DepartmentName") %> <a href="#" style="margin-right: 10px">查看学生</a>
                        </div>
                        <div class="card-block">

                         
                        </div>
                    </div>

                </div>
            </ItemTemplate>
        </asp:Repeater>
        <!--/.col-->
    </div>

    --%>

    <!--/.列表-->
    <div class="row" style="margin-left:5px;margin-bottom:4px">
        <div class="col-lg-4">
            <div class="input-group">
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server"  placeholder="搜索学院"  ></asp:TextBox>
                <span class="input-group-btn">
                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" Text="搜索" OnClick="Button1_Click" />
                </span>
            </div>
            <!-- /input-group -->
        </div>
        <!-- /.col-lg-6 -->
    </div>

    <div class="row" style="margin-left:5px">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="rptCategoryList_ItemDataBound">
            <ItemTemplate>

                <div class="col-lg-4">
                    <div class="card">
                        <div class="card-header">
                            <i class="fa fa-align-justify"></i><%#Eval("DepartmentName") %> <a href="#" style="margin-right: 10px">查看学生</a>
                        </div>
                        <div class="card-block">
                            <table class="table table-bordered table-striped table-condensed">
                                <thead>
                                    <tr>
                                        <th>班级</th>
                                        <th>操作</th>
                                    </tr>
                                </thead>
                                <tbody>

                                    <asp:Repeater ID="Repeater2" runat="server" OnItemDataBound="rptProductList_ItemDataBound">
                                        <ItemTemplate>
                                            <tr>
                                                <td><%#Eval("banjiName") %> </td>
                                                <td><a href='学生列表.aspx?departmentId=<%#Eval("departmentId")%>&banjiId=<%#Eval("banjiId")%>'   style="margin-right: 10px">查看学生</a></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>

                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <!--/.col-->
            </ItemTemplate>
        </asp:Repeater>
    </div>
    <!--/.列表-->

</asp:Content>
