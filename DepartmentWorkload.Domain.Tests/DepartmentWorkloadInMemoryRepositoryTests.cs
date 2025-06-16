using DepartmentWorkload.Domain.Model;
using DepartmentWorkload.Domain.Services.InMemory;


namespace DepartmentWorkload.Domain.Tests
{
    public class DepartmentWorkloadInMemoryRepositoryTests
    {
        private readonly DepartmentWorkloadInMemoryRepository _repository;

        public DepartmentWorkloadInMemoryRepositoryTests()
        {
            _repository = new DepartmentWorkloadInMemoryRepository();
        }

        [Fact]
        public async Task GetLecturersByCourseAsync_ReturnsCorrectLecturers()
        {
            
            var courseName = "����������";

           
            var result = await _repository.GetLecturersByCourseAsync(courseName);

            
            Assert.Single(result);
            Assert.Equal("������ �.�.", result.First().FullName);
            Assert.Equal(AcademicPosition.Professor, result.First().Position);
        }

        [Fact]
        public async Task GetLecturersByCourseAsync_ReturnsEmptyForUnknownCourse()
        {
           
            var unknownCourse = "�������������� ����";

           
            var result = await _repository.GetLecturersByCourseAsync(unknownCourse);

           
            Assert.Empty(result);
        }

        [Fact]
        public async Task GetTeachersWithCourseProjectsAsync_ReturnsUniqueTeachers()
        {
           
            var result = (await _repository.GetTeachersWithCourseProjectsAsync()).ToList();

           
            Assert.Equal(2, result.Count);
            Assert.Contains(result, t => t.FullName == "������ �.�.");
            Assert.Contains(result, t => t.FullName == "������� �.�.");
            Assert.DoesNotContain(result, t => t.FullName == "������� �.�.");
        }

        [Fact]
        public async Task GetTeachersWithCourseProjectsAsync_ReturnsOnlyCourseProjectTeachers()
        {
            
            var result = (await _repository.GetTeachersWithCourseProjectsAsync()).ToList();

            
            Assert.All(result, teacher =>
            {
                Assert.Contains(_repository.GetWorkloadsForTesting()
, w => w.Teacher.Id == teacher.Id && w.ClassType == ClassType.CourseProject);
            });
        }

        [Fact]
        public async Task GetTeachersWithCourseProjectsAsync_ReturnsDistinctTeachers()
        {
           
            var result = (await _repository.GetTeachersWithCourseProjectsAsync()).ToList();

            
            var distinctCount = result.Select(t => t.Id).Distinct().Count();
            Assert.Equal(distinctCount, result.Count);
        }
    }
}