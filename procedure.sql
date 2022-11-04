USE codechallengeDB;
create procedure'usp_PetProcedureDetails'(in procedureType CHAR (50))
BEGIN 
SELECT ProcedureHistory.petid,pet.Name AS'pet name',petowner.name AS'OWNER Name',ProcedureHistory.Description
FROM ProcedureHistory
JOIN pet
JOIN petowner
WHERE ProcedureHistory.Petid=pet.petid AND pet.ownerid=petowner.ownerid AND ProcedureHistory.ProcedureType=procedureType);
END
call usp_PetProcedureDetails('surgery');