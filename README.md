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
  * **Auto-Restock:** The system executes a query to identify all products where stock has fallen below the defined RestockAt level.
  * **Automated System Auditing:** Restock actions are automatically logged in the transaction history under the username "System"
  * **Manual Annotations:** Managers can append custom notes during the restock process for specific inventory tracking.
  * **Auto-Update:** Inventory counts are automatically updated when restock requests are processed.
* 🔎 **On-Demand Partial Search:** Users can search for products by entering partial names or categories; the system retrieves all matches from the database upon clicking search.
## 💰 Staff Features
* 🛒 **Create Sales:** Select multiple products in a single transaction.
* 📉 **Automatic Deduction:** Stock quantity is reduced instantly upon sale completion.
* 📑 **Sales Tracking:** View personal sales history.
## 💻 Tech Stack
* **Language:** C# (.NET)
* **UI Framework:** Windows Forms (WinForms)
* **Database:** Microsoft SQL Server
* **Management Tool:** SQL Server Management Studio (SSMS)
## ⚙️ Installation & Setup
### 1. Pulling the repository:

 To get a local copy of the source code, run the following command in your terminal or Git Bash: 
```bash
git clone https://github.com/averagedude05/Inventory-Management-System
```
### 2. Database Configuration (SSMS)

1. **Create Database:** Open **SQL Server Management Studio (SSMS)** and create a new database named `Inventory Management System`.

2. **Execute Schema:**
   * Open the `schema.sql` file in SSMS.
   * Ensure the dropdown menu in the top left is set to **Inventory Management System**.
   * Click **Execute** (or press **F5**). 

This will automatically create all tables (`Users`, `Product`, `Catagory`, etc.) and set up the relationships (Foreign Keys).



3. **⚠️ CRITICAL REQUIREMENT:** You must manually insert a "system" user. The application’s auto-restock logic is hardcoded to attribute system-generated changes to this specific `UserName`.

**Run this query in SSMS:**

```sql
INSERT INTO [dbo].[Users] 
([UserName], [UserPhone], [UserPassword], [Role], [Full_name]) 
VALUES 
('system', '000', 'system_pass', 'System', 'System Account');
 ```
> **📌 Setup Note:**
> * **Username Requirement:** The username **must** be exactly `system`. The application's automated restock and auditing logic is hardcoded to look for this specific ID.
> * **Customization:** You can choose any values you like for the `UserPassword`, `UserPhone`, and `Full_name` fields.
> * **Database Automation:** Do not worry about the `Status` or `Created_at` columns. The SQL script handles these automatically, defaulting them to 'Active' and the current server timestamp upon insertion.
## 🗺️ **Project Roadmap**
### Phase 1: Core Foundation (Completed ✅)
- [X] **Relational Database Design:** Normalized tables in SSMS for Users, Products, Sales, and History.
- [x] **Role-Based Access Control:** Secure workflows for Admin, Manager, and Staff.
- [x] **Automated Inventory Logic:** Automatic stock deduction upon sale and "System" user audit logging.
- [x] **Threshold-Based Restock:** Logic to trigger replenishment based on `RestockAt` values.
- [x] **Partial Match Search:** Implementation of "On-Demand" search for efficient product lookup.

### Phase 2: Enhanced UX & Stability (In Progress 🛠️)
- [ ] **Input Validation:** Implementation of logic to prevent negative stock levels and invalid data entry.
- [ ] **Low-Stock Dashboard:** A dedicated visual alert system for Managers to see urgent restock needs at a glance.
- [ ] **Data Exporting:** Support for exporting sales and inventory reports to Excel or PDF.
- [ ] **Receipt Generation:** Automatically generate formal receipts/logs upon successful sales or restock operations.

### Phase 3: Advanced Features (Future 🚀)
- [ ] **Barcode Integration:** Support for hardware scanners for faster checkout.
- [ ] **Sales Analytics:** Visual charts and graphs showing business performance trends.
- [ ] **Expanded Payment Support:** Tracking for various payment methods (Cash, Card, Digital Wallets).
- [ ] **Supplier Dashboard:** A dedicated interface to manage vendor details and automate communication for low-stock restock requests.
