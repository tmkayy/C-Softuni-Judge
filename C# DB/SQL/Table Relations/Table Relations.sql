CREATE DATABASE TableRelations

USE TableRelations

--01. One-To-One Relationship
CREATE TABLE Passports
(
PassportID INT PRIMARY KEY IDENTITY(101,1),
PassportNumber NVARCHAR(255)
)

CREATE TABLE Persons
(
	PersonID INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(255),
	Salary DECIMAL(10,2),
	PassportID INT FOREIGN KEY REFERENCES Passports(PassportID)
)

INSERT INTO Passports
VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2')

INSERT INTO Persons
VALUES
('Roberto', 43300.00, 102),
('Tom',	56100.00, 103),
('Yana', 60200.00, 101)

--02. One-To-Many Relationship

CREATE TABLE Manufacturers
(
ManufacturerID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) NOT NULL,
EstablishedOn DATE NOT NULL
)

INSERT INTO Manufacturers
VALUES
('BMW',		'07-03-1916'),
('Tesla',	'01-01-2003'),
('Lada',	'01-05-1966')

CREATE TABLE Models
(
ModelID INT IDENTITY(101, 1),
Name NVARCHAR(50) NOT NULL,
ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Models
VALUES
('X1',	1),
('i6',	1),
('Model S',	2),
('Model X',	2),
('Model 3',	2),
('Nova', 3)

--03. Many-To-Many Relationship

CREATE TABLE Students
(
StudentID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255)
)

CREATE TABLE Exams
(
ExamID INT PRIMARY KEY IDENTITY(101, 1),
Name NVARCHAR(255)
)

CREATE TABLE StudentsExams
(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
PRIMARY KEY(StudentID, ExamID)
)

INSERT INTO Students
VALUES
('Mila'),
('Toni'),
('Ron')

INSERT INTO Exams
VALUES
('SpringMVC'),
('Neo4j'),
('Oracle 11g')

INSERT INTO StudentsExams
VALUES
(1,	101),
(1,	102),
(2,	101)

--04. Self-Referencing
CREATE TABLE Teachers
(
TeacherID INT PRIMARY KEY IDENTITY(101, 1),
Name NVARCHAR(255),
ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers
VALUES
('John',	NULL),
('Maya',	106),
('Silvia',	106),
('Ted'	,105),
('Mark'	,101),
('Greta',	101)

--05. Online Store Database
CREATE TABLE ItemTypes
(
ItemTypeID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255)
)

CREATE TABLE Items
(
ItemID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255),
ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
CityID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255)
)

CREATE TABLE Customers
(
CustomerID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255),
Birthday DATE,
CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
OrderID INT PRIMARY KEY IDENTITY,
CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
ItemID INT FOREIGN KEY REFERENCES Items(ItemID),
PRIMARY KEY(OrderID, ItemID)
)

--06. University Database
CREATE TABLE Majors
(
MajorID INT PRIMARY KEY IDENTITY,
Name NVARCHAR(255)
)

CREATE TABLE Students
(
StudentID INT PRIMARY KEY IDENTITY,
StudentNumber NVARCHAR(255),
StudentName NVARCHAR(255),
MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
PaymentID INT PRIMARY KEY IDENTITY,
PaymentDate DATE,
PaymentAmount DECIMAL(10, 2),
StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)

CREATE TABLE Subjects
(
SubjectID INT PRIMARY KEY IDENTITY,
SubjectName NVARCHAR(255)
)

CREATE TABLE Agenda
(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
PRIMARY KEY (StudentID, SubjectID)
)

--09. *Peaks in Rila
USE Geography

SELECT m.MountainRange, p.PeakName, p.Elevation FROM Peaks AS p
JOIN Mountains AS m ON m.Id = p.MountainId
WHERE m.MountainRange = 'Rila'
ORDER BY p.Elevation DESC