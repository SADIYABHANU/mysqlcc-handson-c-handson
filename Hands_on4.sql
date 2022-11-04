create database Hands_on3;
USE Hands_on4;
delimiter go 


SELECT CONCAT(Employee.Lastname, ' works for ' ,Department.Mgrno) AS 'Hierarchy' FROM Employee 
JOIN Department ON Employee.Workdept=Department.Deptno ORDER BY Employee.Lastname ASC go