
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/29/2014 12:42:57
-- Generated from EDMX file: c:\users\vernon\documents\visual studio 2013\Projects\HouseOfBurt\HouseOfBurt\Models\DataContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HouseOfBurt];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ArticleLink]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articles] DROP CONSTRAINT [FK_ArticleLink];
GO
IF OBJECT_ID(N'[dbo].[FK_CategoryArticle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Articles] DROP CONSTRAINT [FK_CategoryArticle];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductVersion]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Versions] DROP CONSTRAINT [FK_ProductVersion];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Links]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Links];
GO
IF OBJECT_ID(N'[dbo].[Articles]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Articles];
GO
IF OBJECT_ID(N'[dbo].[Categories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Categories];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[Versions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Versions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Links'
CREATE TABLE [dbo].[Links] (
    [LinkId] int IDENTITY(1,1) NOT NULL,
    [Url] nvarchar(max)  NOT NULL,
    [Caption] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Articles'
CREATE TABLE [dbo].[Articles] (
    [ArticleId] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [Links_LinkId] int  NULL
);
GO

-- Creating table 'Categories'
CREATE TABLE [dbo].[Categories] (
    [Tag] nvarchar(max)  NOT NULL,
    [CategoryId] int IDENTITY(1,1) NOT NULL,
    [Article_ArticleId] int  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductId] int IDENTITY(1,1) NOT NULL,
    [SourceLink] nvarchar(max)  NOT NULL,
    [IconUrl] nvarchar(max)  NOT NULL,
    [ImageUrl] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [ShortDescription] nvarchar(max)  NOT NULL,
    [FullDescription] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Versions'
CREATE TABLE [dbo].[Versions] (
    [VersionId] int IDENTITY(1,1) NOT NULL,
    [VersionNumber] nvarchar(max)  NOT NULL,
    [DownloadLink] nvarchar(max)  NOT NULL,
    [Notes] nvarchar(max)  NOT NULL,
    [Product_ProductId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [LinkId] in table 'Links'
ALTER TABLE [dbo].[Links]
ADD CONSTRAINT [PK_Links]
    PRIMARY KEY CLUSTERED ([LinkId] ASC);
GO

-- Creating primary key on [ArticleId] in table 'Articles'
ALTER TABLE [dbo].[Articles]
ADD CONSTRAINT [PK_Articles]
    PRIMARY KEY CLUSTERED ([ArticleId] ASC);
GO

-- Creating primary key on [CategoryId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [PK_Categories]
    PRIMARY KEY CLUSTERED ([CategoryId] ASC);
GO

-- Creating primary key on [ProductId] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductId] ASC);
GO

-- Creating primary key on [VersionId] in table 'Versions'
ALTER TABLE [dbo].[Versions]
ADD CONSTRAINT [PK_Versions]
    PRIMARY KEY CLUSTERED ([VersionId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Links_LinkId] in table 'Articles'
ALTER TABLE [dbo].[Articles]
ADD CONSTRAINT [FK_ArticleLink]
    FOREIGN KEY ([Links_LinkId])
    REFERENCES [dbo].[Links]
        ([LinkId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticleLink'
CREATE INDEX [IX_FK_ArticleLink]
ON [dbo].[Articles]
    ([Links_LinkId]);
GO

-- Creating foreign key on [Product_ProductId] in table 'Versions'
ALTER TABLE [dbo].[Versions]
ADD CONSTRAINT [FK_ProductVersion]
    FOREIGN KEY ([Product_ProductId])
    REFERENCES [dbo].[Products]
        ([ProductId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductVersion'
CREATE INDEX [IX_FK_ProductVersion]
ON [dbo].[Versions]
    ([Product_ProductId]);
GO

-- Creating foreign key on [Article_ArticleId] in table 'Categories'
ALTER TABLE [dbo].[Categories]
ADD CONSTRAINT [FK_ArticleCategory]
    FOREIGN KEY ([Article_ArticleId])
    REFERENCES [dbo].[Articles]
        ([ArticleId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArticleCategory'
CREATE INDEX [IX_FK_ArticleCategory]
ON [dbo].[Categories]
    ([Article_ArticleId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------