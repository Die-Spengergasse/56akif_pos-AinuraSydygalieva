using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * BillingAddress
    /// * BusinessAddress
    /// * Guid
    /// (4P)
    /// </summary>
    public class Supplier
    {
        // TODO: Implementation

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address? BillingAddress { get; set; }
        public Address? BusinessAddress { get; set; }
        public Guid Guid { get; set; }



        private List<Product> _products = new();
        public virtual IReadOnlyList<Product> Products => _products;

        private List<Price> _prices = new();
        public virtual IReadOnlyList<Price> Prices => _prices;

        protected Supplier() { }

        public Supplier(string firstName, string lastName, string eMail, Guid guid, Address? billingAddress, Address? businessAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            Guid = guid;
            BillingAddress = billingAddress;
            BusinessAddress = businessAddress;
            
        }

        
        public void AddProduct(Product subject)
        {
            _products.Add(subject);
        }
    }
}
