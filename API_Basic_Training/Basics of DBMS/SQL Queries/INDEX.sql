# INDEX
SHOW INDEXES 
FROM emp01;

#Create INDEX
CREATE INDEX
	idx_P01F02
ON 
	emp01(P01f02);

# Create MULTI-INDEX
CREATE INDEX
	idx_P01_F02_F05
ON
	emp01(P01F02,P01F04);

# DROP INDEX
ALTER TABLE
	emp01
DROP INDEX
	name_age_idx;