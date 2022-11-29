﻿// <auto-generated />
using System;
using BankDB.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BankDB.Migrations
{
    [DbContext(typeof(BankContext))]
    [Migration("20221129173027_SnakeNamingConvention")]
    partial class SnakeNamingConvention
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BankDB.Models.AccountInBank", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("account_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AccountId"));

                    b.Property<decimal>("AmountOnAccount")
                        .HasColumnType("numeric")
                        .HasColumnName("amount_on_account");

                    b.Property<int?>("ClientPersonId")
                        .HasColumnType("integer")
                        .HasColumnName("client_person_id");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("currency");

                    b.HasKey("AccountId")
                        .HasName("pk_account_in_bank");

                    b.HasIndex("ClientPersonId")
                        .HasDatabaseName("ix_account_in_bank_client_person_id");

                    b.ToTable("account_in_bank", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("bank_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BankId"));

                    b.Property<string>("BankAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bank_address");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bank_name");

                    b.HasKey("BankId")
                        .HasName("pk_bank");

                    b.ToTable("bank", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.BankBranch", b =>
                {
                    b.Property<int>("BankBranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("bank_branch_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BankBranchId"));

                    b.Property<string>("BankBranchName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bank_branch_name");

                    b.Property<int>("BankId")
                        .HasColumnType("integer")
                        .HasColumnName("bank_id");

                    b.HasKey("BankBranchId")
                        .HasName("pk_bank_branch");

                    b.HasIndex("BankId")
                        .HasDatabaseName("ix_bank_branch_bank_id");

                    b.ToTable("bank_branch", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.Client", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PersonId"));

                    b.Property<string>("Citizenship")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValue("Ukraine")
                        .HasColumnName("citizenship");

                    b.Property<string>("EmailAddres")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("email_addres");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("firs_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("last_name");

                    b.HasKey("PersonId")
                        .HasName("pk_clients");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BankDB.Models.Employee", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("person_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PersonId"));

                    b.Property<int>("BankBranchId")
                        .HasColumnType("integer")
                        .HasColumnName("bank_branch_id");

                    b.Property<string>("EmailAddres")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("email_addres");

                    b.Property<string>("EmployeePhone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("employee_phone");

                    b.Property<string>("FirsName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("firs_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("last_name");

                    b.Property<int>("OccupationId")
                        .HasColumnType("integer")
                        .HasColumnName("occupation_id");

                    b.HasKey("PersonId")
                        .HasName("pk_employees");

                    b.HasIndex("BankBranchId")
                        .HasDatabaseName("ix_employees_bank_branch_id");

                    b.HasIndex("OccupationId")
                        .HasDatabaseName("ix_employees_occupation_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BankDB.Models.Occupation", b =>
                {
                    b.Property<int>("OccupationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("occupation_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OccupationId"));

                    b.Property<string>("OccupationName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("occupation_name");

                    b.HasKey("OccupationId")
                        .HasName("pk_occupation");

                    b.ToTable("occupation", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.ServiceForClientInBank", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("integer")
                        .HasColumnName("client_id");

                    b.Property<int>("ServiceInBankId")
                        .HasColumnType("integer")
                        .HasColumnName("service_in_bank_id");

                    b.HasKey("ClientId", "ServiceInBankId")
                        .HasName("pk_service_for_client_in_bank");

                    b.HasIndex("ServiceInBankId")
                        .HasDatabaseName("ix_service_for_client_in_bank_service_in_bank_id");

                    b.ToTable("service_for_client_in_bank", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.ServiceInBank", b =>
                {
                    b.Property<int>("ServiceInBankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("service_in_bank_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServiceInBankId"));

                    b.Property<int>("ClientPersonId")
                        .HasColumnType("integer")
                        .HasColumnName("client_person_id");

                    b.Property<DateTime>("DateOfService")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_service");

                    b.Property<int>("EmployeePersonId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_person_id");

                    b.Property<string>("NameOfService")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name_of_service");

                    b.HasKey("ServiceInBankId")
                        .HasName("pk_service_in_bank");

                    b.HasIndex("ClientPersonId")
                        .HasDatabaseName("ix_service_in_bank_client_person_id");

                    b.HasIndex("EmployeePersonId")
                        .HasDatabaseName("ix_service_in_bank_employee_person_id");

                    b.ToTable("service_in_bank", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.Transaction", b =>
                {
                    b.Property<string>("TransactionId")
                        .HasColumnType("text")
                        .HasColumnName("transaction_id");

                    b.Property<int>("AccountId")
                        .HasColumnType("integer")
                        .HasColumnName("account_id");

                    b.Property<int>("AccountInBankId")
                        .HasColumnType("integer")
                        .HasColumnName("account_in_bank_id");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<string>("TransactionName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("transaction_name");

                    b.HasKey("TransactionId")
                        .HasName("pk_transaction");

                    b.HasIndex("AccountInBankId")
                        .HasDatabaseName("ix_transaction_account_in_bank_id");

                    b.ToTable("transaction", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.WorkingDay", b =>
                {
                    b.Property<int>("WorkingDayId")
                        .HasColumnType("integer")
                        .HasColumnName("working_day_id");

                    b.Property<string>("DayOfTheWeek")
                        .HasColumnType("text")
                        .HasColumnName("day_of_the_week");

                    b.Property<string>("CloseTime")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("close_time");

                    b.Property<string>("OpenTime")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("open_time");

                    b.HasKey("WorkingDayId", "DayOfTheWeek")
                        .HasName("WorkingDay_id");

                    b.ToTable("working_day", (string)null);
                });

            modelBuilder.Entity("BankDB.Models.AccountInBank", b =>
                {
                    b.HasOne("BankDB.Models.Client", null)
                        .WithMany("AccountsInBank")
                        .HasForeignKey("ClientPersonId")
                        .HasConstraintName("fk_account_in_bank_clients_client_person_id");
                });

            modelBuilder.Entity("BankDB.Models.BankBranch", b =>
                {
                    b.HasOne("BankDB.Models.Bank", "Bank")
                        .WithMany("BankBranches")
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_bank_branch_bank_bank_id");

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("BankDB.Models.Employee", b =>
                {
                    b.HasOne("BankDB.Models.BankBranch", "BankBranch")
                        .WithMany("Employees")
                        .HasForeignKey("BankBranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employees_bank_branch_bank_branch_id");

                    b.HasOne("BankDB.Models.Occupation", "Occupation")
                        .WithMany()
                        .HasForeignKey("OccupationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employees_occupation_occupation_id");

                    b.Navigation("BankBranch");

                    b.Navigation("Occupation");
                });

            modelBuilder.Entity("BankDB.Models.ServiceForClientInBank", b =>
                {
                    b.HasOne("BankDB.Models.Client", "Client")
                        .WithMany("ServiceForClientInBanks")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_service_for_client_in_bank_clients_client_id");

                    b.HasOne("BankDB.Models.ServiceInBank", "ServiceInBank")
                        .WithMany("ServiceForClientInBanks")
                        .HasForeignKey("ServiceInBankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_service_for_client_in_bank_service_in_bank_service_in_bank_");

                    b.Navigation("Client");

                    b.Navigation("ServiceInBank");
                });

            modelBuilder.Entity("BankDB.Models.ServiceInBank", b =>
                {
                    b.HasOne("BankDB.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientPersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_service_in_bank_clients_client_person_id");

                    b.HasOne("BankDB.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeePersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_service_in_bank_employees_employee_person_id");

                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BankDB.Models.Transaction", b =>
                {
                    b.HasOne("BankDB.Models.AccountInBank", "AccountInBank")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountInBankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_transaction_account_in_bank_account_in_bank_id");

                    b.Navigation("AccountInBank");
                });

            modelBuilder.Entity("BankDB.Models.AccountInBank", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("BankDB.Models.Bank", b =>
                {
                    b.Navigation("BankBranches");
                });

            modelBuilder.Entity("BankDB.Models.BankBranch", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("BankDB.Models.Client", b =>
                {
                    b.Navigation("AccountsInBank");

                    b.Navigation("ServiceForClientInBanks");
                });

            modelBuilder.Entity("BankDB.Models.ServiceInBank", b =>
                {
                    b.Navigation("ServiceForClientInBanks");
                });
#pragma warning restore 612, 618
        }
    }
}
