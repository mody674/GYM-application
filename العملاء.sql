CREATE TABLE Members (
    MemberID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Gender VARCHAR(10),
    PhoneNumber VARCHAR(15),
    JoinDate DATE
);
SELECT * FROM Members
ORDER BY LastName ASC, FirstName ASC; -- ASC Ì⁄‰Ì  — Ì»  ’«⁄œÌ („‰ «·√ﬁœ„ ≈·Ï «·√ÕœÀ)

CREATE TABLE MemberClasses (
    MemberID INT,
    ClassID INT,
    PRIMARY KEY (MemberID, ClassID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);


