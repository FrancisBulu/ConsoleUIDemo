using Microsoft.Extensions.Configuration;
using StandardLibrary;
using System;

namespace ConsoleUIDemo
{
    class Program
    {
        public static IConfiguration configuration;
        static void Main(string[] args)
        {
            #region MyRegion

            //Person p = new Person();
            //p.FirstName = "Franck";
            //p.LastName = "Bulu";

            //Greetings g = new Greetings();
            //string result = g.Welcome(p);
            //Console.WriteLine(result);
            #endregion

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();

            string connectionstring = configuration.GetConnectionString("Default");
            Console.WriteLine(connectionstring);
        }
    }
}
