using AutoMapper;
using ComandaPro.App.Others;
using ComandaPro.App.Others.CustomerForms;
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
using ComandaPro.App.Others.RestaurantForms;

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
            services.AddTransient<UserListForm, UserListForm>();
            services.AddTransient<CategoryForm, CategoryForm>();
            services.AddTransient<ProductForm, ProductForm>();
            services.AddTransient<RestaurantMenu, RestaurantMenu>();
            services.AddTransient<Quantity, Quantity>();
            services.AddTransient<ClientOrder, ClientOrder>();
            services.AddTransient<PaymentForm, PaymentForm>();
            services.AddTransient<RestaurantOrders, RestaurantOrders>();
            services.AddTransient<OrderForm, OrderForm>();

            #endregion

            #region Mappings
            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<User, UserViewModel>()
                        .ReverseMap();
                        config.CreateMap<Product, ProductViewModel>()
                        .ForMember(p => p.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                        .ForMember(p => p.CategoryUserId, opt => opt.MapFrom(src => src.Category.UserId))
                        .ReverseMap();
                        config.CreateMap<Payment, PaymentViewModel>()
                        .ReverseMap();
                        config.CreateMap<Category, CategoryViewModel>()
                        .ForMember(c => c.UserName, opt => opt.MapFrom(src => src.User.Name))
                        .ReverseMap();
                        config.CreateMap<Order, OrderViewModel>()
                        .ReverseMap();
                        config.CreateMap<ItemOrder, ItemOrderViewModel>()
                        .ReverseMap();
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );

            #endregion

            serviceProvider = services.BuildServiceProvider();
        }
    }
}