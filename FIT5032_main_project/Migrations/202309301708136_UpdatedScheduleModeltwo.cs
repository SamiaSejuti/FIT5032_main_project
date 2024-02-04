﻿namespace FIT5032_main_project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedScheduleModeltwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedules", "DayOfWeek", c => c.Int(nullable: false));
            DropColumn("dbo.Schedules", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Schedules", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Schedules", "DayOfWeek");
        }
    }
}
