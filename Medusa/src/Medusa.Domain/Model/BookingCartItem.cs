using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medusa.Domain.Model
{
    public class BookingCartItem
    {
        public int Id { get; set; }

        public List<BookingCart> BookingCarts { get; set; } = new();
    }
}
