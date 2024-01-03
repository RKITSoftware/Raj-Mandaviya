-- Sorting ASC using p01f04
SELECT 
	p01f01, p01f02, p01f03, p01f04 
FROM
	emp01
ORDER BY
	p01f04;
    
-- Sorting DESC
SELECT 
	p01f01, p01f02, p01f03 , p01f04
from 
	emp01
ORDER BY
	p01f04 DESC;
    
-- Sorting using multiple columns
SELECT 
	p01f01, p01f02, p01f03, p01f04
FROM 
	emp01
ORDER BY 
	p01f04 ,
    p01f01 DESC;