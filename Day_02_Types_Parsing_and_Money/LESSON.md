# Day 2: Types Parsing and Money


## Core idea

A type tells C# what a value means and which operations are safe. `"12"` is text; `12` is an integer. Money should normally use `decimal`, not `double`, because decimal arithmetic is designed for base-10 financial values.

## Learn

- `int`: whole numbers.
- `decimal`: money and precise decimal quantities. Append `m` to literals.
- `bool`: true or false.
- `TryParse`: handles invalid user input without crashing.
- `var`: lets the compiler infer the type; it does not make C# dynamically typed.

## Challenge

Read monthly income and calculate 10% tithe, remaining income, and yearly tithe. Reject invalid or negative input.

## Common trap

Do not use `Convert.ToDecimal` on untrusted input unless you intentionally want an exception.
