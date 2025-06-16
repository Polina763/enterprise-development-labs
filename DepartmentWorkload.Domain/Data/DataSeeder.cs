using DepartmentWorkload.Domain.Model;

namespace DepartmentWorkload.Domain.Data
{
    /// <summary>
    /// Инициализация тестовых данных для нагрузки кафедры
    /// </summary>
    public static class DataSeeder
    {
        /// <summary>
        /// Генерация тестовых данных преподавателей
        /// </summary>
        public static List<Teacher> SeedTeachers()
        {
            return new List<Teacher>
            {
                new() { Id = 1, FullName = "Иванов И.И.", Position = AcademicPosition.Professor },
                new() { Id = 2, FullName = "Петрова С.К.", Position = AcademicPosition.AssociateProfessor },
                new() { Id = 3, FullName = "Сидоров А.В.", Position = AcademicPosition.Assistant }
            };
        }

        /// <summary>
        /// Генерация тестовых данных дисциплин
        /// </summary>
        public static List<Discipline> SeedDisciplines()
        {
            return new List<Discipline>
            {
                new() { Id = 1, Name = "Математика" },
                new() { Id = 2, Name = "Физика" },
                new() { Id = 3, Name = "Курсовой проект" },
                new() { Id = 4, Name = "Программирование" }
            };
        }

        /// <summary>
        /// Генерация тестовых данных нагрузки
        /// </summary>
        public static List<Workload> SeedWorkloads()
        {
            var teachers = SeedTeachers();
            var disciplines = SeedDisciplines();

            return new List<Workload>
            {
                // Лекции
                new() {
                    Teacher = teachers[0],
                    Discipline = disciplines[0], // Математика
                    Semester = 1,
                    GroupNumbers = "101,102",
                    ClassType = ClassType.Lecture,
                    Hours = 90
                },
                new() {
                    Teacher = teachers[1],
                    Discipline = disciplines[1], // Физика
                    Semester = 1,
                    GroupNumbers = "103,104",
                    ClassType = ClassType.Lecture,
                    Hours = 72
                },
                
                // Практические занятия
                new() {
                    Teacher = teachers[2],
                    Discipline = disciplines[0], // Математика
                    Semester = 1,
                    GroupNumbers = "101,102",
                    ClassType = ClassType.Practical,
                    Hours = 45
                },
                
                // Курсовые проекты
                new() {
                    Teacher = teachers[0], // Иванов И.И.
                    Discipline = disciplines[2], // Курсовой проект
                    Semester = 2,
                    GroupNumbers = "201,202",
                    ClassType = ClassType.CourseProject,
                    Hours = 60
                },
                new() {
                    Teacher = teachers[1], // Петрова С.К.
                    Discipline = disciplines[2], // Курсовой проект
                    Semester = 2,
                    GroupNumbers = "203",
                    ClassType = ClassType.CourseProject,
                    Hours = 30
                },
                
                // Лабораторные работы
                new() {
                    Teacher = teachers[2],
                    Discipline = disciplines[3], // Программирование
                    Semester = 2,
                    GroupNumbers = "201,202",
                    ClassType = ClassType.LabWork,
                    Hours = 36
                }
            };
        }
    }
}