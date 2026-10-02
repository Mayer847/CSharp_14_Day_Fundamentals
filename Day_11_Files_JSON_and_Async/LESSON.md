# Day 11: Files JSON and Async


## Core idea

Persistence lets data survive after the program closes. JSON is a text representation of objects. `async` allows a thread to do other work while waiting for I/O, such as files, networks, or databases.

## Learn

- `System.Text.Json` serializes objects to JSON.
- `await` pauses the method without blocking the underlying thread.
- Async methods normally return `Task` or `Task<T>`.
- I/O can fail: permissions, missing paths, locked files, malformed data.

## Challenge

Save a list of applications to `applications.json`, read it back asynchronously, deserialize it, and print the count.
