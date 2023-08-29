IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE TABLE [UrzadSkarbowy] (
        [Id] int NOT NULL IDENTITY,
        [Nazwa] nvarchar(max) NOT NULL,
        [KodUs] int NOT NULL,
        [Adres] nvarchar(max) NOT NULL,
        [RachunekBankowy] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_UrzadSkarbowy] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE TABLE [User] (
        [Id] int NOT NULL IDENTITY,
        [Login] nvarchar(max) NOT NULL,
        [Haslo] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_User] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE TABLE [Pracownik] (
        [Id] int NOT NULL IDENTITY,
        [ImieNazwisko] nvarchar(max) NOT NULL,
        [Pesel] nvarchar(max) NOT NULL,
        [MiejsceUrodzenia] nvarchar(max) NOT NULL,
        [DataUrodzenia] datetime2 NOT NULL,
        [UrzadSkarbowyId] int NOT NULL,
        CONSTRAINT [PK_Pracownik] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Pracownik_UrzadSkarbowy_UrzadSkarbowyId] FOREIGN KEY ([UrzadSkarbowyId]) REFERENCES [UrzadSkarbowy] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE TABLE [Przedsiebiorstwo] (
        [Id] int NOT NULL IDENTITY,
        [NazwaSkrocona] nvarchar(max) NULL,
        [NazwaPelna] nvarchar(max) NOT NULL,
        [NIP] nvarchar(max) NOT NULL,
        [REGON] nvarchar(max) NOT NULL,
        [daneAdresowe] nvarchar(max) NOT NULL,
        [PowiatGmina] nvarchar(max) NULL,
        [Wojewodztwo] nvarchar(max) NOT NULL,
        [RachunekBankowy] nvarchar(max) NOT NULL,
        [FormaPrawna] int NOT NULL,
        [UrzadSkarbowyId] int NOT NULL,
        [UserId] int NOT NULL,
        CONSTRAINT [PK_Przedsiebiorstwo] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Przedsiebiorstwo_UrzadSkarbowy_UrzadSkarbowyId] FOREIGN KEY ([UrzadSkarbowyId]) REFERENCES [UrzadSkarbowy] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_Przedsiebiorstwo_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [User] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE INDEX [IX_Pracownik_UrzadSkarbowyId] ON [Pracownik] ([UrzadSkarbowyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE INDEX [IX_Przedsiebiorstwo_UrzadSkarbowyId] ON [Przedsiebiorstwo] ([UrzadSkarbowyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    CREATE INDEX [IX_Przedsiebiorstwo_UserId] ON [Przedsiebiorstwo] ([UserId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230630101032_M1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230630101032_M1', N'6.0.16');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230814200025_M2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230814200025_M2', N'6.0.16');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230814213453_M3')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230814213453_M3', N'6.0.16');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    ALTER TABLE [Pracownik] DROP CONSTRAINT [FK_Pracownik_UrzadSkarbowy_UrzadSkarbowyId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    ALTER TABLE [Przedsiebiorstwo] DROP CONSTRAINT [FK_Przedsiebiorstwo_UrzadSkarbowy_UrzadSkarbowyId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    DROP TABLE [UrzadSkarbowy];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    DROP INDEX [IX_Przedsiebiorstwo_UrzadSkarbowyId] ON [Przedsiebiorstwo];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    DROP INDEX [IX_Pracownik_UrzadSkarbowyId] ON [Pracownik];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Przedsiebiorstwo]') AND [c].[name] = N'UrzadSkarbowyId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Przedsiebiorstwo] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Przedsiebiorstwo] DROP COLUMN [UrzadSkarbowyId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230825113158_M4')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230825113158_M4', N'6.0.16');
END;
GO

COMMIT;
GO

