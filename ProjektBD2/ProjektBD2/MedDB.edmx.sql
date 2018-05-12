
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
<<<<<<< HEAD
-- Date Created: 04/21/2018 12:41:36
-- Generated from EDMX file: E:\BD2\ProjektBD2\BazyDanych2\ProjektBD2\ProjektBD2\MedDB.edmx
=======
-- Date Created: 05/12/2018 10:06:31
-- Generated from EDMX file: C:\Users\Przemek\source\Repos\Pharma-app\ProjektBD2\ProjektBD2\MedDB.edmx
>>>>>>> gui
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Pharma];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AddressUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_AddressUser];
GO
IF OBJECT_ID(N'[dbo].[FK_HCOAddress]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCOSet] DROP CONSTRAINT [FK_HCOAddress];
GO
IF OBJECT_ID(N'[dbo].[FK_HCOAddress1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCOSet] DROP CONSTRAINT [FK_HCOAddress1];
GO
IF OBJECT_ID(N'[dbo].[FK_HCOHCP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCPSet] DROP CONSTRAINT [FK_HCOHCP];
GO
<<<<<<< HEAD
IF OBJECT_ID(N'[dbo].[FK_HCPAddress]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCPSet] DROP CONSTRAINT [FK_HCPAddress];
GO
IF OBJECT_ID(N'[dbo].[FK_HCPAddress1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCPSet] DROP CONSTRAINT [FK_HCPAddress1];
GO
=======
>>>>>>> gui
IF OBJECT_ID(N'[dbo].[FK_MeetingHCP]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeetingSet] DROP CONSTRAINT [FK_MeetingHCP];
GO
IF OBJECT_ID(N'[dbo].[FK_MeetingProduct]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeetingSet] DROP CONSTRAINT [FK_MeetingProduct];
GO
IF OBJECT_ID(N'[dbo].[FK_Sample_ProductSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sample] DROP CONSTRAINT [FK_Sample_ProductSet];
GO
<<<<<<< HEAD
IF OBJECT_ID(N'[MedDBStoreContainer].[FK_SampleStorage_Sample]', 'F') IS NOT NULL
    ALTER TABLE [MedDBStoreContainer].[SampleStorage] DROP CONSTRAINT [FK_SampleStorage_Sample];
GO
IF OBJECT_ID(N'[MedDBStoreContainer].[FK_SampleStorage_UserSet]', 'F') IS NOT NULL
    ALTER TABLE [MedDBStoreContainer].[SampleStorage] DROP CONSTRAINT [FK_SampleStorage_UserSet];
=======
IF OBJECT_ID(N'[dbo].[FK_HCOAddress1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCOSet] DROP CONSTRAINT [FK_HCOAddress1];
>>>>>>> gui
GO
IF OBJECT_ID(N'[dbo].[FK_UserMeeting]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeetingSet] DROP CONSTRAINT [FK_UserMeeting];
GO
IF OBJECT_ID(N'[dbo].[FK_UserUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserSet] DROP CONSTRAINT [FK_UserUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserUserCredentials]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserCredentialsSet1] DROP CONSTRAINT [FK_UserUserCredentials];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AddressSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AddressSet];
GO
IF OBJECT_ID(N'[dbo].[HCOSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HCOSet];
GO
IF OBJECT_ID(N'[dbo].[HCPSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HCPSet];
GO
IF OBJECT_ID(N'[dbo].[MeetingSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeetingSet];
GO
IF OBJECT_ID(N'[dbo].[ProductSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductSet];
GO
IF OBJECT_ID(N'[dbo].[Sample]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sample];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[MedDBStoreContainer].[SampleStorage]', 'U') IS NOT NULL
    DROP TABLE [MedDBStoreContainer].[SampleStorage];
GO
IF OBJECT_ID(N'[dbo].[UserCredentialsSet1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserCredentialsSet1];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HCOSet'
CREATE TABLE [dbo].[HCOSet] (
    [HCOID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Range] nvarchar(max)  NOT NULL,
    [Level] smallint  NOT NULL,
    [SpecialType] nvarchar(max)  NOT NULL,
    [Beds] nvarchar(max)  NOT NULL,
    [Employees] nvarchar(max)  NOT NULL,
    [PhoneNumber] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Website] nvarchar(max)  NOT NULL,
    [AddressID] int  NOT NULL
);
GO

-- Creating table 'HCPSet'
CREATE TABLE [dbo].[HCPSet] (
    [HCPID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [MiddleName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Gender] nvarchar(max)  NOT NULL,
    [AcademicTitle] nvarchar(max)  NOT NULL,
    [Birthdate] datetime  NOT NULL,
    [PhoneNumber] int  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [KOL] bit  NOT NULL,
    [Specialty] nvarchar(max)  NOT NULL,
    [AddressID] int  NOT NULL,
    [HCOID] int  NOT NULL
);
GO

-- Creating table 'AddressSet'
CREATE TABLE [dbo].[AddressSet] (
    [AddressID] int IDENTITY(1,1) NOT NULL,
    [Street] nvarchar(max)  NOT NULL,
    [City] nvarchar(max)  NOT NULL,
    [Territory] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [ZipCode] int  NOT NULL
);
GO

-- Creating table 'MeetingSet'
CREATE TABLE [dbo].[MeetingSet] (
    [MeetingID] int IDENTITY(1,1) NOT NULL,
    [HCPID] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [Topic] nvarchar(max)  NOT NULL,
    [ProductID] int  NOT NULL,
    [UserID] int  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [JobTitle] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [PhoneNumber] int  NOT NULL,
    [HireDate] datetime  NOT NULL,
    [ManagerID] int  NULL,
    [AddressID] int  NOT NULL,
<<<<<<< HEAD
    [Username] nvarchar(max)  NULL,
    [Address_AddressID] int  NOT NULL
=======
    [Username] nvarchar(max)  NULL
>>>>>>> gui
);
GO

-- Creating table 'ProductSet'
CREATE TABLE [dbo].[ProductSet] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL,
    [AntiDisease] nvarchar(max)  NOT NULL,
    [Manufacturer] nvarchar(max)  NOT NULL,
    [QtyPerCase] smallint  NOT NULL,
    [MIngredient] nvarchar(max)  NOT NULL
);
GO

<<<<<<< HEAD
-- Creating table 'UserCredentialsSet'
CREATE TABLE [dbo].[UserCredentialsSet] (
=======
-- Creating table 'UserCredentialsSet1'
CREATE TABLE [dbo].[UserCredentialsSet1] (
>>>>>>> gui
    [UserCredentialsID] int IDENTITY(1,1) NOT NULL,
    [UserID] int  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

<<<<<<< HEAD
-- Creating table 'Sample'
CREATE TABLE [dbo].[Sample] (
    [SampleID] int  NOT NULL,
    [ProductID] int  NULL
);
GO

-- Creating table 'SampleStorage'
CREATE TABLE [dbo].[SampleStorage] (
    [UserID] int  NOT NULL,
    [SampleID] int  NOT NULL,
    [Qty] int  NOT NULL
);
GO

=======
>>>>>>> gui
-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [HCOID] in table 'HCOSet'
ALTER TABLE [dbo].[HCOSet]
ADD CONSTRAINT [PK_HCOSet]
    PRIMARY KEY CLUSTERED ([HCOID] ASC);
GO

-- Creating primary key on [HCPID] in table 'HCPSet'
ALTER TABLE [dbo].[HCPSet]
ADD CONSTRAINT [PK_HCPSet]
    PRIMARY KEY CLUSTERED ([HCPID] ASC);
GO

-- Creating primary key on [AddressID] in table 'AddressSet'
ALTER TABLE [dbo].[AddressSet]
ADD CONSTRAINT [PK_AddressSet]
    PRIMARY KEY CLUSTERED ([AddressID] ASC);
GO

-- Creating primary key on [MeetingID] in table 'MeetingSet'
ALTER TABLE [dbo].[MeetingSet]
ADD CONSTRAINT [PK_MeetingSet]
    PRIMARY KEY CLUSTERED ([MeetingID] ASC);
GO

-- Creating primary key on [UserID] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- Creating primary key on [ProductID] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [PK_ProductSet]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

<<<<<<< HEAD
-- Creating primary key on [UserCredentialsID] in table 'UserCredentialsSet'
ALTER TABLE [dbo].[UserCredentialsSet]
ADD CONSTRAINT [PK_UserCredentialsSet]
    PRIMARY KEY CLUSTERED ([UserCredentialsID] ASC);
GO

-- Creating primary key on [SampleID] in table 'Sample'
ALTER TABLE [dbo].[Sample]
ADD CONSTRAINT [PK_Sample]
    PRIMARY KEY CLUSTERED ([SampleID] ASC);
GO

-- Creating primary key on [UserID], [SampleID], [Qty] in table 'SampleStorage'
ALTER TABLE [dbo].[SampleStorage]
ADD CONSTRAINT [PK_SampleStorage]
    PRIMARY KEY CLUSTERED ([UserID], [SampleID], [Qty] ASC);
GO

=======
-- Creating primary key on [UserCredentialsID] in table 'UserCredentialsSet1'
ALTER TABLE [dbo].[UserCredentialsSet1]
ADD CONSTRAINT [PK_UserCredentialsSet1]
    PRIMARY KEY CLUSTERED ([UserCredentialsID] ASC);
GO

>>>>>>> gui
-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [HCOID] in table 'HCPSet'
ALTER TABLE [dbo].[HCPSet]
ADD CONSTRAINT [FK_HCOHCP]
    FOREIGN KEY ([HCOID])
    REFERENCES [dbo].[HCOSet]
        ([HCOID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCOHCP'
CREATE INDEX [IX_FK_HCOHCP]
ON [dbo].[HCPSet]
    ([HCOID]);
GO

-- Creating foreign key on [HCPID] in table 'MeetingSet'
ALTER TABLE [dbo].[MeetingSet]
ADD CONSTRAINT [FK_MeetingHCP]
    FOREIGN KEY ([HCPID])
    REFERENCES [dbo].[HCPSet]
        ([HCPID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MeetingHCP'
CREATE INDEX [IX_FK_MeetingHCP]
ON [dbo].[MeetingSet]
    ([HCPID]);
GO

-- Creating foreign key on [AddressID] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_AddressUser]
    FOREIGN KEY ([AddressID])
    REFERENCES [dbo].[AddressSet]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressUser'
CREATE INDEX [IX_FK_AddressUser]
ON [dbo].[UserSet]
    ([AddressID]);
GO

-- Creating foreign key on [ProductID] in table 'MeetingSet'
ALTER TABLE [dbo].[MeetingSet]
ADD CONSTRAINT [FK_MeetingProduct]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[ProductSet]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MeetingProduct'
CREATE INDEX [IX_FK_MeetingProduct]
ON [dbo].[MeetingSet]
    ([ProductID]);
GO

-- Creating foreign key on [UserID] in table 'MeetingSet'
ALTER TABLE [dbo].[MeetingSet]
ADD CONSTRAINT [FK_UserMeeting]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UserSet]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserMeeting'
CREATE INDEX [IX_FK_UserMeeting]
ON [dbo].[MeetingSet]
    ([UserID]);
GO

-- Creating foreign key on [AddressID] in table 'HCPSet'
ALTER TABLE [dbo].[HCPSet]
ADD CONSTRAINT [FK_HCPAddress]
    FOREIGN KEY ([AddressID])
    REFERENCES [dbo].[AddressSet]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCPAddress'
CREATE INDEX [IX_FK_HCPAddress]
ON [dbo].[HCPSet]
    ([AddressID]);
GO

-- Creating foreign key on [AddressID] in table 'HCOSet'
ALTER TABLE [dbo].[HCOSet]
ADD CONSTRAINT [FK_HCOAddress]
    FOREIGN KEY ([AddressID])
    REFERENCES [dbo].[AddressSet]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCOAddress'
CREATE INDEX [IX_FK_HCOAddress]
ON [dbo].[HCOSet]
    ([AddressID]);
GO

-- Creating foreign key on [AddressID] in table 'HCOSet'
ALTER TABLE [dbo].[HCOSet]
ADD CONSTRAINT [FK_HCOAddress1]
    FOREIGN KEY ([AddressID])
    REFERENCES [dbo].[AddressSet]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCOAddress1'
CREATE INDEX [IX_FK_HCOAddress1]
ON [dbo].[HCOSet]
    ([AddressID]);
GO

-- Creating foreign key on [AddressID] in table 'HCPSet'
ALTER TABLE [dbo].[HCPSet]
ADD CONSTRAINT [FK_HCPAddress1]
    FOREIGN KEY ([AddressID])
    REFERENCES [dbo].[AddressSet]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCPAddress1'
CREATE INDEX [IX_FK_HCPAddress1]
ON [dbo].[HCPSet]
    ([AddressID]);
GO

-- Creating foreign key on [ManagerID] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_UserUser]
    FOREIGN KEY ([ManagerID])
    REFERENCES [dbo].[UserSet]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUser'
CREATE INDEX [IX_FK_UserUser]
ON [dbo].[UserSet]
    ([ManagerID]);
GO

<<<<<<< HEAD
-- Creating foreign key on [UserID] in table 'UserCredentialsSet'
ALTER TABLE [dbo].[UserCredentialsSet]
=======
-- Creating foreign key on [UserID] in table 'UserCredentialsSet1'
ALTER TABLE [dbo].[UserCredentialsSet1]
>>>>>>> gui
ADD CONSTRAINT [FK_UserUserCredentials]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UserSet]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserUserCredentials'
CREATE INDEX [IX_FK_UserUserCredentials]
<<<<<<< HEAD
ON [dbo].[UserCredentialsSet]
    ([UserID]);
GO

-- Creating foreign key on [Address_AddressID] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [FK_AddressUser]
    FOREIGN KEY ([Address_AddressID])
    REFERENCES [dbo].[AddressSet]
        ([AddressID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AddressUser'
CREATE INDEX [IX_FK_AddressUser]
ON [dbo].[UserSet]
    ([Address_AddressID]);
GO

-- Creating foreign key on [ProductID] in table 'Sample'
ALTER TABLE [dbo].[Sample]
ADD CONSTRAINT [FK_Sample_ProductSet]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[ProductSet]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Sample_ProductSet'
CREATE INDEX [IX_FK_Sample_ProductSet]
ON [dbo].[Sample]
    ([ProductID]);
GO

-- Creating foreign key on [SampleID] in table 'SampleStorage'
ALTER TABLE [dbo].[SampleStorage]
ADD CONSTRAINT [FK_SampleStorage_Sample]
    FOREIGN KEY ([SampleID])
    REFERENCES [dbo].[Sample]
        ([SampleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SampleStorage_Sample'
CREATE INDEX [IX_FK_SampleStorage_Sample]
ON [dbo].[SampleStorage]
    ([SampleID]);
GO

-- Creating foreign key on [UserID] in table 'SampleStorage'
ALTER TABLE [dbo].[SampleStorage]
ADD CONSTRAINT [FK_SampleStorage_UserSet]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[UserSet]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

=======
ON [dbo].[UserCredentialsSet1]
    ([UserID]);
GO

>>>>>>> gui
-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------