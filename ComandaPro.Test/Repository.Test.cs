using ComandaPro.Domain.Entities;
using ComandaPro.Repository.Context;
using ComandaPro.Repository.Repository;
using System.Text.Json;

namespace ComandaPro.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestCategory()
        {
            using (var context = new ComandaProContext())
            {
                Console.WriteLine("Connected!!");

                var category1 = new Category(1, "Bebidas");
                var category2 = new Category(2, "Comidas");
                var category3 = new Category(3, "Sobremesas");

                context.Categories.Add(category1);
                context.Categories.Add(category2);
                context.Categories.Add(category3);

                context.SaveChanges();
                Console.WriteLine("Categories inserted!!");
            }
            using (var context = new ComandaProContext())
            {
                foreach (var cat in context.Categories)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }
    }
}
