CREATE TABLE [lookup].[CarModel]
(
	CarModelId		INT				NOT NULL	IDENTITY(1,1),
	CarModelName	VARCHAR(1000)	NOT NULL,
	CarMakeId		INT				NOT NULL,
	IsActive		BIT				NOT NULL	DEFAULT(1),

		CONSTRAINT PC_lookup_CarModel PRIMARY KEY CLUSTERED (CarModelId asc)
		WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT UX_lookup_CarModel_CarModelName UNIQUE NONCLUSTERED (CarModelName),

		CONSTRAINT FK_lookup_CarModel_lookup_CarMake_CarMakeId  FOREIGN KEY (CarMakeId) REFERENCES lookup.CarMake (CarMakeId),



);
GO
