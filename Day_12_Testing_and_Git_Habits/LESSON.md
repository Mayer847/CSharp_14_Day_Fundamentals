# Day 12: Testing and Git Habits


## Core idea

A test is executable evidence that behavior still works. Git is a time machine for intentional changes. Both reward small, clear units.

## Testing pattern

- Arrange: create inputs.
- Act: run behavior.
- Assert: compare actual and expected.

This day's starter uses a tiny self-contained test runner so no extra package is required. Later, use xUnit professionally.

## Good Git rhythm

```bash
git init
git add .
git commit -m "Add tithe calculation"
git switch -c feature/validation
git diff
git status
```

Commit one understandable change. A commit message should complete: “This commit will …”.

## Challenge

Implement `CalculateTithe` so all tests pass. Add tests for zero income and an invalid rate.
