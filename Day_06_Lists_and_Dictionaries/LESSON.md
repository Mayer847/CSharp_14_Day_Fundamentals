# Day 6: Lists and Dictionaries


## Core idea

A list stores an ordered group. A dictionary finds a value by a unique key. Choose by how information is accessed, not by habit.

## Learn

- `List<T>`: ordered, allows duplicates, accessed by position.
- `Dictionary<TKey,TValue>`: fast lookup by unique key.
- Generic type notation `<T>` means “this structure stores values of type T.”

## Challenge

Create a skill tracker. Add skill names and confidence from 1 to 5 to a dictionary. Print all skills and the weakest skill.

## Edge case

If a skill is entered twice, update it instead of crashing.
