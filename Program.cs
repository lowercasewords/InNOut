WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

WebApplication webapp = builder.Build();

// Configure the HTTP request pipeline.
if (!webapp.Environment.IsDevelopment())
{
    webapp.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    webapp.UseHsts();
}

webapp.UseHttpsRedirection();
webapp.UseStaticFiles();

webapp.UseRouting();

webapp.UseAuthorization();

webapp.MapRazorPages();

webapp.Run();

