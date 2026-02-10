# 📦 Inventory & Sales Management System

A robust C# desktop application for managing retail operations, featuring a secure SQL Server backend and role-specific workflows for Admins, Managers, and Staff.

## 🚀 Admin Features
* 🔐 **Secure Login:** Access control via secure credentials.
* 👥 **User Management:** Ability to view, add, or delete system users (Admin, Manager, Staff).
* 📊 **Global Oversight:** Full access to monitor all products, purchase history, and sales records.

## 🛠 Manager Features
* 📦 **Product Control:** Add new products with Category, Price, and Stock details.
* 📝 **Inventory Editing:** Update existing product details or delete products.
* 📈 **Stock Automation:**
    * View and search current stock levels in real-time.
    * **Auto-Purchase:** The system detects low stock and triggers a restock request.
    * **Auto-Update:** Inventory counts are automatically updated (+1) when restock requests are processed.

## 💰 Staff Features
* 🛒 **Create Sales:** Select multiple products in a single transaction.
* 📉 **Automatic Deduction:** Stock quantity is reduced instantly upon sale completion.
* 📑 **Sales Tracking:** View personal sales history and print professional sales receipts.

## 💻 Tech Stack
* **Language:** C# (.NET)
* **Database:** Microsoft SQL Server
* **Management Tool:** SQL Server Management Studio (SSMS)

## 🏗 Installation
1. Clone the repository.
2. Import the SQL script from the `/Database` folder into **SSMS**.
3. Update your `connectionString` in the C# code to match your local SQL Server.
4. Build and Run via Visual Studio.
