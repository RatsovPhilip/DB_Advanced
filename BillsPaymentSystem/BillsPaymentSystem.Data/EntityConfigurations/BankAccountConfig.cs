﻿using BillsPaymentSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillsPaymentSystem.Data.EntityConfigurations
{
    public class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {

        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder
                .HasKey(b => b.BankAccountId);

            builder.Property(b => b.Balance)
                .IsRequired();

            builder.Property(bn => bn.BankName)
                .HasMaxLength(50)
                .IsUnicode()
                .IsRequired();

            builder.Property(sc => sc.SwiftCode)
               .HasMaxLength(20)
               .IsRequired();

        }
    }
}
