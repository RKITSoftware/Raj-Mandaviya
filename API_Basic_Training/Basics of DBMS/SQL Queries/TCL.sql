SET 
	autocommit = 0;
    
USE basics_of_dbms;

CREATE TABLE 
	extra_tb(
    id int
    );

INSERT INTO
	extra_tb(id)
VALUES(1),
(2),(3);

SELECT * FROM extra_tb;

COMMIT; -- Commit until insert

DELETE FROM extra_tb WHERE id = 1;

INSERT INTO
	extra_tb(id)
VALUES(4),(5);

SAVEPOINT MYSAVE;

ROLLBACK;

ROLLBACK TO MYSAVE;