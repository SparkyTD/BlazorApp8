using BlazorApp8.Components;
using BlazorApp8.Components.Test;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents().AddServerComponents();

var app = builder.Build();
app.UseStaticFiles();
app.MapRazorComponents<MainAppRouter>().AddServerRenderMode();
app.Run();