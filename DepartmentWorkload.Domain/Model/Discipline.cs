using System.ComponentModel.DataAnnotations;

namespace DepartmentWorkload.Domain.Model
{
    /// <summary>
    /// Модель учебной дисциплины
    /// </summary>
    public class Discipline
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Название дисциплины
        /// </summary>
        [Required, StringLength(100)]
        public required string Name { get; set; }
    }
}