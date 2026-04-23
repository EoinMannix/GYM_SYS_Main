--GYMSYS Database
DROP TABLE Bookings CASCADE CONSTRAINTS;
DROP TABLE Classes CASCADE CONSTRAINTS;
DROP TABLE Members CASCADE CONSTRAINTS;
DROP TABLE Instructors CASCADE CONSTRAINTS;
DROP TABLE ClassTypes CASCADE CONSTRAINTS;
DROP TABLE Rooms CASCADE CONSTRAINTS;


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
    Balance NUMERIC(8,2) DEFAULT 0,
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
    Workdays VARCHAR2(50),
    Status VARCHAR2(10) DEFAULT 'Active' NOT NULL,
    
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
    RoomID NUMERIC(2),
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

-- Rooms Tables

PROMPT CREATING Table Bookings
PROMPT

CREATE TABLE Rooms 
(
    RoomID NUMERIC(2),
    RoomName VARCHAR2(20),
    
    CONSTRAINT pk_Rooms PRIMARY KEY (RoomID)
    
);



-- Sample Class Types

INSERT INTO ClassTypes VALUES('HX','Hyrox');
INSERT INTO ClassTypes VALUES('YG','Yoga');
INSERT INTO ClassTypes VALUES('PL','Pilates');
INSERT INTO ClassTypes VALUES('SP','Spinning');


-- Sample data members

INSERT INTO Members VALUES(1001, 'Sean', 'O Brien', DATE '1995-04-12', '0712345678','sean.obrien@gmail.com','Male',50,'Active');
INSERT INTO Members VALUES(1002, 'Aoife', 'Murphy', DATE '1996-08-18', '0847652390','aoife.murphy@gmail.com','Female',50,'Active');
INSERT INTO Members VALUES(1003, 'Connor', 'Kelly', DATE '2002-05-02','0723748090','connor.kelly@gmail.com','Male',50,'Active');
INSERT INTO Members VALUES(1004, 'Niamh', 'Doyle', DATE '2000-04-18','0864567890','niamh.doyle@gmail.com','Female',50,'Active');
INSERT INTO Members VALUES(1005, 'Ciaran', 'Bryne', DATE '1996-09-12','0855678910','ciaran.bryne@gmail.com','Male',50,'Active');
INSERT INTO Members VALUES(1006, 'Saoirse', 'Ryan', DATE '2001-01-30','0876789012','saoirse.ryan@gmail.com','Female',50,'Active');
INSERT INTO Members VALUES(1007, 'Darragh', 'Walsh', DATE '2001-01-30','0837890123','darragh.walsh@gmail.com','Male',50,'Active');
INSERT INTO Members VALUES(1008, 'Orla', 'O Connor', DATE '1997-03-14','0868901234','orla.oconnor@gmail.com','Female',50,'Active');
INSERT INTO Members VALUES(1009, 'Padraig', 'fitzgerald', DATE '1989-12-08', '0859012345','padraig.fitzgerald@gmail.com','Male',50,'Active');
INSERT INTO Members VALUES(1010, 'Clodagh', 'Higgins', DATE '1995-10-19','0870123456','clodagh.higgins@gmail.com','Female',50,'Active');
INSERT INTO Members VALUES(1011, 'Ronan', 'Mccarthy', DATE '1991-05-27', '0831234567','ronan.mccarthy@gmail.com','Male',50,'Active');
INSERT INTO Members VALUES(1012, 'Eimer', 'Flanagan', DATE '1999-08-03', '0862345678','eimear.flanagan@gmail.com','Female',50,'Active');

-- Sample data Instructors

INSERT INTO Instructors VALUES(2001, 'Michael', 'Bryne', DATE '1985-06-15', '0891234567','michael.bryne@gmail.com','Male','Monday Tuesday', 'Active');
INSERT INTO Instructors VALUES(2002, 'Laura', 'Kavanagh', DATE '1990-02-21','0872345678','laura.kavanagh@gmail.com','Female','Wednesday Friday', 'Active');
INSERT INTO Instructors VALUES(2003, 'Patrick','O Neill', DATE '1982-11-05','0853456789','patrick.oneill@gmail.com','Male','Monday Thursday', 'Active');
INSERT INTO Instructors VALUES(2004, 'Emma','Fitzpatrick', DATE '1993-09-12','0864567890','emma.fitzpatrick@gmail.com','Female','Tuesday Saturday', 'Active');
INSERT INTO Instructors VALUES(2005, 'David','Moran', DATE '1988-03-27','0835678901','david.moran@gmail.com','Male','Monday Friday', 'Active');
INSERT INTO Instructors VALUES(2006, 'Nadine','Power', DATE '1991-01-08','084678901','nadine.power@gmail.com','Female','Wednesday Sunday', 'Active');
INSERT INTO Instructors VALUES(2007, 'Brian','Lynch', DATE '1980-01-08','0827890123','brian.lynch@gmail.com','Male','Thursday Saturday', 'Active');
INSERT INTO Instructors VALUES(2008, 'David','Cornally', DATE '2004-02-12','088901234','david.cornally@gmail.com','Male','Monday Tuesday', 'Active');
INSERT INTO Instructors VALUES(2009, 'Tom','Clancy',DATE '1986-12-14', '0819012345','tom.clancy@gmail.com','Male','Friday Sunday', 'Active');
INSERT INTO Instructors VALUES(2010, 'Aisling','Reilly',DATE '1992-10-03','0870123987','aisling.reilly@gmail.com','Female','Tuesday Thursday', 'Active');

-- Sample data Rooms

INSERT INTO Rooms VALUES (1, 'Yoga Studio');
INSERT INTO Rooms VALUES (2, 'Spin Studio');
INSERT INTO Rooms VALUES (3, 'Hyrox Floor');

-- Sample data Classes Dates (13-19 April 2026)

-- Monday
INSERT INTO Classes VALUES(3301,'Morning Yoga',2002,'YG',DATE '2026-04-13','09:00',15.00,1,'Active');

-- TUESDAY
INSERT INTO Classes VALUES(3302,'Spin Class',2004,'SP',DATE '2026-04-14','12:00',18.00,2,'Active');

-- WEDNESDAY
INSERT INTO Classes VALUES(3303,'Pilates Core',2004,'PL',DATE '2026-04-15','10:00',15.00,2,'Active');

-- THURSDAY
INSERT INTO Classes VALUES(3304,'Hyrox Intro',2001,'HX',DATE '2026-04-16','18:00',20.00,3,'Active');

-- FRIDAY
INSERT INTO Classes VALUES(3305,'Yoga Flow',2002,'YG',DATE '2026-04-17','11:00',15.00,1,'Active');

-- SATURDAY
INSERT INTO Classes VALUES(3306,'Spin Advanced',2004,'SP',DATE '2026-04-18','14:00',20.00,2,'Active');

-- SUNDAY
INSERT INTO Classes VALUES(3307,'Recovery Yoga',2002,'YG',DATE '2026-04-19','17:00',12.00,1,'Active');

-- Sample data Classes Dates (20-26 April 2026)

-- MONDAY
INSERT INTO Classes VALUES(3308,'Morning Yoga',2002,'YG',DATE '2026-04-20','09:00',15.00,1,'Active');

-- TUESDAY
INSERT INTO Classes VALUES(3310,'Spin Class',2004,'SP',DATE '2026-04-21','12:00',18.00,2,'Active');

-- WEDNESDAY
INSERT INTO Classes VALUES(3311,'Pilates',2004,'PL',DATE '2026-04-22','10:00',15.00,2,'Active');

-- THURSDAY
INSERT INTO Classes VALUES(3312,'Hyrox Training',2001,'HX',DATE '2026-04-23','18:00',22.00,3,'Active');

-- FRIDAY
INSERT INTO Classes VALUES(3313,'Yoga Flow',2002,'YG',DATE '2026-04-24','11:00',15.00,1,'Active');

-- SATURDAY
INSERT INTO Classes VALUES(3314,'Morning Pilates',2004,'PL',DATE '2026-04-25','09:00',15.00,2,'Active');

-- SUNDAY
INSERT INTO Classes VALUES(3315,'Stretch Yoga',2002,'YG',DATE '2026-04-26','17:00',12.00,1,'Active');


-- Sample data Booking Dates (13-19 April 2026)

-- I used the SYSYDATE function to get the current date/time to replicate when the booking was make
-- Link to referance material: https://docs.oracle.com/en/database/oracle/oracle-database/19/sqlrf/SYSDATE.html

-- MONDAY
INSERT INTO Bookings VALUES(5001,1001,3301,SYSDATE,'Booked');
INSERT INTO Bookings VALUES(5002,1002,3301,SYSDATE,'Booked');

-- TUESDAY
INSERT INTO Bookings VALUES(5003,1003,3302,SYSDATE,'Booked');

-- WEDNESDAY
INSERT INTO Bookings VALUES(5004,1004,3303,SYSDATE,'Booked');
INSERT INTO Bookings VALUES(5005,1005,3303,SYSDATE,'Booked');

-- THURSDAY
INSERT INTO Bookings VALUES(5006,1006,3304,SYSDATE,'Booked');

-- FRIDAY
INSERT INTO Bookings VALUES(5007,1007,3305,SYSDATE,'Booked');

-- SATURDAY
INSERT INTO Bookings VALUES(5008,1008,3306,SYSDATE,'Booked');

-- SUNDAY
INSERT INTO Bookings VALUES(5009,1009,3307,SYSDATE,'Booked');


-- Sample data Booking Dates (20-26 April 2026)

-- MONDAY
INSERT INTO Bookings VALUES(5010,1010,3308,SYSDATE,'Booked');
INSERT INTO Bookings VALUES(5011,1011,3308,SYSDATE,'Booked');

-- TUESDAY
INSERT INTO Bookings VALUES(5013,1001,3310,SYSDATE,'Booked');

-- WEDNESDAY
INSERT INTO Bookings VALUES(5014,1002,3311,SYSDATE,'Booked');

-- THURSDAY
INSERT INTO Bookings VALUES(5015,1003,3312,SYSDATE,'Booked');
INSERT INTO Bookings VALUES(5016,1004,3312,SYSDATE,'Booked');

-- FRIDAY
INSERT INTO Bookings VALUES(5017,1005,3313,SYSDATE,'Booked');

-- SATURDAY
INSERT INTO Bookings VALUES(5018,1006,3314,SYSDATE,'Booked');

-- SUNDAY
INSERT INTO Bookings VALUES(5019,1007,3315,SYSDATE,'Booked');


COMMIT; 
    



