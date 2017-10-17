using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace pracownicy
{
    [DataContract]
    public class Pracownik
    {
        [DataMember]
        public string PESEL { get; set; }

        [DataMember]
        public string Imie { get; set; }

        [DataMember]
        public string Nazwisko { get; set; }
    }
}
