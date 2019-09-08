using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2ThucHanh
{
    class Country_Capital
    {
        string Country;
        string Capital;

        public Country_Capital(string country, string capital)
        {
            Country1 = country;
            Capital1 = capital;
        }

        public string Country1 { get => Country; set => Country = value; }
        public string Capital1 { get => Capital; set => Capital = value; }
    }
}
