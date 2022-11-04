create database Hands_on2;
use Hands_on2;


CREATE TABLE Supplier
(
supplier_id NUMERIC(5),
supplier_name VARCHAR(150),
address VARCHAR(150),
city VARCHAR(50),
state VARCHAR(15),
country VARCHAR(15),
contact VARCHAR(10),
CHECK (LENGTH(CONTACT)=10)
);

INSERT INTO SUPPLIER VALUES (05,'Ammu','Toopran','Medak','Telangana','India','9876543210');
SELECT * FROM SUPPLIER