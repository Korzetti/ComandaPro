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

            #endregion

            #region Services
            services.AddScoped<IBaseService<User>, BaseService<User>>();
           

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
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );

            #endregion

            serviceProvider = services.BuildServiceProvider();
        }
    }
}