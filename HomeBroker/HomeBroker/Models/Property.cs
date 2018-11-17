using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBroker.Models
{
    public class Property
    {
        public int Id { get; set; }
        public PropertyTyp Typ { get; set; }
        public string Description { get; set; }
        public int Room { get; set; }
        public int Area { get; set; }
        public bool Washer { get; set; }
        public bool Refrigerator { get; set; }
        public bool Iron { get; set; }

        public virtual int AddressId  { get; set; }
        public virtual Address Address { get; set; }

        public virtual int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }

    }

    public enum PropertyTyp
    {
        House = 0,
        Flast = 1
    }
}
