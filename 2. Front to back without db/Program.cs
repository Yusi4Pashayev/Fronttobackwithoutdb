namespace _2._Front_to_back_without_db
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();

            var app = builder.Build();

            
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

            app.Run();
        }
    }
}