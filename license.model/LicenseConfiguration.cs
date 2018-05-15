// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace license.model
{

    // License
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public class LicenseConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<License>
    {
        public LicenseConfiguration()
            : this("")
        {
        }

        public LicenseConfiguration(string schema)
        {
            ToTable("License");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uniqueidentifier").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Trn).HasColumnName(@"TRN").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.Type).HasColumnName(@"Type").HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PPV).HasColumnName(@"PPV").HasColumnType("bit");
            Property(x => x.Laden).HasColumnName(@"Laden").HasColumnType("int");
            Property(x => x.Unladen).HasColumnName(@"Unladen").HasColumnType("int");
            Property(x => x.CCRating).HasColumnName(@"CCRating").HasColumnType("int");
            Property(x => x.PhoneNumber).HasColumnName(@"PhoneNumber").HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Depot).HasColumnName(@"Depot").HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.DateCollected).HasColumnName(@"DateCollected").HasColumnType("datetime");
            Property(x => x.DateReceived).HasColumnName(@"DateReceived").HasColumnType("datetime");
            Property(x => x.ExpireDate).HasColumnName(@"ExpireDate").HasColumnType("datetime");
        }
    }

}
// </auto-generated>