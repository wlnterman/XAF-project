using DevExpress.ExpressApp.EFCore.Updating;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EFCore.DesignTime;

namespace MySolution.Module.BusinessObjects;

// This code allows our Model Editor to get relevant EF Core metadata at design time.
// For details, please refer to https://supportcenter.devexpress.com/ticket/details/t933891.
public class MySolutionContextInitializer : DbContextTypesInfoInitializerBase {
	protected override DbContext CreateDbContext() {
		var optionsBuilder = new DbContextOptionsBuilder<MySolutionEFCoreDbContext>()
            .UseSqlServer(";")
            .UseChangeTrackingProxies()
            .UseObjectSpaceLinkProxies();
        return new MySolutionEFCoreDbContext(optionsBuilder.Options);
	}
}
//This factory creates DbContext for design-time services. For example, it is required for database migration.
public class MySolutionDesignTimeDbContextFactory : IDesignTimeDbContextFactory<MySolutionEFCoreDbContext> {
    public MySolutionEFCoreDbContext CreateDbContext(string[] args)
    {
        // Throw new InvalidOperationException ("Make sure that the database connection string and connection provider are correct. After that, uncomment the code below and remove this exception.")
        var optionsBuilder = new DbContextOptionsBuilder<MySolutionEFCoreDbContext>();
        optionsBuilder.UseSqlServer("Integrated Security=SSPI;Pooling=false;Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MySolution");
        //Automatically implements the INotifyPropertyChanged interface in the business objects
        optionsBuilder.UseChangeTrackingProxies();
        optionsBuilder.UseObjectSpaceLinkProxies();
        return new MySolutionEFCoreDbContext(optionsBuilder.Options);
    }
}
[TypesInfoInitializer(typeof(MySolutionContextInitializer))]
public class MySolutionEFCoreDbContext : DbContext {
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DemoTask> DemoTasks { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Note> Notes { get; set; }
    public DbSet<Resume> Resumes { get; set; }
    public DbSet<ReportDataV2> ReportData { get; set; }
    public DbSet<PortfolioFileData> FileAttachments { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<ApplicationUserLoginInfo> UserLoginInfos { get; set; }
    public MySolutionEFCoreDbContext(DbContextOptions<MySolutionEFCoreDbContext> options) : base(options) {
	}
	//public DbSet<ModuleInfo> ModulesInfo { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SetOneToManyAssociationDeleteBehavior(DeleteBehavior.SetNull, DeleteBehavior.Cascade);
        modelBuilder.HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
        modelBuilder.UsePropertyAccessMode(PropertyAccessMode.PreferFieldDuringConstruction);
    }
}
