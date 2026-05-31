# C# Basics & Fundamentals

This repository tracks my hands-on learning journey through C# and the .NET ecosystem, focusing on building a solid foundational core for backend software development.

## 🚀 Covered in this Project

This initial module focuses on data variables, memory ranges, typing rules, and safe data manipulation:

* **00_Data Types & Type Inference (`var`):** Understanding fundamental primitives (`int`, `float`, `char`, `string`, `bool`) and using implicit typing securely.
* **01_Placeholders & Min/Max Limits:** Printing values dynamically using composite formatting strings (`{0} {1}`) and inspecting architectural limits of data types like `byte` and `float`.
* **02_Constants:** Declaring immutable data streams with the `const` modifier to prevent unintended runtime memory alterations.
* **03_Type Conversion (Implicit vs. Explicit):** Implementing safe, implicit casting (e.g., parsing a narrower `byte` directly into a wider `int`) and utilizing helper utilities like the `Convert` class for string-to-numeric casting.
* **04_Exception Handling (`try-catch`):** Implementing basic data resilience mechanisms by intercepting structural data casting overflows (such as trying to isolate an out-of-bounds string value into a limited `byte` variable) to protect the software thread from crashing.

---

## 🛠️ Tech Stack & Environment

* **Language:** C#
* **Runtime Platform:** .NET Core / .NET SDK (v8.0+)
* **Development Environment:** Visual Studio Code / Linux Command Line Interface
