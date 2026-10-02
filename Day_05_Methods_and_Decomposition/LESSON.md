# Day 5: Methods and Decomposition


## Core idea

A method gives a meaningful name to a small job. Good methods reduce mental load: you understand the name first and inspect details only when needed.

## Learn

- Parameters are inputs.
- A return value is output.
- `void` means no returned value.
- Prefer pure methods: same input, same output, no hidden change.
- Keep user input/output separate from business calculations.

## Challenge

Refactor the tithe calculator into `ReadNonNegativeDecimal`, `CalculateTithe`, and `PrintSummary` methods.

## Design test

If a calculation requires `Console.ReadLine`, it is harder to test. Pass values into calculations instead.
