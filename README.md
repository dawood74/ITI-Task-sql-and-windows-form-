# 📚 Windows Forms Course Management System

A simple C# Windows Forms application for managing courses and client profiles using a SQL Server database. This desktop app provides basic CRUD operations for course records and allows users to log in, view, and update their personal details, including uploading a profile image.

---

## 📌 Features

- 🔐 **User Authentication**
- 📋 **Course Management (Add, Update, Delete, View)**
- 👤 **User Profile Management**
- 🖼️ **Image Upload & Display**

---

## 🛠️ Tech Stack

- **C# (.NET Framework)**
- **Windows Forms**
- **SQL Server (LocalDB / SQL Express)**

---

## 🗂️ Project Structure

WindowsFormsApp1/
│
├── DAL.cs // Data Access Layer
├── APP.cs // Application Logic
├── LoginDL.cs // Login Data Layer
├── Form1.cs // Login Form
├── course.cs // Course Management Form
└── taskcourse (Database)

markdown
Copy
Edit

---

## 📦 Database Tables

**clinet**
- `username`
- `userpass`
- `track`
- `phone`
- `address`
- `image` (varbinary)

**course**
- `id`
- `name`

---
