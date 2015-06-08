CREATE PROCEDURE PersistPeopleTest
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @Person Person;

	INSERT @Person (
		Id
		,FirstName
		)
	VALUES (
		NEWID()
		,'John'
		);

	EXEC PersistPeople @Person;
END;
