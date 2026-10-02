# Day 14: Capstone Job Application Tracker


## Goal

Combine the fundamentals into a small, finished program. Finished beats ambitious.

## Required behavior

1. Add an application: company, role, match score.
2. List applications ordered by score.
3. Mark an application as applied.
4. Show statistics: total, applied count, average score.
5. Save and load JSON asynchronously.
6. Reject invalid scores and missing company/role.

## Architecture

- `JobApplication`: data and valid state changes.
- `ApplicationTracker`: operations on the collection.
- `Program`: console interaction only.

The starter contains the model and menu shell. Complete one feature at a time. The solution is intentionally compact; a production system would use separate files, dependency injection, logging, tests, and a database.

## Graduation challenges

- Add deletion with confirmation.
- Add status history instead of one status string.
- Write unit tests for score validation and marking applied.
- Replace JSON with SQLite.
- Build an ASP.NET Core Web API exposing the same operations.
