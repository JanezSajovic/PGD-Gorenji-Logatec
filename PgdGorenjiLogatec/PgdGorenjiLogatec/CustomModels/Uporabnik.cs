using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PgdGorenjiLogatec.CustomModels
{
    public class Uporabnik
    {
        public string UporabniskoIme { get; set; }

        [DataType(DataType.Password)]
        public string Geslo { get; set; }
    }
}
