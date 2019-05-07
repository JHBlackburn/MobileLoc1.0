CREATE TABLE inquiry.JobLocation
(
	JobLocationId							INT				NOT NULL IDENTITY(1,1),	
	CarKeyInquiryId							INT				NOT NULL,
	LocationDescription						VARCHAR(1000)	NULL,
	PostalCodeShort							VARCHAR(5)		NOT NULL,
	Notes									VARCHAR(1000)	NULL,
	InsertDT								DATETIME		NOT NULL	DEFAULT(GETDATE()),
	InsertBy								INT				NOT NULL	DEFAULT(0),
	UpdateDT								DATETIME		NOT NULL	DEFAULT(GETDATE()),
	UpdateBy								INT				NOT NULL	DEFAULT(0),
	ChangeVersion							ROWVERSION,

		CONSTRAINT PC_inquiry_JobLocation PRIMARY KEY CLUSTERED (JobLocationId asc)
			WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT FK_inquiry_JobLocation_inquiry_CarKeyInquiry_CarKeyInquiryId  FOREIGN KEY (CarKeyInquiryId) REFERENCES inquiry.CarKeyInquiry (CarKeyInquiryId),
		CONSTRAINT FK_inquiry_JobLocation_people_SystemUser_InsertBy  FOREIGN KEY (InsertBy) REFERENCES people.SystemUser (SystemUserId),
		CONSTRAINT FK_inquiry_JobLocation_people_SystemUser_UpdateBy  FOREIGN KEY (UpdateBy) REFERENCES people.SystemUser (SystemUserId),
)
