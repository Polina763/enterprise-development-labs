//Татарникова Полина Андреевна коммит
//Изменения в README.md
# Разработка профессиональных приложений

## Задание

### Цель
Реализация проекта клиент-серверного приложения.

### Задачи
* Реализация объектно-ориентированной модели данных
* Изучение реализации серверных приложений на базе WebAPI/OpenAPI
* Реализация клиентского приложения с использованием Blazor WASM 
* Изучение паттернов проектирования
* Повторение основ работы с системами контроля версий
* Unit-тестирование

### Лабораторные работы
1.	«Классы» - Реализация объектной модели данных
2.	«Сервер» - Реализация серверного приложения
3.	«ORM» - Реализация объектно-реляционной модели. Подключение к базе данных
4.	«Клиент» - Реализация клиентского приложения

В рамках первой лабораторной работы необходимо подготовить структуру классов, описывающих предметную область, определяемую в задании. В каждом из заданий присутствует часть, связанная с обработкой данных, представленная в разделе «Запросы». Данную часть необходимо реализовать в виде unit-тестов: подготовить тестовые данные, выполнить запрос с использованием LINQ, проверить результаты.

Во второй лабораторной работе необходимо реализовать серверное приложение, которое должно:
- Осуществлять базовые CRUD-операции с реализованными в первой лабораторной сущностями
- Предоставлять результаты аналитических запросов (раздел «Запросы» задания)

Хранение данных осуществлять в памяти в виде коллекций.

В третьей лабораторной работе хранение данных должно быть переделано на базу данных. Необходимо использовать объектно-реляционную модель на базе EF Core с целевой СУБД MySQL. 

В четвертой лабораторной работе необходимо реализовать клиентское приложение с использованием Blazor WASM, которое будет взаимодействовать с реализованным серверным приложением.

## Задание. Общая часть
**Обязательно**:
* Реализация как серверной, так и клиентской части системы
* Реализация серверной части на .NET 8
* Реализация серверной части на ASP.NET 
* Реализация unit-тестов с использованием xUnit
* Использование хранения данных в базе данных. По умолчанию MySQL
* Автоматизация тестирования на уровне репозитория через [GitHub Actions](https://docs.github.com/en/actions/learn-github-actions/understanding-github-actions)
* Создание минимальной документации к проекту: страница на GitHub с информацией о задании, скриншоты приложения и прочая информация

**Факультативно**:
* Использование иной СУБД (не MySQL)
* Реализация авторизации/аутентификации

Внимательно прочитайте [дискуссии](https://github.com/appinfd/enterprise-development-labs/discussions/1) о том, как работает автоматическое распределение на ревью.

## Варианты заданий
Номер задания соответствуют вашему номеру в списке групп. 
Задания можно найти [в документе в репозитории](https://github.com/appinfd/enterprise-development-labs/blob/main/projects.pdf)

## Схема сдачи
На каждую из лабораторных работ необходимо сделать отдельный Pull Request (PR).

Общая схема:
1. Сделать форк данного репозитория
2. Выполнить задание
3. Сделать PR в данный репозиторий
4. Исправить замечания после code review
5. Получить approve 
6. Прийти на занятие и защитить работу

## Вопросы и обратная связь по курсу
Чтобы задать вопрос по лабораторной, воспользуйтесь [соответствующим разделом дискуссий](https://github.com/appinfd/enterprise-development-labs/discussions/categories/questions).  
Если у вас появились идеи/пожелания/прочие полезные мысли по преподаваемой дисциплине, их можно оставить [здесь](https://github.com/appinfd/enterprise-development-labs/discussions/categories/ideas).
