﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyAppServer;

#nullable disable

namespace SurveyAppServer.Migrations
{
    [DbContext(typeof(SurveyAppDbContext))]
    partial class SurveyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("SurveyAppServer.Models.Answers.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MultipleChoiceQuestionQuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SingleChoiceQuestionQuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnswerId");

                    b.HasIndex("MultipleChoiceQuestionQuestionId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SingleChoiceQuestionQuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "3"
                        },
                        new
                        {
                            AnswerId = 2,
                            IsCorrect = true,
                            QuestionId = 1,
                            Text = "4"
                        },
                        new
                        {
                            AnswerId = 3,
                            IsCorrect = false,
                            QuestionId = 1,
                            Text = "5"
                        },
                        new
                        {
                            AnswerId = 4,
                            IsCorrect = true,
                            QuestionId = 2,
                            Text = "7"
                        },
                        new
                        {
                            AnswerId = 5,
                            IsCorrect = false,
                            QuestionId = 2,
                            Text = "6"
                        },
                        new
                        {
                            AnswerId = 6,
                            IsCorrect = false,
                            QuestionId = 2,
                            Text = "5"
                        },
                        new
                        {
                            AnswerId = 7,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "In the morning"
                        },
                        new
                        {
                            AnswerId = 8,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "In the afternoon"
                        },
                        new
                        {
                            AnswerId = 9,
                            IsCorrect = false,
                            QuestionId = 3,
                            Text = "At night"
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.QuestionBase", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasRightAnswer")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tooltip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionId");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");

                    b.HasDiscriminator<string>("Discriminator").HasValue("QuestionBase");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.Survey", b =>
                {
                    b.Property<int>("SurveyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("AverageRating")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SurveyId");

                    b.ToTable("Surveys");

                    b.HasData(
                        new
                        {
                            SurveyId = 1,
                            AverageRating = 2.3999999999999999,
                            Title = "Mock survey"
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyAnswer", b =>
                {
                    b.Property<int>("SurveyAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnswerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpenAnswer")
                        .HasColumnType("TEXT");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyAttemptId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyAnswerId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("SurveyAttemptId");

                    b.ToTable("SurveyAnswers");

                    b.HasData(
                        new
                        {
                            SurveyAnswerId = 1,
                            AnswerId = 1,
                            QuestionId = 1,
                            SurveyAttemptId = 1
                        },
                        new
                        {
                            SurveyAnswerId = 2,
                            AnswerId = 6,
                            QuestionId = 2,
                            SurveyAttemptId = 1
                        },
                        new
                        {
                            SurveyAnswerId = 3,
                            AnswerId = 1,
                            OpenAnswer = "I read a book.",
                            QuestionId = 3,
                            SurveyAttemptId = 1
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyAttempt", b =>
                {
                    b.Property<int>("SurveyAttemptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AttemptDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyAttemptId");

                    b.HasIndex("SurveyId");

                    b.HasIndex("UserId");

                    b.ToTable("SurveyAttempts");

                    b.HasData(
                        new
                        {
                            SurveyAttemptId = 1,
                            AttemptDate = new DateTime(2023, 12, 7, 0, 14, 18, 49, DateTimeKind.Local).AddTicks(1830),
                            SurveyId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyRating", b =>
                {
                    b.Property<int>("SurveyRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mark")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SurveyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SurveyRatingId");

                    b.HasIndex("SurveyId");

                    b.HasIndex("UserId");

                    b.ToTable("SurveyRatings");

                    b.HasData(
                        new
                        {
                            SurveyRatingId = 1,
                            Mark = 2,
                            SurveyId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.UserManual", b =>
                {
                    b.Property<int>("UserManualId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SurveyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserManualId");

                    b.HasIndex("SurveyId")
                        .IsUnique();

                    b.ToTable("UserManuals");

                    b.HasData(
                        new
                        {
                            UserManualId = 1,
                            Content = "This is a mock survey manual",
                            SurveyId = 1,
                            Title = "Mock survey manual"
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Users.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "admin0@admin.com",
                            Password = "pass123",
                            Role = 0,
                            Username = "admin0"
                        });
                });

            modelBuilder.Entity("SurveyUser", b =>
                {
                    b.Property<int>("AccessibleByUsersUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessibleSurveysSurveyId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AccessibleByUsersUserId", "AccessibleSurveysSurveyId");

                    b.HasIndex("AccessibleSurveysSurveyId");

                    b.ToTable("UserSurveys", (string)null);

                    b.HasData(
                        new
                        {
                            AccessibleByUsersUserId = 1,
                            AccessibleSurveysSurveyId = 1
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.MultipleChoiceQuestion", b =>
                {
                    b.HasBaseType("SurveyAppServer.Models.Questions.QuestionBase");

                    b.HasDiscriminator().HasValue("MultipleChoiceQuestion");

                    b.HasData(
                        new
                        {
                            QuestionId = 3,
                            HasRightAnswer = false,
                            SurveyId = 1,
                            Text = "When do you feel most hungry?",
                            Tooltip = "This question helps to asses your digestion system's health"
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.OpenTextQuestion", b =>
                {
                    b.HasBaseType("SurveyAppServer.Models.Questions.QuestionBase");

                    b.HasDiscriminator().HasValue("OpenTextQuestion");

                    b.HasData(
                        new
                        {
                            QuestionId = 4,
                            HasRightAnswer = false,
                            SurveyId = 1,
                            Text = "Tell us about your before bed routine",
                            Tooltip = "This question aims to asses the quality of your sleep"
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.SingleChoiceQuestion", b =>
                {
                    b.HasBaseType("SurveyAppServer.Models.Questions.QuestionBase");

                    b.HasDiscriminator().HasValue("SingleChoiceQuestion");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            HasRightAnswer = true,
                            SurveyId = 1,
                            Text = "How many oceans are there?",
                            Tooltip = "This test aims to asses your memory (1)"
                        },
                        new
                        {
                            QuestionId = 2,
                            HasRightAnswer = true,
                            SurveyId = 1,
                            Text = "How many continents are there?",
                            Tooltip = "This test aims to asses your memory (2)"
                        });
                });

            modelBuilder.Entity("SurveyAppServer.Models.Answers.Answer", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Questions.MultipleChoiceQuestion", null)
                        .WithMany("Answers")
                        .HasForeignKey("MultipleChoiceQuestionQuestionId");

                    b.HasOne("SurveyAppServer.Models.Questions.QuestionBase", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyAppServer.Models.Questions.SingleChoiceQuestion", null)
                        .WithMany("Answers")
                        .HasForeignKey("SingleChoiceQuestionQuestionId");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.QuestionBase", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Surveys.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyAnswer", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Answers.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyAppServer.Models.Questions.QuestionBase", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyAppServer.Models.Surveys.SurveyAttempt", "SurveyAttempt")
                        .WithMany("SurveyAnswers")
                        .HasForeignKey("SurveyAttemptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");

                    b.Navigation("SurveyAttempt");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyAttempt", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Surveys.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyAppServer.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyRating", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Surveys.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyAppServer.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.UserManual", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Surveys.Survey", "Survey")
                        .WithOne("UserManual")
                        .HasForeignKey("SurveyAppServer.Models.Surveys.UserManual", "SurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Survey");
                });

            modelBuilder.Entity("SurveyUser", b =>
                {
                    b.HasOne("SurveyAppServer.Models.Users.User", null)
                        .WithMany()
                        .HasForeignKey("AccessibleByUsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyAppServer.Models.Surveys.Survey", null)
                        .WithMany()
                        .HasForeignKey("AccessibleSurveysSurveyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.Survey", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("UserManual")
                        .IsRequired();
                });

            modelBuilder.Entity("SurveyAppServer.Models.Surveys.SurveyAttempt", b =>
                {
                    b.Navigation("SurveyAnswers");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.MultipleChoiceQuestion", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("SurveyAppServer.Models.Questions.SingleChoiceQuestion", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
