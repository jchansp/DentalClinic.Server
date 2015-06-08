CREATE PROCEDURE PersistDoctors @Doctor Doctor READONLY
AS
BEGIN
	SET NOCOUNT ON;

	BEGIN TRAN;

	BEGIN TRY
		DECLARE @Person Person;

		INSERT @Person
		SELECT *
		FROM @Doctor;

		EXEC PersistPeople @Person;

		MERGE Users AS Target
		USING @Doctor AS Source
			ON (Target.Id = Source.Id)
		WHEN NOT MATCHED
			THEN
				INSERT (Id)
				VALUES (Source.Id);

		--OUTPUT deleted.*
		--	,$ACTION
		--	,inserted.*
		--INTO #MyTempTable;
		MERGE Employees AS Target
		USING @Doctor AS Source
			ON (Target.Id = Source.Id)
		WHEN NOT MATCHED
			THEN
				INSERT (Id)
				VALUES (Source.Id);

		--OUTPUT deleted.*
		--	,$ACTION
		--	,inserted.*
		--INTO #MyTempTable;
		MERGE Doctors AS Target
		USING @Doctor AS Source
			ON (Target.Id = Source.Id)
		WHEN NOT MATCHED
			THEN
				INSERT (Id)
				VALUES (Source.Id);

		--OUTPUT deleted.*
		--	,$ACTION
		--	,inserted.*
		--INTO #MyTempTable;
		COMMIT TRAN;
	END TRY

	BEGIN CATCH
		ROLLBACK TRAN;

		THROW;
	END CATCH;
END;
