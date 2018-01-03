-- Script used to create Subscribers table...
-- For production it would need if exists, etc...
-- Since I don't have full SQL Server Management Studio at home, I am just adding this to repo
CREATE TABLE [dbo].[Subscribers] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (128) NOT NULL,
    [LastName]  NVARCHAR (128) NOT NULL,
    [State]     NVARCHAR (32)  NOT NULL,
    [ZipCode]   NVARCHAR (16)  NOT NULL,
    CONSTRAINT [PK_dbo.Subscribers] PRIMARY KEY CLUSTERED ([Id] ASC)
);