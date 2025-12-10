using AutoMapper;
using ComandaPro.App.Others;
using ComandaPro.App.ViewModel;
using ComandaPro.App.Register;
using ComandaPro.Domain.Base;
using ComandaPro.Domain.Entities;
using ComandaPro.Repository.Context;
using ComandaPro.Repository.Repository;
using ComandaPro.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace ComandaPro.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;

        public static void ConfigureServices()
        {
            // Database config
            var dbConfigFile = "Config/DBConfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<ComandaProContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );

            #region Repositories
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
            services.AddScoped<IBaseRepository<Payment>, BaseRepository<Payment>>();
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<Order>, BaseRepository<Order>>();
            services.AddScoped<IBaseRepository<ItemOrder>, BaseRepository<ItemOrder>>();

            #endregion

            #region Services
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<IBaseService<Product>, BaseService<Product>>();
            services.AddScoped<IBaseService<Payment>, BaseService<Payment>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<Order>, BaseService<Order>>();
            services.AddScoped<IBaseService<ItemOrder>, BaseService<ItemOrder>>();


            #endregion

            #region Forms
            services.AddTransient<Login, Login>();
            services.AddTransient<UserForm, UserForm>();


            #endregion

            #region Mappings
            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<User, UserViewModel>();
                        config.CreateMap<Product, ProductViewModel>();
                        config.CreateMap<Payment, PaymentViewModel>();
                        config.CreateMap<Category, CategoryViewModel>();
                        config.CreateMap<Order, OrderViewModel>();
                        config.CreateMap<ItemOrder, ItemOrderViewModel>();
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );

            #endregion

            serviceProvider = services.BuildServiceProvider();
        }
    }
}