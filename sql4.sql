UPDATE T_DOCTOR
SET FEES=CASE
WHEN Specialization='ENT' AND doctor_name LIKE'J' THEN 350
WHEN Specialization='DERMA' AND doctor_name LIKE'J' THEN 600
ELSE fees
END
WHERE specialization IN('ENT','DERMA',)