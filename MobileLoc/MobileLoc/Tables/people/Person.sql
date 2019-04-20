CREATE TABLE people.Person
(
	PersonId						INT				NOT NULL	IDENTITY(1,1),	
	FirstName						VARCHAR(100)	NOT NULL,
	LastName						VARCHAR(100)	NOT NULL,
	Title							VARCHAR(10)		NOT NULL,
	FullName_FN_LN									AS CONCAT(FirstName, ' ', LastName),
	InsertDT						DATETIME		NOT NULL	DEFAULT(GETDATE()),
	InsertBy						INT				NOT NULL	DEFAULT(0),
	UpdateDT						DATETIME		NOT NULL	DEFAULT(GETDATE()),
	UpdateBy						INT				NOT NULL	DEFAULT(0),
	ChangeVersion					ROWVERSION,

		CONSTRAINT PC_people_Person PRIMARY KEY CLUSTERED (PersonId asc)
			WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT FK_people_Person_people_SystemUser_InsertBy  FOREIGN KEY (InsertBy) REFERENCES people.SystemUser (SystemUserId),
		CONSTRAINT FK_people_Person_people_SystemUser_UpdateBy  FOREIGN KEY (UpdateBy) REFERENCES people.SystemUser (SystemUserId),

)
