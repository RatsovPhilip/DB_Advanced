namespace BillsPaymentSystem.Data.EntityConfigurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    public class CreditCardConfig : IEntityTypeConfiguration<CreditCard>
    {
        public void Configure(EntityTypeBuilder<CreditCard> builder)
        {
            builder.HasKey(cc => cc.CreditCardId);

            builder.Property(l => l.Limit)
                .IsRequired();

            builder.Property(mo => mo.MoneyOwned)
                .IsRequired();

            builder.Ignore(ll => ll.LimitLeft);

            builder.Property(ed => ed.ExpirationDate)
                .IsRequired();
        }
    }
}
