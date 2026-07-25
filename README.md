# 📚 Library Management System

A desktop management application built with **C#** and **Windows Forms** to streamline library operations, including book inventory tracking, user management, and dynamic loan/return processing.

---

## 🌟 Key Features

* **📖 Book Inventory Management**: View, search, and filter books dynamically by title or author.
* **👥 User Management**: Manage library users and track active borrowing records.
* **🔄 Loan & Return System**: 
  * Simple book borrowing workflow.
  * Automatic return date calculation (default: 14-day duration).
  * Real-time loan status updates upon book returns.
* **🔍 Search & Filtering**: Dedicated search bar powered by explicit action triggers for clean user interaction.

---

## 🛠️ Tech Stack & Architecture

* **Language**: C# (.NET Framework)
* **GUI**: Windows Forms (WinForms)
* **IDE**: SharpDevelop / Visual Studio
* **Data Layer**: Centralized `DataContext` pattern using `System.Collections.Generic` (`List<T>`) and LINQ.
* **Assets**: Embedded local resource management for full portability across environments.
