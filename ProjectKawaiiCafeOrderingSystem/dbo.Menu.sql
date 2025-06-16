CREATE TABLE [dbo].[Menu] (
    [menu_ID]    INT            NOT NULL,
    [menu_name]  VARCHAR (100)   NOT NULL,
    [menu_price] DECIMAL (10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([menu_ID] ASC)
);

