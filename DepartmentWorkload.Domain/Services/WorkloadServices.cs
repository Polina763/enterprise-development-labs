using DepartmentWorkload.Domain.Model;

namespace DepartmentWorkload.Domain.Services
{
    /// <summary>
    /// Сервис для работы с учебной нагрузкой
    /// </summary>
    public class WorkloadServices(IDepartmentWorkloadRepository repository)
    {
        private readonly IDepartmentWorkloadRepository _repository = repository;

        /// <summary>
        /// Получить лекторов по курсу
        /// </summary>
        public async Task<IEnumerable<Teacher>> GetCourseLecturers(string courseName)
        {
            return await _repository.GetLecturersByCourseAsync(courseName);
        }

        /// <summary>
        /// Получить преподавателей с курсовыми проектами
        /// </summary>
        public async Task<IEnumerable<Teacher>> GetTeachersWithCourseProjects()
        {
            return await _repository.GetTeachersWithCourseProjectsAsync();
        }
    }




}