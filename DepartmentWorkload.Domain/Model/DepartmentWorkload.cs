using System.ComponentModel.DataAnnotations;

namespace DepartmentWorkload.Domain.Model
{
    /// <summary>
    /// Модель распределения нагрузки преподавателя
    /// </summary>
    public class Workload
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Преподаватель
        /// </summary>
        [Required]
        public required Teacher Teacher { get; set; }

        /// <summary>
        /// Дисциплина
        /// </summary>
        [Required]
        public required Discipline Discipline { get; set; }

        /// <summary>
        /// Номер семестра (1-8)
        /// </summary>
        [Range(1, 8)]
        public int Semester { get; set; }

        /// <summary>
        /// Номера групп через запятую
        /// </summary>
        [Required]
        public required string GroupNumbers { get; set; }

        /// <summary>
        /// Вид занятия
        /// </summary>
        [Required]
        public ClassType ClassType { get; set; }

        /// <summary>
        /// Количество часов
        /// </summary>
        [Range(1, 200)]
        public int Hours { get; set; }
    }
}