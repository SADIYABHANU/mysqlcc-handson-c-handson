create database Hands_on5;
use Hands_on5;
DELIMITER //
CREATE procedure EMPLOYEESDEPT (IN DEPTNO CHAR(3))
BEGIN
SELECT LASTNAME AS 'NAMES' FROM EMPLOYEE WHERE WORKDEPT=DEPTNO;
END//