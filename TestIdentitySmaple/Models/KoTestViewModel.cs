using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestIdentitySmaple.Models
{
    public class KoTestViewModel
    {
        public KoTestViewModel()
        {
            Friends = new List<Friend>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Friend> Friends { get; set; }
    }

    public class Friend
    {
        public string Name { get; set; }
        public bool KnowJs { get; set; }
        public string FavoriteJsLibrary { get; set; }
    }
}