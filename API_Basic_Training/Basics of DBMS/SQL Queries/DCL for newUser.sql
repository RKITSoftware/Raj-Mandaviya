-- DCL
SELECT
	* 
FROM
    emp_master;

INSERT INTO
	emp_master(name)
VALUES('yash');

UPDATE 
	emp_master 
SET 
	name = 'jar' 
WHERE 
	employeeID = 1;