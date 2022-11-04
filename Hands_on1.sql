create database Hands_on1;
use Hands_0n1;


create table salesman
(
salesman_id numeric(5) primary key,
name varchar(30),
city varchar(15),
commission decimal(5,2)
);
create table orders
(
ord_no numeric(5) primary key,
purch_amt decimal(8,2),
ord_date date,
customer_id numeric(5),
salesman_id numeric(5)
);