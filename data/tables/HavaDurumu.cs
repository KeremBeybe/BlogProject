using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.tables
{
    public class HavaDurumu
    {
        [Key]
        public int derece {get;set;}
        public string Hava_Durumu {get;set;}
        public string rüzgar {get;set;}
        public string il {get;set;}
        public string tarih {get;set;}
    }
}