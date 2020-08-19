### Arnold Burnley   
### ISTA322ASPChp3.md  
### August 19th, 2020  


**Read chapter 03, in the Pro ASP.NET Core 3 book.**  

**1. What is the most important part of an ASP.NET Core 3 application?**  

The data model is the most important part of an ASP.NET core 3 application.  

**2. What is the domain model?**  

The domain model is all of the C# objects and the methods that manipulate them.  

**3. Where are the model classes in an ASP.NET Core 3 application placed?**  

The model classes in an ASP.NET core 3 application are placed in a folder named *Models*.  

**4. How many action methods can a controller class define?**

A controller class can define as many methods as needed.  

**5. What is a tag helper?**   

A tag helper is an instruction for Razor that will be performed when the view is rendered. 

**6. What does the asp-action attribute do?**  

The asp-action attribute is an instruction to add an href attribute to the a element that contains a URL for an action method.

**7. What is the difference between HTTP GET and HTTP POST? This is an important question, and you should understand the difference.**  

THe difference between GET and POST is that GET is a request to get data from a specified source, while post is used to send data. 

**8. What is model binding?**  

*Model Binding* is the process of creating .NET objects using the values from the HTTP request to provide easy access to the data required  
by action methods and Razor Pages.

**9. Why should we validate user data? How do we validate user data?**  

Without validating user data a user could input nonsense data making an application useless.  We validate user data usig the ModelState.IsValid property.  

**10. What, specifically, is the ModelState.IsValid property?**  

The controller base class provides a property called ModelState that provides details of the outcome of the model binding process.

**11. What does the asp-validation-summary do?**  

It displays a list of validation errors when the view is rendered. The value for the asp-validation-summary attribute is a value from an enumeration called  
ValidationSummary, which specifies what types of validation errors the summary will contain.

**12. Static content consists of content such as images, script files, style files, etc. In an ASP.NET Core application, what is the name of the folder that cotains static content?**

The name of the folder that contains static content is wwwroot/js.

**13. What is Bootstrap? Who developed Bootstrap? Is Bootstrap a proprietary package? If not, what is it?**

Bootstrap is an open source CSS framework designed by Twitter. 