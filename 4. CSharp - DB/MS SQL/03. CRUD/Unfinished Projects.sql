 USE SoftUni
 GO

UPDATE Projects
   SET EndDate = GETDATE()
 WHERE EndDate IS NULL
