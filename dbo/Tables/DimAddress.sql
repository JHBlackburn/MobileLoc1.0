CREATE TABLE DimAddress
( AddressID int not null
, AddressFull varchar(1000) not null
, County varchar(50) not null
, City varchar(50)  not null
, State varchar(2) not null
, PostalCodeShort varchar(10)  not null
, PostalCodeSuffix varchar(4) not null
)