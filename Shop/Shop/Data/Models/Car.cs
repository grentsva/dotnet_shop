using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string fullDesc { set; get; }
        public string img { set; get; }
        public ulong price { set; get; }
        public bool isFavorite { set; get; }
        public bool available { set; get; }
        public int categoryId { set; get; }
        public virtual Category Category { set; get; }
    }
}
