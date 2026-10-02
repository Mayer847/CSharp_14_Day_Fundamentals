# C# Fundamentals in 14 Days

A focused path for learning **C# and backend thinking without drowning in theory**.

## How to use this course

Each day contains only three files:

- `LESSON.md`: the explanation and tasks
- `Starter.cs`: incomplete code or a clean starting point
- `Solution.cs`: one possible solution, not the only correct answer

## Daily rhythm: 60-90 minutes

1. Read the lesson once: 15-20 minutes.
2. Type the examples yourself: 15 minutes.
3. Attempt the challenge without looking at the solution: 25-40 minutes.
4. Compare, explain every difference aloud, then improve your code: 10-15 minutes.

## One rule

Do not copy a solution until you can state exactly what is blocking you. Struggling for 15 minutes is training. Struggling for two hours is inefficient.

## Setup

Install the current .NET SDK and VS Code with C# Dev Kit. Verify:

```powershell
dotnet --version
dotnet new console -n Playground
cd Playground
dotnet run
```

For each exercise, replace `Playground/Program.cs` with the day's `Starter.cs`. After attempting it, compare with `Solution.cs`.

## The mental model

A program is mostly:

1. **Data**: values representing reality.
2. **Decisions**: rules choosing what happens.
3. **Repetition**: processing many values.
4. **Organization**: methods, classes, and files.
5. **I/O**: receiving and returning information.

C# syntax is merely how those five ideas are expressed.

## Progress rule

Move forward when you can solve about 70-80% of the task and explain the solution. Perfection is not required.
