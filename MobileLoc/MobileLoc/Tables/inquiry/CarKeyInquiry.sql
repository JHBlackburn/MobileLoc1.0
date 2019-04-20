CREATE TABLE [Inquiry].[CarKeyInquiry]
(
	CarKeyInquiryId					INT				NOT NULL	IDENTITY(1,1),
	CarId							INT				NOT NULL,
	TotalPriceQuoted				MONEY			NULL,
	IsKey							BIT				NOT NULL	DEFAULT(0),
	IsRemote						BIT				NOT NULL	DEFAULT(0),
	IsIntegratedKeyRemote			BIT				NOT NULL	DEFAULT(0),
	IsMovedToScheduling				BIT				NOT NULL	DEFAULT(0),
	InsertDT						DATETIME		NOT NULL	DEFAULT(GETDATE()),
	InsertBy						INT				NOT NULL	DEFAULT(0),
	UpdateDT						DATETIME		NOT NULL	DEFAULT(GETDATE()),
	UpdateBy						INT				NOT NULL	DEFAULT(0),
	ChangeVersion					ROWVERSION,

		CONSTRAINT PC_inquiry_CarKeyInquiry PRIMARY KEY CLUSTERED (CarKeyInquiryId asc)
			WITH (DATA_COMPRESSION = PAGE),

		CONSTRAINT FK_inquiry_CarKeyInquiry_lookup_Care_CarId  FOREIGN KEY (CarId) REFERENCES lookup.CarMake (CarMakeId),
		CONSTRAINT FK_inquiry_CarKeyInquiry_people_SystemUser_InsertBy  FOREIGN KEY (InsertBy) REFERENCES people.SystemUser (SystemUserId),
		CONSTRAINT FK_inquiry_CarKeyInquiry_people_SystemUser_UpdateBy  FOREIGN KEY (UpdateBy) REFERENCES people.SystemUser (SystemUserId),
)
