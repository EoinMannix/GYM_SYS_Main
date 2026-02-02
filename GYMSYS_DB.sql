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

PROMPT CREATING Table Instructors
PROMPT

CREATE TABLE Instructors
(
    InstructorID NUMERIC(4),
    Forename VARCHAR(20),
    Surename VARCHAR2(20),
    DOB DATE,
    Phone NUMERIC(10),
    Email VARCHAR2(40),
    Gender VARCHAR2(6),
    
    CONSTRAINT pk_Instructors PRIMARY KEY (InstructorID)
);


-- Classes Table

PROMPT CREATING Table Classes
PROMPT

CREATE TABLE Classes
(
    ClassID NUMERIC(4),
    ClassName VARCHAR2(20),
    InstructorID NUMERIC(4),
    TypeCode CHAR(2),
    ClassDate DATE,
    ClassTime VARCHAR2(5), -- I put varchar as there is then room for a semi colon eg 10:00
    Price NUMERIC(6,2),
    Room VARCHAR2(10),
    Status VARCHAR(10),
    
    CONSTRAINT pk_Classes PRIMARY KEY (ClassID),
    
    CONSTRAINT fk_Classes_Instructors
        FOREIGN KEY (InstructorID) REFERENCES Instructors,
        
    CONSTRAINT fk_Classes_Types
        FOREIGN KEY (TypeCode)  REFERENCES ClassTypes
);

-- Booking table 

PROMPT CREATING Table Bookings
PROMPT

CREATE TABLE Bookings 
(
    BookingID NUMERIC(4),
    MemberID NUMERIC(4),
    ClassID CHAR(4),
    BookingDate DATE,
    Status VARCHAR2(10),
    
    CONSTRAINT pk_Bookings PRIMARY KEY (BookingID),
    
    CONSTRAINT fk_Bookings_Members
        FOREIGN KEY (MemberID) REFERENCES Members,
        
    CONSTRAINT fk_Bookings_Classes
        FOREIGN KEY (ClassID) REFERENCES Classes
);

-- Sample Class Types

INSERT INTO ClassTypes VALUES('HX','Hyrox');
INSERT INTO ClassTypes VALUES('YG','Yoga');
INSERT INTO ClassTypes VALUES('PL','Pilates');
INSERT INTO ClassTypes VALUES('SP','Spinning');


-- Sample data members

INSERT INTO Members 
    




    
    
    
    



