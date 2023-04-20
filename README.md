# Mod 1 Week 5 Assessment

## Questions (10 Points Possible)
1. What would happen if you try to use a variable that is not in scope?
When attempting to reference a variable that is not in scope you will get an error stating that the given variable does not exist in the given context and cannot be used.
2. Describe the three As of a test:  
A -   Arrange - Setup the object nessesary to run the test on
A -   Act     - run the method you want to test
A -   Assert  - use Assert method to test the outcome of the Act for the given test

3. What is the difference between `public` and `private` access modifiers?
the public access modifier allow for the variable to be accessable from anywhere in the project. The private access modifier only allows for the variable to be accessed from within the class that it resides in, limmiting its scope to inturnal methods and considerations.
4. A method should:  (**Select all that apply**) <br/>
(A) Make changes to an object  <--
(B) Return some information about an object  <-- 
(C) Make changes to an object and return information about the object.  
(D) None of the Above.  


5. How did you determine what to answer for the question above?
You need both command methods that change the object and query methods that return some information. Because of the importance of a method only having a single responsibility, a method that does both should not exist and instead be two seperate methods each doing one thing.
## Exercise (10 Points Possible)

Clone your forked copy of this repository into Visual Studio.  

In this solution, there is a User project with a single User class.  The class works, but it needs some additional effort to be great! One thing that is missing is tests; your job is to write the tests that will confirm the functionality of the class. Write one test for the constructor, and at least one test for each of the other 4 methods. As you write the tests, you might find some refactoring opportunities; update the user class with any refactors you deem necessary and add a comment describing why you made that refactor.  The only rule is that all the existing methods must still exist when you are finished!


## Submission

When finished:
* Commit your changes in Visual Studio
* Push up to GitHub
* DM a link to your forked repository to your instructors
