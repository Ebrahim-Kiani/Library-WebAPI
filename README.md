API Documentation - api_practice
این مستندات برای استفاده از API پروژه api_practice طراحی شده است. این API شامل مسیرهای مختلف برای مدیریت کتاب‌ها و دسته‌بندی‌ها است.

اطلاعات پروژه
عنوان پروژه: api_practice

نسخه: 1.0

مسیرهای API
/api/categories/{categoryId}/books
GET /api/categories/{categoryId}/books
این مسیر برای دریافت لیستی از کتاب‌ها در یک دسته خاص است.

پارامترها:

categoryId (required): شناسه دسته‌بندی (نوع: integer)

پاسخ‌ها:

200 OK: موفقیت آمیز است و لیستی از کتاب‌ها به فرمت JSON یا XML باز می‌گردد.

POST /api/categories/{categoryId}/books
این مسیر برای افزودن یک کتاب جدید به یک دسته خاص است.

پارامترها:

categoryId (required): شناسه دسته‌بندی (نوع: integer)

بدنه درخواست:

BooksForCreationDto: شیء شامل اطلاعات کتاب جدید

پاسخ‌ها:

200 OK: موفقیت آمیز است و کتاب اضافه شده به فرمت JSON یا XML باز می‌گردد.

/api/categories/{categoryId}/books/{bookId}
GET /api/categories/{categoryId}/books/{bookId}
این مسیر برای دریافت جزئیات یک کتاب خاص است.

پارامترها:

categoryId (required): شناسه دسته‌بندی (نوع: integer)

bookId (required): شناسه کتاب (نوع: integer)

پاسخ‌ها:

200 OK: موفقیت آمیز است و جزئیات کتاب به فرمت JSON یا XML باز می‌گردد.

PUT /api/categories/{categoryId}/books/{bookId}
این مسیر برای بروزرسانی اطلاعات یک کتاب خاص است.

پارامترها:

categoryId (required): شناسه دسته‌بندی (نوع: integer)

bookId (required): شناسه کتاب (نوع: integer)

بدنه درخواست:

BooksForCreationDto: شیء شامل اطلاعات جدید کتاب

پاسخ‌ها:

200 OK: موفقیت آمیز است و اطلاعات کتاب به‌روزرسانی شده است.

PATCH /api/categories/{categoryId}/books/{bookId}
این مسیر برای به‌روزرسانی جزئیات یک کتاب خاص است.

پارامترها:

categoryId (required): شناسه دسته‌بندی (نوع: integer)

bookId (required): شناسه کتاب (نوع: integer)

بدنه درخواست:

Operation: شیء شامل اطلاعات به‌روزرسانی جزئیات کتاب

پاسخ‌ها:

200 OK: موفقیت آمیز است و اطلاعات کتاب به‌روزرسانی شده است.

DELETE /api/categories/{categoryId}/books/{bookId}
این مسیر برای حذف یک کتاب خاص از یک دسته‌بندی است.

پارامترها:

categoryId (required): شناسه دسته‌بندی (نوع: integer)

bookId (required): شناسه کتاب (نوع: integer)

پاسخ‌ها:

200 OK: موفقیت آمیز است و کتاب حذف شده است.

/api/categories
GET /api/categories
این مسیر برای دریافت لیستی از دسته‌بندی‌ها است.

پاسخ‌ها:

200 OK: موفقیت آمیز است و لیستی از دسته‌بندی‌ها به فرمت JSON یا XML باز می‌گردد.

مدل‌ها
BooksDto
این مدل برای نمایندگی اطلاعات کتاب استفاده می‌شود.


{
  "id": 1,
  "title": "Book Title",
  "description": "Book Description",
  "authorName": "Author Name",
  "price": 29.99,
  "categoryName": "Category Name"
}
BooksForCreationDto
این مدل برای ایجاد کتاب جدید استفاده می‌شود.


{
  "title": "New Book",
  "description": "Description of the new book",
  "authorId": 1,
  "isbn": "978-3-16-148410-0",
  "price": 19.99,
  "publishedDate": "2025-01-01T00:00:00Z",
  "categoryId": 1
}
CategoriesDto
این مدل برای نمایندگی اطلاعات دسته‌بندی‌ها استفاده می‌شود.


{
  "id": 1,
  "name": "Science Fiction",
  "books": [
    {
      "id": 1,
      "title": "Book Title"
    }
  ]
}
Operation
این مدل برای انجام عملیات‌های تغییر داده‌ها استفاده می‌شود.


{
  "operationType": 1,
  "path": "/title",
  "op": "replace",
  "value": "New Title"
}
نحوه استفاده از API
برای استفاده از API، می‌توانید از ابزارهایی مانند Postman یا Insomnia برای ارسال درخواست‌ها و دریافت پاسخ‌ها استفاده کنید.

