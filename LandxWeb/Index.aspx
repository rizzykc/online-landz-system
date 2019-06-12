<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="LandxWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	
	<meta charset="utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=edge"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<meta name="description" content=""/>
	<meta name="author" content=""/>

	
	<title>Land Search</title>
	<link href="css/bootstrap.css" rel="stylesheet" type="text/css" />
	<script src="js/bootstrap.js"></script>
	<script src="js/jquery.js"></script>
</head>
<body style="background-color:#90EE90">
	<form id="form1" runat="server">
		<nav class="navbar navbar-default topnav" role="navigation" style="border-bottom:2px #069 solid">
			<div class="container topnav">
				<!-- Brand and toggle get grouped for better mobile display -->
				<div class="navbar-header">
					<button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
						<span class="sr-only">Toggle navigation</span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
					<a class="navbar-brand topnav" href="Index.aspx"><span style="font-size:27px; color:black; font-weight:bold;">Ministry of Lands, Physical Planning and Rural Development</span></a>
				</div>
				<!-- Collect the nav links, forms, and other content for toggling -->
				<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
					<ul class="nav navbar-nav navbar-right" >
						<li><a href="#" class="btns">Home</a></li>
					</ul>
				</div>
				<!-- /.navbar-collapse -->
			</div>
			<!-- /.container -->
		</nav>

		<div class="container-fluid" style="">
			<div class="col-sm-4 col-sm-offset-4 bg-success form-group" style="min-height:150px; border-radius:10px 10px 10px 10px; padding-top:20px; margin-top:200px;">
				<asp:TextBox ID="txtSearch" runat="server" CssClass="form-control input-lg" placeholder="Enter the LandId you want to search."></asp:TextBox>
				<asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-success btn-lg" OnClick="btnSearch_Click" />
				<asp:Literal ID="litError" runat="server"></asp:Literal>
				
			</div>
		</div>

		<div class="container-fluid">
			<asp:Panel ID="panFound" runat="server" class="col-sm-4 col-sm-offset-4 bg-default form-group" style="min-height:200px; margin-top:30px;" Visible="False">
				<b>
					LandID <asp:Literal ID="litId" runat="server"></asp:Literal> was found. The details are:
				</b>
				<table class="table table-hover">
					<tr>
						<td>
							Land Owner&#39;s Name:
						</td>
						<td>
							<asp:Literal ID="litOwnerName" runat="server"></asp:Literal>
						</td>

					</tr>
					<tr>
						<td>Land Owner&#39;s Phone Number:</td>
						<td>
							<asp:Literal ID="litPhone" runat="server"></asp:Literal></td>
						</tr>
					<tr>
						<td>Land Description:</td>
						<td>
							<asp:Literal ID="litDescription" runat="server"></asp:Literal>
						</td>
					</tr>
				</table>
			</asp:Panel>

		</div>
	</form>
</body>
</html>
