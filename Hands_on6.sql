create database Hands_on6;
use Hands_on6;

Create table Employee(
Empo char(6) not null,
Firstname varchar(12) not null,
Midinit char(1) not null,
Lastname varchar(15) not null,
Workdept char(3),
foreign key (Workdept) references department(Deptno),
Phoneno char(10), check(phoneno >=0000000000 AND Phoneno <= 9999999999),
Hiredate date,
Job char(9),
Edlevel smallint,
Sex char(1),
Salary decimal(9,2),
Bonus decimal(9,2),
Comm decimal(9,2)
);

create table Department(
Deptno CHAR(3) primary key,
Deptname varchar(36) not null,
Mgrno CHAR(6),
Admrdept char(3) not null,
Location char(16)
);

INSERT into Department Values(55,'D0','M6','11','LC5');


DELIMITER $$
create procedure 'AvailableDepartments'()
BEGIN
SELECT Deptname AS 'Name' FROM Departments;
END$$

DELIMITER ;

CALL AvailableDepartments();