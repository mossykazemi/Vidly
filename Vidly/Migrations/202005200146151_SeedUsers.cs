namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b05dca5b-adaf-4841-aafa-9713546bdc5a', N'guest@vidly.com', 0, N'AHB2BrY8CThMbbznaHdyu0CLKcZPQ9zFnR58y7PTE6BitfSU9hrLcCi8WtpN2HcREQ==', N'1a712cfa-5e80-4156-88f6-6935bab88bdf', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd731d7b7-b9a3-47b4-a8b7-4b462c476b41', N'admin@vidly.com', 0, N'AP6wFTDtqjAvGLCh/MsbYtnI+Z/f78VJn5KZFNmlrB2ZEYW+Fe7tftm60yq09W77uA==', N'5bfec0ef-2158-437e-81b4-759b51dfed96', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9794182e-fa65-4124-ac16-f25443190ad7', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd731d7b7-b9a3-47b4-a8b7-4b462c476b41', N'9794182e-fa65-4124-ac16-f25443190ad7')

");
        }
        
        public override void Down()
        {
        }
    }
}
