CREATE PROCEDURE Data
@empa varchar(50)
AS
SELECT FirstName, LastName from Yahooo where EmailAddress=@empa
RETURN 0