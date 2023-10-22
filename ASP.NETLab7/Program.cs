var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=File}/{action=DownloadFile}/{id?}",
    new { controller = "File", action = "DownloadFile" }
);

app.Run();
