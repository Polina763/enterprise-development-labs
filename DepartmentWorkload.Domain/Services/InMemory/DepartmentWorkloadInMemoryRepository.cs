using DepartmentWorkload.Domain.Data;
using DepartmentWorkload.Domain.Model;
namespace DepartmentWorkload.Domain.Services.InMemory
{
    /// <summary>
    /// In-memory реализация репозитория нагрузки кафедры
    /// </summary>
    public class DepartmentWorkloadInMemoryRepository : IDepartmentWorkloadRepository
    {
        private readonly List<Workload> _workloads = DataSeeder.SeedWorkloads();

        public List<Workload> GetWorkloadsForTesting() => _workloads;
        /// <summary>
        /// Получить преподавателей, читающих лекции по указанному курсу
        /// </summary>
        public Task<IEnumerable<Teacher>> GetLecturersByCourseAsync(string courseName)
        {
            var result = _workloads
                .Where(w => w.Discipline.Name == courseName && w.ClassType == ClassType.Lecture)
                .Select(w => w.Teacher)
                .OrderBy(t => t.FullName);

            return Task.FromResult(result.AsEnumerable());
        }

        /// <summary>
        /// Получить преподавателей с курсовыми проектами в нагрузке
        /// </summary>
        public Task<IEnumerable<Teacher>> GetTeachersWithCourseProjectsAsync()
        {
            var result = _workloads
                .Where(w => w.ClassType == ClassType.CourseProject)
                .Select(w => w.Teacher)
                .Distinct();

            return Task.FromResult(result.AsEnumerable());
        }
    }
}