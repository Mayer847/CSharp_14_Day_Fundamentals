# Day 3: Decisions and Validation


## Core idea

A condition is a yes/no question. Good validation rejects impossible data early, making the rest of the program simpler.

## Learn

- Comparison: `==`, `!=`, `>`, `<`, `>=`, `<=`.
- Logic: `&&` means both; `||` means either; `!` means not.
- Guard clause: detect a bad state, respond, and exit early.
- `switch` expresses one choice among known alternatives.

## Challenge

Build an application-priority classifier. Read match percentage and whether the role is remote. Output `High`, `Medium`, or `Skip` using these rules:

- High: match >= 80 and remote.
- Medium: match >= 65.
- Skip: otherwise.

Validate percentage between 0 and 100.
