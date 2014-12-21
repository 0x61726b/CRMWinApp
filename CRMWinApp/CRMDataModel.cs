namespace CRMWinApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
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

        public virtual DbSet<Models.Criminal> Criminals { get; set; }

        public virtual DbSet<Models.Agency> Agencies { get; set; }

        public virtual DbSet<Models.CrimeType> CrimeTypes { get; set; }

        public virtual DbSet<Models.Charge> Charges { get; set; }

        public virtual DbSet<Models.CiteType> CiteTypes { get; set; }

        public virtual DbSet<Models.Cite> Cites { get; set; }

        public virtual DbSet<Models.Arrest> Arrests { get; set; }

        public virtual DbSet<Models.Cell> Cells { get; set; }

        public virtual DbSet<Models.Jail> Jails { get; set; }

        public virtual DbSet<Models.Outsider> Outsiders { get; set; }

        public virtual DbSet<Models.Meeting> Meetings { get; set; }

        public virtual DbSet<Models.Transfer> Transfers { get; set; }

        public virtual DbSet<Models.Attorney> Attorneys { get; set; }

        public virtual DbSet<Models.Sentence> Sentences { get; set; }


        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(" The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }

        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}