using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using SG.Model;

namespace SG.Mapping
{
    public class PaymentConfig : EntityTypeConfiguration<Payment>
    {
        public PaymentConfig()
        {
            HasKey(k => k.PaymentId);

        }
    }
}
