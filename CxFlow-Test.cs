<html>
<body>
<table id="Search_holder" runat="Server" style="width:100%">
	<tr>
		<td>
			txtUserId = getRequestString("UserId");
			txtSQL = "SELECT * FROM Users WHERE UserId = " + txtUserId;
		</td>
    </tr>
 </body>
 </html>
       