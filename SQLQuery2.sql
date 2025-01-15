-- حذف الجدول إذا كان موجودًا مسبقًا
IF OBJECT_ID('dbo.Books', 'U') IS NOT NULL
DROP TABLE dbo.Books;

-- إنشاء الجدول مع الترقيم التلقائي يبدأ من 1 ويزداد بترتيب
CREATE TABLE [dbo].[Books] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [TITLE]  NVARCHAR (50) NULL,
    [AUTHER] NVARCHAR (50) NULL,
    [CAT]    NVARCHAR (50) NULL,
    [PRICE]  NVARCHAR (50) NULL,
    [BDATE]  DATETIME      NULL,
    [RATE]   INT           NULL,
    [COVER]  IMAGE         NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);