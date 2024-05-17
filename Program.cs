namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddRazorPages();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute(
     name: "default",
  pattern: "{controller=user}/{action=index}/{id?}");

            app.Run();
        }
    }
}
