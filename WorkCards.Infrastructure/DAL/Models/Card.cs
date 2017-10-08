using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WorkCards.Infrastructure.DAL.Models
{
    public class Card
    {
        [Key]
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("ID")]
        public WorkCard WorkCard { get; set; }
    }
}
