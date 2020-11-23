using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCQExams.Models
{
    public class ProDbContext: DbContext
    {
        public ProDbContext(DbContextOptions<ProDbContext> options ):base(options)
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Questionair> Questionairs { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }

    }
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
    public class Questionair
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Question> Questions { get; set; }

    }
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public string Qt { get; set; }

        public List<Option> Options { get; set; }
    }
    public class Option
    {
        public int Id { get; set; }
        public string Opt { get; set; }
        public bool isCorrection { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }

    }
}
