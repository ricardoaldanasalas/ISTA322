# ASP.NET Homework 08
## Name: Ricardo Aldana Salas
## Date: April 06, 2020
---

##### 1.What is the purpose of the Startup class in an MVC application?
1.  Is a reusable component that provides app functionality. It includes a configure method to create the app's request processing pipelin.
---
##### 2. What is the purpose of the ConfigureServices() method?
2. The dependency injection pattern is used heavely in asp.net core architecture. It includes built-in loC container to provide dependent object using constructors.
--
##### 3. What is the purpose of hte AddMvc() method?
3. Is the way your applciation says that you want to MVC services available tot he system to work correctly.
---
##### 4. What does the book describe as “the heart of an MVC application?”
4. The controllers in ASP.
---
##### 5. What is the purpose of the Queryable<T> interface? What does it allow you to do?
5. is intended for implementation by query providers. This interface inherits the IEnumerable<T> intreface so that if it represents a query, the result of that quey can be enumarated it.
---
##### 6. How does the book describe loosely coupled components? Why is this an important principle of software design?
6. is one in which each of its components has, or makes us of, litte or no knowledge of the definition of other separate componets.
---
##### 7. What, specifically, does the AddTransient() method do?
7. It creates a transient servcie. which in term creates a scoped servcie.
---
##### 8. Describe dependency injection? What is the dependency? What does it mean to say that it is injected?
8. is a pattern to allow your application to inject object on the fly to classes that need them, without forcing those classes to be responsible for those objects.
---
##### 9 What is the purpose of a shared ayout?
9. Is the same as the master page of the ASP>NET websorm application. Layout views are shared with multiple views so it must be stored inthe shared folder.
---
##### 10. What is a database context class? What purpose does it serve?
10. Is used to query or sa ve data to the database. is use to configure domain classes,database related mappings, etc.
---
##### 11. . What function does the EnsurePopulated() method perform?
11. A delegate tha tpoints to a method that accepts one or more argumetns.
---
##### 12. What is a ViewModel?
12. Is a component of the Model/View/ViewModel()MVVM) programming architectuaral pattern. Viewmodel creates hooks for these word processors to link the UI with your programming. 
