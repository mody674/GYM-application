CREATE TABLE Trainers (
    TrainerID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    PhoneNumber VARCHAR(15),
    HireDate DATE
);
SELECT FirstName, PhoneNumber FROM Trainers
ORDER BY PhoneNumber DESC;

CREATE TABLE Claasees (
    ClassID INT PRIMARY KEY,
    ClassName VARCHAR(50),
    ScheduleDay VARCHAR(20),
    StartTime TIME,
    EndTime TIME,
    TrainerID INT,
    FOREIGN KEY (TrainerID) REFERENCES Trainers(TrainerID)
);
