namespace DepartmentWorkload.Domain.Model
{
    /// <summary>
    /// Тип учебного занятия
    /// </summary>
    public enum ClassType
    {
        Lecture,        // Лекции
        Practical,      // Практические
        LabWork,        // Лабораторные
        KSR,            // КСРС
        CourseProject,  // Курсовой проект
        GEC             // ГЭК
    }

    /// <summary>
    /// Форма обучения
    /// </summary>
    public enum StudyForm
    {
        FullTime,       // Дневное
        Evening         // Вечернее
    }

    /// <summary>
    /// Должность преподавателя
    /// </summary>
    public enum AcademicPosition
    {
        Assistant,          // Ассистент
        AssociateProfessor, // Доцент
        Professor           // Профессор
    }
}