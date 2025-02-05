# Unit of Work Pattern
Implementation of Unit of Work in ASP.NET Core 9.0 and EF Core 9.0


The **Unit of Work** pattern is a design pattern used to manage transactions in a way that ensures multiple changes to a database can be grouped together and either committed or rolled back as a single operation. This pattern helps in maintaining consistency across different repositories when multiple operations are performed on them.

### What is Unit of Work?

The **Unit of Work** pattern is designed to track and manage multiple repository operations within a single transaction. It is used to ensure that all operations either succeed or fail together, preserving data integrity.

### Why Use Unit of Work?

- **Transaction Management**: It handles transactions in a centralized way, making it easier to commit or roll back all changes at once.
- **Consistency**: Ensures that all operations on the repositories are consistent and are either all successful or all fail together.
- **Simplifies Complex Transactions**: Helps in dealing with complex scenarios where multiple repository operations need to be done together in a single unit.

### Benefits

- **Simplifies Data Handling**: Grouping changes to multiple repositories into one transaction simplifies the data handling process.
- **Reduces Code Duplication**: Centralizes transaction handling, reducing the need for repetitive code.
- **Improved Testability**: Easier to write unit tests for business logic by abstracting the database operations.

### How to Implement Unit of Work

1. **Define the IUnitOfWork Interface**
    - The `IUnitOfWork` interface is used to manage repositories and transactions.
    - It provides a contract for how repositories will be accessed and how the transaction will be committed.
  
2. **Implement the UnitOfWork Class**
    - The `UnitOfWork` class implements the `IUnitOfWork` interface and is responsible for managing the actual database context and repositories.

3. **Define Repository Interfaces**
    - The repository interfaces define the operations that can be performed on specific entities (e.g., `ProductRepository`, `OrderRepository`).

4. **Implement Repository Classes**
    - Repository classes implement the interfaces and define the actual logic for data access.

5. **Using Unit of Work in Business Logic**
    - The service layer uses `UnitOfWork` to perform operations across multiple repositories within a single transaction.

---


الگوی **Unit of Work** یک الگوی طراحی است که برای مدیریت تراکنش‌ها استفاده می‌شود. این الگو تضمین می‌کند که تغییرات مختلف در پایگاه داده به صورت گروهی انجام شوند و به صورت یک عملیات واحد تأسیس یا برگشت داده شوند. این الگو به حفظ یکپارچگی داده‌ها در هنگام انجام عملیات مختلف بر روی مخازن داده (repositories) کمک می‌کند.

###  چیست؟ Unit of Work

الگوی **Unit of Work** به منظور ردیابی و مدیریت چندین عملیات repository در یک تراکنش واحد طراحی شده است. این الگو تضمین می‌کند که همه عملیات‌ها یا با موفقیت انجام شوند یا همه به طور همزمان با شکست مواجه شوند، که یکپارچگی داده‌ها حفظ شود.

### چرا باید از Unit of Work استفاده کنیم؟

- **مدیریت تراکنش‌ها**: این الگو تراکنش‌ها را به صورت متمرکز مدیریت می‌کند و باعث می‌شود که بتوانید همه تغییرات را به راحتی تأسیس یا برگشت دهید.
- **یکپارچگی**: تضمین می‌کند که تمامی عملیات‌ها در مخازن داده به صورت یکپارچه انجام شوند و یا همه به موفقیت برسند یا همه با شکست مواجه شوند.
- **سادگی در تراکنش‌های پیچیده**: به راحتی می‌توانید با سناریوهایی که نیاز به انجام عملیات‌های مختلف در یک تراکنش دارند، مقابله کنید.

### مزایا

- **سادگی در مدیریت داده‌ها**: گروه‌بندی تغییرات در چندین repository به یک تراکنش، فرآیند مدیریت داده‌ها را ساده‌تر می‌کند.
- **کاهش تکرار کد**: مدیریت تراکنش به صورت متمرکز، نیاز به نوشتن کدهای تکراری را کاهش می‌دهد.
- **بهبود قابلیت تست**: نوشتن تست‌های واحد برای منطق تجاری آسان‌تر می‌شود زیرا عملیات‌های پایگاه داده از منطق تجاری جدا شده‌اند.

### نحوه پیاده‌سازی Unit of Work

1. **تعریف رابط IUnitOfWork**
    - رابط `IUnitOfWork` برای مدیریت مخازن داده و تراکنش‌ها استفاده می‌شود.
    - این رابط قراردادی است برای نحوه دسترسی به مخازن داده و نحوه تأسیس تراکنش.

2. **پیاده‌سازی کلاس UnitOfWork**
    - کلاس `UnitOfWork` رابط `IUnitOfWork` را پیاده‌سازی می‌کند و مسئولیت مدیریت واقعی context پایگاه داده و مخازن داده را بر عهده دارد.

3. **تعریف رابط‌های Repository**
    - رابط‌های repository عملیات‌هایی را که می‌توانند بر روی موجودیت‌های خاص (مثل `ProductRepository`، `OrderRepository`) انجام شوند، تعریف می‌کنند.

4. **پیاده‌سازی کلاس‌های Repository**
    - کلاس‌های repository این رابط‌ها را پیاده‌سازی کرده و منطق واقعی دسترسی به داده‌ها را تعریف می‌کنند.

5. **استفاده از Unit of Work در منطق تجاری**
    - لایه سرویس از `UnitOfWork` برای انجام عملیات در چندین repository در یک تراکنش واحد استفاده می‌کند.
