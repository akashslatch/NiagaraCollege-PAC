﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NCPAC_LambdaX.Data;

#nullable disable

namespace NCPAC_LambdaX.Data.NCPACMigrations
{
    [DbContext(typeof(NCPACContext))]
    partial class NCPACContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("NCPAC_LambdaX.Models.ActionItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ActionItemTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeetingID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MemberID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TimeAppointed")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TimeUntil")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MeetingID");

                    b.HasIndex("MemberID");

                    b.ToTable("ActionItems");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Announcement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AnnouncementDescription")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TimePosted")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Commitee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommiteeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Division")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Commitees");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("BLOB");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.FileContent", b =>
                {
                    b.Property<int>("FileContentID")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.HasKey("FileContentID");

                    b.ToTable("FileContent");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.MailPrefference", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("MailPrefferences");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommiteeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MeetingTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Minitues")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("TimeFrom")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CommiteeID");

                    b.ToTable("Meetings");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateJoined")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationalSummary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsNCGrad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MailPrefferenceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OccupationalSummary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceID")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RenewalDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salutation")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkProvinceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkStreetAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MailPrefferenceID");

                    b.HasIndex("ProvinceID");

                    b.HasIndex("WorkProvinceID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.MemberCommitee", b =>
                {
                    b.Property<int>("MemberID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommiteeID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MemberVMID")
                        .HasColumnType("INTEGER");

                    b.HasKey("MemberID", "CommiteeID");

                    b.HasIndex("CommiteeID");

                    b.HasIndex("MemberVMID");

                    b.ToTable("MemberCommitees");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CommiteeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("TimeUntil")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CommiteeID");

                    b.ToTable("Poll");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.PollOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PollId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("VoteCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("PollOptions");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.PollVote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PollId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SelectedOption")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("PollVotes");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Province", b =>
                {
                    b.Property<string>("ID")
                        .HasMaxLength(2)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.UploadedFile", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("UploadedFiles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UploadedFile");
                });

            modelBuilder.Entity("NCPAC_LambdaX.ViewModels.MemberVM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationalSummary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsNCGrad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MailPrefferenceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("MiddleName")
                        .HasColumnType("TEXT");

                    b.Property<string>("OccupationalSummary")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Salutation")
                        .HasColumnType("TEXT");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkPostalCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkProvinceID")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkStreetAddress")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("MailPrefferenceID");

                    b.HasIndex("ProvinceID");

                    b.HasIndex("WorkProvinceID");

                    b.ToTable("MemberVM");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.ActionItemDocument", b =>
                {
                    b.HasBaseType("NCPAC_LambdaX.Models.UploadedFile");

                    b.Property<int>("ActionItemID")
                        .HasColumnType("INTEGER");

                    b.HasIndex("ActionItemID");

                    b.HasDiscriminator().HasValue("ActionItemDocument");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.MeetingDocument", b =>
                {
                    b.HasBaseType("NCPAC_LambdaX.Models.UploadedFile");

                    b.Property<int>("MeetingID")
                        .HasColumnType("INTEGER");

                    b.HasIndex("MeetingID");

                    b.HasDiscriminator().HasValue("MeetingDocument");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.ActionItem", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Meeting", "Meeting")
                        .WithMany("ActionItems")
                        .HasForeignKey("MeetingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NCPAC_LambdaX.Models.Member", "Member")
                        .WithMany("ActionItems")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.FileContent", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.UploadedFile", "UploadedFile")
                        .WithOne("FileContent")
                        .HasForeignKey("NCPAC_LambdaX.Models.FileContent", "FileContentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UploadedFile");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Meeting", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Commitee", "Commitee")
                        .WithMany("Meetings")
                        .HasForeignKey("CommiteeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commitee");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Member", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.MailPrefference", "MailPrefference")
                        .WithMany()
                        .HasForeignKey("MailPrefferenceID");

                    b.HasOne("NCPAC_LambdaX.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID");

                    b.HasOne("NCPAC_LambdaX.Models.Province", "WorkProvince")
                        .WithMany()
                        .HasForeignKey("WorkProvinceID");

                    b.Navigation("MailPrefference");

                    b.Navigation("Province");

                    b.Navigation("WorkProvince");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.MemberCommitee", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Commitee", "Commitee")
                        .WithMany("MemberCommitees")
                        .HasForeignKey("CommiteeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NCPAC_LambdaX.Models.Member", "Member")
                        .WithMany("MemberCommitees")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NCPAC_LambdaX.ViewModels.MemberVM", null)
                        .WithMany("MemberCommitees")
                        .HasForeignKey("MemberVMID");

                    b.Navigation("Commitee");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Poll", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Commitee", "Commitee")
                        .WithMany()
                        .HasForeignKey("CommiteeID");

                    b.Navigation("Commitee");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.PollOption", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Poll", "Poll")
                        .WithMany("Options")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.PollVote", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Poll", "Poll")
                        .WithMany("Votes")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("NCPAC_LambdaX.ViewModels.MemberVM", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.MailPrefference", "MailPrefference")
                        .WithMany()
                        .HasForeignKey("MailPrefferenceID");

                    b.HasOne("NCPAC_LambdaX.Models.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID");

                    b.HasOne("NCPAC_LambdaX.Models.Province", "WorkProvince")
                        .WithMany()
                        .HasForeignKey("WorkProvinceID");

                    b.Navigation("MailPrefference");

                    b.Navigation("Province");

                    b.Navigation("WorkProvince");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.ActionItemDocument", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.ActionItem", "ActionItem")
                        .WithMany("ActionItemDocuments")
                        .HasForeignKey("ActionItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ActionItem");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.MeetingDocument", b =>
                {
                    b.HasOne("NCPAC_LambdaX.Models.Meeting", "Meeting")
                        .WithMany("MeetingDocuments")
                        .HasForeignKey("MeetingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Meeting");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.ActionItem", b =>
                {
                    b.Navigation("ActionItemDocuments");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Commitee", b =>
                {
                    b.Navigation("Meetings");

                    b.Navigation("MemberCommitees");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Meeting", b =>
                {
                    b.Navigation("ActionItems");

                    b.Navigation("MeetingDocuments");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Member", b =>
                {
                    b.Navigation("ActionItems");

                    b.Navigation("MemberCommitees");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.Poll", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("Votes");
                });

            modelBuilder.Entity("NCPAC_LambdaX.Models.UploadedFile", b =>
                {
                    b.Navigation("FileContent")
                        .IsRequired();
                });

            modelBuilder.Entity("NCPAC_LambdaX.ViewModels.MemberVM", b =>
                {
                    b.Navigation("MemberCommitees");
                });
#pragma warning restore 612, 618
        }
    }
}
