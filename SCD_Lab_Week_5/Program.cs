// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SCD_Lab_Week_5;

using var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) => //we have to make sql server services
    {
        //Add services to the container

        services.AddDbContext<DatabaseContext>(options =>
        options.UseSqlServer("Data Source=(local);Initial Catalog=TechNova-Ecommerce-B;Integrated Security=True;Encrypt=False")
        ); //Connection String of database will be pasted.

    })
.Build();
