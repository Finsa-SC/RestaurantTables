# HovSedhep POS System

A Windows Forms Point of Sale application for restaurant management built with .NET 8 and SQL Server.

---

## Tech Stack

| Component | Technology |
|-----------|------------|
| Framework | .NET 8 (WinForms) |
| Database | Microsoft SQL Server (Express) |
| Data Access | Microsoft.Data.SqlClient 6.1.3 |
| IDE | Visual Studio 2022+ |
| Target OS | Windows 10/11 |

---

## Project Structure

```
HovSedhep/
├── Program.cs                  # Application entry point
├── Form1.cs / .Designer.cs     # Main window — navigation (Table, Menu, History)
├── TableUC.cs                  # UserControl — restaurant table layout & status
├── DialogTable.cs              # Dialog form — Assign table or view seating detail
├── MenuUC.cs                   # UserControl — menu search & category filter
├── HistoryUC.cs                # UserControl — transaction, order & order detail history
├── Models/
│   └── TableProperty.cs        # Model — table seating data (Waitress, CustomerName, maxPax)
└── Helper/
    ├── DBHelper.cs             # Database connection & query execution wrapper
    └── UIHelper.cs             # Form input validation & button highlight
```

---

## Database Schema

### RestaurantTables
| Column | Type | Description |
|--------|------|-------------|
| TableID | INT IDENTITY PK | Auto-generated table ID |
| Name | NVARCHAR(50) | Table name (e.g. A1, B2, C1) |
| Capacity | INT | Maximum guest capacity (pax) |
| Location | NVARCHAR(100) | Table location (e.g. Indoor, Outdoor) |

### Employees
| Column | Type | Description |
|--------|------|-------------|
| EmployeeID | INT IDENTITY PK | Auto-generated employee ID |
| Name | NVARCHAR(100) | Employee full name |
| Role | NVARCHAR(50) | Role: `Waitress`, `Cashier`, `Manager` |
| Phone | NVARCHAR(20) | Phone number |

### Categories
| Column | Type | Description |
|--------|------|-------------|
| CategoryID | INT IDENTITY PK | Auto-generated category ID |
| Name | NVARCHAR(100) | Category name |

### MenuItems
| Column | Type | Description |
|--------|------|-------------|
| MenuItemID | INT IDENTITY PK | Auto-generated menu item ID |
| CategoryID | INT FK | References Categories |
| Name | NVARCHAR(150) | Menu item name |
| Price | DECIMAL(12,2) | Unit price |
| Description | NVARCHAR(500) | Item description |

### Transactions
| Column | Type | Description |
|--------|------|-------------|
| TransactionID | INT IDENTITY PK | Auto-generated transaction ID |
| TableID | INT FK | References RestaurantTables |
| CustomerName | NVARCHAR(150) | Customer name |
| TransactionDate | DATETIME | Transaction timestamp (default: GETDATE()) |
| Status | NVARCHAR(20) | `Ongoing` \| `Completed` \| `Cancelled` |

### Orders
| Column | Type | Description |
|--------|------|-------------|
| OrderID | INT IDENTITY PK | Auto-generated order ID |
| TransactionID | INT FK | References Transactions |
| EmployeeID | INT FK | References Employees (assigned waitress) |
| OrderTime | DATETIME | Time the order was created |

### OrderDetails
| Column | Type | Description |
|--------|------|-------------|
| OrderDetailID | INT IDENTITY PK | Auto-generated order detail ID |
| OrderID | INT FK | References Orders |
| MenuItemID | INT FK | References MenuItems |
| Quantity | INT | Number of items ordered |
| Price | DECIMAL(12,2) | Price at time of order (snapshot) |

---

## Features

### Table Seating
- Visual restaurant floor layout with 8 tables (A1–A4, B1–B2, C1–C2)
- Table color indicates status: white = available, yellow = occupied (Ongoing)
- Click an available table → Assign Table dialog (select waitress, customer name, pax size)
- Click an occupied table → Seating Detail dialog (view info, Finish Table, Cancel Table)

### Menu
- Browse menu items with filter by category and name
- Displays: Menu ID, Category, Name, Price, Description

### History
- Filter transactions by date and table name
- Three cascading DataGridViews: Transaction → Order → Order Detail
- Click a transaction row to load its orders
- Click an order row to load its order details

---

## Configuration

Connection string is located in `Helper/DBHelper.cs`:

```csharp
public static readonly string connectionString =
    "Server=HOSHIMI-MIYABI\\SQLEXPRESS;Database=HovSedhepDatabase;" +
    "Integrated Security=true;TrustServerCertificate=true";
```

> Update `HOSHIMI-MIYABI\\SQLEXPRESS` to match your SQL Server instance name.

---

## Getting Started

### Prerequisites
- .NET 8 SDK or Runtime
- SQL Server (Express or higher)
- Visual Studio 2022 or JetBrains Rider

### Setup
1. Open SQL Server Management Studio (SSMS) or Azure Data Studio
2. Run `HovSedhep_Database.sql` to create the database, tables, and seed data
3. Open `HovSedhep.sln` in Visual Studio
4. Update the connection string in `Helper/DBHelper.cs` if needed
5. Build and run (F5)

---

## Helper Classes

### DBHelper
Static wrapper for all SQL Server operations with built-in exception handling.

| Method | Returns | Usage |
|--------|---------|-------|
| `ExecuteNonQuery()` | `int` | INSERT, UPDATE, DELETE — returns rows affected |
| `ExecuteScalar()` | `object` | Retrieve a single value (COUNT, SUM, etc.) |
| `ExecuteQuery()` | `DataTable` | SELECT into a DataTable (for DataGridView / ComboBox) |
| `ExecuteReader<T>()` | `List<T>` | SELECT with object mapping via `Func<SqlDataReader, T>` |

### UIHelper
| Method | Usage |
|--------|-------|
| `ButtonHover(Control parent)` | Highlights the border of active buttons (those with a Tag set) |
| `Chek_Blok(Control parent)` | Validates form inputs — blocks empty TextBox, zero NumericUpDown, unselected ComboBox |

---

## Known Issues

- **Hardcoded connection string** — consider moving to `app.config` or `appsettings.json` for production use.
- **ComboBox validation** — `UIHelper.Chek_Blok` treats `SelectedIndex <= 0` as invalid, meaning the first item (index 0, typically "All") will also be blocked. Ensure this is handled consistently across all forms.
- **`dataGridView3` wrong event** — in `HistoryUC`, `dataGridView3` is bound to `dataGridView1_CellClick` instead of `dataGridView2_CellClick`, which means Order Detail may not refresh correctly when clicking an Order row.

---

## License

This project was built for learning / internal purposes. Feel free to modify as needed.
