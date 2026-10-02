# Day 9: Exceptions and Debugging


## Core idea

Validation handles expected bad input. Exceptions represent a failure that interrupts normal execution. Catch an exception only when you can recover, add useful context, or show an appropriate boundary-level message.

## Learn

- Throw specific exceptions.
- Do not use `catch (Exception) { }`; it hides failures.
- Preserve stack details by using `throw;`, not `throw ex;`.
- Debug by reducing the problem and inspecting values.

## Challenge

Implement `Withdraw`. Reject non-positive amounts and insufficient balance with different exception types. Handle them at the UI boundary.
