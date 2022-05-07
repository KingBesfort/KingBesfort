using System;
using System.Collections.Generic;
using System.Text;

namespace PostOfficeManagement.BO
{
    public class RegjistrimiKlientit : Base
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Emri { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Qyteti { get; set; }
        public string FacebookLink { get; set; }
    }
}
