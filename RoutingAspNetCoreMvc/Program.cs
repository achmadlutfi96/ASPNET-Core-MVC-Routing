namespace RoutingAspNetCoreMvc;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        // app.MapControllerRoute(
        //     name: "default",
        //     pattern: "{controller=Home}/{action=Index}/{id?}");

        //https://localhost:44359/Student/All
        app.MapControllerRoute(
            name: "StudentAll",
            pattern: "Student/All",
            defaults: new { controller = "Student", action = "Index" }
        );
        //https://localhost:44359/StudentDetails/10
        app.MapControllerRoute(
            name: "StudentIndex",
            pattern: "StudentDetails/{ID}",
            defaults: new { controller = "Student", action = "Details" }
        );
        //For Rest of the Controller Actions including the Default Home Controller Index
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}/{id:int?}",
            defaults: new { controller = "Home", action = "Index" }
        );

        app.Run();
    }
}
