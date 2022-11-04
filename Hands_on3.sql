create database Hands_on3;
use Hands_on3;


CREATE TABLE employee(
empno char(6) not null,
first_name varchar(12) not null,
midinit char(1) not null,
last_name varchar(15) not null,
workdept char(3),
phone_no char(50),
hiredate date,
job char(9) not null,
edlevel smallint,
sex char(1),
birthdate date,
sal decimal(9,2),
bonus decimal(9,2),
comm decimal(9,2) );
/*FOREIGN KEY (WORKDEPT) REFERENCES DEPARTMENT(DEPTNO)*/
/*DROP TABLE employee;*/
insert into employee(empno, first_name, midinit, last_name, workdept, phone_no ,hiredate,
job, edlevel ,sex, date_of_birth, sal,bonus,comm ) values 
(5,'saddu','a','bhanu',5,'8888888888','03-09-13','PRESIDENT',1,'F','12-09-2000','50000','5000','10.5'),
(20,'ABD','b','jjj',4,'1232456545','08-08-15','ANALYST',2,'F','25-03-1998','45000','4000','10.5'),
(25,'HHHH','c','kkk',4,'9856985698','06-03-26','ANALYST',3,'M','01-03-1989','45000','4000','10.5'),
(30,'IKJL','d','lll',3,'9854126325','25-10-31','MANAGER',4,'F','01-03-1987','40000','3000','7.5'),
(35,'OPQ','e','ssk',3,'8845213654','02-06-11','PRESIDENT',5,'M','02-07-1990','40000','3000','7.5'),

ALTER TABLE employee ADD CHECK (phone_no<='999999999');
SELECT * FROM EMPLOYEE;
CREATE TABLE DEPARTMENT
      (DEPTNO    CHAR(3) NOT NULL,
       DEPTNAME  VARCHAR(36) NOT NULL,
       MGRNO     CHAR(6),
       ADMRDEPT  CHAR(3) NOT NULL, 
       LOCATION  CHAR(16),
       PRIMARY KEY (DEPTNO));
/*foreign key(ADMRDEPT) references employee(workdept),*/
DROP TABLE DEPARTMENT;
INSERT INTO DEPARTMENT2 VALUES (1, 'SOFTWARE',45,'TECH','EDINBURGH');
SELECT * FROM DEPARTMENT2;
INSERT INTO DEPARTMENT2 VALUES(2,'TECH',55,'TECH','CO'),
                              (3, 'BUSINESS ADMIN',66,'NON TECH','LA'),
                              (4,'SALES',77,'NON TECH','KY'),
                              (5,'ADMIN',88,'TECH','NY');
 select d.deptname as Worker_Department, d.location, d.admrdept as Manager_Department 
 from department d inner join employee e on (e.workdept) != (d.ADMRDEPT) order by e.workdept;                     
