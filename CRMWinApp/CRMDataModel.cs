namespace CRMWinApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CRMDataModel : DbContext
    {
        // Your context has been configured to use a 'CRMDataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CRMWinApp.CRMDataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CRMDataModel' 
        // connection string in the application configuration file.
        public CRMDataModel()
            : base("name=CRMDataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Models.User> Users { get; set; }
        public virtual DbSet<Models.Permission> Permissions { get; set; }

        public virtual DbSet<Models.AuthLevel_Permission> AuthLevel_Permissions { get; set; }

        public virtual DbSet<Models.Criminal> Criminals { get;set; }

        public virtual DbSet<Models.Agency> Agencies { get;set; }

        public virtual DbSet<Models.CrimeType> CrimeTypes { get;set; }

        public virtual DbSet<Models.Charge> Charges { get;set; }

        public virtual DbSet<Models.CiteType> CiteTypes { get;set; }

        public virtual DbSet<Models.Cite> Cites { get;set; }

        public virtual DbSet<Models.Arrest> Arrests { get;set; }

        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}