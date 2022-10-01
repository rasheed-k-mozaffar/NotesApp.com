var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient(typeof(INoteRepository), typeof(NoteRepository));

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapDefaultControllerRoute();
app.UseStaticFiles();

app.Run();

