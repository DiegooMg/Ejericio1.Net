using System.ComponentModel.DataAnnotations;

namespace Comenzando.Models.DataModels
{
    public class Curso: BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(150)]
        public string ShortDescription { get; set; } = string.Empty;

        [Required]
        public string TypeOfGroup { get; set; } = string.Empty;

        [Required]
        public string Objetives { get; set; } = string.Empty;

        [Required]
        public string Requirements { get; set; } = string.Empty;

        [Required]
        //Lo hice de esta manera ya que sino no aparecia levls en las tablas, porque el enum no me acepta [Required]
        public string Levels { get; set; }enum LevelsEnum
        {
            Basic,
            Inter,
            Advance
        };

    }
}
