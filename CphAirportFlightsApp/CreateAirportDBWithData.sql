--CREATE DATABASE CphAirportDB;

--CREATE TABLE Countries (
--	Id int NOT NULL IDENTITY PRIMARY KEY,
--	[Name] varchar (255),
--	ISO2 varchar (8)
--);

--CREATE TABLE Cities (
--	ID int NOT NULL IDENTITY PRIMARY KEY,
--	CountryId int NOT NULL FOREIGN KEY REFERENCES Countries,
--	[Name] varchar (255)
--);

--CREATE TABLE Airports (
--	Id int NOT NULL IDENTITY PRIMARY KEY,
--	IATA varchar(20),
--	[Name] varchar(255),
--	CityId int NOT NULL FOREIGN KEY REFERENCES Cities
--);

--CREATE TABLE [Routes] (
--	Id int NOT NULL IDENTITY PRIMARY KEY,
--	OriginId int FOREIGN KEY REFERENCES Airports,
--	DestinationId int FOREIGN KEY REFERENCES Airports
--);

--CREATE TABLE Stops(
--	RouteId int FOREIGN KEY REFERENCES [Routes],
--	AirportId int FOREIGN KEY REFERENCES Airports,
--	CONSTRAINT PK_Stop PRIMARY KEY (RouteId, AirportId)
--);

--CREATE TABLE Airlines(
--	Id int NOT NULL IDENTITY PRIMARY KEY,
--	[Name] varchar(255)
--);

--CREATE TABLE Flights(
--	Id int IDENTITY PRIMARY KEY,
--	RouteId int FOREIGN KEY REFERENCES [Routes],
--	OwnerId int FOREIGN KEY REFERENCES Airlines,
--	OperatorId int FOREIGN KEY REFERENCES Airlines
--);

--INSERT INTO Countries VALUES ('Denmark', 'DK');
--INSERT INTO Countries VALUES ('Sweden','SE');
--INSERT INTO Countries VALUES ('Germany','DE');
--INSERT INTO Countries VALUES ('United States of America','US');
--INSERT INTO Countries VALUES ('Spain','ES');


--INSERT INTO Cities (CountryId, [Name]) VALUES (1,'Copenhagen');
--INSERT INTO Cities (CountryId, [Name]) VALUES (1,'Aalborg');
--INSERT INTO Cities (CountryId, [Name]) VALUES (2,'Stockholm');
--INSERT INTO Cities (CountryId, [Name]) VALUES (3,'Hamburg');
--INSERT INTO Cities (CountryId, [Name]) VALUES (4,'Los Angeles');
--INSERT INTO Cities (CountryId, [Name]) VALUES (5,'Palma de Mallorca');

--INSERT INTO Airports VALUES ('CPH', 'Kastrup Airport', 1);
--INSERT INTO Airports VALUES ('AAL', 'Aalborg Airport', 2);
--INSERT INTO Airports VALUES ('ARN', 'Arlanda Airport', 3);
--INSERT INTO Airports VALUES ('HAM', 'Hamburg Airport', 4);
--INSERT INTO Airports VALUES ('LAX', 'Los Angeles International Airport', 5);
--INSERT INTO Airports VALUES ('PMI', 'Palma de Mallorca Airport', 6);

--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (1,2);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (2,1);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (1,3);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (1,4);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (1,5);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (1,6);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (2,6);
--INSERT INTO [Routes] (OriginId, DestinationId) VALUES (2,3);

--INSERT INTO Airlines VALUES ('Danish Air');
--INSERT INTO Airlines VALUES ('Easy Jet');
--INSERT INTO Airlines VALUES ('Norwegian Air International');
--INSERT INTO Airlines VALUES ('SAS');
--INSERT INTO Airlines VALUES ('EgyptAir');
--INSERT INTO Airlines VALUES ('Ryanair');

------SELECT r.Id, oa.Id, oa.Name as [From], da.Id, da.[Name] as [To] FROM [Routes] r
------INNER JOIN Airports oa ON oa.Id = r.OriginId
------INNER JOIN Airports da ON da.Id = r.DestinationId
------SELECT * FROM Airlines

--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (1,1,1);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (2,1,2);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (2,4,4);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (6,4,4);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (6,4,2);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (4,3,3);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (5,6,6);
--INSERT INTO Flights (RouteId, OwnerId, OperatorId) VALUES (5,4,4);

