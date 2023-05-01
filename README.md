---------------------------------------English

Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generative patterns:
- Macrocommamds. 
- Template Method. 

Terms of reference.
To develop application capable of generating reports for Housing compnany, this should cover reports that should display data in different formats. This system will produce different types of reports with varying data sources, filters, and visualizations. Employees need to be capable of generating reports for next cases:

-Last 100 sold houses

-Avg price for last quarter

-Spots on US map with circles indicating housing popularity

The system should also be flexible enough to generate reports in different formats such as CSV, PDF, and HTML.

1. Create a set of report templates that define the structure of the reports, including any formatting rules, data sources, and visualization options. The templates should be designed in a way that allows them to be extended and customized for different types of reports.

2. Implement a set of concrete report generators that can use the report templates to generate actual reports. The generators should be designed to work with different report formats, such as CSV, PDF, and HTML, and be flexible enough to allow for the customization of the report output.

3. Define a set of filter classes that can be used to extract specific data from the input data sources. The filters should be designed to work with the report templates and be easily extensible to accommodate new data sources and filtering requirements.

4. Develop a mechanism for visualizing the data in the reports, including charts, graphs, and tables. The visualization framework should be flexible enough to allow for the customization of the visual output and should be designed to work with the report templates and data sources.

5. Create a client application that can use the report generator system to produce reports based on user input. The application should allow the user to select the report type, data source, filter options, and visualization format, and then generate the report in the desired format.

Requirements:

- The report generator must be implemented in C#.

- The generator should be developed using the Commands and Template Method templates.

- The report generator should support the creation of reports in at least three different formats (e.g. PDF, Excel, HTML).

- The report generator must support applying at least three different filters to the data (e.g., date range, user, product).

- The report generator should support at least two different visualization methods (e.g., charts, tables).

- The report generator should be easily extensible to add new formats, filters, and visualization methods in the future.

- The report generator should be efficient and capable of handling large amounts of data. 

Deliverables:

- C# code that implements the report generator using the Prototype and Builder templates.

- Unit tests that check the functionality of the report generator.


The code implements the Macrocommand and Template Method design patterns to create different types of reports with different formats and filters.

The IReportGenerator interface defines the GenerateReport() method, which is implemented by the ExcelReportGenerator and PDFReportGenerator classes. These classes take a ReportTemplate object in their constructor and use it to generate a report in the specified format.

The abstract ReportTemplate class defines the GenerateReport() method as an abstract method that is implemented by the specific template classes SalesReportTemplate and InventoryReportTemplate. These classes use the FormatData() method, common to all subclasses, to format the report data before generating the report in the specified format.

The SalesReportTemplate and InventoryReportTemplate classes also have special properties (filter and visualizationMethod) that are used to filter and visualize report data, respectively.

In general, this code allows you to create several types of reports in different formats, with different filters and visualization methods using the macro command design templates and the template method.


---------------------------------------Українська

Розробити технічне завдання. Покажіть декомпозицію завдання, де частина завдань повинна бути реалізована за допомогою генеративних патернів:
- Макрокоманди. 
- Шаблонний метод. 

Технічне завдання.
Розробити систему генерації звітів, яка може створювати різні типи звітів з різними джерелами даних, фільтрами та візуалізаціями. 
Система також повинна бути достатньо гнучкою, щоб генерувати звіти у різних форматах, таких як CSV, PDF та HTML.

1. Створіть набір шаблонів звітів, які визначають структуру звітів, включаючи будь-які правила форматування, джерела даних та варіанти візуалізації. Шаблони повинні бути розроблені таким чином, щоб їх можна було розширювати і налаштовувати для різних типів звітів.

2. Реалізувати набір конкретних генераторів звітів, які можуть використовувати шаблони звітів для створення реальних звітів. Генератори повинні працювати з різними форматами звітів, такими як CSV, PDF та HTML, і бути достатньо гнучкими, щоб дозволити кастомізувати висновок звіту.

3. Визначити набір класів фільтрів, які можна використовувати для вилучення певних даних з джерел вхідних даних. Фільтри мають бути розроблені так, щоб працювати з шаблонами звітів і бути легко розширюваними для адаптації до нових джерел даних і вимог до фільтрації.

4. Розробити механізм візуалізації даних у звітах, включаючи діаграми, графіки та таблиці. Механізм візуалізації має бути достатньо гнучким, щоб дозволити кастомізувати візуальний висновок, і має бути розроблений для роботи з шаблонами звітів та джерелами даних.

5. Створити клієнтську програму, яка може використовувати систему генерації звітів для створення звітів на основі даних, введених користувачем. Додаток повинен дозволяти користувачеві вибрати тип звіту, джерело даних, параметри фільтрації та формат візуалізації, а потім згенерувати звіт у потрібному форматі.

Вимоги:

- Генератор звітів повинен бути реалізований на C#.

- Генератор повинен бути розроблений з використанням шаблонів Commands та Template Method.

- Генератор звітів повинен підтримувати створення звітів щонайменше у трьох різних форматах (наприклад, PDF, Excel, HTML).

- Генератор звітів повинен підтримувати застосування щонайменше трьох різних фільтрів до даних (наприклад, діапазон дат, користувач, продукт).

- Генератор звітів повинен підтримувати щонайменше два різні методи візуалізації (наприклад, діаграми, таблиці).

- Генератор звітів має бути легко розширюваним для додавання нових форматів, фільтрів і методів візуалізації в майбутньому.

- Генератор звітів повинен бути ефективним і здатним обробляти великі обсяги даних. 

Результати роботи:

- Код на C#, що реалізує генератор звітів з використанням шаблонів Prototype та Builder.

- Юніт-тести, які перевіряють функціональність генератора звітів.


Код реалізує патерни проектування Macrocommand та Template Method для створення різних типів звітів з різними форматами та фільтрами.

Інтерфейс IReportGenerator визначає метод GenerateReport(), який реалізується класами ExcelReportGenerator та PDFReportGenerator. Ці класи отримують об'єкт ReportTemplate у своєму конструкторі і використовують його для генерації звіту у вказаному форматі.

Абстрактний клас ReportTemplate визначає метод GenerateReport() як абстрактний метод, який реалізується конкретними шаблонними класами SalesReportTemplate і InventoryReportTemplate. Ці класи використовують спільний для всіх підкласів метод FormatData() для форматування даних звіту перед генерацією звіту у вказаному форматі.

Класи SalesReportTemplate та InventoryReportTemplate також мають спеціальні властивості (filter та visualizationMethod), які використовуються для фільтрації та візуалізації даних звіту відповідно.

Загалом, цей код дозволяє створювати кілька типів звітів у різних форматах, з різними фільтрами та методами візуалізації за допомогою макрокоманди шаблонів дизайну та методу шаблонів.
