namespace MyFirstMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateNameColumnInMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET Name='Pay as You Go' where Id=1");
            Sql("Update MembershipTypes SET Name='Monthly' where Id=2");
            Sql("Update MembershipTypes SET Name='Quaterly' where Id=3");
            Sql("Update MembershipTypes SET Name='Yearly' where Id=4");

        }
        
        public override void Down()
        {
        }
    }
}
