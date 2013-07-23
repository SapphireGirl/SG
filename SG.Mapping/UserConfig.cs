using System;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class UserConfig : EntityTypeConfiguration<User>
    {

        public UserConfig()
        {

          
            HasKey(k => k.UserId);

            Property(p => p.FirstName).HasMaxLength(50);
            Property(p => p.LastName).HasMaxLength(50);
          

            Ignore(f => f.FullName);
            //Date Created
            Property(p => p.DateCreated).
                 HasColumnName("CreationDate").
                HasColumnType("DateTime").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Configuring a 1 to 1 relationship
            HasOptional(i => i.Info).WithRequired(d => d.User);
            
                
   

            Map<User>(m => m.ToTable("Users"));

        }
    }
}
