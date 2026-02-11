# 📦Inventory Management System
A comprehensive, role-based web application designed to automate inventory tracking, manage sales transactions, and streamline user administration. This system bridges the gap between warehouse management and the retail point-of-sale.


## 🚀 Admin Features

* 🔐 **Secure Login:** Access control via secure credentials.
* 👥 **User Management:** Ability to view, add, or delete system users (Admin, Manager, Staff).
## 🛠️ Manager Features
* 📦 **Product Control:** Add new products with Category, Price, and Stock details.
* 📝 **Inventory Editing:** Update existing product details or delete products.
* 📈 **Stock Automation:**
  * View and search current stock levels in real-time.
  * **Auto-Purchase:** The system detects low stock and triggers a restock request.
  * **Auto-Update:** Inventory counts are automatically updated when restock requests are processed.
## 💰 Staff Features
* 🛒 **Create Sales:** Select multiple products in a single transaction.
* 📉 **Automatic Deduction:** Stock quantity is reduced instantly upon sale completion.
* 📑 **Sales Tracking:** View personal sales history.
## 💻 Tech Stack
* **Language:** C# (.NET)
* **Database:** Microsoft SQL Server
* **Management Tool:** SQL Server Management Studio (SSMS)
  
## 🗺️ **Project Roadmap**
### Phase 1: Core Foundation (Completed ✅)

    [x] Relational Database Design (SSMS)

    [x] Basic CRUD for Inventory Management

    [x] Automated Stock Deduction on Sale

    [x] Role-Based Access Control (Admin vs. User)

### Phase 2: Enhanced POS Experience (In Progress 🛠️)

    [ ] Search & Filter functionality for products

    [ ] Transaction history and digital receipt generation (PDF/Text)

    [ ] Input validation to prevent negative stock

    [ ] Basic dashboard with "Low Stock" alerts

### Phase 3: Advanced Features (Future)

    [ ] Barcode scanner integration

    [ ] Sales analytics & reporting charts

    [ ] Multi-payment method support (Cash, Card, etc.)

    [ ] Data backup and export to Excel/CSV

