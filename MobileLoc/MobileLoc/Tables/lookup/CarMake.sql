CREATE TABLE [lookup].[CarMake]
(
	CarMakeId		INT				NOT NULL	IDENTITY(1,1),
	CarMakeName		VARCHAR(1000)	NOT NULL,
	IsActive		BIT				NOT NULL	DEFAULT(1),

	CONSTRAINT PC_lookup_CarMake PRIMARY KEY CLUSTERED (CarMakeId asc)
		WITH (DATA_COMPRESSION = PAGE),

	CONSTRAINT UX_lookup_CarMake_CarMakeName unique nonclustered (CarMakeName)

);
GO
