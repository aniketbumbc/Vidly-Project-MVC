namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'821fc816-b147-42ca-ac81-8fb95d4989ba', N'bunny@domain.com', 0, N'ANCpcMq5Ayl5wXPKhsfl0qgGDwZ8lCgMrYQysfT0fN0eIKk23UYaGfop9e82fHjs3A==', N'625c5ae7-9b86-4511-bbcd-ac0915a16a9b', NULL, 0, 0, NULL, 1, 0, N'bunny@domain.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'daac6e3d-51ba-44b6-948f-38acecddd507', N'admin@vidly.com', 0, N'ALaYkjJairkr+2CSlmrSjCFZ8cOagGgfrA0CHmshClInl4Qm31p17IDttl9QkuU4hA==', N'8c19a88b-ca47-4c02-bba9-089d2cd0d402', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ee2ffe86-2708-4af3-b047-85878e0086c0', N'guest@vidly.com', 0, N'AGtWVZUxM+/pCC9pmIdFl7Caj4OKn3Hfx/DsRlxL+SrwikRJjDvlQG/nn2JRgltwEA==', N'b837c079-40cf-4f4a-a108-134fe25fb28e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'50413117-8950-4254-b7fa-d5b395a7bf00', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'daac6e3d-51ba-44b6-948f-38acecddd507', N'50413117-8950-4254-b7fa-d5b395a7bf00')



");
        }
        
        public override void Down()
        {
        }
    }
}
