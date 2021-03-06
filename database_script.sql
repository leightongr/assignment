
CREATE TABLE [User] (
  [Id] uniqueidentifier NOT NULL
, [Username] nvarchar(100)  NOT NULL
, [Password] nvarchar(100)  NOT NULL
);
GO
CREATE TABLE [License] (
  [Id] uniqueidentifier NOT NULL
, [FirstName] nvarchar(100)  NOT NULL
, [LastName] nvarchar(100)  NOT NULL
, [TRN] nvarchar(100)  NOT NULL
, [Type] nvarchar(100)  NULL
, [PPV] bit NULL
, [Laden] int  NULL
, [PhoneNumber] nvarchar(100)  NULL
, [Unladen] int  NULL
, [CCRating] int  NULL
, [Depot] nvarchar(100)  NULL
, [DateCollected] datetime NULL
, [DateReceived] datetime NULL
, [ExpireDate] datetime NULL
);
GO
INSERT INTO [User] ([Id],[Username],[Password]) VALUES (
'748d5d7b-b0c2-487b-b002-115e7a04edac',N'Admin',N'Admin');
GO
INSERT INTO [License] ([Id],[FirstName],[LastName],[TRN],[Type],[PPV],[Laden],[PhoneNumber],[Unladen],[CCRating],[Depot],[DateCollected],[DateReceived],[ExpireDate]) VALUES (
'99fe61c7-9e15-4fa5-959f-8ffc18aa5528',N'test',N'232323',N'2323232',NULL,NULL,NULL,N'32323232323',NULL,NULL,NULL,NULL,NULL,NULL);
GO
INSERT INTO [License] ([Id],[FirstName],[LastName],[TRN],[Type],[PPV],[Laden],[PhoneNumber],[Unladen],[CCRating],[Depot],[DateCollected],[DateReceived],[ExpireDate]) VALUES (
'bd246f92-716f-4e98-9ce0-9c6df2ef58ab',N'John',N'Peterson',N'4545444',N'Private',1,NULL,N'39834934',NULL,NULL,NULL,{ts '2018-05-31 18:33:53.000'},NULL,NULL);
GO
INSERT INTO [License] ([Id],[FirstName],[LastName],[TRN],[Type],[PPV],[Laden],[PhoneNumber],[Unladen],[CCRating],[Depot],[DateCollected],[DateReceived],[ExpireDate]) VALUES (
'a810696f-4c50-473b-9304-c59b1d2753c3',N'Peter',N'John',N'232323',NULL,1,343,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
GO
ALTER TABLE [User] ADD CONSTRAINT [PK_User] PRIMARY KEY ([Id]);
GO
ALTER TABLE [License] ADD CONSTRAINT [PK_License] PRIMARY KEY ([Id]);
GO

