using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using SG.Model;

namespace SG.Mapping
{
    public class PersonalInfoConfig : EntityTypeConfiguration<PersonalInfo>
    {
        public PersonalInfoConfig()
        {

           HasKey(k => k.PersonalInfoId);

            Property(b => b.Bio)
                .IsOptional()
                .HasMaxLength(250)
                .HasColumnName("Bio");
               
            Property(b => b.PoliticalAffiliation)
               .IsOptional()
               .HasMaxLength(25)
               .HasColumnName("PA");
        
            Property(s => s.SocialSecurityNumber)
                .IsConcurrencyToken();

            Map<PersonalInfo>(m => m.ToTable("PersonalInfo"));

        }
    }
}
