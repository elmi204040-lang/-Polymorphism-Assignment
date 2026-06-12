# EmployeeInterfaceApp

This C# console application demonstrates the use of:
- Interfaces (`IQuittable`)
- Class implementation of an interface (`Employee`)
- Polymorphism (interface reference pointing to a class object)

## How It Works
1. An interface `IQuittable` defines a method `Quit()`.
2. The `Employee` class implements this interface and defines what happens when `Quit()` is called.
3. In `Main()`, the `Employee` object is assigned to an `IQuittable` reference.
4. The `Quit()` method is called using polymorphism.

