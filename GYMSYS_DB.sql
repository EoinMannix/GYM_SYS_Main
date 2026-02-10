--GYMSYS Database
DROP TABLE Bookings CASCADE CONSTRAINTS;
DROP TABLE Classes CASCADE CONSTRAINTS;
DROP TABLE Members CASCADE CONSTRAINTS;
DROP TABLE Instructors CASCADE CONSTRAINTS;
DROP TABLE ClassTypes CASCADE CONSTRAINTS;


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
    Phone VARCHAR2(15),
    Email VARCHAR2(40),
    Gender VARCHAR2(6),
    Status VARCHAR2(10) DEFAULT 'Active' NOT NULL,
    
    CONSTRAINT pk_Members PRIMARY KEY (MemberID)
);


-- Instructors Table

PROMPT CREATING Table Instructors
PROMPT

CREATE TABLE Instructors
(
    InstructorID NUMERIC(4),
    Forename VARCHAR2(20),
    Surename VARCHAR2(20),
    DOB DATE,
    Phone VARCHAR2(15),
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
    Status VARCHAR2(10),
    
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
    ClassID NUMERIC(4),
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

INSERT INTO Members VALUES(1001, 'Sean', 'O Brien', DATE '1995-04-12', '0712345678','sean.obrien@gmail.com','Male','Active');
INSERT INTO Members VALUES(1002, 'Aoife', 'Murphy', DATE '1996-08-18', '0847652390','aoife.murphy@gmail.com','Female','Active');
INSERT INTO Members VALUES(1003, 'Connor', 'Kelly', DATE '2002-05-02','0723748090','connor.kelly@gmail.com','Male','Active');
INSERT INTO Members VALUES(1004, 'Niamh', 'Doyle', DATE '2000-04-18','0864567890','niamh.doyle@gmail.com','Female','Active');
INSERT INTO Members VALUES(1005, 'Ciaran', 'Bryne', DATE '1996-09-12','0855678910','ciaran.bryne@gmail.com','Male','Active');
INSERT INTO Members VALUES(1006, 'Saoirse', 'Ryan', DATE '2001-01-30','0876789012','saoirse.ryan@gmail.com','Female','Active');
INSERT INTO Members VALUES(1007, 'Darragh', 'Walsh', DATE '2001-01-30','0837890123','darragh.walsh@gmail.com','Male','Active');
INSERT INTO Members VALUES(1008, 'Orla', 'O Connor', DATE '1997-03-14','0868901234','orla.oconnor@gmail.com','Female','Active');
INSERT INTO Members VALUES(1009, 'Padraig', 'fitzgerald', DATE '1989-12-08', '0859012345','padraig.fitzgerald@gmail.com','Male','Active');
INSERT INTO Members VALUES(1010, 'Clodagh', 'Higgins', DATE '1995-10-19','0870123456','clodagh.higgins@gmail.com','Female','Active');
INSERT INTO Members VALUES(1011, 'Ronan', 'Mccarthy', DATE '1991-05-27', '0831234567','ronan.mccarthy@gmail.com','Male','Active');
INSERT INTO Members VALUES(1012, 'Eimer', 'Flanagan', DATE '1999-08-03', '0862345678','eimear.flanagan@gmail.com','Female','Active');

-- Sample data Instructors

INSERT INTO Instructors VALUES(2001, 'Michael', 'Bryne', DATE '1985-06-15', '0891234567','michael.bryne@gmail.com','Male');
INSERT INTO Instructors VALUES(2002, 'Laura', 'Kavanagh', DATE '1990-02-21','0872345678','laura.kavanagh@gmail.com','Female');
INSERT INTO Instructors VALUES(2003, 'Patrick','O Neill', DATE '1982-11-05','0853456789','patrick.oneill@gmail.com','Male');
INSERT INTO Instructors VALUES(2004, 'Emma','Fitzpatrick', DATE '1993-09-12','0864567890','emma.fitzpatrick@gmail.com','Female');
INSERT INTO Instructors VALUES(2005, 'David','Moran', DATE '1988-03-27','0835678901','david.moran@gmail.com','Male');
INSERT INTO Instructors VALUES(2006, 'Nadine','Power', DATE '1991-01-08','084678901','nadine.power@gmail.com','Female');
INSERT INTO Instructors VALUES(2007, 'Brian','Lynch', DATE '1980-01-08','0827890123','brian.lynch@gmail.com','Male');
INSERT INTO Instructors VALUES(2008, 'David','Cornally', DATE '2004-02-12','088901234','david.cornally@gmail.com','Male');
INSERT INTO Instructors VALUES(2009, 'Tom','Clancy',DATE '1986-12-14', '0819012345','tom.clancy@gmail.com','Male');
INSERT INTO Instructors VALUES(2010, 'Aisling','Reilly',DATE '1992-10-03','0870123987','aisling.reilly@gmail.com','Female');

    
-- 
    



