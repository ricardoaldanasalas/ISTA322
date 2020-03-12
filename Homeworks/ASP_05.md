# MVC Chapter 05
## Name: Ricardo Aldana Salas
## Date: March 10, 2020
---

##### 1.What is a view engine?
1. It is responsible for rendering the view into html form to the browser.
---
##### 2.What is Razor?
2. Is a markup syntax that lets you embed server-based code into web pages using C# and VB.Net. A server side markup language.
---
##### 3. What do views do?
3. 1 responsible for the UI. 2 Displays the data coming from the model.
---
##### 4.. How does Razor respond when it encounters statements that begin with the at character (@)? Be specific.
4. To open a code block, denote an inline expression, To render the value of variables.
---
##### 5.How does Razor respond when it encounters statements that begin with the at character followed by the colon (@:)?
5. It ignores the At character.
---
##### 6. Describe how you implement a standard formatting for all pages in an ASP.NET application.
6.
---
##### 7 What is the difference in using Razor to interpolate data values as stand-alone HTML elements and as attributes to HTML elements. What is the similarity?
7. HTML elements represetn some kind of structure or semantics and generally consosts of a start tag, content and an end tag. HTML attributes defines a property for an element, consists of an attribute/value pair and appears within the element's start tag.
---
##### 8. What is a view start file and where is it located?
8. Its a CSHTML file located in the root of the Views folder. It will then work its way up the folder hierarchy, executing the code in each_View Start.
---
##### 9. What is a Razor code block? What is the syntax of a Razor code block?
9. <text>. Is a tag that control whitespace when rendering content.
---
##### 10 Describe the different roles of action methods and views.
10. Action Methods are responsible to execute request and generate responses to it. View is reponsible for the UI.
---
##### 11. Describe the use of the @ using statement. Give an example of how you would use it.
11. Defines the model type and @model expression to access the model object.
---
