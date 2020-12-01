--
-- Adds a character to the system.
--
-- PARAMS:
--    name - The name of the character. Must be unique and cannot be empty.
--    rating - The rating of the character. Cannot be empty.
--    releaseYear - The release year. If specified must be >= 0.
--    runLength - The run length. If specified must be >= 0.
--    description - Specifies the description of the character.
--
-- RETURNS: The ID of the item.
--
CREATE PROCEDURE [dbo].[Addcharacter]
	@name NVARCHAR(255),
    @rating NVARCHAR(20),    
    @description NVARCHAR(MAX) = NULL,
    @releaseYear INT = NULL,
    @runLength INT = NULL,
    @isClassic BIT = NULL
AS BEGIN
    SET NOCOUNT ON;

    SET @name = LTRIM(RTRIM(ISNULL(@name, '')))
    SET @rating = LTRIM(RTRIM(ISNULL(@rating, '')))

    -- Validate
	IF LEN(@name) = 0
        THROW 51000, 'Name cannot be empty.', 1
    IF LEN(@rating) = 0
        THROW 51000, 'Rating cannot be empty.', 1
    
    IF ISNULL(@releaseYear, 0) < 0
        THROW 51001, 'ReleaseYear must be >= 0.', 1
    IF ISNULL(@runLength, 0) < 0
        THROW 51002, 'RunLength must be >= 0.', 1
    
    IF EXISTS (SELECT * FROM characters WHERE Name = @name)
        THROW 51003, 'character already exists.', 1

    -- Add
    SET @description = LTRIM(RTRIM(ISNULL(@description, '')))
    IF LEN(@description) = 0 
        SET @description = NULL

    INSERT INTO characters (Name, Description, Rating, ReleaseYear, RunLength, IsClassic) 
        VALUES (@name, @description, @rating, @releaseYear, @runLength, @isClassic)

    SELECT SCOPE_IDENTITY()
END