using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WorkCards.Infrastructure.DAL.Models
{
    public class WorkCard
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
    }
}
