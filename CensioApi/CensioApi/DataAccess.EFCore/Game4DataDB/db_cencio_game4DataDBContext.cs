using System;
using Domain.Game4DataEntites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.EFCore.Game4DataEntites
{
    public partial class db_cencio_game4DataDBContext : DbContext
    {
        public db_cencio_game4DataDBContext()
        {
        }

        public db_cencio_game4DataDBContext(DbContextOptions<db_cencio_game4DataDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAvatar> TblAvatar { get; set; }
        public virtual DbSet<TblBehaviorElement> TblBehaviorElement { get; set; }
        public virtual DbSet<TblBehaviorUserLog> TblBehaviorUserLog { get; set; }
        public virtual DbSet<TblCmsRoles> TblCmsRoles { get; set; }
        public virtual DbSet<TblCmsUsers> TblCmsUsers { get; set; }
        public virtual DbSet<TblGame> TblGame { get; set; }
        public virtual DbSet<TblGame1UserLog> TblGame1UserLog { get; set; }
        public virtual DbSet<TblGame2UserLog> TblGame2UserLog { get; set; }
        public virtual DbSet<TblGame3UserLog> TblGame3UserLog { get; set; }
        public virtual DbSet<TblGame4LevelImages> TblGame4LevelImages { get; set; }
        public virtual DbSet<TblGame4LevelInstructions> TblGame4LevelInstructions { get; set; }
        public virtual DbSet<TblGame4LevelMaster> TblGame4LevelMaster { get; set; }
        public virtual DbSet<TblGame4Userlog> TblGame4Userlog { get; set; }
        public virtual DbSet<TblGame4WordMaster> TblGame4WordMaster { get; set; }
        public virtual DbSet<TblGame4WordsLog> TblGame4WordsLog { get; set; }
        public virtual DbSet<TblGame5UserLog> TblGame5UserLog { get; set; }
        public virtual DbSet<TblGameAttemptdata> TblGameAttemptdata { get; set; }
        public virtual DbSet<TblGameChallengelevel> TblGameChallengelevel { get; set; }
        public virtual DbSet<TblGameMaster> TblGameMaster { get; set; }
        public virtual DbSet<TblGameUserAttemptPurchaseLog> TblGameUserAttemptPurchaseLog { get; set; }
        public virtual DbSet<TblGuideDialogues> TblGuideDialogues { get; set; }
        public virtual DbSet<TblMainmenu> TblMainmenu { get; set; }
        public virtual DbSet<TblOrganization> TblOrganization { get; set; }
        public virtual DbSet<TblPuzzleGame> TblPuzzleGame { get; set; }
        public virtual DbSet<TblSubliminalMeasurement1> TblSubliminalMeasurement1 { get; set; }
        public virtual DbSet<TblSubliminalMeasurement2> TblSubliminalMeasurement2 { get; set; }
        public virtual DbSet<TblSubmenu> TblSubmenu { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=13.127.109.239;user id=tgc_rani_db;password=hQVUH#4G;port=3306;database=db_censio_beta", x => x.ServerVersion("5.7.34-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAvatar>(entity =>
            {
                entity.HasKey(e => e.IdAvatar)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_avatar");

                entity.Property(e => e.IdAvatar)
                    .HasColumnName("Id_Avatar")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TblBehaviorElement>(entity =>
            {
                entity.HasKey(e => e.IdBehavior)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_behavior_element");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(6)");

                entity.Property(e => e.BehaviorElement)
                    .IsRequired()
                    .HasColumnName("Behavior_Element")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblBehaviorUserLog>(entity =>
            {
                entity.HasKey(e => e.BehaviorUserLog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_behavior_user_log");

                entity.Property(e => e.BehaviorUserLog)
                    .HasColumnName("behavior_user_log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("is_completed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("updated_date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblCmsRoles>(entity =>
            {
                entity.HasKey(e => e.IdCmsRole)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_cms_roles");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("fk1_tbl_cms_roles_idx");

                entity.Property(e => e.IdCmsRole)
                    .HasColumnName("Id_CMS_Role")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasColumnName("Role_Name")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblCmsUsers>(entity =>
            {
                entity.HasKey(e => e.IdCmsUser)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_cms_users");

                entity.HasIndex(e => e.IdOrganization)
                    .HasName("ID_ORGANIZATION");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsRole)
                    .HasColumnName("Id_CMS_Role")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(30)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("Phone_No")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.IdOrganizationNavigation)
                    .WithMany(p => p.TblCmsUsers)
                    .HasForeignKey(d => d.IdOrganization)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tbl_cms_usersfk_1");
            });

            modelBuilder.Entity<TblGame>(entity =>
            {
                entity.ToTable("tbl_game");

                entity.Property(e => e.Id).HasColumnType("int(6)");

                entity.Property(e => e.AccuracyLimit)
                    .HasColumnName("Accuracy_Limit")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MapImgUrl)
                    .HasColumnName("Map_ImgURL")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblGame1UserLog>(entity =>
            {
                entity.HasKey(e => e.Game1UserLog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game1_user_log");

                entity.Property(e => e.Game1UserLog)
                    .HasColumnName("Game1_User_Log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttemptNo)
                    .HasColumnName("Attempt_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.GameCoins)
                    .HasColumnName("Game_Coins")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GoldCoins)
                    .HasColumnName("Gold_Coins")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement1)
                    .HasColumnName("Id_Subliminal_Measurement_1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement2)
                    .HasColumnName("Id_Subliminal_Measurement_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("Is_Completed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RewardCoins)
                    .HasColumnName("Reward_Coins")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimetakenToComplete)
                    .HasColumnName("Timetaken_To_Complete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("updated_date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGame2UserLog>(entity =>
            {
                entity.HasKey(e => e.Game2UserLog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game2_user_log");

                entity.Property(e => e.Game2UserLog)
                    .HasColumnName("Game2_User_Log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AccuracyLevel)
                    .HasColumnName("Accuracy_Level")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AttemptNo)
                    .HasColumnName("Attempt_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement1)
                    .HasColumnName("Id_Subliminal_Measurement_1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement2)
                    .HasColumnName("Id_Subliminal_Measurement_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("Is_Completed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardCoins)
                    .HasColumnName("Reward_Coins")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimetakenToComplete)
                    .HasColumnName("Timetaken_To_Complete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("updated_date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGame3UserLog>(entity =>
            {
                entity.HasKey(e => e.Game3UserLog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game3_user_log");

                entity.Property(e => e.Game3UserLog)
                    .HasColumnName("Game3_User_Log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttemptNo)
                    .HasColumnName("Attempt_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement1)
                    .HasColumnName("Id_Subliminal_Measurement_1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement2)
                    .HasColumnName("Id_Subliminal_Measurement_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("Is_Completed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LinesEliminated)
                    .HasColumnName("Lines_Eliminated")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Score)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecialPoints)
                    .HasColumnName("Special_Points")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimetakenToComplete)
                    .HasColumnName("Timetaken_To_Complete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("updated_date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGame4LevelImages>(entity =>
            {
                entity.HasKey(e => e.IdLevelImage)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game4_level_images");

                entity.Property(e => e.IdLevelImage)
                    .HasColumnName("id_level_image")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("id_game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdImage)
                    .HasColumnName("id_image")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("id_level")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TblGame4LevelInstructions>(entity =>
            {
                entity.HasKey(e => e.IdInstruction)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game4_level_instructions");

                entity.Property(e => e.IdInstruction)
                    .HasColumnName("id_instruction")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("id_game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdInstructionNo)
                    .HasColumnName("id_instruction_no")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("id_level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InstructionDetail)
                    .HasColumnName("instruction_detail")
                    .HasColumnType("varchar(450)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InstructionImage)
                    .HasColumnName("instruction_image")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.InstructionStatus)
                    .HasColumnName("instruction_status")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("timestamp");
            });

            modelBuilder.Entity<TblGame4LevelMaster>(entity =>
            {
                entity.HasKey(e => e.IdLevel)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game4_level_master");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("id_level")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("id_game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevelStatus)
                    .HasColumnName("id_level_status")
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LevelBonuspts)
                    .HasColumnName("level_bonuspts")
                    .HasColumnType("int(6)");

                entity.Property(e => e.LevelName)
                    .HasColumnName("level_name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.LevelTimerequired)
                    .HasColumnName("level_timerequired")
                    .HasColumnType("int(3)");

                entity.Property(e => e.LevelWordcount)
                    .HasColumnName("level_wordcount")
                    .HasColumnType("int(6)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("timestamp");
            });

            modelBuilder.Entity<TblGame4Userlog>(entity =>
            {
                entity.HasKey(e => e.IdUserlog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game4_userlog");

                entity.HasIndex(e => e.IdLevelMasterid)
                    .HasName("id_level_masterid_idx");

                entity.Property(e => e.IdUserlog)
                    .HasColumnName("id_userlog")
                    .HasColumnType("int(6)");

                entity.Property(e => e.BonusPoint)
                    .HasColumnName("bonus_point")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CountofWordsMade)
                    .HasColumnName("countof_words_made")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("id_game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevelMasterid)
                    .HasColumnName("id_level_masterid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeTaken)
                    .HasColumnName("time_taken")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("timestamp");

                entity.Property(e => e.WordSelected)
                    .HasColumnName("word_selected")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TblGame4WordMaster>(entity =>
            {
                entity.HasKey(e => e.IdLevelWord)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game4_word_master");

                entity.Property(e => e.IdLevelWord)
                    .HasColumnName("id_level_word")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("id_game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevelMaster)
                    .HasColumnName("id_level_master")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdWordDetail)
                    .HasColumnName("id_word_detail")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.IdWordNo)
                    .HasColumnName("id_word_no")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdWordStatus)
                    .HasColumnName("id_word_status")
                    .HasColumnType("char(1)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("timestamp");
            });

            modelBuilder.Entity<TblGame4WordsLog>(entity =>
            {
                entity.HasKey(e => e.IdWordsMade)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game4_words_log");

                entity.Property(e => e.IdWordsMade)
                    .HasColumnName("id_words_made")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("id_game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("id_level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUserlog)
                    .HasColumnName("id_userlog")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdateDatetime)
                    .HasColumnName("update_datetime")
                    .HasColumnType("timestamp");

                entity.Property(e => e.WordMadeDetail)
                    .HasColumnName("word_made_detail")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.WordSelected)
                    .HasColumnName("word_selected")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            modelBuilder.Entity<TblGame5UserLog>(entity =>
            {
                entity.HasKey(e => e.Game5UserLog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game5_user_log");

                entity.Property(e => e.Game5UserLog)
                    .HasColumnName("Game5_User_Log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttemptNo)
                    .HasColumnName("Attempt_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.GoldCoins)
                    .HasColumnName("Gold_Coins")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement1)
                    .HasColumnName("Id_Subliminal_Measurement_1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSubliminalMeasurement2)
                    .HasColumnName("Id_Subliminal_Measurement_2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnName("Is_Completed")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MedallionsCollected)
                    .HasColumnName("Medallions_Collected")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TimetakenToComplete)
                    .HasColumnName("Timetaken_To_Complete")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("updated_date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGameAttemptdata>(entity =>
            {
                entity.HasKey(e => e.IdAttempt)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game_attemptdata");

                entity.Property(e => e.IdAttempt)
                    .HasColumnName("Id_Attempt")
                    .HasColumnType("int(6)");

                entity.Property(e => e.AttemptNo)
                    .HasColumnName("Attempt_No")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("decimal(5,2)");

                entity.Property(e => e.ChallengeCompletedTime1)
                    .HasColumnName("Challenge_Completed_Time1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChallengeCompletedTime2)
                    .HasColumnName("Challenge_Completed_Time2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FailAttemptMessage)
                    .HasColumnName("Fail_Attempt_Message")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Game5Behaviors)
                    .HasColumnName("Game5_Behaviors")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GoldCoins)
                    .HasColumnName("Gold_Coins")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RewardCoinsTime1)
                    .HasColumnName("Reward_Coins_Time1")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RewardCoinsTime2)
                    .HasColumnName("Reward_Coins_Time2")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SuccessAttemptMessage)
                    .HasColumnName("SuccessAttempt_Message")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TimeInSecond)
                    .HasColumnName("Time_IN_Second")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblGameChallengelevel>(entity =>
            {
                entity.HasKey(e => e.IdLevel)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game_challengelevel");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(6)");

                entity.Property(e => e.AgainPlayCoins)
                    .HasColumnName("Again_Play_Coins")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AttemptTimer)
                    .HasColumnName("Attempt_Timer")
                    .HasColumnType("int(6)");

                entity.Property(e => e.AttemptsAllowed)
                    .HasColumnName("Attempts_Allowed")
                    .HasColumnType("int(100)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BigImgText)
                    .HasColumnName("BigImg_Text")
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BottomCompleteMessage)
                    .HasColumnName("Bottom_Complete_Message")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.BottomFailMessage)
                    .HasColumnName("Bottom_Fail_Message")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChallengeBigImgUrl)
                    .HasColumnName("Challenge_Big_ImgURL")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChallengeIntroMessage)
                    .HasColumnName("Challenge_Intro_Message")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChallengeName)
                    .IsRequired()
                    .HasColumnName("Challenge_Name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChallengePieceMapImgUrl)
                    .HasColumnName("Challenge_Piece_Map_ImgUrl")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChallengePieceMapMsg)
                    .HasColumnName("Challenge_Piece_Map_Msg")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChallengeSmallImgUrl)
                    .HasColumnName("Challenge_Small_ImgURL")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotBackingOutMsg)
                    .HasColumnName("Not_Backing_Out_Msg")
                    .HasColumnType("varchar(3000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SpecialPoint)
                    .HasColumnName("Special_Point")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SuperpowerCoinGame3)
                    .HasColumnName("SuperpowerCoin_Game3")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ThirdGameScore)
                    .HasColumnName("ThirdGame_Score")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblGameMaster>(entity =>
            {
                entity.HasKey(e => e.IdGame)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game_master");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(6)");

                entity.Property(e => e.GameName)
                    .IsRequired()
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblGameUserAttemptPurchaseLog>(entity =>
            {
                entity.HasKey(e => e.GameAttemptPurchaseLog)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_game_user_attempt_purchase_log");

                entity.Property(e => e.GameAttemptPurchaseLog)
                    .HasColumnName("Game_Attempt_Purchase_log")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AttemptNo)
                    .HasColumnName("Attempt_No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Coins).HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUser)
                    .HasColumnName("id_user")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("updated_date_time")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblGuideDialogues>(entity =>
            {
                entity.HasKey(e => e.IdGuideDialogues)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_guide_dialogues");

                entity.Property(e => e.IdGuideDialogues)
                    .HasColumnName("Id_Guide_Dialogues")
                    .HasColumnType("int(6)");

                entity.Property(e => e.GuideDialogue)
                    .IsRequired()
                    .HasColumnName("Guide_Dialogue")
                    .HasColumnType("varchar(1000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GuideIntroMessage)
                    .HasColumnName("Guide_Intro_Message")
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.TypeDialogue)
                    .HasColumnName("Type_Dialogue")
                    .HasColumnType("int(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TypeDialogueName)
                    .HasColumnName("Type_Dialogue_Name")
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblMainmenu>(entity =>
            {
                entity.HasKey(e => e.MainMenuId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_mainmenu");

                entity.Property(e => e.MainMenuId)
                    .HasColumnName("MainMenu_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdCmsRole)
                    .HasColumnName("Id_CMS_Role")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainMenuName)
                    .HasColumnName("MainMenu_Name")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblOrganization>(entity =>
            {
                entity.HasKey(e => e.IdOrganization)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_organization");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactEmail)
                    .IsRequired()
                    .HasColumnName("Contact_Email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DefaultEmail)
                    .IsRequired()
                    .HasColumnName("Default_Email")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(2000)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Logo)
                    .HasColumnType("varchar(450)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasColumnName("Organization_Name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnType("varchar(15)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblPuzzleGame>(entity =>
            {
                entity.HasKey(e => e.IdPuzzle)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_puzzle_game");

                entity.Property(e => e.IdPuzzle)
                    .HasColumnName("Id_Puzzle")
                    .HasColumnType("int(6)");

                entity.Property(e => e.AnswerSequence)
                    .HasColumnName("Answer_Sequence")
                    .HasColumnType("int(6)");

                entity.Property(e => e.Coins).HasColumnType("int(6)");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Images)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("'A'")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RowColumn)
                    .IsRequired()
                    .HasColumnName("Row_Column")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblSubliminalMeasurement1>(entity =>
            {
                entity.HasKey(e => e.IdSubliminalMeasurement1)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_subliminal_measurement_1");

                entity.Property(e => e.IdSubliminalMeasurement1)
                    .HasColumnName("Id_Subliminal_Measurement_1")
                    .HasColumnType("int(6)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubliminalMeasurementName)
                    .IsRequired()
                    .HasColumnName("Subliminal_Measurement_Name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblSubliminalMeasurement2>(entity =>
            {
                entity.HasKey(e => e.IdSubliminalMeasurement2)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_subliminal_measurement_2");

                entity.Property(e => e.IdSubliminalMeasurement2)
                    .HasColumnName("Id_Subliminal_Measurement_2")
                    .HasColumnType("int(6)");

                entity.Property(e => e.BehaviorScore)
                    .HasColumnName("Behavior_Score")
                    .HasColumnType("int(6)");

                entity.Property(e => e.GameFeedbackMsg)
                    .HasColumnName("Game_Feedback_Msg")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdBehavior)
                    .HasColumnName("Id_Behavior")
                    .HasColumnType("int(6)");

                entity.Property(e => e.IdCmsUser)
                    .HasColumnName("Id_CmsUser")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdGame)
                    .HasColumnName("Id_Game")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdLevel)
                    .HasColumnName("Id_Level")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubliminalMeasurement2Name)
                    .IsRequired()
                    .HasColumnName("Subliminal_Measurement2_Name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_Time")
                    .HasColumnType("timestamp")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TblSubmenu>(entity =>
            {
                entity.HasKey(e => e.SubMenuId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_submenu");

                entity.HasIndex(e => e.IdCmsRole)
                    .HasName("FK_Id_CMS_Role");

                entity.HasIndex(e => e.MainMenuId)
                    .HasName("FK_MainMenu_Id");

                entity.Property(e => e.SubMenuId)
                    .HasColumnName("SubMenu_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Controller)
                    .HasColumnType("varchar(300)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdCmsRole)
                    .HasColumnName("Id_CMS_Role")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainMenuId)
                    .HasColumnName("MainMenu_Id")
                    .HasColumnType("int(50)");

                entity.Property(e => e.Sequence).HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubMenuName)
                    .HasColumnName("SubMenu_Name")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdatedDateTime)
                    .HasColumnName("Updated_Date_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.HasOne(d => d.MainMenu)
                    .WithMany(p => p.TblSubmenu)
                    .HasForeignKey(d => d.MainMenuId)
                    .HasConstraintName("FK_MainMenu_Id");
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("tbl_users");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvatarUserName)
                    .HasColumnName("Avatar_User_Name")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdAvatar)
                    .HasColumnName("Id_Avatar")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrganization)
                    .HasColumnName("ID_ORGANIZATION")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoginUserId)
                    .IsRequired()
                    .HasColumnName("Login_User_Id")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(500)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("char(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
