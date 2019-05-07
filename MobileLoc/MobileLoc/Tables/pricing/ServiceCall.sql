CREATE TABLE [pricing].[ServiceCall]
(
	ServiceCallId					INT					NOT NULL	IDENTITY(1,1),
	ServiceCallZipCodeShort			INT					NOT NULL,
	ServiceCallPrice				DECIMAL(18,2)		NOT NULL,
	InsertDT						DATETIME			NOT NULL	DEFAULT(GETDATE()),
	InsertBy						INT					NOT NULL	DEFAULT(0),
	UpdateDT						DATETIME			NOT NULL	DEFAULT(GETDATE()),
	UpdateBy						INT					NOT NULL	DEFAULT(0),
	ChangeVersion					ROWVERSION,
	
		CONSTRAINT PC_pricing_ServiceCall PRIMARY KEY CLUSTERED (ServiceCallId asc)
		WITH (DATA_COMPRESSION = PAGE)
)
