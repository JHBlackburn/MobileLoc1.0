CREATE TABLE inquiry.JobLocation
(
	JobLocationId							INT				NOT NULL IDENTITY(1,1),	
	CarKeyInquiryId							INT				NOT NULL,
	LocationDescription						VARCHAR(1000)	NOT NULL,
	AddressFull								VARCHAR(1000)	NOT NULL,
	Line1									VARCHAR(200)	NULL,
	Line2									VARCHAR(200)	NULL,
	City									VARCHAR(200)	NULL,
	StateCode								VARCHAR(2)		NULL,
	PostalCodeShort							VARCHAR(5)		NULL,
	PostalCodePlusFour						VARCHAR(4)		NULL,
	Notes									VARCHAR(1000)	NULL,
	InsertDT								DATETIME		NOT NULL	DEFAULT(GETDATE()),
	InsertBy								INT				NOT NULL	DEFAULT(0),
	UpdateDT								DATETIME		NOT NULL	DEFAULT(GETDATE()),
	UpdateBy								INT				NOT NULL	DEFAULT(0),
	ChangeVersion							ROWVERSION,

		CONSTRAINT PC_inquiry_JobLocation PRIMARY KEY CLUSTERED (JobLocationId asc)
			WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT FK_inquiry_JobLocation_inquiry_CarKeyInquiry_CarKeyInquiryId  FOREIGN KEY (CarKeyInquiryId ) REFERENCES inquiry.CarKeyInquiry (CarKeyInquiryId),
		CONSTRAINT FK_inquiry_JobLocation_people_SystemUser_InsertBy  FOREIGN KEY (InsertBy) REFERENCES people.SystemUser (SystemUserId),
		CONSTRAINT FK_inquiry_JobLocation_people_SystemUser_UpdateBy  FOREIGN KEY (UpdateBy) REFERENCES people.SystemUser (SystemUserId),
)
