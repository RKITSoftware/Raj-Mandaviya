#Explain

SELECT 
	* 
FROM 
	emp01;

SHOW INDEXES FROM emp01;

EXPLAIN FORMAT = JSON SELECT  # FORMAT = JSON CAN BE USED
	P01F02
FROM
	emp01 
WHERE 
	P01F02 = "raj";
    

    