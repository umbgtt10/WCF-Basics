<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetData.aspx.cs" Inherits="WebApiClient.GetData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function() {
            $("#btnGetData").click(function() {
                $.ajax({
                    type:"GET",
                    url:"http://localhost/FirstWebApi/api/Mtt",
                    success: function(data) {
                        console.log(data);
                    },
                    error: function() {
                        console.log('Error');
                    }
                } )            
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="GetData" id="btnGetData"/>
        </div>
    </form>
</body>
</html>
