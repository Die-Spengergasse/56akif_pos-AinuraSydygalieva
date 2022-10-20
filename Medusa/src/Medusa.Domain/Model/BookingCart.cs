using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medusa.Domain.Model
{
    public class BookingCart
    {
        public int Id { get; set; }
        public int ServiceCount { get;}
        public Client ClientNavigation { get; set; } = default!;
        public List<BookingCartItem> BookingCartItems { get; set; } = new();
    }
}
