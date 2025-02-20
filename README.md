# Web API with C# .NET Core and Entity Framework

This project is a RESTful Web API built using C# .NET Core and Entity Framework. It provides basic CRUD operations for managing data entities, such as `Product`, in a database. The project also includes Swagger UI for easy testing and documentation of the API endpoints.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete operations on `Product` entities.
- **Entity Framework Core**: Used for database interaction and ORM functionality.
- **Swagger UI**: Provides a user-friendly interface for testing API endpoints.
- **JWT Authentication** (optional): Secure API access (if implemented).

### Prerequisites

- .NET Core SDK
- SQL Server (or any database of your choice)
- Visual Studio or any IDE of your choice

## API Endpoints

- `GET /api/products` – Retrieve all products.
- `GET /api/products/{id}` – Retrieve a product by ID.
- `POST /api/products` – Create a new product.
- `PUT /api/products/{id}` – Update an existing product by ID.
- `DELETE /api/products/{id}` – Delete a product by ID.

<img width="1440" alt="Screenshot 2025-02-19 at 9 14 18 PM" src="https://github.com/user-attachments/assets/669446f8-e117-4fc6-aa3a-d866fa577407" />


### Steps to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/your-repository-name.git
