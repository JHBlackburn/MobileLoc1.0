CREATE TABLE [people].[PersonContact]
(
	PersonContactId			INT				NOT NULL IDENTITY(1,1),	
	PersonId				INT				NOT NULL,
	PersonEmail				VARCHAR(200)	NOT NULL,
	PersonPhone				VARCHAR(20)	NOT NULL,
	IsActive				BIT				NOT NULL	DEFAULT(1),
	IsPrimary				BIT				NOT NULL	DEFAULT(1),

		CONSTRAINT PC_people_PersonContact PRIMARY KEY CLUSTERED (PersonContactId asc)
			WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT FK_people_PersonContact_people_Person_PersonId  FOREIGN KEY (PersonId) REFERENCES people.Person (PersonId),
)