
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/20/2013 18:35:11
-- Generated from EDMX file: C:\Users\fredy\Desktop\tambak\tambak.Web\TambakEDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CPL];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PondConsumptionsLog_Ponds]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PondConsumptionsLog] DROP CONSTRAINT [FK_PondConsumptionsLog_Ponds];
GO
IF OBJECT_ID(N'[dbo].[FK_PondConsumptionsLog_PondsProductionCycle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PondConsumptionsLog] DROP CONSTRAINT [FK_PondConsumptionsLog_PondsProductionCycle];
GO
IF OBJECT_ID(N'[dbo].[FK_PondConsumptionsLog_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PondConsumptionsLog] DROP CONSTRAINT [FK_PondConsumptionsLog_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_PondsProductionCycle_Ponds]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PondsProductionCycle] DROP CONSTRAINT [FK_PondsProductionCycle_Ponds];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductPurchaseLog_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductPurchaseLog] DROP CONSTRAINT [FK_ProductPurchaseLog_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductsDetails_Products]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductsDetails] DROP CONSTRAINT [FK_ProductsDetails_Products];
GO
IF OBJECT_ID(N'[dbo].[FK_ResultNote_ResultNote]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResultNote] DROP CONSTRAINT [FK_ResultNote_ResultNote];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_Contacts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Contacts];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_Ponds]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_Ponds];
GO
IF OBJECT_ID(N'[dbo].[FK_Tasks_PondsProductionCycle]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Tasks] DROP CONSTRAINT [FK_Tasks_PondsProductionCycle];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Contacts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contacts];
GO
IF OBJECT_ID(N'[dbo].[PondConsumptionsLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PondConsumptionsLog];
GO
IF OBJECT_ID(N'[dbo].[Ponds]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ponds];
GO
IF OBJECT_ID(N'[dbo].[PondsProductionCycle]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PondsProductionCycle];
GO
IF OBJECT_ID(N'[dbo].[ProductPurchaseLog]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductPurchaseLog];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductsDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductsDetails];
GO
IF OBJECT_ID(N'[dbo].[ResultNote]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResultNote];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Tasks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tasks];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Contacts'
CREATE TABLE [dbo].[Contacts] (
    [ContactID] int IDENTITY(1,1) NOT NULL,
    [Company] nvarchar(50)  NULL,
    [LastName] nvarchar(50)  NULL,
    [FirstName] nvarchar(50)  NULL,
    [email] nvarchar(50)  NULL,
    [jobTitle] nvarchar(50)  NULL,
    [BusinessPhone] nvarchar(50)  NULL,
    [homePhone] nvarchar(50)  NULL,
    [MobilePhone] nvarchar(50)  NULL,
    [fax] nvarchar(50)  NULL,
    [address] nvarchar(255)  NULL,
    [city] nvarchar(255)  NULL,
    [State] nvarchar(255)  NULL,
    [zip] nvarchar(255)  NULL,
    [Country] nvarchar(255)  NULL,
    [WebPage] nvarchar(max)  NULL,
    [Notes] nvarchar(max)  NULL,
    [archive] bit  NULL
);
GO

-- Creating table 'PondConsumptionsLogs'
CREATE TABLE [dbo].[PondConsumptionsLogs] (
    [LogID] int IDENTITY(1,1) NOT NULL,
    [ProductID] int  NOT NULL,
    [Usage] int  NOT NULL,
    [UOM] nvarchar(255)  NULL,
    [LogDate] datetime  NULL,
    [userId] nvarchar(255)  NULL,
    [PondID] int  NULL,
    [ProductionCycleID] int  NULL
);
GO

-- Creating table 'Ponds'
CREATE TABLE [dbo].[Ponds] (
    [PondID] int IDENTITY(1,1) NOT NULL,
    [PondDescription] nvarchar(max)  NULL,
    [pondSize] int  NULL,
    [pondUOM] nvarchar(50)  NULL,
    [pondLocation] geography  NULL
);
GO

-- Creating table 'PondsProductionCycles'
CREATE TABLE [dbo].[PondsProductionCycles] (
    [ProductionCycleID] int IDENTITY(1,1) NOT NULL,
    [StartDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [isInProduction] bit  NULL,
    [Note] nvarchar(max)  NULL,
    [PondID] int  NOT NULL
);
GO

-- Creating table 'ProductPurchaseLogs'
CREATE TABLE [dbo].[ProductPurchaseLogs] (
    [PurchaseLogID] int IDENTITY(1,1) NOT NULL,
    [ProductID] int  NOT NULL,
    [batchID] nvarchar(255)  NULL,
    [Currency] nvarchar(3)  NULL,
    [PurchasePrice] decimal(19,4)  NULL,
    [Quantity] int  NULL,
    [Total] decimal(19,4)  NULL,
    [Shipping] decimal(19,4)  NULL,
    [tax] decimal(19,4)  NULL,
    [Requester] nvarchar(255)  NULL,
    [userID] nvarchar(255)  NULL,
    [Date] datetime  NULL,
    [isDelivered] bit  NULL,
    [location] nvarchar(255)  NULL,
    [ExpireDate] datetime  NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [ProductID] int IDENTITY(1,1) NOT NULL,
    [SKU] nvarchar(256)  NULL,
    [ProductName] nvarchar(255)  NULL,
    [Product_Description] nvarchar(max)  NULL,
    [qtyperunit] decimal(18,2)  NULL,
    [Uom] nvarchar(50)  NULL,
    [UnitInStock] decimal(18,2)  NULL,
    [UnitInOrder] decimal(18,2)  NULL,
    [ReorderLevel] decimal(18,2)  NULL
);
GO

-- Creating table 'ProductsDetails'
CREATE TABLE [dbo].[ProductsDetails] (
    [ProductTrxID] int IDENTITY(1,1) NOT NULL,
    [ProductID] int  NOT NULL,
    [Description] nvarchar(max)  NULL,
    [Ordered] int  NULL,
    [received] int  NULL,
    [sold] int  NULL,
    [shrinkage] int  NULL,
    [trxDate] int  NULL,
    [UserID] nvarchar(50)  NULL
);
GO

-- Creating table 'ResultNotes'
CREATE TABLE [dbo].[ResultNotes] (
    [resultID] int IDENTITY(1,1) NOT NULL,
    [ResultNote1] nvarchar(max)  NULL,
    [taskID] int  NULL,
    [entryDate] datetime  NULL,
    [UserId] nvarchar(255)  NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Tasks'
CREATE TABLE [dbo].[Tasks] (
    [TaskID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(255)  NOT NULL,
    [Priority] nvarchar(20)  NULL,
    [Status] nvarchar(255)  NOT NULL,
    [CompletePercentage] float  NULL,
    [assignedTo] int  NOT NULL,
    [Description] nvarchar(255)  NULL,
    [StartDate] datetime  NULL,
    [DueDate] datetime  NULL,
    [EndDate] datetime  NULL,
    [Attachments] nvarchar(max)  NULL,
    [PondID] int  NULL,
    [UserId] nvarchar(255)  NULL,
    [plannedManHours] float  NULL,
    [ProductionCycleID] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ContactID] in table 'Contacts'
ALTER TABLE [dbo].[Contacts]
ADD CONSTRAINT [PK_Contacts]
    PRIMARY KEY CLUSTERED ([ContactID] ASC);
GO

-- Creating primary key on [LogID] in table 'PondConsumptionsLogs'
ALTER TABLE [dbo].[PondConsumptionsLogs]
ADD CONSTRAINT [PK_PondConsumptionsLogs]
    PRIMARY KEY CLUSTERED ([LogID] ASC);
GO

-- Creating primary key on [PondID] in table 'Ponds'
ALTER TABLE [dbo].[Ponds]
ADD CONSTRAINT [PK_Ponds]
    PRIMARY KEY CLUSTERED ([PondID] ASC);
GO

-- Creating primary key on [ProductionCycleID] in table 'PondsProductionCycles'
ALTER TABLE [dbo].[PondsProductionCycles]
ADD CONSTRAINT [PK_PondsProductionCycles]
    PRIMARY KEY CLUSTERED ([ProductionCycleID] ASC);
GO

-- Creating primary key on [PurchaseLogID] in table 'ProductPurchaseLogs'
ALTER TABLE [dbo].[ProductPurchaseLogs]
ADD CONSTRAINT [PK_ProductPurchaseLogs]
    PRIMARY KEY CLUSTERED ([PurchaseLogID] ASC);
GO

-- Creating primary key on [ProductID] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([ProductID] ASC);
GO

-- Creating primary key on [ProductTrxID] in table 'ProductsDetails'
ALTER TABLE [dbo].[ProductsDetails]
ADD CONSTRAINT [PK_ProductsDetails]
    PRIMARY KEY CLUSTERED ([ProductTrxID] ASC);
GO

-- Creating primary key on [resultID] in table 'ResultNotes'
ALTER TABLE [dbo].[ResultNotes]
ADD CONSTRAINT [PK_ResultNotes]
    PRIMARY KEY CLUSTERED ([resultID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [TaskID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [PK_Tasks]
    PRIMARY KEY CLUSTERED ([TaskID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [assignedTo] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_Contacts]
    FOREIGN KEY ([assignedTo])
    REFERENCES [dbo].[Contacts]
        ([ContactID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_Contacts'
CREATE INDEX [IX_FK_Tasks_Contacts]
ON [dbo].[Tasks]
    ([assignedTo]);
GO

-- Creating foreign key on [PondID] in table 'PondConsumptionsLogs'
ALTER TABLE [dbo].[PondConsumptionsLogs]
ADD CONSTRAINT [FK_PondConsumptionsLog_Ponds]
    FOREIGN KEY ([PondID])
    REFERENCES [dbo].[Ponds]
        ([PondID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PondConsumptionsLog_Ponds'
CREATE INDEX [IX_FK_PondConsumptionsLog_Ponds]
ON [dbo].[PondConsumptionsLogs]
    ([PondID]);
GO

-- Creating foreign key on [ProductionCycleID] in table 'PondConsumptionsLogs'
ALTER TABLE [dbo].[PondConsumptionsLogs]
ADD CONSTRAINT [FK_PondConsumptionsLog_PondsProductionCycle]
    FOREIGN KEY ([ProductionCycleID])
    REFERENCES [dbo].[PondsProductionCycles]
        ([ProductionCycleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PondConsumptionsLog_PondsProductionCycle'
CREATE INDEX [IX_FK_PondConsumptionsLog_PondsProductionCycle]
ON [dbo].[PondConsumptionsLogs]
    ([ProductionCycleID]);
GO

-- Creating foreign key on [ProductID] in table 'PondConsumptionsLogs'
ALTER TABLE [dbo].[PondConsumptionsLogs]
ADD CONSTRAINT [FK_PondConsumptionsLog_Products]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PondConsumptionsLog_Products'
CREATE INDEX [IX_FK_PondConsumptionsLog_Products]
ON [dbo].[PondConsumptionsLogs]
    ([ProductID]);
GO

-- Creating foreign key on [PondID] in table 'PondsProductionCycles'
ALTER TABLE [dbo].[PondsProductionCycles]
ADD CONSTRAINT [FK_PondsProductionCycle_Ponds]
    FOREIGN KEY ([PondID])
    REFERENCES [dbo].[Ponds]
        ([PondID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PondsProductionCycle_Ponds'
CREATE INDEX [IX_FK_PondsProductionCycle_Ponds]
ON [dbo].[PondsProductionCycles]
    ([PondID]);
GO

-- Creating foreign key on [PondID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_Ponds]
    FOREIGN KEY ([PondID])
    REFERENCES [dbo].[Ponds]
        ([PondID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_Ponds'
CREATE INDEX [IX_FK_Tasks_Ponds]
ON [dbo].[Tasks]
    ([PondID]);
GO

-- Creating foreign key on [ProductionCycleID] in table 'Tasks'
ALTER TABLE [dbo].[Tasks]
ADD CONSTRAINT [FK_Tasks_PondsProductionCycle]
    FOREIGN KEY ([ProductionCycleID])
    REFERENCES [dbo].[PondsProductionCycles]
        ([ProductionCycleID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Tasks_PondsProductionCycle'
CREATE INDEX [IX_FK_Tasks_PondsProductionCycle]
ON [dbo].[Tasks]
    ([ProductionCycleID]);
GO

-- Creating foreign key on [ProductID] in table 'ProductPurchaseLogs'
ALTER TABLE [dbo].[ProductPurchaseLogs]
ADD CONSTRAINT [FK_ProductPurchaseLog_Products]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductPurchaseLog_Products'
CREATE INDEX [IX_FK_ProductPurchaseLog_Products]
ON [dbo].[ProductPurchaseLogs]
    ([ProductID]);
GO

-- Creating foreign key on [ProductID] in table 'ProductsDetails'
ALTER TABLE [dbo].[ProductsDetails]
ADD CONSTRAINT [FK_ProductsDetails_Products]
    FOREIGN KEY ([ProductID])
    REFERENCES [dbo].[Products]
        ([ProductID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductsDetails_Products'
CREATE INDEX [IX_FK_ProductsDetails_Products]
ON [dbo].[ProductsDetails]
    ([ProductID]);
GO

-- Creating foreign key on [taskID] in table 'ResultNotes'
ALTER TABLE [dbo].[ResultNotes]
ADD CONSTRAINT [FK_ResultNote_ResultNote]
    FOREIGN KEY ([taskID])
    REFERENCES [dbo].[Tasks]
        ([TaskID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ResultNote_ResultNote'
CREATE INDEX [IX_FK_ResultNote_ResultNote]
ON [dbo].[ResultNotes]
    ([taskID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------