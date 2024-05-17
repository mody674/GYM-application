
CREATE TABLE machine(
    machineID INT PRIMARY KEY,
   machineeName VARCHAR(50),
  machineType VARCHAR(50),
  
);
SELECT  machineeName ,    machineType FROM machine
ORDER BY  machineType ASC;
