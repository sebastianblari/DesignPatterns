# Adapter Pattern

## Intent
* Convert the interface of a class into another interface clients expect.
* Allow classes to work together that couldn't otherwise due to incompatible interfaces
* Future-proof client implementations by having them depend on Adapter interfaces, rather than concrete classes directly.

## Applicability:
* You want to use an existing class, but its interface does not match the required one.
* You want to create a reusable class that cooperates with unrelated or unforeseen classes (i.e. classes that won't necessarily share the same interface).
* You need to use several existing subclasses, but it's impractical to adapt their interface by subclassing everyone.

## How to get used:
* Client depends on the Adapter Interface, rather than a particular implementation.
* At least one concrete Adapter class is created to allow the client to work with a particular class that it requires.
* Future client needs for alternate implementations can be through the creation of additional concrete Adapter classes.
* Effective way to achieve Open/Closed Principle.

## Collaboration
* Clients call operations on an Adapter instance;
* Adapter instance calls Adaptee operations that carry out the request.
* Single Adapter interface may work with many Adaptees
  * One Adaptee and all of its subclasses.
  * Separate Adaptees via separate concrete Adapter implementations.
* Can be difficult to override Adaptee behavior:
  * Must subclass Adaptee and add overriden behavior.
  * Then, change concrete Adapter implementation to refer to Adaptee subclass.
