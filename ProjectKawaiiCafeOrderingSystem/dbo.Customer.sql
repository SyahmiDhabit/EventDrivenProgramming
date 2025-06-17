CREATE TABLE [dbo].[Customer] (
    [cust_ID]         INT    IDENTITY(7,7) NOT NULL,
    [cust_name]       VARCHAR (50) NOT NULL,
    [cust_phone]      VARCHAR (50) NOT NULL,
    [cust_username]   VARCHAR (50) NOT NULL,
    [cust_password]   VARCHAR (50) NOT NULL,
    [cust_membertype] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([cust_ID] ASC)
);

