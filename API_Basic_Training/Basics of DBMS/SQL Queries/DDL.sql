-- DDL
CREATE TABLE employee(
	p01f01 int NOT NULL AUTO_INCREMENT, -- id
    p01f02 varchar(30), -- name
    p01f03 varchar(20), -- role
    p01f04 int, -- age
    p01f05 int, -- salary
    PRIMARY KEY(p01f01)
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
RENAME to
	emp01;

ALTER TABLE 
	emp01
ADD COLUMN 
	dept VARCHAR(50) COMMENT "department"; -- department
    
ALTER TABLE 
	emp01
RENAME COLUMN 	
	dept to p01f06;

ALTER TABLE
	emp01
AUTO_INCREMENT = 1001;
    
-- DROP 
DROP DATABASE
	extra_db;

DROP TABLE
	extra_tb;
    
-- truncate
INSERT INTO
	emp01(p01f02, p01f03, p01f04, p01f05, p01f06)
    VALUES('raj', 'SDE', 20, 50000, 'DEV');

TRUNCATE TABLE
	emp01;
    
ALTER TABLE
		emp01
MODIFY COLUMN 
p01f05 INT COMMENT "salary";
    
-- Single line Comment
/*
Hello 
this is multi line comment
*/
