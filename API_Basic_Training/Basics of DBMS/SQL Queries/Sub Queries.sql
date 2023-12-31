# Sub Queries

# FOR RETRIEVAL
SELECT 
	P01F02, 
    P01F05, 
    (SELECT AVG(P01F05) FROM emp01) AS AVG_SALARY
FROM 
	emp01;
    
#FOR COMPARING
SELECT 
	P01F02, 
    P01F05
FROM 
	emp01
WHERE 
	P01F05 > 
	(SELECT AVG(P01F05) FROM emp01);

# COMPARE USING IN
SELECT 
	P01F02, 
    P01F04
FROM
	emp01
WHERE 
	P01F01 IN 
    (SELECT P01F01 FROM emp01 WHERE P01F04 IS NOT NULL);