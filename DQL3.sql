CREATE DATABASE IPO;
USE IPO;

CREATE TABLE  Department(
	Dept_id INT(11) PRIMARY KEY,
	Dept_name VARCHAR(25)
);

CREATE TABLE  Staff(
	Staff_id int(11) PRIMARY KEY,
	Staff_name VARCHAR(25),
	Supervisor_id INT(11),
	Salary BIGINT(20),
	Join_date DATE,
	Dept_id INT(11),
	FOREIGN KEY (Dept_id) REFERENCES Department(Dept_id)
);
SELECT MIN(Avg_Salary)
FROM (SELECT Dept_id,AVG(Salary) AS 'Avg_Salary' 
		from Staff GROUP BY Dept_id) q1 
        WHERE Dept_id IS NOT NULL AND Dept_id != 10;

SELECT Staff_id,Staff_name,salary,dept_id
FROM STAFF
WHERE salary >  (SELECT MIN(Avg_Salary)
				FROM (SELECT Dept_id,AVG(Salary) AS 'Avg_Salary' 
					  from Staff GROUP BY Dept_id) q1 
				WHERE Dept_id IS NOT NULL AND Dept_id != 10) AND dept_id=10
ORDER BY Staff_id;