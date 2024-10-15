using CustomRouteConstraintInAspNetCoreMvc.Models;

namespace CustomRouteConstraintInAspNetCoreMvc;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddRouting(options =>
            {
                // This lambda is configuring the options for routing services that are added to the application's service container.
                options.ConstraintMap.Add("alphanumeric", typeof(AlphaNumericConstraint));
                // Adds a new entry to the ConstraintMap dictionary with the key "alphanumeric".
                // "alphanumeric" is the name that you will use in your route definitions to apply this constraint.
                // typeof(AlphaNumericConstraint) specifies the type of the custom constraint that will handle the logic when this key is used in route definitions.
                // AlphaNumericConstraint is a custom class implementing IRouteConstraint, which enforces that a route parameter meets specific conditions (being alphanumeric in this case).
            });

        


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

        app.MapControllerRoute(
                name: "CustomRoute",
                pattern: "{controller}/{action}/{id:alphanumeric?}",
                defaults: new { controller = "Home", action = "Index"}
            );
        app.Run();
    }
}
