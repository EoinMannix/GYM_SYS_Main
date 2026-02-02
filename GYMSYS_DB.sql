--GYMSYS Database
DROP TABLE Bookings;
DROP TABLE Classes;
DROP TABLE Members;
DROP TABLE Instructors;
DROP TABLE ClassTypes;


-- Class Types Table

PROMPT CREATING Table ClassTypes
PROMPT

CREATE TABLE ClassTypes
(
    TypeCode CHAR(2),
    Meaning VARCHAR2(20),
    
    CONSTRAINT pk_ClassTypes PRIMARY KEY (TypeCode)
    
);


-- Members Table

PROMPT CREATING Table Members
PROMPT

CREATE TABLE Members
(
    MemberID NUMERIC(4),
    Forename VARCHAR2(20),
    Surename VARCHAR2(20),
    DOB DATE,
    Phone NUMERIC(10),
    Email VARCHAR2(40),
    Gender VARCHAR2(6),
    
    CONSTRAINT pk_Members PRIMARY KEY (MemberID)
);


-- Instructors Table



