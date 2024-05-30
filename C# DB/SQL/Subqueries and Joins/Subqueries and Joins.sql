USE SoftUni

--01. Employee Address
SELECT TOP 5 e.EmployeeID, e.JobTitle, e.AddressID, a.AddressText FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
ORDER BY e.AddressID

--02. Addresses with Towns
SELECT TOP 50 e.FirstName, e.LastName, t.Name, a.AddressText FROM Employees AS e
JOIN Addresses AS a ON a.AddressID = e.AddressID
JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY e.FirstName, e.LastName

--03. Sales Employees
SELECT e.EmployeeID, e.FirstName, e.LastName, d.Name FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID

--04. Employee Departments
SELECT TOP 5 e.EmployeeID, e.FirstName, e.Salary, d.Name FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE e.Salary > 15000
ORDER BY d.DepartmentID

--05. Employees Without Projects
SELECT TOP 3 e.EmployeeID, e.FirstName FROM Employees AS e
LEFT JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
WHERE ep.EmployeeID IS NULL
ORDER BY e.EmployeeID

--06. Employees Hired After
SELECT e.FirstName, e.LastName, e.HireDate, d.Name FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance') AND e.HireDate>'1/1/1999'
ORDER BY e.HireDate

--07. Employees With Project
SELECT TOP 5 e.EmployeeID, e.FirstName, p.Name FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.EndDate IS NULL AND p.StartDate > '8/13/2002'
ORDER BY e.EmployeeID

--08. Employee 24
SELECT e.EmployeeID, e.FirstName, CASE
WHEN YEAR(p.StartDate) >= 2005 THEN NULL
ELSE p.Name
END AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE ep.EmployeeID = 24

--09. Employee Manager
SELECT e1.EmployeeID, e1.FirstName, e1.ManagerID, e2.FirstName FROM Employees AS e1
JOIN Employees AS e2 ON e1.ManagerID = e2.EmployeeID
WHERE e2.EmployeeID IN (3,7)
ORDER BY e1.EmployeeID

--10. Employees Summary
SELECT TOP 50 e1.EmployeeID, CONCAT(e1.FirstName, ' ', e1.LastName) AS EmployeeName, CONCAT(e2.FirstName, ' ', e2.LastName) AS ManagerName, d.Name FROM Employees AS e1
JOIN Employees AS e2 ON e1.ManagerID = e2.EmployeeID
JOIN Departments AS d ON e1.DepartmentID = d.DepartmentID
ORDER BY e1.EmployeeID

--11. Min Average Salary
SELECT MIN(a.minavg) FROM (SELECT AVG(Salary) AS minavg FROM Employees
GROUP BY DepartmentID) AS a

--12. Highest Peaks in Bulgaria
USE Geography

SELECT mc.CountryCode,m.MountainRange,p.PeakName, p.Elevation FROM MountainsCountries AS mc
JOIN Mountains AS m ON m.Id = mc.MountainId
JOIN Peaks AS p ON P.MountainId = mc.MountainId
WHERE mc.CountryCode = 'BG' AND p.Elevation>2835
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges
SELECT mc.CountryCode, COUNT(*) FROM MountainsCountries AS mc
JOIN Mountains AS m ON m.Id = mc.MountainId
GROUP BY mc.CountryCode
HAVING mc.CountryCode IN ('BG', 'RU', 'US')

--14. Countries With or Without Rivers
SELECT TOP 5 c.CountryName, r.RiverName FROM Countries AS c
LEFT JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
LEFT JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentCode = 'AF'
ORDER BY c.CountryName

--15. Continents and Currencies
--lol
SELECT 
	[r].ContinentCode, 
	[r].CurrencyCode, 
	[r].CurrencyUsage
FROM 
(
	SELECT 
      c.[ContinentCode],
	  c.[CurrencyCode],
	  COUNT(c.[CurrencyCode]) AS [CurrencyUsage],
	  DENSE_RANK() OVER
	  (
		PARTITION BY c.[ContinentCode] 
		ORDER BY COUNT(c.[CurrencyCode]) DESC
	  ) AS [CurrencyRank]
	  FROM [Countries] AS [c]
	  GROUP BY c.[ContinentCode],c.[CurrencyCode]
	  HAVING COUNT(c.[CurrencyCode]) > 1
) AS [r]
WHERE [r].CurrencyRank = 1
ORDER BY [r].ContinentCode

--16. Countries Without any Mountains
SELECT COUNT(*) FROM Countries AS c
LEFT JOIN MountainsCountries AS cM ON cm.CountryCode = c.CountryCode
WHERE cm.CountryCode IS NULL

--17. Highest Peak and Longest River by Country
SELECT TOP 5 c.CountryName, MAX(p.Elevation) AS HighestPeakElevation, MAX(r.Length) AS LongestRiverLength
FROM Countries AS c
 JOIN MountainsCountries AS mc ON mc.CountryCode = c.CountryCode
 JOIN Peaks AS p ON p.MountainId = mc.MountainId
 JOIN CountriesRivers AS cr ON cr.CountryCode = c.CountryCode
 JOIN Rivers AS r ON r.Id = cr.RiverId
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, LongestRiverLength DESC, c.CountryName

--18. Highest Peak Name and Elevation by Country
--lol2
--wtf bruh
SELECT TOP(5)
	[Country],
	CASE
		WHEN [PeakName] IS NULL THEN '(no highest peak)'
		ELSE [PeakName]
	END AS [Highest Peak Name],
	CASE
		WHEN [Elevation] IS NULL THEN 0
		ELSE [Elevation]
	END AS [Highest Peak Elevation],
	CASE
		WHEN [MountainRange] IS NULL THEN '(no mountain)'
		ELSE [MountainRange]
	END AS [Mountain]

FROM
(
	SELECT 
		c.[CountryName] AS [Country],
		m.[MountainRange],
		p.[PeakName],
		p.[Elevation],
		DENSE_RANK() OVER
		(
			PARTITION BY c.[CountryName] 
			ORDER BY p.[Elevation] DESC
		) AS [PeakRank]
	FROM [Countries] AS [c]
	LEFT JOIN [MountainsCountries] AS [mc]
		ON mc.[CountryCode] = c.[CountryCode]
	LEFT JOIN [Mountains] AS [m]
		ON mc.[MountainId] = m.[Id]
	LEFT JOIN [Peaks] AS [p]
		ON p.[MountainId] = m.[Id]
) AS [PeakRankingTable]
WHERE [PeakRank] = 1
ORDER BY [Country], [Highest Peak Name] 