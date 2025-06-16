using System.ComponentModel.DataAnnotations;

namespace DepartmentWorkload.Domain.Model
{
    /// <summary>
    /// Модель преподавателя
    /// </summary>
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Полное имя преподавателя
        /// </summary>
        [Required, StringLength(100)]
        public required string FullName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        [Required]
        public AcademicPosition Position { get; set; }
    }
}