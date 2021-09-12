# HTTP-API
create and API that returns a payment list

OVERVIEW
- I created an API that returns an account balance and a list of payment of the user (date, amount, status) and sorted by the latest date. 

E.G. 
- account balance: 25000.00
- payment list:
--  date: 9/10/2021
--  amount: 2500.00
--  status: PENDING,,
--  date: 9/9/2021
--  amount: 3500.00
--  status: CLOSED
  
HOW TO RUN
- open project solution
- run program with Visual Studio
- You can call the API thru .../api/users/{number id}

EXAMPLE ID WITH DATA
- /api/values/1
- /api/values/2

FLOW
- call the API function
- get all the payments with the specific user id
- get the account balance of the user id
- put the data model into object
- return object to JSON format

ADDED FUNCTION
- returns all users with specific payment list when no ID is returned. .../api/users

DATA USED:
- Local DB
- Tables with Entity Framework core calling on API
- You can manipulate the data thru local db server in visual studio (insert tblUser first before inserting to tblPayment table)

TECHNOLOGIES USED:
- Visual Studio 2019
- SQL DB
- EF Core
- HTTP API
- Internet Browser

PATTERNS USED:
- MVC Pattern
