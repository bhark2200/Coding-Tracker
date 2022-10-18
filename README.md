# Coding-Tracker
Console based CRUD application to track time spent coding using a start time and end time. Developed using C# and SQLite.
## Project Guidlines:
- Create a database and table in SQLite if one is not there.
- Be able to Insert, Delete, Update, and View hours logged.
- Can only interact with the database using raw SQL.
- Should handle all possible errors so the application never crashes.
- Use the ConsloeTableExt library.
- Create a configuration file that contains database path and connection strings.
- Required to have separte classes in different files.
- Create a "CodingSession" class in a seperate file containing: Id, StartTime, EndTime, Duration.

## Features
- Coded in c# with a SQLite database
  - Used Visual Studio.
  - Created a database using a configuration file for database path and connection strings.
  
 - Created a menu in order to use the CRUD operations.

![CodingTracker Menu](https://user-images.githubusercontent.com/17260312/196338485-c78d68e5-1f68-42b9-b55e-4c3733fd84ce.png)

- You are able to manually input a start time and end time, which will then calculate your duration of coding.

- Used ConsoleTableExt Library for a better formatted table view

![TableView](https://user-images.githubusercontent.com/17260312/196338838-92efad21-4ff3-4f24-9c3a-d9f9030a2d51.png)

## Challenges
- Using a configuration file for the first time was frusterating at first but reading and researching on the subject gained new insight on how it works.
- Understanding the Readme for ConsoleTableExt and figuring out how to use it was a great challenge.
- Creating different classes and simplifying my code down as much as I know how to, and not writing the same code more then once.

## Takeaways
- Always have a plan in place before you start coding.
- Just code small pieces at a time and test before moving on.(You can always add more later)
- If you get frusterated, take a break and maybe research more about the topic or ask questions.
- When you come back the answer will come eventually. 
- Sometimes it just takes time and patience but the work and wait is worth the outcome.
