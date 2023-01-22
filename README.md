# Design Patterns

In software engineering, a software design pattern is a general, reusable solution to a commonly occurring problem within a given context in software design. It is not a finished design that can be transformed directly into source or machine code. Rather, it is a description or template for how to solve a problem that can be used in many different situations. Design patterns are formalized best practices that the programmer can use to solve common problems when designing an application or system.

Object-oriented design patterns typically show relationships and interactions between classes or objects, without specifying the final application classes or objects that are involved. Patterns that imply mutable state may be unsuited for functional programming languages. Some patterns can be rendered unnecessary in languages that have built-in support for solving the problem they are trying to solve, and object-oriented patterns are not necessarily suitable for non-object-oriented languages.

Design patterns may be viewed as a structured approach to computer programming intermediate between the levels of a programming paradigm and a concrete algorithm.

** Creational design patterns
These design patterns are all about class instantiation. This pattern can be further divided into class-creation patterns and object-creational patterns. While class-creation patterns use inheritance effectively in the instantiation process, object-creation patterns use delegation effectively to get the job done.

* Abstract Factory
Creates an instance of several families of classes
* Builder
Separates object construction from its representation
* Factory Method
Creates an instance of several derived classes
* Object Pool
Avoid expensive acquisition and release of resources by recycling objects that are no longer in use
* Prototype
A fully initialized instance to be copied or cloned
* Singleton
A class of which only a single instance can exist

* Structural design patterns
These design patterns are all about Class and Object composition. Structural class-creation patterns use inheritance to compose interfaces. Structural object-patterns define ways to compose objects to obtain new functionality.

* Adapter
Match interfaces of different classes
* Bridge
Separates an object’s interface from its implementation
* Composite
A tree structure of simple and composite objects
* Decorator
Add responsibilities to objects dynamically
* Facade
A single class that represents an entire subsystem
* Flyweight
A fine-grained instance used for efficient sharing
* Private Class Data
Restricts accessor/mutator access
* Proxy
An object representing another object

** Behavioral design patterns
These design patterns are all about Class's objects communication. Behavioral patterns are those patterns that are most specifically concerned with communication between objects.

* Chain of responsibility
A way of passing a request between a chain of objects
* Command
Encapsulate a command request as an object
* Interpreter
A way to include language elements in a program
* Iterator
Sequentially access the elements of a collection
* Mediator
Defines simplified communication between classes
* Memento
Capture and restore an object's internal state
* Null Object
Designed to act as a default value of an object
* Observer
A way of notifying change to a number of classes
* State
Alter an object's behavior when its state changes
* Strategy
Encapsulates an algorithm inside a class
* Template method
Defer the exact steps of an algorithm to a subclass
* Visitor
Defines a new operation to a class without change



- https://sourcemaking.com/design_patterns
- https://en.wikipedia.org/wiki/Software_design_pattern
