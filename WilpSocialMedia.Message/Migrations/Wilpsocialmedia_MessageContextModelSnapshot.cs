﻿// <auto-generated />
using System;
using WilpSocialMedia.Message.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace WilpSocialMedia.Message.Migrations
{
    [DbContext(typeof(Wilpsocialmedia_MessageContext))]
    partial class Wilpsocialmedia_MessageContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WilpSocialMedia.Message.Domain.Model.ActivityStatus", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("ActivityStatus");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac252cd4-7851-465d-95b6-b4b625507be9"),
                            Description = "Delivered",
                            Name = "Delivered"
                        },
                        new
                        {
                            Id = new Guid("0d4b0712-7d5f-4c5e-8318-97e9f0293e35"),
                            Description = "Read",
                            Name = "Read"
                        },
                        new
                        {
                            Id = new Guid("9b5c5929-5f66-4dd0-8160-a15f73a69446"),
                            Description = "Replied",
                            Name = "Replied"
                        },
                        new
                        {
                            Id = new Guid("13508d97-bb53-479c-8e89-92fd811acdca"),
                            Description = "UnRead",
                            Name = "UnRead"
                        });
                });

            modelBuilder.Entity("WilpSocialMedia.Message.Domain.Model.Conversation", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<Guid>("UserCreator");

                    b.HasKey("Id");

                    b.ToTable("Conversation");
                });

            modelBuilder.Entity("WilpSocialMedia.Message.Domain.Model.Messages", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<string>("ContentMessage")
                        .IsRequired();

                    b.Property<Guid>("ConversationId");

                    b.Property<Guid>("ParticipantId");

                    b.Property<Guid?>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("Status");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WilpSocialMedia.Message.Domain.Model.Participant", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("ConversationId");

                    b.Property<Guid>("Status");

                    b.Property<Guid>("UserAccount");

                    b.HasKey("Id");

                    b.HasIndex("ConversationId");

                    b.HasIndex("Status");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("WilpSocialMedia.Message.Domain.Model.Messages", b =>
                {
                    b.HasOne("WilpSocialMedia.Message.Domain.Model.Conversation", "Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ConversationId")
                        .HasConstraintName("FK_Message_Conversation");

                    b.HasOne("WilpSocialMedia.Message.Domain.Model.Participant", "Participant")
                        .WithMany("Messages")
                        .HasForeignKey("ParticipantId")
                        .HasConstraintName("FK_Message_Participant");

                    b.HasOne("WilpSocialMedia.Message.Domain.Model.ActivityStatus", "StatusNavigation")
                        .WithMany("Messages")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_Message_ActivityStatus");
                });

            modelBuilder.Entity("WilpSocialMedia.Message.Domain.Model.Participant", b =>
                {
                    b.HasOne("WilpSocialMedia.Message.Domain.Model.Conversation", "Conversation")
                        .WithMany("Participant")
                        .HasForeignKey("ConversationId")
                        .HasConstraintName("FK_Participant_Conversation");

                    b.HasOne("WilpSocialMedia.Message.Domain.Model.ActivityStatus", "StatusNavigation")
                        .WithMany("Participant")
                        .HasForeignKey("Status")
                        .HasConstraintName("FK_Participant_ActivityStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
