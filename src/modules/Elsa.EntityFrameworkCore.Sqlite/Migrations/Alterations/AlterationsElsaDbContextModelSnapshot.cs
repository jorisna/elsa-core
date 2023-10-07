﻿// <auto-generated />
using Elsa.EntityFrameworkCore.Modules.Alterations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.Sqlite.Migrations.Alterations
{
    [DbContext(typeof(AlterationsElsaDbContext))]
    partial class AlterationsElsaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("Elsa.Alterations.Core.Entities.AlterationJob", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PlanId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedLog")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkflowInstanceId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_AlterationJob_CompletedAt");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_AlterationJob_CreatedAt");

                    b.HasIndex("PlanId")
                        .HasDatabaseName("IX_AlterationJob_PlanId");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_AlterationJob_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_AlterationJob_Status");

                    b.HasIndex("WorkflowInstanceId")
                        .HasDatabaseName("IX_AlterationJob_WorkflowInstanceId");

                    b.ToTable("AlterationJobs");
                });

            modelBuilder.Entity("Elsa.Alterations.Core.Entities.AlterationPlan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedAlterations")
                        .HasColumnType("TEXT");

                    b.Property<string>("SerializedWorkflowInstanceIds")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CompletedAt")
                        .HasDatabaseName("IX_AlterationPlan_CompletedAt");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_AlterationPlan_CreatedAt");

                    b.HasIndex("StartedAt")
                        .HasDatabaseName("IX_AlterationPlan_StartedAt");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_AlterationPlan_Status");

                    b.ToTable("AlterationPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
