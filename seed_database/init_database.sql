-- ============================================================
--  HovSedhep POS System - Database Setup Script
--  Create & Seed Data
-- ============================================================

USE master;
GO

-- Create Database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'HovSedhepDatabase')
BEGIN
    CREATE DATABASE HovSedhepDatabase;
    PRINT 'Database HovSedhepDatabase created.';
END
GO

USE HovSedhepDatabase;
GO

-- ============================================================
--  DROP TABLES (urutan: child dulu baru parent)
-- ============================================================
IF OBJECT_ID('OrderDetails',   'U') IS NOT NULL DROP TABLE OrderDetails;
IF OBJECT_ID('Orders',         'U') IS NOT NULL DROP TABLE Orders;
IF OBJECT_ID('Transactions',   'U') IS NOT NULL DROP TABLE Transactions;
IF OBJECT_ID('MenuItems',      'U') IS NOT NULL DROP TABLE MenuItems;
IF OBJECT_ID('Categories',     'U') IS NOT NULL DROP TABLE Categories;
IF OBJECT_ID('Employees',      'U') IS NOT NULL DROP TABLE Employees;
IF OBJECT_ID('RestaurantTables','U') IS NOT NULL DROP TABLE RestaurantTables;
GO

-- ============================================================
--  CREATE TABLES
-- ============================================================

-- 1. RestaurantTables
CREATE TABLE RestaurantTables (
    TableID     INT             PRIMARY KEY IDENTITY(1,1),
    Name        NVARCHAR(50)    NOT NULL,
    Capacity    INT             NOT NULL DEFAULT 2,
    Location    NVARCHAR(100)   NULL        -- contoh: 'Indoor', 'Outdoor'
);

-- 2. Employees
CREATE TABLE Employees (
    EmployeeID  INT             PRIMARY KEY IDENTITY(1,1),
    Name        NVARCHAR(100)   NOT NULL,
    Role        NVARCHAR(50)    NOT NULL,   -- 'Waitress', 'Cashier', 'Manager', dsb
    Phone       NVARCHAR(20)    NULL
);

-- 3. Categories
CREATE TABLE Categories (
    CategoryID  INT             PRIMARY KEY IDENTITY(1,1),
    Name        NVARCHAR(100)   NOT NULL
);

-- 4. MenuItems
CREATE TABLE MenuItems (
    MenuItemID  INT             PRIMARY KEY IDENTITY(1,1),
    CategoryID  INT             NOT NULL REFERENCES Categories(CategoryID),
    Name        NVARCHAR(150)   NOT NULL,
    Price       DECIMAL(12,2)   NOT NULL DEFAULT 0,
    Description NVARCHAR(500)   NULL
);

-- 5. Transactions
CREATE TABLE Transactions (
    TransactionID   INT             PRIMARY KEY IDENTITY(1,1),
    TableID         INT             NOT NULL REFERENCES RestaurantTables(TableID),
    CustomerName    NVARCHAR(150)   NOT NULL,
    TransactionDate DATETIME        NOT NULL DEFAULT GETDATE(),
    Status          NVARCHAR(20)    NOT NULL DEFAULT 'Ongoing'
    -- Status: 'Ongoing' | 'Completed' | 'Cancelled'
);

-- 6. Orders
CREATE TABLE Orders (
    OrderID         INT             PRIMARY KEY IDENTITY(1,1),
    TransactionID   INT             NOT NULL REFERENCES Transactions(TransactionID),
    EmployeeID      INT             NOT NULL REFERENCES Employees(EmployeeID),
    OrderTime       DATETIME        NOT NULL DEFAULT GETDATE()
);

-- 7. OrderDetails
CREATE TABLE OrderDetails (
    OrderDetailID   INT             PRIMARY KEY IDENTITY(1,1),
    OrderID         INT             NOT NULL REFERENCES Orders(OrderID),
    MenuItemID      INT             NOT NULL REFERENCES MenuItems(MenuItemID),
    Quantity        INT             NOT NULL DEFAULT 1,
    Price           DECIMAL(12,2)   NOT NULL  -- harga saat dipesan (snapshot)
);
GO

PRINT 'All tables created successfully.';
GO

-- ============================================================
--  SEED DATA
-- ============================================================

-- ---- RestaurantTables ----
SET IDENTITY_INSERT RestaurantTables ON;
INSERT INTO RestaurantTables (TableID, Name, Capacity, Location) VALUES
(1, 'A1', 4,  'Indoor'),
(2, 'A2', 4,  'Indoor'),
(3, 'A3', 4,  'Indoor'),
(4, 'A4', 4,  'Indoor'),
(5, 'B1', 6,  'Indoor'),
(6, 'B2', 6,  'Indoor'),
(7, 'C1', 10, 'Indoor'),
(8, 'C2', 10, 'Indoor');
SET IDENTITY_INSERT RestaurantTables OFF;

-- ---- Employees ----
INSERT INTO Employees (Name, Role, Phone) VALUES
('Siti Rahayu',   'Waitress', '081234567001'),
('Dewi Anggraini', 'Waitress', '081234567002'),
('Rina Kusuma',   'Waitress', '081234567003'),
('Budi Santoso',  'Cashier',  '081234567004'),
('Ahmad Fauzi',   'Manager',  '081234567005');

-- ---- Categories ----
INSERT INTO Categories (Name) VALUES
('Main Course'),
('Beverages'),
('Appetizer'),
('Dessert'),
('Snack');

-- ---- MenuItems ----
-- Main Course (CategoryID = 1)
INSERT INTO MenuItems (CategoryID, Name, Price, Description) VALUES
(1, 'Grilled Chicken Steak',  55000, 'Grilled chicken breast with mushroom sauce and mashed potato'),
(1, 'Beef Burger',            65000, 'Beef patty with cheddar, lettuce, tomato, and pickles on a brioche bun'),
(1, 'Spaghetti Bolognese',    48000, 'Classic spaghetti with slow-cooked beef and tomato ragout'),
(1, 'Fish and Chips',         52000, 'Beer-battered fish fillet with fries and tartar sauce'),
(1, 'Club Sandwich',          42000, 'Triple-decker sandwich with chicken, bacon, egg, and fresh vegetables');

-- Beverages (CategoryID = 2)
INSERT INTO MenuItems (CategoryID, Name, Price, Description) VALUES
(2, 'Iced Lemon Tea',         12000, 'Freshly brewed black tea with lemon and ice'),
(2, 'Orange Juice',           18000, 'Freshly squeezed orange juice'),
(2, 'Strawberry Smoothie',    25000, 'Blended strawberry with yogurt and honey'),
(2, 'Americano',              18000, 'Double shot espresso with hot water'),
(2, 'Caffe Latte',            22000, 'Espresso with steamed milk and light foam');

-- Appetizer (CategoryID = 3)
INSERT INTO MenuItems (CategoryID, Name, Price, Description) VALUES
(3, 'Chicken Wings',          28000, 'Crispy fried chicken wings with BBQ or buffalo sauce (6 pcs)'),
(3, 'Bruschetta',             22000, 'Toasted bread topped with fresh tomato, basil, and olive oil'),
(3, 'Cream of Mushroom Soup', 20000, 'Velvety mushroom soup with a drizzle of truffle oil');

-- Dessert (CategoryID = 4)
INSERT INTO MenuItems (CategoryID, Name, Price, Description) VALUES
(4, 'Chocolate Lava Cake',    28000, 'Warm chocolate cake with a molten center, served with vanilla ice cream'),
(4, 'Cheesecake',             25000, 'Classic New York cheesecake with strawberry compote'),
(4, 'Tiramisu',               27000, 'Italian dessert with mascarpone, espresso-soaked ladyfingers, and cocoa');

-- Snack (CategoryID = 5)
INSERT INTO MenuItems (CategoryID, Name, Price, Description) VALUES
(5, 'French Fries',           20000, 'Crispy golden fries with your choice of dipping sauce'),
(5, 'Onion Rings',            22000, 'Crunchy battered onion rings with ranch sauce'),
(5, 'Nachos',                 30000, 'Tortilla chips with melted cheese, jalapeños, salsa, and sour cream');

PRINT 'Seed data inserted successfully.';
GO

-- ============================================================
--  SAMPLE TRANSACTION DATA (opsional, untuk testing)
-- ============================================================

-- Transaksi 1 - Table A1 - Completed
INSERT INTO Transactions (TableID, CustomerName, TransactionDate, Status)
VALUES (1, 'Budi Hartono', DATEADD(hour, -3, GETDATE()), 'Completed');

DECLARE @tid1 INT = SCOPE_IDENTITY();
INSERT INTO Orders (TransactionID, EmployeeID, OrderTime)
VALUES (@tid1, 1, DATEADD(hour, -3, GETDATE()));

DECLARE @oid1 INT = SCOPE_IDENTITY();
INSERT INTO OrderDetails (OrderID, MenuItemID, Quantity, Price) VALUES
(@oid1, 1,  2, 55000),  -- Grilled Chicken Steak x2
(@oid1, 6,  2, 12000),  -- Iced Lemon Tea x2
(@oid1, 11, 1, 28000);  -- Chicken Wings x1


-- Transaksi 2 - Table B1 - Ongoing
INSERT INTO Transactions (TableID, CustomerName, TransactionDate, Status)
VALUES (5, 'Rina Fitriani', DATEADD(minute, -30, GETDATE()), 'Ongoing');

DECLARE @tid2 INT = SCOPE_IDENTITY();
INSERT INTO Orders (TransactionID, EmployeeID, OrderTime)
VALUES (@tid2, 2, DATEADD(minute, -30, GETDATE()));

DECLARE @oid2 INT = SCOPE_IDENTITY();
INSERT INTO OrderDetails (OrderID, MenuItemID, Quantity, Price) VALUES
(@oid2, 2,  1, 65000),  -- Beef Burger x1
(@oid2, 10, 2, 22000),  -- Caffe Latte x2
(@oid2, 17, 1, 20000);  -- French Fries x1


-- Transaksi 3 - Table A2 - Cancelled
INSERT INTO Transactions (TableID, CustomerName, TransactionDate, Status)
VALUES (2, 'Dian Prasetyo', DATEADD(hour, -5, GETDATE()), 'Cancelled');

DECLARE @tid3 INT = SCOPE_IDENTITY();
INSERT INTO Orders (TransactionID, EmployeeID, OrderTime)
VALUES (@tid3, 3, DATEADD(hour, -5, GETDATE()));

DECLARE @oid3 INT = SCOPE_IDENTITY();
INSERT INTO OrderDetails (OrderID, MenuItemID, Quantity, Price) VALUES
(@oid3, 4, 1, 52000),   -- Fish and Chips x1
(@oid3, 7, 1, 18000);   -- Orange Juice x1


PRINT 'Sample transaction data inserted successfully.';
GO

-- ============================================================
--  VERIFICATION QUERIES
-- ============================================================

SELECT 'RestaurantTables'  AS [Table], COUNT(*) AS [Rows] FROM RestaurantTables
UNION ALL
SELECT 'Employees',        COUNT(*) FROM Employees
UNION ALL
SELECT 'Categories',       COUNT(*) FROM Categories
UNION ALL
SELECT 'MenuItems',        COUNT(*) FROM MenuItems
UNION ALL
SELECT 'Transactions',     COUNT(*) FROM Transactions
UNION ALL
SELECT 'Orders',           COUNT(*) FROM Orders
UNION ALL
SELECT 'OrderDetails',     COUNT(*) FROM OrderDetails;
GO

PRINT '=== Database setup complete! ===';
GO
