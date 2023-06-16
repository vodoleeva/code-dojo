# Factory programming pattern

Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

Source and read more - [here.](https://refactoring.guru/design-patterns/factory-method)

**Task:**

1. Look at `Creators/Abstract/AccessRole`. This is the _Abstract factory_ that generates a list of menu items accessible to user. The list is empty by default. Method `CreateMenuItems()` can be overriden by inheriting classes.
2. Now look at `Creators/Concrete/User`. It inherits from Abstract factory `AccessRole` and overrides method `CreateMenuItems` by adding more items to the list.
3. Start the app to see what is displayed in the console.
4. Let’s add more `AccessRoles`. Add Admin and Manager Roles to `Creators/Concrete` analog to `User`. They should have access to more menu items than the `User`.
5. Now add those Roles to Program.cs `Main()` function and start the app.
