USE Gringotts

--01. Records’ Count
SELECT COUNT(*) FROM WizzardDeposits

--02. Longest Magic Wand
SELECT MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits

--03. Longest Magic Wand per Deposit Groups
SELECT DepositGroup, MAX(MagicWandSize) AS LongestMagicWand FROM WizzardDeposits
GROUP BY DepositGroup

--11. Average Interest
SELECT DepositGroup,IsDepositExpired,
AVG(DepositInterest) AS AverageInterest FROM WizzardDeposits
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC	,IsDepositExpired

--12. *Rich Wizard, Poor Wizard
SELECT SUM(wd1.DepositAmount - wd2.DepositAmount) FROM WizzardDeposits AS wd1
LEFT JOIN WizzardDeposits AS wd2 ON wd1.Id + 1 = wd2.Id

--13. Departments Total Salaries
USE SoftUni

SELECT DepartmentID ,SUM(Salary) FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID

--14. Employees Minimum Salaries
SELECT DepartmentID ,MIN(Salary) FROM Employees
WHERE HireDate > '1/1/2000' AND DepartmentID IN (2,5,7)
GROUP BY DepartmentID

--15. Employees Average Salaries
SELECT * INTO EMP2 FROM Employees
WHERE Salary>30000

DELETE FROM EMP2
WHERE ManagerID = 42

UPDATE EMP2
SET Salary+=5000
WHERE DepartmentID = 1

SELECT DepartmentID, AVG(Salary) FROM EMP2
GROUP BY DepartmentID

--16. Employees Maximum Salaries
SELECT DepartmentID, MAX(Salary) FROM Employees
GROUP BY DepartmentID
HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000

--17. Employees Count Salaries
SELECT COUNT(*) FROM Employees
WHERE ManagerID IS NULL