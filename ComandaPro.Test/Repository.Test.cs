using ComandaPro.Domain.Entities;
using ComandaPro.Repository.Context;
using ComandaPro.Repository.Repository;
using System.Net.Mime;
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

        [TestMethod]
        public void TestUser()
        {
            using (var context = new ComandaProContext())
            {
                Console.WriteLine("Connected!!");

                var user1 = new User(1, "Diego", "18988040621", "Rua José Castilho Sobrinho 533", "12345678910", "123", "piresg.diego@gmail.com", false);
                var user2 = new User(2, "Veneza", "18988079401", "Rua A", "11111111111111", "12345", "venezarestaurante@gmail.com", true);

                context.Users.Add(user1);
                context.Users.Add(user2);

                context.SaveChanges();
                Console.WriteLine("Users inserted!!");
            }
            using (var context = new ComandaProContext())
            {
                foreach (var cat in context.Users)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }

        [TestMethod]
        public void TestOrder()
        {
            using (var context = new ComandaProContext())
            {
                Console.WriteLine("Connected!!");

                var user1 = context.Users.Find(1);

                var order1 = new Order(1, user1, DateTime.Now, "A caminho", 18);

                context.Orders.Add(order1);

                context.SaveChanges();
                Console.WriteLine("Order inserted!!");
            }
            using (var context = new ComandaProContext())
            {
                foreach (var cat in context.Orders)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }

        [TestMethod]
        public void TestPayment()
        {
            using (var context = new ComandaProContext())
            {
                Console.WriteLine("Connected!!");

                var order1 = context.Orders.Find(1);

                var payment1 = new Payment(1, order1, "Pix", 18, DateTime.Now);

                context.Payments.Add(payment1);
                context.SaveChanges();

                Console.WriteLine("Payment inserted!!");
            }
            using (var context = new ComandaProContext())
            {
                foreach (var cat in context.Payments)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }

        [TestMethod]
        public void TestProduct()
        {
            using (var context = new ComandaProContext())
            {
                Console.WriteLine("Connected!!");

                var category1 = context.Categories.Find(1);
                var category2 = context.Categories.Find(2);
                var category3 = context.Categories.Find(3);

                var product1 = new Product(1, category1, "Coca-cola lata", 5, "");
                var product2 = new Product(2, category2, "X-Salada", 18, "");
                var product3 = new Product(3, category3, "Açaí 500ml", 26, "");

                context.Products.Add(product1);
                context.Products.Add(product2);
                context.Products.Add(product3);

                context.SaveChanges();
                Console.WriteLine("Products inserted!!");
            }
            using (var context = new ComandaProContext())
            {
                foreach (var cat in context.Products)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }

        [TestMethod]
        public void TestItemOrder()
        {
            using (var context = new ComandaProContext())
            {
                Console.WriteLine("Connected!!");

                var order1 = context.Orders.Find(1);
                var product1 = context.Products.Find(2);

                var itemorder1 = new ItemOrder(1, order1, product1, 1, product1.Price, "");

                context.ItemOrders.Add(itemorder1);

                context.SaveChanges();
                Console.WriteLine("Item Order inserted!!");
            }
            using (var context = new ComandaProContext())
            {
                foreach (var cat in context.ItemOrders)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }
    }
}
