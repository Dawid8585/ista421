### -- Dawid Perkowski

### --File: .NET #7

1. There are many kinds of tests, including Unit Tests. What is a unit test, and what does it enable you to do?
   - Unit testing is a form of testing in which individual components are isolated from the rest of the application so their behavior can be thoroughly validated.
2. What is the primary benefit of using unit tests?
   - One of the main benefits of unit testing is that it makes the coding process more Agile
3. What is the purpose of using method GetHashCode() when using Assert.Equal()?s
   - Static equals overloads are used for comparing instances of two types for reference equality. This method should not be used for comparison of two instances for equality.
4. The book states: “[T]he chain of dependencies can make it difficult to understand what causes a test to fail.” Why is this statement true?
   - Its true because it states in a real application there are many pieces to a chain and its near impossible to trace it all.
5. How do unit tests isolate small parts of an application?
   - They target an individual method or class. 
6.  According to the book, what is the key to isolating components?
   - The key to isolating components is to use C# interfaces.
7.  Briefly discuss the nature and purpose of a fake implementation of a class. What does a fake implementation do that a real implementation cannot do?
   - Real implementation cannot fail your unit test because you know what you are implementing and why you are implementing it. But fake implementation is just an object that mimics the real object. 
8. What is test driven development? What is the development cycle for test driven development? This is not in the book.
   - Test Driven Development is when test cases are created before code is written, it;s purpose is to make the code clearer, simple and bug-free. The development cycle is 1. Add tests 2. See test fails 3. Write code 4. Run test 5. Refactor 6. Repeat.
9. What are parameterized tests and why would we want to use them?
   - Parameterized tests are tests that run and get rid of duplicate code.
10. What is a mocking framework? What is the difference between a fake object and a mock object?
   - There is a technical difference between fake and mock objects, but modern test tools blur them together for ease of use. Mocking framework is the same as Fakes framework.
11. (Optional) Can you think of one very important drawback to writing unit tests?
    - The code can get very long and complicated making it hard to maintain.