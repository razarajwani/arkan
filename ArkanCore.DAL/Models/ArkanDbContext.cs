using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ArkkanCore.DAL.Models
{
    public partial class ArkanDbContext : DbContext
    {
        public ArkanDbContext()
        {
        }

        public ArkanDbContext(DbContextOptions<ArkanDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbsentExamMa> AbsentExamMas { get; set; }
        public virtual DbSet<AbsentMa> AbsentMas { get; set; }
        public virtual DbSet<AllCourse> AllCourses { get; set; }
        public virtual DbSet<AllReleation> AllReleations { get; set; }
        public virtual DbSet<AmanaCard> AmanaCards { get; set; }
        public virtual DbSet<AnswerMa> AnswerMas { get; set; }
        public virtual DbSet<BadalFaeedMa> BadalFaeedMas { get; set; }
        public virtual DbSet<BaladyaMa> BaladyaMas { get; set; }
        public virtual DbSet<BankMa> BankMas { get; set; }
        public virtual DbSet<BranchMa> BranchMas { get; set; }
        public virtual DbSet<CardsDeductMa> CardsDeductMas { get; set; }
        public virtual DbSet<CertifTypeMa> CertifTypeMas { get; set; }
        public virtual DbSet<CertificateHma> CertificateHmas { get; set; }
        public virtual DbSet<CertificateTma> CertificateTmas { get; set; }
        public virtual DbSet<ChangeIdlog> ChangeIdlogs { get; set; }
        public virtual DbSet<CompanyMa> CompanyMas { get; set; }
        public virtual DbSet<CompanyMap> CompanyMaps { get; set; }
        public virtual DbSet<ConstMa> ConstMas { get; set; }
        public virtual DbSet<CourseDegreeMa> CourseDegreeMas { get; set; }
        public virtual DbSet<CourseDegreeMas1417> CourseDegreeMas1417s { get; set; }
        public virtual DbSet<CourseLangMa> CourseLangMas { get; set; }
        public virtual DbSet<CourseMa> CourseMas { get; set; }
        public virtual DbSet<CourseMoveMa> CourseMoveMas { get; set; }
        public virtual DbSet<CourseStudentMa> CourseStudentMas { get; set; }
        public virtual DbSet<CourseStudentMas180114> CourseStudentMas180114s { get; set; }
        public virtual DbSet<CourseStudentMas716> CourseStudentMas716s { get; set; }
        public virtual DbSet<CourseTransLogMa> CourseTransLogMas { get; set; }
        public virtual DbSet<CustodyCancelMa> CustodyCancelMas { get; set; }
        public virtual DbSet<CustodyMa> CustodyMas { get; set; }
        public virtual DbSet<DateTable> DateTables { get; set; }
        public virtual DbSet<DepMa> DepMas { get; set; }
        public virtual DbSet<EmpMa> EmpMas { get; set; }
        public virtual DbSet<EssamStud> EssamStuds { get; set; }
        public virtual DbSet<ExamDegree> ExamDegrees { get; set; }
        public virtual DbSet<FieldsMa> FieldsMas { get; set; }
        public virtual DbSet<Hcrefused> Hcrefuseds { get; set; }
        public virtual DbSet<HealthCard> HealthCards { get; set; }
        public virtual DbSet<HealthResultMa> HealthResultMas { get; set; }
        public virtual DbSet<HisHospitalMa> HisHospitalMas { get; set; }
        public virtual DbSet<HistCourseStudentMa> HistCourseStudentMas { get; set; }
        public virtual DbSet<HistHealthResultMa> HistHealthResultMas { get; set; }
        public virtual DbSet<HistoryDataMa> HistoryDataMas { get; set; }
        public virtual DbSet<HospResUpdateLog> HospResUpdateLogs { get; set; }
        public virtual DbSet<HospitalCheckMa> HospitalCheckMas { get; set; }
        public virtual DbSet<HospitalMa> HospitalMas { get; set; }
        public virtual DbSet<HospitalRechargeOnLine> HospitalRechargeOnLines { get; set; }
        public virtual DbSet<HospitalTransMa> HospitalTransMas { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<ImageExist> ImageExists { get; set; }
        public virtual DbSet<InboxMsg> InboxMsgs { get; set; }
        public virtual DbSet<IncomeExam> IncomeExams { get; set; }
        public virtual DbSet<ItTypeMa> ItTypeMas { get; set; }
        public virtual DbSet<JobMa> JobMas { get; set; }
        public virtual DbSet<JobTypeMa> JobTypeMas { get; set; }
        public virtual DbSet<LevelMa> LevelMas { get; set; }
        public virtual DbSet<MenuMa> MenuMas { get; set; }
        public virtual DbSet<Menumas171231> Menumas171231s { get; set; }
        public virtual DbSet<Menumas180107> Menumas180107s { get; set; }
        public virtual DbSet<ModuleMa> ModuleMas { get; set; }
        public virtual DbSet<ModulePermMa> ModulePermMas { get; set; }
        public virtual DbSet<MonthMa> MonthMas { get; set; }
        public virtual DbSet<NatMa> NatMas { get; set; }
        public virtual DbSet<NewCert> NewCerts { get; set; }
        public virtual DbSet<OnlineInsert> OnlineInserts { get; set; }
        public virtual DbSet<Perm180801Error> Perm180801Errors { get; set; }
        public virtual DbSet<Permma> Permmas { get; set; }
        public virtual DbSet<Permmas180627> Permmas180627s { get; set; }
        public virtual DbSet<QbankMa> QbankMas { get; set; }
        public virtual DbSet<RangeTimeMa> RangeTimeMas { get; set; }
        public virtual DbSet<ReExamDetail> ReExamDetails { get; set; }
        public virtual DbSet<ReExamMa> ReExamMas { get; set; }
        public virtual DbSet<RegionMa> RegionMas { get; set; }
        public virtual DbSet<RevenueDetail> RevenueDetails { get; set; }
        public virtual DbSet<RoomMa> RoomMas { get; set; }
        public virtual DbSet<Search> Searches { get; set; }
        public virtual DbSet<SessionUser> SessionUsers { get; set; }
        public virtual DbSet<Setma> Setmas { get; set; }
        public virtual DbSet<SqlMa> SqlMas { get; set; }
        public virtual DbSet<Ssqlinjection> Ssqlinjections { get; set; }
        public virtual DbSet<StopCard> StopCards { get; set; }
        public virtual DbSet<Stud> Studs { get; set; }
        public virtual DbSet<StudImage> StudImages { get; set; }
        public virtual DbSet<StudImages2> StudImages2s { get; set; }
        public virtual DbSet<StudentMa> StudentMas { get; set; }
        public virtual DbSet<StudentMas01072020> StudentMas01072020s { get; set; }
        public virtual DbSet<StudentTransMa> StudentTransMas { get; set; }
        public virtual DbSet<Studhavefineview> Studhavefineviews { get; set; }
        public virtual DbSet<SubjectMa> SubjectMas { get; set; }
        public virtual DbSet<TableConstraint> TableConstraints { get; set; }
        public virtual DbSet<TermsMa> TermsMas { get; set; }
        public virtual DbSet<TimeMa> TimeMas { get; set; }
        public virtual DbSet<TrainingRecharg> TrainingRechargs { get; set; }
        public virtual DbSet<TransStudentFbranch> TransStudentFbranches { get; set; }
        public virtual DbSet<TryLogin> TryLogins { get; set; }
        public virtual DbSet<UserGroupMa> UserGroupMas { get; set; }
        public virtual DbSet<UserMa> UserMas { get; set; }
        public virtual DbSet<VoucherMa> VoucherMas { get; set; }
        public virtual DbSet<VwHospitalBal> VwHospitalBals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=CodeWithRaza;Database=Arkkannew; uid=SA; password=321301;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Arabic_CI_AS");

            modelBuilder.Entity<AbsentExamMa>(entity =>
            {
                entity.HasKey(e => e.AbsentExamCode)
                    .HasName("PK_AbsentExamMas_1");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<AbsentMa>(entity =>
            {
                entity.HasKey(e => new { e.Absentcode, e.BranchCode })
                    .HasName("pk_AbsentMas");

                entity.Property(e => e.Absentcode).HasColumnName("absentcode");

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.Absentdate).HasColumnName("absentdate");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Studentcode).HasColumnName("studentcode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<AllCourse>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CourseNmA).HasMaxLength(200);

                entity.Property(e => e.CourselangCode).HasColumnName("courselangCode");

                entity.Property(e => e.LevelCode).HasColumnName("levelCode");

                entity.Property(e => e.NewCourse).HasColumnName("newCourse");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<AllReleation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllReleations");

                entity.Property(e => e.Constraints)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MasterTable)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmanaCard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Expire).HasColumnName("expire");

                entity.Property(e => e.Id)
                    .HasMaxLength(20)
                    .HasColumnName("id");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<AnswerMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AnswerNmA)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.QbankCode).HasColumnName("QBankCode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<BadalFaeedMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BadalFaeedCode).ValueGeneratedOnAdd();

                entity.Property(e => e.CertificateHcode).HasColumnName("CertificateHCode");

                entity.Property(e => e.EmpCode).HasColumnName("empCode");

                entity.Property(e => e.HealthResultDate).HasDefaultValueSql("(CONVERT([char](8),getdate(),(112)))");

                entity.Property(e => e.SadadNo)
                    .HasMaxLength(25)
                    .HasColumnName("SadadNO");

                entity.Property(e => e.StampDatetTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([char],getdate(),(112)))");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<BaladyaMa>(entity =>
            {
                entity.HasKey(e => new { e.BaladyaCode, e.BranchCode });

                entity.Property(e => e.BaladyaNmA).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.BaladyaMas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BaladyaMas_BranchMas");
            });

            modelBuilder.Entity<BankMa>(entity =>
            {
                entity.HasKey(e => e.BankCode);

                entity.Property(e => e.BankCode).ValueGeneratedNever();

                entity.Property(e => e.BankNmA).HasMaxLength(150);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<BranchMa>(entity =>
            {
                entity.HasKey(e => e.BranchCode);

                entity.Property(e => e.BranchCode).ValueGeneratedNever();

                entity.Property(e => e.BranchNmA).HasMaxLength(50);

                entity.Property(e => e.Remainder)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("remainder");

                entity.Property(e => e.ReprintValue).HasColumnName("reprintValue");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CardsDeductMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.DeductReason).HasMaxLength(300);

                entity.Property(e => e.HospitalCode).HasColumnName("hospitalCode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CertifTypeMa>(entity =>
            {
                entity.HasKey(e => e.CertifTypeCode);

                entity.Property(e => e.CertifTypeCode).ValueGeneratedNever();

                entity.Property(e => e.CertifTypeNmA).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CertificateHma>(entity =>
            {
                entity.HasKey(e => e.CertificateHcode);

                entity.ToTable("CertificateHMas");

                entity.Property(e => e.CertificateHcode).HasColumnName("CertificateHCode");

                entity.Property(e => e.Act).HasColumnName("act");

                entity.Property(e => e.BadelSadadNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.CancelSadadNo).HasMaxLength(25);

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DelExpireDate).HasColumnName("delExpireDate");

                entity.Property(e => e.DelExpireDateH).HasColumnName("delExpireDateH");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.FineStopReason).HasMaxLength(300);

                entity.Property(e => e.HospitalCode).HasColumnName("hospitalCode");

                entity.Property(e => e.PaidNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Printdate).HasColumnName("printdate");

                entity.Property(e => e.SadadType).HasComment("1- Asdar 2- badelfaad 3- ghrama  ");

                entity.Property(e => e.StopDate).HasMaxLength(20);

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CertificateHmas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateHMas_BranchMas");
            });

            modelBuilder.Entity<CertificateTma>(entity =>
            {
                entity.HasKey(e => e.CertificateTcode);

                entity.ToTable("CertificateTMas");

                entity.Property(e => e.CertificateTcode).HasColumnName("CertificateTCode");

                entity.Property(e => e.Bnm)
                    .HasMaxLength(10)
                    .HasColumnName("bnm,/")
                    .IsFixedLength(true);

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.StampDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CertificateTmas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CertificateTMas_BranchMas");
            });

            modelBuilder.Entity<ChangeIdlog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChangeIDLog");

                entity.Property(e => e.ChangeIdLogCode).ValueGeneratedOnAdd();

                entity.Property(e => e.Idnew)
                    .HasMaxLength(20)
                    .HasColumnName("IDNew");

                entity.Property(e => e.Idold)
                    .HasMaxLength(20)
                    .HasColumnName("IDOld");

                entity.Property(e => e.IdtypeNew).HasColumnName("IDTypeNew");

                entity.Property(e => e.Idtypeold).HasColumnName("IDtypeold");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CompanyMa>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.BranchCode });

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.CompanyNmA).HasMaxLength(150);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CompanyMas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyMas_BranchMas");
            });

            modelBuilder.Entity<CompanyMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CompanyMap");

                entity.Property(e => e.CompanyNmA)
                    .HasMaxLength(150)
                    .HasColumnName("companyNmA");

                entity.Property(e => e.NewCode).HasColumnName("newCode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ConstMa>(entity =>
            {
                entity.HasKey(e => new { e.Typ, e.ConstCode });

                entity.Property(e => e.Typ).HasColumnName("typ");

                entity.Property(e => e.ConstCode).HasColumnName("constCode");

                entity.Property(e => e.ConstNmA)
                    .HasMaxLength(50)
                    .HasColumnName("constNmA");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CourseDegreeMa>(entity =>
            {
                entity.HasKey(e => new { e.CourseDegreecode, e.BranchCode })
                    .HasName("PK_CourseDegreeMas_1");

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardPrinted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Studentcode).HasColumnName("studentcode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CourseDegreeMas1417>(entity =>
            {
                entity.HasKey(e => new { e.CourseDegreecode, e.BranchCode })
                    .HasName("pk_CourseDegreeMas");

                entity.ToTable("CourseDegreeMas_14-17");

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Studentcode).HasColumnName("studentcode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CourseLangMa>(entity =>
            {
                entity.HasKey(e => e.CourseLangCode)
                    .HasName("PK_CourseLangMas_1");

                entity.Property(e => e.CourseLangCode).ValueGeneratedNever();

                entity.Property(e => e.CourseLangNmA).HasMaxLength(50);

                entity.Property(e => e.CourselangNmE)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CourseMa>(entity =>
            {
                entity.HasKey(e => new { e.CourseCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CourseDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CourseNmA).HasMaxLength(50);

                entity.Property(e => e.CourseNmE).HasMaxLength(150);

                entity.Property(e => e.Courseno1).HasColumnName("[courseno1]");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Daywork).HasColumnName("daywork");

                entity.Property(e => e.DepCode).HasColumnName("depCode");

                entity.Property(e => e.Hours).HasColumnName("hours");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.CourseMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseMas_BranchMas");
            });

            modelBuilder.Entity<CourseMoveMa>(entity =>
            {
                entity.HasKey(e => new { e.CourseMoveCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.CourseCode).HasColumnName("courseCode");

                entity.Property(e => e.Depcode).HasColumnName("depcode");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.EnddateH).HasColumnName("enddateH");

                entity.Property(e => e.LevelCode).HasDefaultValueSql("((1))");

                entity.Property(e => e.RoomCode).HasColumnName("roomCode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.CourseMoveMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseMoveMas_BranchMas");

                entity.HasOne(d => d.CourseMa)
                    .WithMany(p => p.CourseMoveMas)
                    .HasForeignKey(d => new { d.CourseCode, d.Branchcode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseMoveMas_CourseMas");

                entity.HasOne(d => d.RoomMa)
                    .WithMany(p => p.CourseMoveMas)
                    .HasForeignKey(d => new { d.RoomCode, d.Branchcode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseMoveMas_RoomMas");

                entity.HasOne(d => d.EmpMa)
                    .WithMany(p => p.CourseMoveMas)
                    .HasForeignKey(d => new { d.TeacherCode, d.Branchcode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseMoveMas_EmpMas");
            });

            modelBuilder.Entity<CourseStudentMa>(entity =>
            {
                entity.HasKey(e => new { e.CourseStudentCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.AbortDate).HasColumnName("abortDate");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CompVatFile).HasMaxLength(50);

                entity.Property(e => e.CourselangCode).HasColumnName("courselangCode");

                entity.Property(e => e.Depcode).HasColumnName("depcode");

                entity.Property(e => e.Getdatetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Oldvoucher).HasColumnName("oldvoucher");

                entity.Property(e => e.RandomPass).HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.Reprint).HasColumnName("reprint");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.TaxValue).HasColumnName("taxValue");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.CourseMoveMa)
                    .WithMany(p => p.CourseStudentMas)
                    .HasForeignKey(d => new { d.CourseMoveCode, d.Branchcode })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseStudentMas_CourseMoveMas");
            });

            modelBuilder.Entity<CourseStudentMas180114>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CourseStudentMas180114");

                entity.Property(e => e.AbortDate).HasColumnName("abortDate");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.CourselangCode).HasColumnName("courselangCode");

                entity.Property(e => e.Depcode).HasColumnName("depcode");

                entity.Property(e => e.Getdatetime).HasColumnType("datetime");

                entity.Property(e => e.Oldvoucher).HasColumnName("oldvoucher");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.Reprint).HasColumnName("reprint");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.TaxValue).HasColumnName("taxValue");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CourseStudentMas716>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CourseStudentMas716", "tmp");

                entity.Property(e => e.AbortDate).HasColumnName("abortDate");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.CompVatFile).HasMaxLength(50);

                entity.Property(e => e.CourselangCode).HasColumnName("courselangCode");

                entity.Property(e => e.Depcode).HasColumnName("depcode");

                entity.Property(e => e.Getdatetime).HasColumnType("datetime");

                entity.Property(e => e.Oldvoucher).HasColumnName("oldvoucher");

                entity.Property(e => e.RandomPass).HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.Reprint).HasColumnName("reprint");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Tax).HasColumnName("tax");

                entity.Property(e => e.TaxValue).HasColumnName("taxValue");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CourseTransLogMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.ToCourseMove).HasColumnName("toCourseMove");
            });

            modelBuilder.Entity<CustodyCancelMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Empcode).HasColumnName("empcode");

                entity.Property(e => e.LastNo).HasColumnName("lastNo");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<CustodyMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Empcode).HasColumnName("empcode");

                entity.Property(e => e.LastNo).HasColumnName("lastNo");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<DateTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DateTable");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.Hdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("HDate")
                    .IsFixedLength(true);

                entity.Property(e => e.Mdate)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SNo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("S_No")
                    .IsFixedLength(true);

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<DepMa>(entity =>
            {
                entity.HasKey(e => e.DepCode);

                entity.ToTable("depMas");

                entity.Property(e => e.DepCode)
                    .ValueGeneratedNever()
                    .HasColumnName("depCode");

                entity.Property(e => e.DepNmA)
                    .HasMaxLength(150)
                    .HasColumnName("depNmA");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<EmpMa>(entity =>
            {
                entity.HasKey(e => new { e.EmpCode, e.BranchCode });

                entity.Property(e => e.DepCode).HasColumnName("depCode");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.EmpNmA).HasMaxLength(150);

                entity.Property(e => e.EmpNmE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(25)
                    .HasColumnName("mobile");

                entity.Property(e => e.Tel)
                    .HasMaxLength(25)
                    .HasColumnName("tel");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.EmpMas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmpMas_BranchMas");

                entity.HasOne(d => d.CertifTypeCodeNavigation)
                    .WithMany(p => p.EmpMas)
                    .HasForeignKey(d => d.CertifTypeCode)
                    .HasConstraintName("FK_EmpMas_CertifTypeMas");

                entity.HasOne(d => d.ItTypeCodeNavigation)
                    .WithMany(p => p.EmpMas)
                    .HasForeignKey(d => d.ItTypeCode)
                    .HasConstraintName("FK_EmpMas_ItTypeMas");

                entity.HasOne(d => d.NatCodeNavigation)
                    .WithMany(p => p.EmpMas)
                    .HasForeignKey(d => d.NatCode)
                    .HasConstraintName("FK_EmpMas_NatMas");
            });

            modelBuilder.Entity<EssamStud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EssamStud");

                entity.Property(e => e.NewCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("newCode");
            });

            modelBuilder.Entity<ExamDegree>(entity =>
            {
                entity.HasKey(e => e.ExamDegree1);

                entity.ToTable("ExamDegree");

                entity.Property(e => e.ExamDegree1).HasColumnName("ExamDegree");

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<FieldsMa>(entity =>
            {
                entity.HasKey(e => e.Fieldname);

                entity.Property(e => e.Fieldname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fieldname");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<Hcrefused>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HCRefused");

                entity.Property(e => e.HcrefusedCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("HCRefusedCode");

                entity.Property(e => e.ReasonOfRejection)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<HealthCard>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateHcode).HasColumnName("CertificateHCode");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.HospitalCode).HasColumnName("hospitalCode");

                entity.Property(e => e.IdType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Idno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("idno");

                entity.Property(e => e.StudentNmA)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthResultMa>(entity =>
            {
                entity.HasKey(e => new { e.HealthResultCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.HealthType).HasMaxLength(1);

                entity.Property(e => e.HospitalCode).HasColumnName("hospitalCode");

                entity.Property(e => e.LabNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.OldUser2).HasColumnName("oldUser2");

                entity.Property(e => e.RefuseReason).HasMaxLength(200);

                entity.Property(e => e.SadadNo).HasColumnName("SadadNO");

                entity.Property(e => e.StmpDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Suitable).HasColumnName("suitable");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.HealthResultMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HealthResultMas_BranchMas");
            });

            modelBuilder.Entity<HisHospitalMa>(entity =>
            {
                entity.HasKey(e => e.HisId);

                entity.Property(e => e.HisId).HasColumnName("HisID");

                entity.Property(e => e.DatTime).HasColumnType("datetime");

                entity.Property(e => e.HospitalNmA).HasMaxLength(50);

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.TransType).HasMaxLength(50);
            });

            modelBuilder.Entity<HistCourseStudentMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.CourselangCode).HasColumnName("courselangCode");

                entity.Property(e => e.Depcode).HasColumnName("depcode");

                entity.Property(e => e.MoveSerial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("moveSerial");

                entity.Property(e => e.Movecode).HasColumnName("movecode");

                entity.Property(e => e.Movetime)
                    .HasColumnType("datetime")
                    .HasColumnName("movetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Movetype).HasColumnName("movetype");

                entity.Property(e => e.Reason).HasMaxLength(200);

                entity.Property(e => e.Reprint).HasColumnName("reprint");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<HistHealthResultMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.HospitalCode).HasColumnName("hospitalCode");

                entity.Property(e => e.LabNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MoveSerial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("moveSerial");

                entity.Property(e => e.Movecode).HasColumnName("movecode");

                entity.Property(e => e.Movetime)
                    .HasColumnType("datetime")
                    .HasColumnName("movetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Movetype).HasColumnName("movetype");

                entity.Property(e => e.RefuseReason).HasMaxLength(200);

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Suitable).HasColumnName("suitable");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<HistoryDataMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.HistorySerial).ValueGeneratedOnAdd();

                entity.Property(e => e.MoveCode).HasColumnName("moveCode");

                entity.Property(e => e.Movetime)
                    .HasColumnType("datetime")
                    .HasColumnName("movetime");

                entity.Property(e => e.Movetype).HasColumnName("movetype");

                entity.Property(e => e.TableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tableName");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<HospResUpdateLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HospResUpdateLog");

                entity.Property(e => e.HospReslogCode).ValueGeneratedOnAdd();

                entity.Property(e => e.Reson).HasMaxLength(100);

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");
            });

            modelBuilder.Entity<HospitalCheckMa>(entity =>
            {
                entity.HasKey(e => new { e.HospitalCheckCode, e.BranchCode });

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.BankCode).HasColumnName("bankCode");

                entity.Property(e => e.CheckNo).HasMaxLength(50);

                entity.Property(e => e.HcardCount).HasColumnName("HCardCount");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.HospitalCheckMas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalCheckMas_BranchMas");
            });

            modelBuilder.Entity<HospitalMa>(entity =>
            {
                entity.HasKey(e => new { e.HospitalCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.ActiveSadad).HasDefaultValueSql("((0))");

                entity.Property(e => e.CardBal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cr)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("CR");

                entity.Property(e => e.ExpDateCr).HasColumnName("ExpDateCR");

                entity.Property(e => e.HospitalNmA).HasMaxLength(50);

                entity.Property(e => e.Mail)
                    .HasMaxLength(100)
                    .HasColumnName("mail");

                entity.Property(e => e.MedicalNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .HasColumnName("mobile");

                entity.Property(e => e.MossasaNum).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.HospitalMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalMas_BranchMas");
            });

            modelBuilder.Entity<HospitalRechargeOnLine>(entity =>
            {
                entity.HasKey(e => e.RechargeOnLineId);

                entity.ToTable("HospitalRechargeOnLine");

                entity.Property(e => e.RechargeOnLineId).HasColumnName("RechargeOnLineID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Done).HasDefaultValueSql("((0))");

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.SadadNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<HospitalTransMa>(entity =>
            {
                entity.HasKey(e => new { e.HospitalTransCode, e.BranchCode });

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Studentcode).HasColumnName("studentcode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.HospitalTransMas)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HospitalTransMas_BranchMas");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ImgSerial).HasColumnName("imgSerial");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ImageExist>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ImageTyp).HasColumnName("imageTyp");

                entity.Property(e => e.Level1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NewPath)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("newPath");

                entity.Property(e => e.OldPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InboxMsg>(entity =>
            {
                entity.HasKey(e => e.InBoxId);

                entity.ToTable("InboxMsg");

                entity.Property(e => e.InBoxId).HasColumnName("InBoxID");

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .HasColumnName("msg");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<IncomeExam>(entity =>
            {
                entity.HasKey(e => e.IncomeExamCode);

                entity.ToTable("IncomeExam");

                entity.Property(e => e.CancelReason).HasMaxLength(200);

                entity.Property(e => e.Reprint).HasColumnName("reprint");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ItTypeMa>(entity =>
            {
                entity.HasKey(e => e.ItTypeCode);

                entity.Property(e => e.ItTypeCode).ValueGeneratedNever();

                entity.Property(e => e.ItTypeNmA).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<JobMa>(entity =>
            {
                entity.HasKey(e => e.JobCode);

                entity.Property(e => e.JobCode).ValueGeneratedNever();

                entity.Property(e => e.JobNmA).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<JobTypeMa>(entity =>
            {
                entity.HasKey(e => e.JobTypeCode);

                entity.Property(e => e.JobTypeCode).ValueGeneratedNever();

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasColumnName("color");

                entity.Property(e => e.JobTypeNmA).HasMaxLength(150);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<LevelMa>(entity =>
            {
                entity.HasKey(e => e.LevelCode);

                entity.Property(e => e.LevelCode).ValueGeneratedNever();

                entity.Property(e => e.LevelNmA).HasMaxLength(150);

                entity.Property(e => e.LevelNmE)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("levelNmE");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<MenuMa>(entity =>
            {
                entity.HasKey(e => new { e.ModuleCode, e.Menuvalue });

                entity.Property(e => e.Menuvalue)
                    .HasMaxLength(50)
                    .HasColumnName("menuvalue");

                entity.Property(e => e.BetweenDate).HasMaxLength(100);

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.BtnRemove).HasColumnName("btnRemove");

                entity.Property(e => e.Btnaddview).HasColumnName("btnaddview");

                entity.Property(e => e.CapOfForm).HasMaxLength(50);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DrillDownCap).HasMaxLength(50);

                entity.Property(e => e.DrillDownField).HasMaxLength(100);

                entity.Property(e => e.GroupFnma)
                    .HasMaxLength(50)
                    .HasColumnName("GroupFNma");

                entity.Property(e => e.LinkAdd).HasMaxLength(100);

                entity.Property(e => e.Linkpage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("linkpage");

                entity.Property(e => e.Main)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("main");

                entity.Property(e => e.Mainsql).HasColumnName("mainsql");

                entity.Property(e => e.Menuorder).HasColumnName("menuorder");

                entity.Property(e => e.Menutext)
                    .HasMaxLength(1000)
                    .HasColumnName("menutext");

                entity.Property(e => e.Orederfield)
                    .HasMaxLength(50)
                    .HasColumnName("orederfield");

                entity.Property(e => e.Parameter1).HasMaxLength(50);

                entity.Property(e => e.Pkfield)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pkfield");

                entity.Property(e => e.RecordByPage).HasDefaultValueSql("((25))");

                entity.Property(e => e.RepId).HasColumnName("RepID");

                entity.Property(e => e.SumField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tablename)
                    .HasMaxLength(50)
                    .HasColumnName("tablename");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.ModuleCodeNavigation)
                    .WithMany(p => p.MenuMas)
                    .HasForeignKey(d => d.ModuleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuMas_ModuleMas");
            });

            modelBuilder.Entity<Menumas171231>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menumas171231");

                entity.Property(e => e.BetweenDate).HasMaxLength(100);

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.BtnRemove).HasColumnName("btnRemove");

                entity.Property(e => e.Btnaddview).HasColumnName("btnaddview");

                entity.Property(e => e.CapOfForm).HasMaxLength(50);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DrillDownCap).HasMaxLength(50);

                entity.Property(e => e.DrillDownField).HasMaxLength(100);

                entity.Property(e => e.GroupFnma)
                    .HasMaxLength(50)
                    .HasColumnName("GroupFNma");

                entity.Property(e => e.LinkAdd).HasMaxLength(100);

                entity.Property(e => e.Linkpage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("linkpage");

                entity.Property(e => e.Main)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("main");

                entity.Property(e => e.Mainsql)
                    .HasMaxLength(2600)
                    .HasColumnName("mainsql");

                entity.Property(e => e.Menuorder).HasColumnName("menuorder");

                entity.Property(e => e.Menutext)
                    .HasMaxLength(1000)
                    .HasColumnName("menutext");

                entity.Property(e => e.Menuvalue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("menuvalue");

                entity.Property(e => e.Orederfield)
                    .HasMaxLength(50)
                    .HasColumnName("orederfield");

                entity.Property(e => e.Parameter1).HasMaxLength(50);

                entity.Property(e => e.Pkfield)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pkfield");

                entity.Property(e => e.RepId).HasColumnName("RepID");

                entity.Property(e => e.SumField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tablename)
                    .HasMaxLength(50)
                    .HasColumnName("tablename");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<Menumas180107>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Menumas_180107");

                entity.Property(e => e.BetweenDate).HasMaxLength(100);

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.BtnRemove).HasColumnName("btnRemove");

                entity.Property(e => e.Btnaddview).HasColumnName("btnaddview");

                entity.Property(e => e.CapOfForm).HasMaxLength(50);

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.DrillDownCap).HasMaxLength(50);

                entity.Property(e => e.DrillDownField).HasMaxLength(100);

                entity.Property(e => e.GroupFnma)
                    .HasMaxLength(50)
                    .HasColumnName("GroupFNma");

                entity.Property(e => e.LinkAdd).HasMaxLength(100);

                entity.Property(e => e.Linkpage)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("linkpage");

                entity.Property(e => e.Main)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("main");

                entity.Property(e => e.Mainsql)
                    .HasMaxLength(2600)
                    .HasColumnName("mainsql");

                entity.Property(e => e.Menuorder).HasColumnName("menuorder");

                entity.Property(e => e.Menutext)
                    .HasMaxLength(1000)
                    .HasColumnName("menutext");

                entity.Property(e => e.Menuvalue)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("menuvalue");

                entity.Property(e => e.Orederfield)
                    .HasMaxLength(50)
                    .HasColumnName("orederfield");

                entity.Property(e => e.Parameter1).HasMaxLength(50);

                entity.Property(e => e.Pkfield)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("pkfield");

                entity.Property(e => e.RepId).HasColumnName("RepID");

                entity.Property(e => e.SumField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Tablename)
                    .HasMaxLength(50)
                    .HasColumnName("tablename");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ModuleMa>(entity =>
            {
                entity.HasKey(e => e.ModuleCode);

                entity.Property(e => e.ModuleCode).ValueGeneratedNever();

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.MenuOrder).HasColumnName("menuOrder");

                entity.Property(e => e.ModuleNmA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ModulePermMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<MonthMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.MonthNma)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MonthNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<NatMa>(entity =>
            {
                entity.HasKey(e => e.NatCode);

                entity.Property(e => e.NatCode).ValueGeneratedNever();

                entity.Property(e => e.NatNmA).HasMaxLength(50);

                entity.Property(e => e.NatNmE).HasMaxLength(150);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<NewCert>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("newCert");

                entity.Property(e => e.OldDate).HasColumnName("oldDate");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.Studentcode).HasColumnName("studentcode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<OnlineInsert>(entity =>
            {
                entity.HasKey(e => e.OnLineCode);

                entity.ToTable("OnlineInsert");

                entity.Property(e => e.OnLineCode).HasColumnName("onLineCode");

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("IDno");

                entity.Property(e => e.IqamaJob)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StampDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StudentNma)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("StudentNMA");

                entity.Property(e => e.StudentNme)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("StudentNME");
            });

            modelBuilder.Entity<Perm180801Error>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("perm180801_error");

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.MenuValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<Permma>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("permmas");

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.MenuValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<Permmas180627>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("permmas_180627");

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.MenuValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<QbankMa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("QBankMas");

                entity.Property(e => e.QbankCode).HasColumnName("QBankCode");

                entity.Property(e => e.QbankNmA)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("QBankNmA");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<RangeTimeMa>(entity =>
            {
                entity.HasKey(e => e.RangeTimeCode);

                entity.Property(e => e.RangeTimeCode).ValueGeneratedNever();

                entity.Property(e => e.RangeTimeNmA).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ReExamDetail>(entity =>
            {
                entity.HasKey(e => e.ReExamDetailsCode)
                    .HasName("PK_ReExamDetailsCode");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<ReExamMa>(entity =>
            {
                entity.HasKey(e => e.ReExamCode)
                    .HasName("PK_ReExam");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<RegionMa>(entity =>
            {
                entity.HasKey(e => new { e.RegionCode, e.BranchCode });

                entity.Property(e => e.BranchCode).HasColumnName("branchCode");

                entity.Property(e => e.RegionNmA).HasMaxLength(150);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<RevenueDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdvancePayment).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankDeposit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Notes).HasMaxLength(400);

                entity.Property(e => e.PrvRemainder).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Remainder).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Replace).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenueDetalisCode).ValueGeneratedOnAdd();

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<RoomMa>(entity =>
            {
                entity.HasKey(e => new { e.RoomCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.DepCode).HasColumnName("depCode");

                entity.Property(e => e.RoomNmA).HasMaxLength(50);

                entity.Property(e => e.RoomNmE)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.RoomMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoomMas_BranchMas");
            });

            modelBuilder.Entity<Search>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("search");

                entity.Property(e => e.Betweendate)
                    .HasMaxLength(200)
                    .HasColumnName("betweendate");

                entity.Property(e => e.Date1).HasColumnName("date1");

                entity.Property(e => e.Date2).HasColumnName("date2");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.SearchData)
                    .HasMaxLength(500)
                    .HasColumnName("searchData");

                entity.Property(e => e.SearchDesc)
                    .HasMaxLength(500)
                    .HasColumnName("searchDesc");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<SessionUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sessionUser");

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Logindate)
                    .HasColumnType("datetime")
                    .HasColumnName("logindate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.SessionId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("sessionId");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("userIP");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userName");

                entity.Property(e => e.Usercode).HasColumnName("usercode");
            });

            modelBuilder.Entity<Setma>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PlantyDays).HasColumnName("plantyDays");

                entity.Property(e => e.SiteClosed).HasColumnName("siteClosed");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<SqlMa>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Sql).HasMaxLength(2000);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ssqlinjection>(entity =>
            {
                entity.ToTable("ssqlinjection");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<StopCard>(entity =>
            {
                entity.ToTable("StopCard");

                entity.Property(e => e.StopCardId).HasColumnName("StopCardID");

                entity.Property(e => e.Idno).HasColumnName("IDNO");

                entity.Property(e => e.StopCard1).HasColumnName("StopCard");
            });

            modelBuilder.Entity<Stud>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Stud");
            });

            modelBuilder.Entity<StudImage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OldPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Path2018)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("path2018");

                entity.Property(e => e.Typ).HasColumnName("typ");
            });

            modelBuilder.Entity<StudImages2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StudImages2", "tmp");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Level1).HasColumnName("level1");

                entity.Property(e => e.Level2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("level2");

                entity.Property(e => e.Level3).HasColumnName("level3");

                entity.Property(e => e.Level4).HasColumnName("level4");

                entity.Property(e => e.Level5).HasColumnName("level5");

                entity.Property(e => e.Level6).HasColumnName("level6");

                entity.Property(e => e.OldPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Path2018)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("path2018");

                entity.Property(e => e.Typ).HasColumnName("typ");
            });

            modelBuilder.Entity<StudentMa>(entity =>
            {
                entity.HasKey(e => e.StudentCode);

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Comp).HasColumnName("comp");

                entity.Property(e => e.CompanyAddress).HasMaxLength(500);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IdEnddate).HasColumnName("idEnddate");

                entity.Property(e => e.IdEnddateH).HasColumnName("idEnddateH");

                entity.Property(e => e.IdSource)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Iddate).HasColumnName("iddate");

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("idno");

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(150)
                    .HasColumnName("imgPath");

                entity.Property(e => e.IqamaJob).HasMaxLength(150);

                entity.Property(e => e.IsFine).HasColumnName("isFine");

                entity.Property(e => e.KafeelAddress)
                    .HasMaxLength(300)
                    .HasColumnName("kafeelAddress");

                entity.Property(e => e.KafeelComputer)
                    .HasMaxLength(50)
                    .HasColumnName("kafeelComputer");

                entity.Property(e => e.KafeelMobil)
                    .HasMaxLength(20)
                    .HasColumnName("kafeelMobil");

                entity.Property(e => e.Kafeelname)
                    .HasMaxLength(50)
                    .HasColumnName("kafeelname");

                entity.Property(e => e.Kafeelno)
                    .HasMaxLength(50)
                    .HasColumnName("kafeelno");

                entity.Property(e => e.KafelIdNo).HasMaxLength(50);

                entity.Property(e => e.Moassakafeel)
                    .HasMaxLength(50)
                    .HasColumnName("moassakafeel");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.OldCompanyCode).HasColumnName("oldCompanyCode");

                entity.Property(e => e.Passport).HasMaxLength(50);

                entity.Property(e => e.RegDate).HasColumnName("regDate");

                entity.Property(e => e.Rokhsano)
                    .HasMaxLength(50)
                    .HasColumnName("rokhsano");

                entity.Property(e => e.StId)
                    .HasMaxLength(50)
                    .HasColumnName("stId");

                entity.Property(e => e.StudId).HasColumnName("StudID");

                entity.Property(e => e.StudentNmA)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StudentNmE).HasMaxLength(150);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<StudentMas01072020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StudentMas_01072020");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Comp).HasColumnName("comp");

                entity.Property(e => e.CompanyAddress).HasMaxLength(500);

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IdEnddate).HasColumnName("idEnddate");

                entity.Property(e => e.IdEnddateH).HasColumnName("idEnddateH");

                entity.Property(e => e.IdSource)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Iddate).HasColumnName("iddate");

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("idno");

                entity.Property(e => e.ImgPath)
                    .HasMaxLength(150)
                    .HasColumnName("imgPath");

                entity.Property(e => e.IqamaJob).HasMaxLength(150);

                entity.Property(e => e.IsFine).HasColumnName("isFine");

                entity.Property(e => e.KafeelAddress)
                    .HasMaxLength(300)
                    .HasColumnName("kafeelAddress");

                entity.Property(e => e.KafeelComputer)
                    .HasMaxLength(50)
                    .HasColumnName("kafeelComputer");

                entity.Property(e => e.KafeelMobil)
                    .HasMaxLength(20)
                    .HasColumnName("kafeelMobil");

                entity.Property(e => e.Kafeelname)
                    .HasMaxLength(50)
                    .HasColumnName("kafeelname");

                entity.Property(e => e.Kafeelno)
                    .HasMaxLength(50)
                    .HasColumnName("kafeelno");

                entity.Property(e => e.KafelIdNo).HasMaxLength(50);

                entity.Property(e => e.Moassakafeel)
                    .HasMaxLength(50)
                    .HasColumnName("moassakafeel");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.OldCompanyCode).HasColumnName("oldCompanyCode");

                entity.Property(e => e.Passport).HasMaxLength(50);

                entity.Property(e => e.RegDate).HasColumnName("regDate");

                entity.Property(e => e.Rokhsano)
                    .HasMaxLength(50)
                    .HasColumnName("rokhsano");

                entity.Property(e => e.StudentNmA)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.StudentNmE).HasMaxLength(150);

                entity.Property(e => e.TimeAdd).HasColumnType("datetime");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<StudentTransMa>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CetificateNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idno).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Natcode).HasColumnName("natcode");

                entity.Property(e => e.StudentTransCode).ValueGeneratedOnAdd();

                entity.Property(e => e.Studentnma)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<Studhavefineview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("studhavefineview");

                entity.Property(e => e.Idno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("idno");

                entity.Property(e => e.Studentcode).HasColumnName("studentcode");
            });

            modelBuilder.Entity<SubjectMa>(entity =>
            {
                entity.HasKey(e => e.SubjectCode)
                    .HasName("PK_SubjectMas_1");

                entity.Property(e => e.SubjectCode).ValueGeneratedNever();

                entity.Property(e => e.SubjectNmA).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<TableConstraint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TableConstraint");

                entity.Property(e => e.Deleted).HasColumnName("deleted");

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.Ok).HasDefaultValueSql("((0))");

                entity.Property(e => e.Statement).HasMaxLength(250);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<TermsMa>(entity =>
            {
                entity.HasKey(e => e.TermsCode);

                entity.Property(e => e.TermsCode).ValueGeneratedNever();
            });

            modelBuilder.Entity<TimeMa>(entity =>
            {
                entity.HasKey(e => e.TimeCode)
                    .HasName("Pk_TimeMas");

                entity.Property(e => e.TimeCode).ValueGeneratedNever();

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.TimeNmA).HasMaxLength(50);

                entity.Property(e => e.TimeNmE).HasMaxLength(50);

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<TrainingRecharg>(entity =>
            {
                entity.HasKey(e => e.TrainigRechargeId);

                entity.ToTable("TrainingRecharg");

                entity.Property(e => e.TrainigRechargeId).HasColumnName("TrainigRechargeID");

                entity.Property(e => e.ImagePath)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.TransInfo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransStudentFbranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransStudentFBranch");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");
            });

            modelBuilder.Entity<TryLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TryLogin");

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Pass)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("pass");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.Trydate)
                    .HasColumnType("datetime")
                    .HasColumnName("trydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<UserGroupMa>(entity =>
            {
                entity.HasKey(e => e.UsergroupCode);

                entity.Property(e => e.UsergroupCode)
                    .ValueGeneratedNever()
                    .HasColumnName("usergroupCode");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.Property(e => e.UsergroupnmA)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("usergroupnmA");
            });

            modelBuilder.Entity<UserMa>(entity =>
            {
                entity.HasKey(e => e.UserCode)
                    .HasName("PK_UserMas_1");

                entity.Property(e => e.UserCode)
                    .ValueGeneratedNever()
                    .HasColumnName("userCode");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.DepCode).HasColumnName("depCode");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .HasColumnName("email");

                entity.Property(e => e.EmpCode).HasColumnName("empCode");

                entity.Property(e => e.OldUser).HasColumnName("oldUser");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.Property(e => e.Usercode2).HasColumnName("usercode2");

                entity.Property(e => e.Usercode3).HasColumnName("usercode3");

                entity.Property(e => e.UsergroupCode).HasColumnName("usergroupCode");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.VoucherBal).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.UserMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMas_BranchMas");

                entity.HasOne(d => d.EmpMa)
                    .WithMany(p => p.UserMas)
                    .HasForeignKey(d => new { d.EmpCode, d.Branchcode })
                    .HasConstraintName("FK_UserMas_EmpMas");
            });

            modelBuilder.Entity<VoucherMa>(entity =>
            {
                entity.HasKey(e => new { e.VoucherCode, e.Branchcode });

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");

                entity.Property(e => e.Closed).HasColumnName("closed");

                entity.Property(e => e.TimeAdd)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeDel)
                    .HasColumnType("datetime")
                    .HasColumnName("timeDel")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TimeEdit).HasColumnType("datetime");

                entity.Property(e => e.UserDel).HasColumnName("userDel");

                entity.HasOne(d => d.BranchcodeNavigation)
                    .WithMany(p => p.VoucherMas)
                    .HasForeignKey(d => d.Branchcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoucherMas_BranchMas");

                entity.HasOne(d => d.EmpMa)
                    .WithMany(p => p.VoucherMas)
                    .HasForeignKey(d => new { d.EmpCode, d.Branchcode })
                    .HasConstraintName("FK_VoucherMas_EmpMas");
            });

            modelBuilder.Entity<VwHospitalBal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_hospitalBal");

                entity.Property(e => e.Bal).HasColumnName("bal");

                entity.Property(e => e.Branchcode).HasColumnName("branchcode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
