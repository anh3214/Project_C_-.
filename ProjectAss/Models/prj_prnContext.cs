using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjectAss.Models
{
    public partial class prj_prnContext : DbContext
    {
        public prj_prnContext()
        {
        }

        public prj_prnContext(DbContextOptions<prj_prnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<Tblcustomer> Tblcustomers { get; set; }
        public virtual DbSet<Tblemployee> Tblemployees { get; set; }
        public virtual DbSet<TblfoodSize> TblfoodSizes { get; set; }
        public virtual DbSet<Tblorder> Tblorders { get; set; }
        public virtual DbSet<Tblorderdetail> Tblorderdetails { get; set; }
        public virtual DbSet<Tblpayment> Tblpayments { get; set; }
        public virtual DbSet<Tblproduct> Tblproducts { get; set; }
        public virtual DbSet<Tblrating> Tblratings { get; set; }
        public virtual DbSet<Tblsiteinfo> Tblsiteinfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=TUANANH\\TUANANH; database=prj_prn; uid=sa; pwd=123456;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.FoodTypeId)
                    .HasName("PK__tblCateg__B6ACC8D2840F57D5");

                entity.ToTable("tblCategory");

                entity.Property(e => e.FoodTypeId).HasColumnName("food_type_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("type_name");
            });

            modelBuilder.Entity<Tblcustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__tblcusto__CD65CB85554F019C");

                entity.ToTable("tblcustomer");

                entity.HasIndex(e => e.CustomerUsername, "UQ__tblcusto__64E4CB01819B6128")
                    .IsUnique();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_email");

                entity.Property(e => e.CustomerFirstName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("customer_first_name");

                entity.Property(e => e.CustomerLandline)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("customer_landline");

                entity.Property(e => e.CustomerLastName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("customer_last_name");

                entity.Property(e => e.CustomerMiddleName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("customer_middle_name");

                entity.Property(e => e.CustomerPassword)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("customer_password");

                entity.Property(e => e.CustomerPhoneNumber)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("customer_phone_number");

                entity.Property(e => e.CustomerUsername)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("customer_username");
            });

            modelBuilder.Entity<Tblemployee>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblemplo__B9BE370FD004F81A");

                entity.ToTable("tblemployee");

                entity.HasIndex(e => e.Username, "UQ__tblemplo__F3DBC5727AC359FA")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("contact");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("email_address");

                entity.Property(e => e.EmployeeImage)
                    .HasMaxLength(100)
                    .HasColumnName("employee_image");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("full_name");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblfoodSize>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblfood_size");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.FoodPrice).HasColumnName("food_price");

                entity.Property(e => e.FoodSize)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("food_size");

                entity.HasOne(d => d.Food)
                    .WithMany()
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblfood_s__food___38996AB5");
            });

            modelBuilder.Entity<Tblorder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__tblorder__46596229BE5B0323");

                entity.ToTable("tblorder");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("order_status")
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.ProcessedBy).HasColumnName("processed_by");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Tblorders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tblorder_ibfk_2");

                entity.HasOne(d => d.ProcessedByNavigation)
                    .WithMany(p => p.Tblorders)
                    .HasForeignKey(d => d.ProcessedBy)
                    .HasConstraintName("tblorder_ibfk_1");
            });

            modelBuilder.Entity<Tblorderdetail>(entity =>
            {
                entity.HasKey(e => e.OrderDetailsId)
                    .HasName("PK__tblorder__F6FB5AE434AA49F7");

                entity.ToTable("tblorderdetails");

                entity.Property(e => e.OrderDetailsId).HasColumnName("order_details_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.TotalAmount).HasColumnName("total_amount");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.Tblorderdetails)
                    .HasForeignKey(d => d.FoodId)
                    .HasConstraintName("tblorderdetails_ibfk_1");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Tblorderdetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("tblorderdetails_ibfk_2");
            });

            modelBuilder.Entity<Tblpayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__tblpayme__ED1FC9EA22289BC6");

                entity.ToTable("tblpayment");

                entity.Property(e => e.PaymentId).HasColumnName("payment_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PaidBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("paid_by");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("date")
                    .HasColumnName("payment_date");

                entity.Property(e => e.ProcessedBy).HasColumnName("processed_by");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Tblpayments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblpayment_ibfk_2");

                entity.HasOne(d => d.ProcessedByNavigation)
                    .WithMany(p => p.Tblpayments)
                    .HasForeignKey(d => d.ProcessedBy)
                    .HasConstraintName("tblpayment_ibfk_1");
            });

            modelBuilder.Entity<Tblproduct>(entity =>
            {
                entity.HasKey(e => e.FoodId)
                    .HasName("PK__tblprodu__2F4C4DD8748BD74F");

                entity.ToTable("tblproducts");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.FoodCategory)
                    .HasMaxLength(45)
                    .HasColumnName("food_category");

                entity.Property(e => e.FoodDescription)
                    .HasMaxLength(200)
                    .HasColumnName("food_description");

                entity.Property(e => e.FoodImage)
                    .IsRequired()
                    .HasMaxLength(45)
                    .HasColumnName("food_image");

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("food_name");

                entity.Property(e => e.MenuTypeId).HasColumnName("menu_type_id");

                entity.HasOne(d => d.MenuType)
                    .WithMany(p => p.Tblproducts)
                    .HasForeignKey(d => d.MenuTypeId)
                    .HasConstraintName("tblproducts_ibfk_1");
            });

            modelBuilder.Entity<Tblrating>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__tblratin__D35B278BD29DA55E");

                entity.ToTable("tblrating");

                entity.Property(e => e.RatingId).HasColumnName("rating_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateRecorded)
                    .HasColumnType("date")
                    .HasColumnName("date_recorded");

                entity.Property(e => e.FoodId).HasColumnName("food_id");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("remarks");

                entity.Property(e => e.Score).HasColumnName("score");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Tblratings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("tblrating_ibfk_2");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.Tblratings)
                    .HasForeignKey(d => d.FoodId)
                    .HasConstraintName("tblrating_ibfk_1");
            });

            modelBuilder.Entity<Tblsiteinfo>(entity =>
            {
                entity.HasKey(e => e.SiteInfoId)
                    .HasName("PK__tblsitei__866ED2E4FF7B9987");

                entity.ToTable("tblsiteinfo");

                entity.Property(e => e.SiteInfoId).HasColumnName("site_info_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.ContactInfo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("contact_info");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("description");

                entity.Property(e => e.LastUpdate)
                    .HasColumnType("date")
                    .HasColumnName("last_update");

                entity.Property(e => e.SiteName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("site_name");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tblsiteinfos)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("tblsiteinfo_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
