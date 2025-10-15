using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCD_Lab_Week_5.Models.Entities
{
    [Table("Enrollments")]
    public class Enrollment
    {
        //ID
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //student Id
        [Column("student_id")]
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;


        //course Id
        [Column("course_id")]
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;


        //Grade
        [Column("grade")]
        public string? Grade { get; set; }
    }
}
