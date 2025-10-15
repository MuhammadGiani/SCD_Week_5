using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_Lab_Week_5.Models.Entities
{
    public class Student
    {
        //student id
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //name
        [Column("name")]
        public string Name { get; set; }

        //age
        [Column("age")]
        public int Age { get; set; }
    }
}
