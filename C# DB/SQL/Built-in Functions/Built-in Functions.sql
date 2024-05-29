USE SoftUni

--01. Find Names of All Employees by First Name
SELECT FirstName, LastName FROM Employees
WHERE FirstName LIKE 'Sa%'

--02. Find Names of All Employees by Last Name
SELECT FirstName, LastName FROM Employees
WHERE LastName LIKE '%ei%'

--03. Find First Names of All Employees
SELECT FirstName FROM Employees
WHERE DepartmentID IN (3,10) AND YEAR(HireDate) BETWEEN 1995 AND 2005

--04. Find All Employees Except Engineers
SELECT FirstName, LastName FROM Employees
WHERE JobTitle NOT LIKE '%engineer%'

--05. Find Towns with Name Length
SELECT Name FROM Towns
WHERE DATALENGTH(Name) IN (5,6)
ORDER BY Name

--06. Find Towns Starting With
SELECT TownID, Name FROM Towns
WHERE Name LIKE '[MKBE]%'
ORDER BY Name

--07. Find Towns Not Starting With
SELECT TownID, Name FROM Towns
WHERE Name LIKE '[^RBD]%'
ORDER BY Name

--08. Create View Employees Hired After 2000 Year
CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName,LastName FROM Employees
WHERE YEAR(HireDate)>2000

--09. Length of Last Name
SELECT FirstName, LastName FROM Employees
WHERE DATALENGTH(LastName)=5

--10. Rank Employees by Salary
--wtf
SELECT EmployeeID, FirstName, LastName, Salary,DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]  FROM Employees   
WHERE Salary BETWEEN 10000 AND 50000   
ORDER BY Salary DESC;

 --11. Find All Employees with Rank 2
 --man
 SELECT *
FROM (
       SELECT EmployeeID,
              FirstName,
              LastName,
              Salary,
              DENSE_RANK() over (partition by Salary ORDER BY EmployeeID) AS Rank
       FROM Employees
       WHERE Salary BETWEEN 10000 AND 50000) AS MyTable
WHERE Rank = 2
ORDER BY Salary DESC

--12. Countries Holding 'A' 3 or More Times
USE Geography

SELECT CountryName, IsoCode FROM Countries
WHERE UPPER(CountryName) LIKE '%A%A%A%'
ORDER BY IsoCode

--13. Mix of Peak and River Names
--dont understand the uslovie lol
SELECT 
	[PeakName], 
	[RiverName],
	LOWER(CONCAT(SUBSTRING(PeakName, 1, LEN([PeakName]) - 1), [RiverName])) AS [Mix]
FROM [Peaks], [Rivers]
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY [Mix]

--14. Games From 2011 and 2012 Year
USE Diablo

SELECT TOP 50 Name, FORMAT(Start, 'yyyy-MM-dd') AS Start FROM Games
WHERE YEAR(Start) IN (2011, 2012)
ORDER BY Start, Name

--15. User Email Providers
--LOL
SELECT 
	[Username], 
	SUBSTRING([Email], CHARINDEX('@', [Email]) + 1, LEN([Email]) - CHARINDEX('@', [Email])) AS [Email Provider]
FROM [Users]
ORDER BY [Email Provider], [Username]

--16. Get Users with IP Address Like Pattern
SELECT Username, IpAddress FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username

--17. Show All Games with Duration & Part of the Day
SELECT Name, 
	CASE 
WHEN DATEPART(HOUR, Start) BETWEEN 0 AND 11 THEN 'Morning'
WHEN DATEPART(HOUR, Start) BETWEEN 12 AND 17 THEN 'Afternoon'
ELSE 'Evening'
END AS [Part of the Day],
	CASE
WHEN Duration<=3 THEN 'Extra Short'
WHEN DURATION BETWEEN 4 AND 6 THEN 'Short'
WHEN Duration>6  THEN 'Long'
ELSE 'Extra Long'
END AS Duration
FROM Games
ORDER BY Name, Duration, [Part of the day]

--18. Orders Table
--shoutout to my homie hris fr. i dont even know where this table is
SELECT
	[ProductName],
	[OrderDate],
	DATEADD(DAY, 3, [OrderDate]) AS [Pay Due],
	DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due]
FROM [Orders]