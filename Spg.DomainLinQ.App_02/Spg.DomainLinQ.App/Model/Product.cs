using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description (PK)
    /// * Ean13;
    /// * Stock;
    /// * ExpiryDate;
    /// * DeliveryDate;
    /// * Price;
    /// * ShopNavigation
    /// (4P)
    /// </summary>
    public class Product : EntityBase
    {
        // TODO: Implementation
        public string Description { get;} = string.Empty;
        public string Ean13 { get; set; } = string.Empty;
        public int Stock { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime DeliveryDate { get; set; }

        public virtual Shop ShopNavigation { get; set; } = default!;
        public int ShopNavigationId { get; set; }

        private List<Price> _prices = new();
        public virtual IReadOnlyList<Price> Prices => _prices;

        private List<Supplier> _suppliers { get; set; } = new();
        public virtual IReadOnlyList<Supplier> Suppliers => _suppliers;

        private List<User> _users = new();
        public virtual IReadOnlyList<User> Users => _users;

        protected Product() { }

        public Product(string description, string ean13, int stock, DateTime expiryDate, DateTime deliveryDate, Shop shopNavigation)
        {
            Description = description;
            Ean13 = ean13;
            Stock = stock;
            ExpiryDate = expiryDate;
            DeliveryDate = deliveryDate;
            ShopNavigation = shopNavigation;
        }
        
    }
}
