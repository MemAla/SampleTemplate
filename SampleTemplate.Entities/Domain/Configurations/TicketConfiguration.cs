using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SampleTemplate.Entities.Domain
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            #region Propert

            builder.ToTable("Ticket");

            builder.Property(ticket => ticket.Title)
                   .HasColumnName("Title")
                   .HasMaxLength(250)
                   .IsRequired();

            builder.Property(ticket => ticket.Private)
                   .HasColumnName("Private");

            builder.Property(ticket => ticket.Priority)
                   .HasColumnName("Priority");

            builder.Property(ticket => ticket.TicketStatus)
                   .HasColumnName("TicketStatus");

            builder.Property(ticket => ticket.Description)
                   .HasColumnName("Description");

            #endregion

            #region Relation
            //builder
               //.HasMany<TicketEvent>(ticket => ticket.TicketEvents)
               //.WithOne(ticketEvent => ticketEvent.Ticket)
               //.HasForeignKey(ticketEvent => ticketEvent.TicketId)
               //.OnDelete(DeleteBehavior.Cascade);
            #endregion
        }
    }
}
