namespace BillsPaymentSystem.Data.EntityConfigurations
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PaymentMethodConfig : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .HasOne(u => u.User)
                .WithMany(pm => pm.PaymentMethods)
                .HasForeignKey(u => u.UserId);

            builder.HasOne(cc => cc.CreditCard)
                .WithOne(pm => pm.PaymentMethod)
                .HasForeignKey<PaymentMethod>(cc => cc.CreditCardId);

            builder.HasOne(ba => ba.BankAccount)
                .WithOne(pm => pm.PaymentMethod)
                .HasForeignKey<PaymentMethod>(ba => ba.BankAccountId);

          //  builder.Property(pt => pt.PaymentType).IsRequired();

        }
    }
}
