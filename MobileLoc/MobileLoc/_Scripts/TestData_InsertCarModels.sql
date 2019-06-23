
	DECLARE @hondaMakeId int = (select CarMakeId from lookup.CarMake cm where cm.CarMakeName = 'Honda');
	DECLARE @fordMakeId int = (select CarMakeId from lookup.CarMake cm where cm.CarMakeName = 'Ford');
	DECLARE @chevyMakeId int = (select CarMakeId from lookup.CarMake cm where cm.CarMakeName = 'Chevrolet');
	DECLARE @toyotaMakeId int = (select CarMakeId from lookup.CarMake cm where cm.CarMakeName = 'Toyota');

	INSERT INTO MobileLoc.lookup.CarModel (
		CarModelName,
		CarMakeId)

		VALUES 
			(
			'Civic',
			@hondaMakeId
			),			
			(
			'Accord',
			@hondaMakeId
			),
			(
			'F-150',
			@fordMakeId
			),
			(
			'F-250',
			@fordMakeId
			),
			(
			'F-350',
			@fordMakeId
			),
			(
			'Mustang',
			@fordMakeId
			),
			(
			'Caprice',
			@chevyMakeId
			),
			(
			'Corvette',
			@chevyMakeId
			),
			(
			'Camaro',
			@chevyMakeId
			),
			(
			'Rav4',
			@toyotaMakeId
			),
			(
			'4Runner',
			@toyotaMakeId
			),
			(
			'Tundra',
			@toyotaMakeId
			)

