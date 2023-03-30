using Microsoft.AspNetCore.Authentication.Cookies;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(15);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
    options =>
    {
        options.LoginPath = new PathString("/LogIn");
        options.AccessDeniedPath = new PathString("/404");
    }
);
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = new PathString("/LogIn");
    options.AccessDeniedPath = new PathString("/404");
});


builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizePage("/Home");
    options.Conventions.AuthorizeFolder("/Subject");
});




// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();
