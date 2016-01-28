﻿using System.Data.Entity;
using SwashbuckleODataSample.ApiControllers;
using SwashbuckleODataSample.Models;
using SwashbuckleODataSample.Utils;

namespace SwashbuckleODataSample.Repositories
{
    public class SwashbuckleODataContext : DbContext
    {
        static SwashbuckleODataContext()
        {
            Database.SetInitializer(new SwashbuckleODataInitializer());
        }


        public SwashbuckleODataContext() : base("name=SwashbuckleODataContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Project> Projects { get; set; }
    }

    public class SwashbuckleODataInitializer : DropCreateDatabaseAlways<SwashbuckleODataContext>
    {
        protected override void Seed(SwashbuckleODataContext context)
        {
            var clientOne = new Client { Name = "ClientOne" };
            context.Clients.Add(clientOne);
            context.Clients.Add(new Client { Name = "ClientTwo" });

            context.Projects.Add(new Project { ProjectName = "ProjectOne", Client = clientOne});
            context.Projects.Add(new Project { ProjectName = "ProjectTwo", Client = clientOne});

            var customerOne = new Customer { Name = "CustomerOne", Id=10, _privateIdentifier="1254-4343", _tenantKey="client1" };
            context.Customers.Add(customerOne);
            context.Customers.Add(new Customer { Name = "CustomerTwo", Id = 11, _privateIdentifier = "9872-0003", _tenantKey = "client1" });

            context.Orders.Add(new Order { OrderId = SequentialGuidGenerator.Generate(SequentialGuidType.SequentialAtEnd), OrderName = "OrderOne", Customer = customerOne, UnitPrice = 4.0 });
            context.Orders.Add(new Order { OrderId = SequentialGuidGenerator.Generate(SequentialGuidType.SequentialAtEnd), OrderName = "OrderTwo", Customer = customerOne, UnitPrice = 3.5 });

            base.Seed(context);
        }
    }
}