using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PgdGorenjiLogatec.CustomModels
{
    public class Intervencija
    {
        public int Id { get; set; }
        public string Naslov { get; set; }

        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
    }
}
