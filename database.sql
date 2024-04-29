IF OBJECT_ID('room', 'U') IS NOT NULL
    DROP TABLE room;
IF OBJECT_ID('customer', 'U') IS NOT NULL
    DROP TABLE customer;
IF OBJECT_ID('reservation', 'U') IS NOT NULL
    DROP TABLE reservation;
IF OBJECT_ID('employee', 'U') IS NOT NULL
    DROP TABLE employee;
IF OBJECT_ID('tasks', 'U') IS NOT NULL
    DROP TABLE tasks;

CREATE TABLE customer
(
    mobile      INTEGER PRIMARY KEY,
    fname       VARCHAR(255),
    lname       VARCHAR(255),
    pass        VARCHAR(255)
);

CREATE TABLE room
(
    roomNum     INTEGER PRIMARY KEY,
    roomStatus  VARCHAR(255) NOT NULL DEFAULT 'AVAILABLE',
    numBeds     INTEGER,
    roomSize    VARCHAR(255)
);

CREATE TABLE reservation
(
    id          INTEGER IDENTITY(1,1) PRIMARY KEY,
    customerID  INTEGER NOT NULL,
    roomNum     INTEGER NOT NULL,
    checkin     DATE NOT NULL,
    checkout    DATE NOT NULL,
    FOREIGN KEY (customerID) REFERENCES customer(mobile),
    FOREIGN KEY (roomNum) REFERENCES room(roomNum)
);

CREATE TABLE employee
(
    id          INTEGER IDENTITY(1,1) PRIMARY KEY,
    emptype     VARCHAR(255) NOT NULL
);

CREATE TABLE tasks
(
    id          INTEGER IDENTITY(1,1) PRIMARY KEY,
    tasktype     VARCHAR(255) NOT NULL,
    taskdescription VARCHAR(255),
    taskstatus    VARCHAR(255),
    roomNum        INTEGER,
    FOREIGN KEY (roomNum) REFERENCES room(roomNum)
);

-- Deleting all data from tables
DELETE FROM tasks;
DELETE FROM reservation;
DELETE FROM room;
DELETE FROM customer;
DELETE FROM employee;

-- Inserting mock data into customer table
INSERT INTO customer (mobile, fname, lname, pass)
VALUES (123, 'John', 'Doe', 'password1'),
       (234, 'Jane', 'Doe', 'password2'),
       (345, 'Bob', 'Smith', 'password3'),
       (456, 'Alice', 'Johnson', 'password4'),
       (567, 'Charlie', 'Brown', 'password5'),
       (678, 'Dave', 'Lee', 'password6'),
       (789, 'Eve', 'Kim', 'password7'),
       (890, 'Frank', 'Liu', 'password8'),
       (122, 'Grace', 'Zhang', 'password9'),
       (133, 'Hank', 'Chen', 'password10');

-- Inserting mock data into room table
INSERT INTO room (roomNum, roomStatus, numBeds, roomSize)
VALUES (101, DEFAULT, 2, 'SMALL'),
       (102, DEFAULT, 2, 'SMALL'),
       (103, DEFAULT, 1, 'SMALL'),
       (104, DEFAULT, 1, 'SMALL'),
       (105, DEFAULT, 3, 'LARGE'),
       (106, DEFAULT, 3, 'LARGE'),
       (107, DEFAULT, 4,'LARGE'),
       (108,'OCCUPIED' ,4,'LARGE'),
       (109,'OCCUPIED' ,2,'MEDIUM'),
       (110,'OCCUPIED' ,2,'MEDIUM');

-- Inserting mock data into reservation table
INSERT INTO reservation (customerID , roomNum , checkin , checkout )
VALUES(123 ,101 ,'2023-01-01','2023-01-05' ),
      (234 ,102 ,'2023-01-02','2023-01-06' ),
      (345 ,103 ,'2023-01-03','2023-01-07' ),
      (456 ,104 ,'2023-01-04','2023-01-08' ),
      (567 ,105 ,'2023-01-05','2023-01-09' ),
      (678 ,106 ,'2023-01-06','2023-01-10' ),
      (789 ,107 ,'2023-01-07','2023-01-11' ),
      (890 ,108 ,'2023-01-08','2023-01-12' ),
      (122 ,109 ,'2023-01-09','2023-01-13' ),
      (133 ,110 ,'2023-01-10','2023-01-14' );

-- Inserting mock data into employee table
INSERT INTO employee(emptype)
VALUES('MANAGER'),('RECEPTIONIST'),('HOUSEKEEPING'),('HOUSEKEEPING'),('HOUSEKEEPING'),('HOUSEKEEPING'),('HOUSEKEEPING'),('HOUSEKEEPING'),('HOUSEKEEPING'),('HOUSEKEEPING');

-- Inserting mock data into tasks table
INSERT INTO tasks(tasktype , taskdescription , taskstatus , roomNum )
VALUES('CLEANING','Clean the room','PENDING',101),
      ('CLEANING','Clean the room','PENDING',102),
      ('CLEANING','Clean the room','PENDING',103),
      ('CLEANING','Clean the room','PENDING',104),
      ('CLEANING','Clean the room','PENDING',105),
      ('CLEANING','Clean the room','PENDING',106),
      ('CLEANING','Clean the room','PENDING',107),
      ('CLEANING','Clean the room','PENDING',108),
      ('CLEANING','Clean the room','PENDING',109),
      ('CLEANING','Clean the room','PENDING',110);