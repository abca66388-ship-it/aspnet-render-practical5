var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
"""
<html>
<head>
<title>ASP.NET Practical 5</title>
</head>

<body>

<h1>ASP.NET Web Application</h1>

<p>Application running successfully on Render</p>

</body>

</html>
""");

app.Run();
