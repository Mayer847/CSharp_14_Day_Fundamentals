# Day 13: Database Design and Normalization


## Core idea

A database is not an Excel sheet with more power. It protects relationships and truth over time.

## Learn

- A table represents one kind of thing.
- A row represents one instance.
- A primary key identifies a row.
- A foreign key connects rows.
- A constraint prevents invalid data.
- Normalization reduces duplicated facts and update contradictions.

## Normalization in plain language

- **1NF:** one value per cell; no repeating groups.
- **2NF:** non-key facts depend on the whole key.
- **3NF:** non-key facts depend on the key, not on other non-key facts.

Bad design: store `CompanyName`, `CompanyWebsite`, and `CompanyCountry` inside every application row. If the website changes, many rows disagree.

Better design: `Companies` stores company facts once; `Applications` references `CompanyId`.

## Challenge

Explain why this design is bad, then normalize it:

`Applications(Id, CompanyName, CompanyWebsite, Role, Status, InterviewDate1, InterviewDate2)`

Create classes representing the normalized model. The solution demonstrates relationships, not a database framework.
