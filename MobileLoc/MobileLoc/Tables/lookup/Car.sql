CREATE TABLE lookup.Car
(
	CarId						INT				NOT NULL	IDENTITY(1,1),
	CarMakeId					INT				NOT NULL,
	CarModelId					INT				NOT NULL,
	CarYearId					INT				NOT NULL,
	IsActive					BIT				NOT NULL	DEFAULT(1),
	InsertDT					DATETIME		NOT NULL	DEFAULT(GETDATE()),
	InsertBy					INT				NOT NULL	DEFAULT(0),
	UpdateDT					DATETIME		NOT NULL	DEFAULT(GETDATE()),
	UpdateBy					INT				NOT NULL	DEFAULT(0)

		CONSTRAINT PC_lookup_Car PRIMARY KEY CLUSTERED (CarId asc)
		WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT UX_lookup_Car_CarModelId_CarYearId UNIQUE NONCLUSTERED (CarModelId, CarYearId),

		CONSTRAINT FK_lookup_Car_lookup_CarMake_CarMakeId  FOREIGN KEY (CarMakeId) REFERENCES lookup.CarMake (CarMakeId),
		CONSTRAINT FK_lookup_Car_lookup_CarModel_CarModelId  FOREIGN KEY (CarModelId) REFERENCES lookup.CarModel (CarModelId),
		CONSTRAINT FK_lookup_Car_lookup_CarYear_CarYearId  FOREIGN KEY (CarYearId) REFERENCES lookup.CarYear (CarYearId),
		CONSTRAINT FK_lookup_Car_people_SystemUser_InsertBy  FOREIGN KEY (InsertBy) REFERENCES people.SystemUser (SystemUserId),
		CONSTRAINT FK_lookup_Car_people_SystemUser_UpdateBy  FOREIGN KEY (UpdateBy) REFERENCES people.SystemUser (SystemUserId),
)
