SELECT EMPLOYEE.FIRSTNAME, EMPLOYEE.LASTNAME, EMPLOYEE.SALARY FROM EMPLOYEE
JOIN DEPARTMENT WHERE EMPLOYEE.WORKDEPT=DEPARTMENT.DEPTNO AND DEPARTMENT.LOCATION='NEW YORK'
ORDER BY EMPLOYEE.FIRSTNAME ASC;