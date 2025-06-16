using DepartmentWorkload.Domain.Model;

namespace DepartmentWorkload.Domain.Services
{
    /// <summary>
    /// Интерфейс репозитория для работы с нагрузкой
    /// </summary>
    public interface IDepartmentWorkloadRepository
    {
        /// <summary>
        /// Получить преподавателей по дисциплине
        /// </summary>
        Task<IEnumerable<Teacher>> GetLecturersByCourseAsync(string courseName);

        /// <summary>
        /// Получить преподавателей с курсовыми проектами
        /// </summary>
        Task<IEnumerable<Teacher>> GetTeachersWithCourseProjectsAsync();
    }
}