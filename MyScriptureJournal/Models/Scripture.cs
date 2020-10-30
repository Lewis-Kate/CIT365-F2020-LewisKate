using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; }

        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Note { get; set; }

        [DisplayName("Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

    }
}
