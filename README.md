📦 Inventory & Sales Management System 
A desktop-based management solution designed to bridge the gap between inventory control and point-of-sale operations. This project implements a Role-Based Access Control (RBAC) system, ensuring that Admins, Managers, and Staff have tailored interfaces for their specific responsibilities.
🚀 Key Features
🔐 Multi-User Authentication

    Admin: Full system oversight. Manages user accounts (Add/Delete/View) and has global visibility into all products, purchases, and sales data.

    Manager: Focuses on supply chain. Handles product entry, updates, and inventory monitoring.

    Staff: Optimized for the storefront. Creates sales for multiple products, manages stock reduction, and prints receipts.

📉 Smart Stock Automation (C# Logic)

The system features an Automated Procurement Logic handled directly within the application layer:

    Auto-Restock: The C# code monitors stock levels; when a product hits a "low" threshold, the system automatically triggers a restock request.

    Smart Increment: Once a restock is processed, the system automatically increments the stock count and updates the SQL Server database.

    Real-time Deduction: Stock is automatically reduced the moment a staff member completes a sale.

💰 Point of Sale (POS)

    Supports multi-product selection in a single transaction.

    Automated calculation of totals and stock impact.

    Viewable and printable sales receipts for records.

🛠 Tech Stack

    Frontend/Logic: C# (.NET)

    Database: Microsoft SQL Server

    Management Tool: SQL Server Management Studio (SSMS)

🗄️ Database Schema

The project uses a relational database design to ensure data consistency across users and inventory.

Key Tables Include:

    Users: Stores credentials and roles (Admin/Manager/Staff).

    Products: Tracks pricing, categories, and live stock levels.

    Sales: Logs every transaction performed by the staff.

💻 Technical Highlights

Instead of using database triggers, I implemented the inventory logic within the C# Business Layer. This allows for:

    Better Debugging: Easy to track logic flow within Visual Studio.

    Explicit Control: The application explicitly checks if (stock < limit) before sending an update command to SQL Server.

    Data Integrity: Ensures that the UI and the Database stay perfectly in sync during sales and restocks.

🏗 Installation

    Clone this repository.

    Open the .sln file in Visual Studio.

    Import the SQL script provided in the /Database folder into your SQL Server Management Studio.

    Update the Connection String in the app configuration to point to your local SQL instance.

    Build and Run.
