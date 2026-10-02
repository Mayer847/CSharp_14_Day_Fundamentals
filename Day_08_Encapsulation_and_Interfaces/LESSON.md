# Day 8: Encapsulation and Interfaces


## Core idea

Encapsulation means an object protects its own valid state. An interface is a promise: “anything implementing me provides these operations.” Code can depend on the promise rather than one implementation.

## Learn

- Use `private set` when outside code may read but should not freely mutate.
- Validate changes through methods.
- Interfaces help replace implementations and make testing easier.
- Do not create interfaces for every class. Create one where alternate behavior is useful.

## Challenge

Create `INotifier` with `Send(string message)`. Implement `ConsoleNotifier`. Make `ApplicationService` depend on `INotifier` and notify after an application is submitted.
