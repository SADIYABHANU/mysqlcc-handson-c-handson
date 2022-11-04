CREATE DATABASE QQQ;
USE QQQ;

CREATE TABLE Pizza(
	Pizza_id VARCHAR(10) PRIMARY KEY,
    Cust_id VARCHAR(10),
    Partner_id VARCHAR(10),
    Pizza_name VARCHAR(50),
    Pizza_type VARCHAR(50),
    Order_Date DATE,
    Amount BIGINT(20)
);

SELECT Pizza_name,COUNT(Pizza_name) AS 'No.Sold' 
FROM Pizza 
WHERE pizza_id=pizza_id
GROUP BY Pizza_name;
order by count(amount)desc limit 1;

