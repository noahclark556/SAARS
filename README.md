# SAARS
## Security Assessment and Reporting System
## Developed by Noah Clark
### https://qwertycode.org
### Donations at the above URL are very helpful

# Introduction
___

This windows desktop application is intended security / penetration testers. Similar to the mobile "pentest reporter" application found on the above url.
This software allows users to create security assessments with a consistent format. After filling the "new assessment" form. A row will be added to the data grid view.
Each row is viewable/exportable. All the user has to do is right click and select view report. This will open the report in a nicely formatted PDF.

The system allows classification levels to be assigned to each report. As of now, everything is very minimal in this software and has not been styled up to its full potential.
An Azure SQL database is required to use this software, the schema for the database and its table is listed below. 

When your database is set up, head to 'access>DatabaseCredentials.cs' and add your credentials there.

# Requirements
___

This is not a release, meaning it is not compiled into its standalone version. You will need Visual Studio to open and run this software as of now.

# Change Notes
___

### August 31, 2023 @ 8:00 AM (Initial)
- Software provisioned, secured and pushed to github.

# Database Setup
___
Step 1. Create a standard azure sql database named 'saars'

Step 2. Create a table, the name of this table reflects the company name of those generating the reports:
		In this example, the company name is 'qwertyco'.
```
/****** Object:  Table [dbo].[qwertyco]    Script Date: 8/31/2023 7:50:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[qwertyco](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](max) NULL,
	[description] [nvarchar](max) NULL,
	[conducted_date] [nvarchar](50) NULL,
	[reported_date] [nvarchar](50) NULL,
	[conducted_by] [nvarchar](max) NULL,
	[report_data] [nvarchar](max) NULL,
	[classification] [nvarchar](50) NULL,
	[documentSettings] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```

Step 3. Under the access folder, create a static class named 'DatabaseCredentials.cs' in the following format
		Please ensure these values reflect the credentials used to access your database.
```
namespace SAARS.access
{
    public static class DatabaseCredentials
    {
        public static string DataSource = "";
        public static string UserID = "";
        public static string Password = "";
        public static string InitialCatalog = "saars";
    }
}
```

Step 4. Under the access folder, open 'AccessVariables.cs' and set the company name to your table name and the user id to any username of your choice in standard username format.


Step 5. Spin it up and enjoy!
