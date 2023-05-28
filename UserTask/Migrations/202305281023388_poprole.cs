namespace UserTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poprole : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'61c37f7d-0bc0-4ad3-9905-9a7a6c513042', N'user@task.com', 0, N'AMrwfjYc88acpivyIm0jjAeHDYSeNJ4liCnS+zr4/8gvTpTHbRHUZzprbntfSfTG2Q==', N'324f1557-1dae-4eda-8de1-3867bbf56acc', NULL, 0, 0, NULL, 1, 0, N'user@task.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1e5ad91f-9f77-432d-97a1-aa07ec2249fd', N'CanEditProfile')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dfab1403-b116-4a28-92cf-4bc7af083abc', N'1e5ad91f-9f77-432d-97a1-aa07ec2249fd')
");
        }
        
        public override void Down()
        {
        }
    }
}
