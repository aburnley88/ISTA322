#### Arnold Burnley  
#### ISTA322C#Chp15.md  
#### August 21st 2020  


**Answer the discussion questions in writing.**  
 
**1. What is the difference between a property and a field?**  

A property can contain two blocks of code, starting with the *get* and *set* keywords. The *get* keyword pertains to statements that execute when the property is  
read and the *set* is when the property is to be written. A field is a variable of any type in a class or struct.  


**2. What is the difference between a property and a method?**  

A property is a special type of method for encapsulation that allows data to be handled but remain "hidden". A method is a general tool for implementing logic.

**3. What is your understanding of encapsulation?**  

Encapsulation is a principle of software development that suggests that fields in a class should be private.

**4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter. C# is case sensitive. What implications does this have**  
**regarding the naming of variables, methods, and other identifiers? Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?**

On the one hand it creates room for more errors. However, when used as a tool it helps for code readability. A private field may begin with a capital letter.  
A parameter of the same name and type with a lowercase could represent that variable public.


**5. Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use s write-only property.**

Your frequent flyer account balance. 

**6. Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.**  

There are a variety of reasons why one might want to make getters and setters private. Private getters might be used for transaction dates and private setters for passwords.  


**7. What are restrictions on the use of properties?**

* You can assign value through a property of a structure or class only after the structure or class has been initialized.  
* You can't use a property as a *ref* or an *out* argument to a method.  
* A property can contain at most one *get* accessor and one *set* accessor.  
* The *get* and *set* accessors cannot take any parameters. 
* You can't declare properties by using const 

*