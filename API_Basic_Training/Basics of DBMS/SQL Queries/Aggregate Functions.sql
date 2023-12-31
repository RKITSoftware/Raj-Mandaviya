-- MIN MAX

-- Max Salary from everyone
SELECT 
	p01f02,MAX(p01f05) 
FROM
	emp01;

-- Max Salary in each depts
SELECT 
	p01f06, MAX(p01f05) 
FROM 
	emp01 
GROUP BY
	p01f06;
    
# COUNT 
SELECT 
	COUNT(P01F01) as total_emps
FROM 
	emp01;
    
SELECT 
	P01F06, COUNT(P01F01) as total_emps
FROM 
	emp01 
GROUP BY
	P01F06;
    
# AVG 

SELECT 
	AVG(P01F05)
FROM 
	emp01;
    
SELECT 
	P01F06, AVG(P01F05) AS AVG_SALARY
FROM 
	emp01
GROUP BY 
	P01F06;
    
# SUM
SELECT 
	SUM(P01F05)
FROM 
	emp01;
    
SELECT 
	P01F06 AS DEPT, 
    SUM(P01F05) AS TOTAL_SALARY_PAID
FROM 
	emp01
GROUP BY 
	P01F06;
 

