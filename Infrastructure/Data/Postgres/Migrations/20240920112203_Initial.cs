using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdminID = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    ContactInformation = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DiseaseID = table.Column<int>(type: "integer", nullable: false),
                    DiseaseName = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Symptoms = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DoctorID = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    ContactInformation = table.Column<string>(type: "text", nullable: false),
                    DoctorUsername = table.Column<string>(type: "text", nullable: false),
                    DoctorPassword = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsFirstLogin = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MedicationID = table.Column<int>(type: "integer", nullable: false),
                    MedicationName = table.Column<string>(type: "text", nullable: false),
                    ActiveIngredient = table.Column<string>(type: "text", nullable: false),
                    UsageInstructions = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientID = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    ContactInformation = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    EmergencyContactFirstName = table.Column<string>(type: "text", nullable: false),
                    EmergencyContactLastName = table.Column<string>(type: "text", nullable: false),
                    EmergencyContactPhone = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsFirstLogin = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorPatients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ID = table.Column<int>(type: "integer", nullable: false),
                    PatientID = table.Column<int>(type: "integer", nullable: false),
                    DoctorID = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_Doctors_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorPatients_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationPatients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ID = table.Column<int>(type: "integer", nullable: false),
                    MedicationID = table.Column<int>(type: "integer", nullable: false),
                    PatientID = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationPatients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicationPatients_Medications_MedicationID",
                        column: x => x.MedicationID,
                        principalTable: "Medications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationPatients_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiseases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ID = table.Column<int>(type: "integer", nullable: false),
                    PatientID = table.Column<int>(type: "integer", nullable: false),
                    DiseaseID = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PatientDiseases_Diseases_DiseaseID",
                        column: x => x.DiseaseID,
                        principalTable: "Diseases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientDiseases_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "AdminID", "ContactInformation", "CreatedAt", "FirstName", "IsDeleted", "LastName", "Password", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, 0, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(2819), "Emre", false, "Oz", "123", null, "Emre" },
                    { 2, 0, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(2825), "Batuhan", false, "Ya", "123", null, "Batuhan" },
                    { 3, 0, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(2828), "Ziya", false, "XX", "123", null, "Ziya" }
                });

            migrationBuilder.InsertData(
                table: "Diseases",
                columns: new[] { "Id", "CreatedAt", "Description", "DiseaseID", "DiseaseName", "IsDeleted", "Symptoms", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 20, 14, 22, 3, 11, DateTimeKind.Local).AddTicks(1409), "Açıklama1", 0, "Hasta1", false, "Semptomlar1", null },
                    { 2, new DateTime(2024, 9, 20, 14, 22, 3, 11, DateTimeKind.Local).AddTicks(1415), "Açıklama2", 0, "Hasta2", false, "Semptomlar2", null },
                    { 3, new DateTime(2024, 9, 20, 14, 22, 3, 11, DateTimeKind.Local).AddTicks(1422), "Açıklama3", 0, "Hasta3", false, "Semptomlar3", null }
                });

            migrationBuilder.InsertData(
                table: "DoctorPatients",
                columns: new[] { "Id", "CreatedAt", "DoctorID", "ID", "IsDeleted", "PatientID", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(8822), 0, 0, false, 0, null },
                    { 2, new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(8829), 0, 0, false, 0, null },
                    { 3, new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(8833), 0, 0, false, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "ContactInformation", "CreatedAt", "DoctorID", "DoctorPassword", "DoctorUsername", "FirstName", "IsDeleted", "IsFirstLogin", "LastName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(5053), 0, "123", "Doktor1", "A", false, false, "A", null },
                    { 2, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(5059), 0, "123", "Doktor2", "B", false, false, "B", null },
                    { 3, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 10, DateTimeKind.Local).AddTicks(5066), 0, "123", "Doktor3", "C", false, false, "C", null }
                });

            migrationBuilder.InsertData(
                table: "MedicationPatients",
                columns: new[] { "Id", "CreatedAt", "ID", "IsDeleted", "MedicationID", "PatientID", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 20, 14, 22, 3, 12, DateTimeKind.Local).AddTicks(2554), 0, false, 0, 0, null },
                    { 2, new DateTime(2024, 9, 20, 14, 22, 3, 12, DateTimeKind.Local).AddTicks(2560), 0, false, 0, 0, null },
                    { 3, new DateTime(2024, 9, 20, 14, 22, 3, 12, DateTimeKind.Local).AddTicks(2563), 0, false, 0, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "ActiveIngredient", "CreatedAt", "IsDeleted", "MedicationID", "MedicationName", "UpdatedAt", "UsageInstructions" },
                values: new object[,]
                {
                    { 1, "3", new DateTime(2024, 9, 20, 14, 22, 3, 12, DateTimeKind.Local).AddTicks(6823), false, 0, "İlaç1", null, "2" },
                    { 2, "3", new DateTime(2024, 9, 20, 14, 22, 3, 12, DateTimeKind.Local).AddTicks(6830), false, 0, "İlaç2", null, "2" },
                    { 3, "3", new DateTime(2024, 9, 20, 14, 22, 3, 12, DateTimeKind.Local).AddTicks(6836), false, 0, "İlaç3", null, "2" }
                });

            migrationBuilder.InsertData(
                table: "PatientDiseases",
                columns: new[] { "Id", "CreatedAt", "DiseaseID", "ID", "IsDeleted", "PatientID", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 20, 14, 22, 3, 13, DateTimeKind.Local).AddTicks(1497), 0, 0, false, 0, null },
                    { 2, new DateTime(2024, 9, 20, 14, 22, 3, 13, DateTimeKind.Local).AddTicks(1500), 0, 0, false, 0, null },
                    { 3, new DateTime(2024, 9, 20, 14, 22, 3, 13, DateTimeKind.Local).AddTicks(1503), 0, 0, false, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "ContactInformation", "CreatedAt", "DateOfBirth", "EmergencyContactFirstName", "EmergencyContactLastName", "EmergencyContactPhone", "FirstName", "Gender", "IsDeleted", "IsFirstLogin", "LastName", "Password", "PatientID", "UpdatedAt", "Username" },
                values: new object[] { 1, "0555", new DateTime(2024, 9, 20, 14, 22, 3, 11, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "X", "X", "0256", "XX", "M", false, false, "XX", "123", 0, null, "Hasta1" });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_DoctorID",
                table: "DoctorPatients",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorPatients_PatientID",
                table: "DoctorPatients",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationPatients_MedicationID",
                table: "MedicationPatients",
                column: "MedicationID");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationPatients_PatientID",
                table: "MedicationPatients",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiseases_DiseaseID",
                table: "PatientDiseases",
                column: "DiseaseID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientDiseases_PatientID",
                table: "PatientDiseases",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "DoctorPatients");

            migrationBuilder.DropTable(
                name: "MedicationPatients");

            migrationBuilder.DropTable(
                name: "PatientDiseases");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Medications");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
