-- Insert
INSERT INTO
	emp01(p01f02, p01f03, p01f04, p01f05, p01f06)
VALUES('raj','SDE', 22, 50000,'DEV TEAM');
 
INSERT INTO 
	emp01(p01f02, p01f03, p01f04, p01f05, p01f06) 
VALUES('Dev','SDE', 20, 50000, 'DEV TEAM'),
		('AUM','HR', 21, 60000, 'MGMT');
    
-- Select
SELECT 	
	* 
FROM
	emp01;
    
SELECT 
	p01f01, COALESCE(p01f04, 10) p01f04 #can be used in most dbs
FROM 
	emp01;
    
SELECT 
	p01f01, 
    IFNULL(p01f04, 0) p01f04 #db specific to mysql and sqlite
FROM 
	emp01;

-- SELECT WITH LIMIT
SELECT 
	p01f01,
    p01f02, 
    p01f03 -- id name role
FROM
	emp01
LIMIT 2 OFFSET 1;

SELECT 
	P01f01,
    P01F02, 
    P01F03 -- ID name role
FROM
	emp01
LIMIT 2, 1;
    
SELECT 
	p01f02, p01f03, p01f04
FROM
	emp01 
WHERE
	p01f04>20;

SELECT 
	p01f06, COUNT(p01f01) as employee_count 
FROM 
	emp01 
GROUP BY 
	p01f06;

# Having Clause    
SELECT 
	p01f06, COUNT(p01f01) as employee_count 
FROM 
	emp01 
GROUP BY 
	p01f06
HAVING
	COUNT(P01F01) = 1;

SELECT 
	AVG(P01F05)
FROM 
	EMP01
GROUP BY
	P01F06
HAVING 
	AVG(P01F05) > 50000;
    
-- UPDATE
UPDATE 
	emp01
SET 
	p01f05 = p01f05 * 1.1
WHERE 
	p01f06='MGMT'; 
    
UPDATE 
	emp01
SET
	p01f06 = 'MGMT'
WHERE 
	p01f06 = 'DEV TEAM';
    
-- Delete
DELETE FROM 
	emp01
WHERE 
	p01f04 < 21;
    
-- TO Delete all records (Truncate)
DELETE FROM 
	emp01;

	

    


    
