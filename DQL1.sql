CREATE DATABASE ZEE;
USE ZEE;

CREATE TABLE ZeeRentals(
	Rental_id VARCHAR(10) PRIMARY KEY,
    Cust_id VARCHAR(10),
    Laptop_id VARCHAR(10),
    Pick_date DATE,
    Return_date DATE,
    Amount BIGINT(20)
);



SELECT Rental_id, Cust_id, Laptop_id, Amount, RPAD(Amount,10,"*") AS Modified_Amount 
FROM ZeeRentals
WHERE Amount > 7000 AND YEAR(Pick_Date) = 2020 AND MONTH(Pick_Date) = 05
ORDER BY Rental_id;