-- DDL
CREATE TABLE employee(
	employeeID int NOT NULL AUTO_INCREMENT,
    name varchar(30),
    role varchar(20),
    PRIMARY KEY(employeeID)
);

CREATE TABLE 
	extra_tb(
    id int
    );
    
CREATE DATABASE
	extra_db;

-- Alter table

ALTER TABLE 
	employee
ADD COLUMN 
	DEPARTMENT VARCHAR(50);
    
ALTER TABLE 
	employee
RENAME COLUMN 
	DEPARTMENT to dept;
    
ALTER TABLE
	employee
RENAME to
	emp_master;
    
-- DROP
DROP DATABASE
	extra_db;

DROP TABLE
	extra_tb;
    
-- truncate
INSERT INTO
	emp_master(
    name,
    role,
    dept
)VALUES(
	'raj',
    'SDE',
    'DEV'
);

TRUNCATE TABLE
	emp_master;
    
-- Single line Comment
/*
Hello 
this is multi line comment
*/
