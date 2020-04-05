
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/15/2020 15:29:51
-- Generated from EDMX file: D:\Info\Anul3\Sem2\GPC\Repository\Repository\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FilesManager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BaseEntities'
CREATE TABLE [dbo].[BaseEntities] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'BaseEntities_Movie'
CREATE TABLE [dbo].[BaseEntities_Movie] (
    [Name] nvarchar(150)  NULL,
    [DateAdded] datetime  NOT NULL,
    [Description] nvarchar(150)  NULL,
    [Path] nvarchar(150)  NOT NULL,
    [PathChanged] bit  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'BaseEntities_Person'
CREATE TABLE [dbo].[BaseEntities_Person] (
    [Name] nvarchar(150)  NOT NULL,
    [Id] int  NOT NULL,
    [Movie_Id] int  NOT NULL,
    [Photo_Id] int  NOT NULL
);
GO

-- Creating table 'BaseEntities_Photo'
CREATE TABLE [dbo].[BaseEntities_Photo] (
    [Event] nvarchar(150)  NULL,
    [DateAdded] datetime  NOT NULL,
    [Place] nvarchar(150)  NULL,
    [Description] nvarchar(150)  NULL,
    [Path] nvarchar(150)  NOT NULL,
    [PathChanged] bit  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'BaseEntities_MovieExtraProperty'
CREATE TABLE [dbo].[BaseEntities_MovieExtraProperty] (
    [PropertyName] nvarchar(150)  NOT NULL,
    [PropertyValue] nvarchar(150)  NOT NULL,
    [Id] int  NOT NULL,
    [Movie_Id] int  NOT NULL
);
GO

-- Creating table 'BaseEntities_PhotoExtraProperty'
CREATE TABLE [dbo].[BaseEntities_PhotoExtraProperty] (
    [PropertyName] nvarchar(150)  NOT NULL,
    [PropertyValue] nvarchar(150)  NOT NULL,
    [Id] int  NOT NULL,
    [Photo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BaseEntities'
ALTER TABLE [dbo].[BaseEntities]
ADD CONSTRAINT [PK_BaseEntities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseEntities_Movie'
ALTER TABLE [dbo].[BaseEntities_Movie]
ADD CONSTRAINT [PK_BaseEntities_Movie]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseEntities_Person'
ALTER TABLE [dbo].[BaseEntities_Person]
ADD CONSTRAINT [PK_BaseEntities_Person]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseEntities_Photo'
ALTER TABLE [dbo].[BaseEntities_Photo]
ADD CONSTRAINT [PK_BaseEntities_Photo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseEntities_MovieExtraProperty'
ALTER TABLE [dbo].[BaseEntities_MovieExtraProperty]
ADD CONSTRAINT [PK_BaseEntities_MovieExtraProperty]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BaseEntities_PhotoExtraProperty'
ALTER TABLE [dbo].[BaseEntities_PhotoExtraProperty]
ADD CONSTRAINT [PK_BaseEntities_PhotoExtraProperty]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Movie_Id] in table 'BaseEntities_Person'
ALTER TABLE [dbo].[BaseEntities_Person]
ADD CONSTRAINT [FK_MoviePerson]
    FOREIGN KEY ([Movie_Id])
    REFERENCES [dbo].[BaseEntities_Movie]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MoviePerson'
CREATE INDEX [IX_FK_MoviePerson]
ON [dbo].[BaseEntities_Person]
    ([Movie_Id]);
GO

-- Creating foreign key on [Photo_Id] in table 'BaseEntities_Person'
ALTER TABLE [dbo].[BaseEntities_Person]
ADD CONSTRAINT [FK_PhotoPerson]
    FOREIGN KEY ([Photo_Id])
    REFERENCES [dbo].[BaseEntities_Photo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPerson'
CREATE INDEX [IX_FK_PhotoPerson]
ON [dbo].[BaseEntities_Person]
    ([Photo_Id]);
GO

-- Creating foreign key on [Movie_Id] in table 'BaseEntities_MovieExtraProperty'
ALTER TABLE [dbo].[BaseEntities_MovieExtraProperty]
ADD CONSTRAINT [FK_MovieMovieExtraProperty]
    FOREIGN KEY ([Movie_Id])
    REFERENCES [dbo].[BaseEntities_Movie]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MovieMovieExtraProperty'
CREATE INDEX [IX_FK_MovieMovieExtraProperty]
ON [dbo].[BaseEntities_MovieExtraProperty]
    ([Movie_Id]);
GO

-- Creating foreign key on [Photo_Id] in table 'BaseEntities_PhotoExtraProperty'
ALTER TABLE [dbo].[BaseEntities_PhotoExtraProperty]
ADD CONSTRAINT [FK_PhotoPhotoExtraProperty]
    FOREIGN KEY ([Photo_Id])
    REFERENCES [dbo].[BaseEntities_Photo]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotoPhotoExtraProperty'
CREATE INDEX [IX_FK_PhotoPhotoExtraProperty]
ON [dbo].[BaseEntities_PhotoExtraProperty]
    ([Photo_Id]);
GO

-- Creating foreign key on [Id] in table 'BaseEntities_Movie'
ALTER TABLE [dbo].[BaseEntities_Movie]
ADD CONSTRAINT [FK_Movie_inherits_BaseEntity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BaseEntities]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BaseEntities_Person'
ALTER TABLE [dbo].[BaseEntities_Person]
ADD CONSTRAINT [FK_Person_inherits_BaseEntity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BaseEntities]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BaseEntities_Photo'
ALTER TABLE [dbo].[BaseEntities_Photo]
ADD CONSTRAINT [FK_Photo_inherits_BaseEntity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BaseEntities]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BaseEntities_MovieExtraProperty'
ALTER TABLE [dbo].[BaseEntities_MovieExtraProperty]
ADD CONSTRAINT [FK_MovieExtraProperty_inherits_BaseEntity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BaseEntities]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'BaseEntities_PhotoExtraProperty'
ALTER TABLE [dbo].[BaseEntities_PhotoExtraProperty]
ADD CONSTRAINT [FK_PhotoExtraProperty_inherits_BaseEntity]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[BaseEntities]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------