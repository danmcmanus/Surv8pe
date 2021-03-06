namespace SurvApe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class id : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Respondants", "UserID", c => c.String());
            AddColumn("dbo.Surveys", "PollsterID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surveys", "PollsterID");
            DropColumn("dbo.Respondants", "UserID");
        }
    }
}
