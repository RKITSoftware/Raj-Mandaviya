-- GRANT

GRANT SELECT, INSERT ON basics_of_dbms.emp01 TO 'raj'@'localhost';

GRANT ALL PRIVILEGES ON basics_of_dbms.emp01 TO 'raj'@'localhost';

REVOKE INSERT ON basics_of_dbms.emp01 FROM 'raj'@'localhost';

REVOKE ALL PRIVILEGES ON basics_of_dbms.emp01 FROM 'raj'@'localhost';
