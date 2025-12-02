using AutoMapper;
using ComandaPro.Domain.Entities;
using ComandaPro.Domain.Base;
using ComandaPro.Repository.Context;
using ComandaPro.Repository.Repository;
using ComandaPro.Service.Service;
using ComandaPro.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text.Json;

namespace ComandaPro.Test
{
    [TestClass]
    public sealed class ServiceTest
    {
        private ServiceCollection services;
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<ComandaProContext>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                new MapperConfiguration(
                    config => { config.CreateMap<User, User>(); },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            return services.BuildServiceProvider();

        }
        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();
            var _userService = serviceProvider.GetService<IBaseService<User>>();

            var user = new User
            {
                Name = "Diego",
                Telephone = "19988040621",
                Email = "piresg.diego@gmail.com",
                Password = "12345",
                Address = "Rua José Castilho Sobrinho 533",
                Document = "49915980876",
                IsRestaurant = false
            };
            var result = _userService.Add<User, User, UserValidator>(user);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}