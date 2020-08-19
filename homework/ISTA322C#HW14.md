### Arnold Burnley  
###  ISTA322C#HW14.md  
### August 17th, 2020

**Read chapter 14, pages 305 – 328 in the C# Step by Step book.**  
**Discussion Questions**  
**Answer the discussion questions in writing.**  
**1. What is the difference between a managed resource and an unmanaged resource?**  



Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control.  
Unmanaged resources are those that are not: File handles, pinned memory, COM objects, database connections etc.

**2. When is memory for an object (reference type) allocated? When is the memory deallocated?**  

Memory for an object is allocated when an instance of the objected instantiated. A *new* operation allocates  
a chunk of *raw* memory from the heap. Object destruction is a two-phase process:  

1. CLR performs tidying up
2. CLR must return the memory previously belonging to the object back to the heap.

**3. What is a destructor?**  

A special method that the CLR calls after the reference to an object has disappeared.  

**4. What is the difference in syntax between a constructor and a destructor?**  

A destructor uses a tilde **~**

**5. Give some examples of scarce resources. Why would you want to manage scarce resources?**  

Some examples of scarce resources are:  memory, database connections, and file handles that need to be released. You want to manage resources  
to optimize your application.

**6. What is exception-safe disposal?**  

A good example of exception-safe disposal is utilizing a finally block in code. The finally block can act as the destructor with a dispose method.

**7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.**  

It creates a block of code that is only accessible and in memory while the method is in use.   

**8. What ill effects could result from attempting to dispose of a resource more than once?**  




**9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question.**  

Threads have to interact with resources at any given time while an application is running and must have some way to keep them in a valid state so that the program can  
continue running until the desired run time.  


**10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?**  

Because it may create performance issues because the GC doesnt dispose in order. There may be exceptions if there are resources that need to be handled explicitly. 