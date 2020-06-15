<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Canuckington Post</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <link href="~/Content/global.css" rel="stylesheet" type="text/css" media="screen" charset="utf-8" />
</head>
<body>
    <div class="container body-content">
        @RenderBody()
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
