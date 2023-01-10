using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber (PK)
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * BillingAddress
    /// * BusinessAddress
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class User
    {
        // TODO: Implementation
        public int RegistrationNumber { get; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address BillingAddress { get; set; }
        public Address BusinessAddress { get; set; }
        public string AccountName => LastName.Substring(0, 5) + RegistrationNumber.ToString();
        public Gender Gender { get; set; }
        public Guid Guid { get; set; }

        private List<Product> _products = new();
        public virtual IReadOnlyList<Product> Products => _products;

        public virtual Shop ShopNavigation { get; set; } = default!;
        public int ShopNavigationId { get; set; }

        public void AddProduct(List<Product> product)
        {
            _products.AddRange(product);
        }

        protected User() { }

        public User(int registrationNumber, string firstName, string lastName, string eMail, Address billingAddress, Address businessAddress, 
            Gender gender, Guid guid,  Shop shopNavigation)
        {
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
            BillingAddress = billingAddress;
            BusinessAddress = businessAddress;
            Gender = gender;
            Guid = guid;
            ShopNavigation = shopNavigation;
        }
    }
}
