using System;
using System.Collections.Generic;

namespace Catalog.DAL.Entities
{
    public class SweetFab
    {
        public int SweetFabID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Director { get; set; }
        public IEnumerable<Sweet> Streets { get; set; }
        public IEnumerable<User> Users { get; set; }
    }

    public class User
    {
    }

    
}
