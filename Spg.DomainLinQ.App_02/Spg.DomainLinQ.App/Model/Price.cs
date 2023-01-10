using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * PriceGross (wird durch PriceNet und Tax ermittelt)
    /// * PriceNett
    /// * Created
    /// * Guid
    /// //int Tax
    /// (4P)
    /// </summary>
    public class Price : EntityBase
    {
        public decimal PriceNett { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }
        public int Tax { get; set; }
        private decimal _priceGross;

        public decimal PriceGross => PriceNett + ((PriceNett * Tax) / 100); 
            
        

        // TODO: Implementation
        public virtual Product ProductNavigation { get; } = default!;
       
        public int ProducttNavigationId { get; set; }
        protected Price() { }

        public Price(decimal priceNett, int tax, DateTime created, Guid guid,  Product productNavigation)
        {
            PriceNett = priceNett;
            Tax = tax;
            Created = created;
            Guid = guid;
            
            ProductNavigation = productNavigation;
        }
        
    }
}
