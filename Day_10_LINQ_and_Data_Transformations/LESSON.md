# Day 10: LINQ and Data Transformations


## Core idea

LINQ describes what result you want from a sequence. Think of a pipeline: filter, transform, sort, then materialize.

## Learn

- `Where`: keep matching items.
- `Select`: transform items.
- `OrderBy`: sort.
- `Any`, `All`, `Count`, `Sum`, `Average`: answer questions.
- `ToList`: execute and store the current result.

## Challenge

From a list of applications, return unapplied roles scoring at least 75, ordered by score descending, formatted as display strings.

## Warning

A clever one-line query is worse than readable code. Give intermediate ideas names when the pipeline becomes difficult to explain.
