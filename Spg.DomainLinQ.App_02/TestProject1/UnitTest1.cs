using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using System;
using static Bogus.DataSets.Name;
using Gender = Spg.DomainLinQ.App.Model.Gender;

namespace TestProject1
{
    public class UnitTest1
    {
        private Shop2000Context GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source = Shop2000.db");

            Shop2000Context db = new Shop2000Context(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            return db;
        }
        [Fact]
        public void User_Add_OneEntity_SuccessTest()
        {

            // 1. Arrange

            Shop2000Context db = GenerateDb();
            User newUser = new User(1, "Fname1", "Lname1", "@mail",
                new Address("Street1", "PLZ1", "City", "jlksnk"), new Address("Street11", "PLZ2", "City2", "23322rr"), Gender.FEMALE, Guid.NewGuid(),
                new Shop("Shop1", Guid.NewGuid()));

            // 2. Act
            db.Users.Add(newUser);
            db.SaveChanges();

            // 3. Assert 

            Assert.Equal(1, db.Users.Count());
        }
        [Fact]
        public void Supplier_Add_OneEntity_SuccessTest()
        {

            // 1. Arrange

            Shop2000Context db = GenerateDb();
            Supplier newSupplier = new Supplier("Fname1", "Lname1", "@mail", new Guid(),
                new Address("Street1", "PLZ1", "City", "jlksnk"), 
                new Address("Street11", "PLZ2", "City2", "23322rr"));
               
           
            // 2. Act
            db.Suppliers.Add(newSupplier);
            db.SaveChanges();

            // 3. Assert 

            Assert.Equal(1, db.Suppliers.Count());
        }
        public void Price_Add_OneEntity_SuccessTest()
        {

            Shop2000Context db = GenerateDb();
            Price newPrice = new Price(25, 10, new DateTime(), new Guid(),
                new Product("Product1", "Barcode1", 25, new DateTime(), new DateTime(),
                new Shop("Shop1", new Guid())));

            db.Prices.Add(newPrice);
            db.SaveChanges();

            Assert.Equal(1, db.Prices.Count());

        }
        [Fact]
        public void Product_Add_OneEntity_SuccessTest()
        {

            Shop2000Context db = GenerateDb();
            Product newProduct = new Product("Product1", "Barcode1", 25, new DateTime(), new DateTime(),
                new Shop("Shop1", new Guid()));

            db.Products.Add(newProduct);
            db.SaveChanges();

            Assert.Equal(1, db.Products.Count());

         }
            [Fact]
            public void Shop_Add_OneEntity_SuccessTest()
            {

                Shop2000Context db = GenerateDb();
                Shop newShop = new Shop("Shop1", new Guid());

                db.Shops.Add(newShop);
                db.SaveChanges();

                Assert.Equal(1, db.Shops.Count());

            }




        }
    
}