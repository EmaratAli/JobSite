using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobSite.Model.Migrations
{
    public partial class ScriptA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInformation_AspNetUsers_UserId",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_UserId",
                table: "PersonalInformation");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PersonalInformation",
                newName: "UserID");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PersonalInformation",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PersonalInformation",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlternateEmail",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "PersonalInformation",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenderID",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaritalStatusID",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MobileNoOne",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MobileNoThree",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNoTwo",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NationalIdNo",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityID",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "PassportIssueDate",
                table: "PersonalInformation",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PassportNumber",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentAddress",
                table: "PersonalInformation",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReligionID",
                table: "PersonalInformation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyDetails",
                columns: table => new
                {
                    CompanyDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    BusinessDescription = table.Column<string>(nullable: false),
                    LicenseNo = table.Column<string>(nullable: false),
                    WebSite = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDetails", x => x.CompanyDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "DegreeLevels",
                columns: table => new
                {
                    DegreeLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeLevelName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeLevels", x => x.DegreeLevelId);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentStatuses",
                columns: table => new
                {
                    EmploymentStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentStatuses", x => x.EmploymentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "FunctionalCategories",
                columns: table => new
                {
                    FunctionalCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FunctionalCategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunctionalCategories", x => x.FunctionalCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IndustryTypes",
                columns: table => new
                {
                    IndustryTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryTypeName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryTypes", x => x.IndustryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "JobCategoryTypes",
                columns: table => new
                {
                    JobCategoryTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCategoryTypeName = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategoryTypes", x => x.JobCategoryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "JobLevel",
                columns: table => new
                {
                    JobLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobLevelName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLevel", x => x.JobLevelId);
                });

            migrationBuilder.CreateTable(
                name: "JobNature",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobNature", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PreferredJobAreas",
                columns: table => new
                {
                    PreferredJobAreasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreferredJobAreaName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferredJobAreas", x => x.PreferredJobAreasId);
                });

            migrationBuilder.CreateTable(
                name: "Religion",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religion", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "SpecialSkillCategories",
                columns: table => new
                {
                    SpecialSkillCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecialSkillCategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialSkillCategories", x => x.SpecialSkillCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(nullable: false),
                    Designation = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    CompanyDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contacts_CompanyDetails_CompanyDetailsId",
                        column: x => x.CompanyDetailsId,
                        principalTable: "CompanyDetails",
                        principalColumn: "CompanyDetailsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                    table.ForeignKey(
                        name: "FK_Districts_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeNames",
                columns: table => new
                {
                    DegreeNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(nullable: false),
                    DegreeLevelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeNames", x => x.DegreeNameId);
                    table.ForeignKey(
                        name: "FK_DegreeNames_DegreeLevels_DegreeLevelId",
                        column: x => x.DegreeLevelId,
                        principalTable: "DegreeLevels",
                        principalColumn: "DegreeLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequiredPeople",
                columns: table => new
                {
                    RequiredPersonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinimumAge = table.Column<int>(nullable: false),
                    MaximumAge = table.Column<int>(nullable: false),
                    GenderID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredPeople", x => x.RequiredPersonId);
                    table.ForeignKey(
                        name: "FK_RequiredPeople_Gender_GenderID",
                        column: x => x.GenderID,
                        principalTable: "Gender",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryTypeDetails",
                columns: table => new
                {
                    IndustryTypeDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryTypeId = table.Column<int>(nullable: false),
                    CompanyDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryTypeDetails", x => x.IndustryTypeDetailsId);
                    table.ForeignKey(
                        name: "FK_IndustryTypeDetails_CompanyDetails_CompanyDetailsId",
                        column: x => x.CompanyDetailsId,
                        principalTable: "CompanyDetails",
                        principalColumn: "CompanyDetailsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryTypeDetails_IndustryTypes_IndustryTypeId",
                        column: x => x.IndustryTypeId,
                        principalTable: "IndustryTypes",
                        principalColumn: "IndustryTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    JobCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobCategoryName = table.Column<string>(nullable: false),
                    JobCategoryTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.JobCategoryId);
                    table.ForeignKey(
                        name: "FK_JobCategories_JobCategoryTypes_JobCategoryTypeId",
                        column: x => x.JobCategoryTypeId,
                        principalTable: "JobCategoryTypes",
                        principalColumn: "JobCategoryTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CareerInformation",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Objective = table.Column<string>(nullable: false),
                    PresentSalary = table.Column<decimal>(type: "MONEY", nullable: false),
                    ExpectedSalary = table.Column<decimal>(type: "MONEY", nullable: false),
                    JobLevelId = table.Column<int>(nullable: false),
                    JobNatureID = table.Column<int>(nullable: false),
                    PersonalInfoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerInformation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CareerInformation_JobLevel_JobLevelId",
                        column: x => x.JobLevelId,
                        principalTable: "JobLevel",
                        principalColumn: "JobLevelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerInformation_JobNature_JobNatureID",
                        column: x => x.JobNatureID,
                        principalTable: "JobNature",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CareerInformation_PersonalInformation_PersonalInfoID",
                        column: x => x.PersonalInfoID,
                        principalTable: "PersonalInformation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Thanas",
                columns: table => new
                {
                    ThanaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanaName = table.Column<string>(nullable: true),
                    DistrictId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thanas", x => x.ThanaId);
                    table.ForeignKey(
                        name: "FK_Thanas_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequiredGenders",
                columns: table => new
                {
                    RequiredGenderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderId = table.Column<int>(nullable: false),
                    RequiredPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredGenders", x => x.RequiredGenderId);
                    table.ForeignKey(
                        name: "FK_RequiredGenders_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequiredGenders_RequiredPeople_RequiredPersonId",
                        column: x => x.RequiredPersonId,
                        principalTable: "RequiredPeople",
                        principalColumn: "RequiredPersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    RequirementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtherEducationalQualification = table.Column<string>(nullable: false),
                    Training = table.Column<string>(nullable: false),
                    ProfessionalCertification = table.Column<string>(nullable: false),
                    AdditionalRequirements = table.Column<string>(nullable: false),
                    RequiredPersonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.RequirementId);
                    table.ForeignKey(
                        name: "FK_Requirements_RequiredPeople_RequiredPersonId",
                        column: x => x.RequiredPersonId,
                        principalTable: "RequiredPeople",
                        principalColumn: "RequiredPersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanaId = table.Column<int>(nullable: false),
                    CompanyAddress = table.Column<string>(nullable: false),
                    CompanyDetailsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_CompanyDetails_CompanyDetailsId",
                        column: x => x.CompanyDetailsId,
                        principalTable: "CompanyDetails",
                        principalColumn: "CompanyDetailsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Thanas_ThanaId",
                        column: x => x.ThanaId,
                        principalTable: "Thanas",
                        principalColumn: "ThanaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    DegreeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeNameId = table.Column<int>(nullable: false),
                    Major = table.Column<string>(nullable: false),
                    RequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.DegreeId);
                    table.ForeignKey(
                        name: "FK_Degrees_DegreeNames_DegreeNameId",
                        column: x => x.DegreeNameId,
                        principalTable: "DegreeNames",
                        principalColumn: "DegreeNameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Degrees_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MinimumYears = table.Column<int>(nullable: false),
                    MaximumYears = table.Column<int>(nullable: false),
                    FresherAllowed = table.Column<bool>(nullable: false),
                    AreaOfExperience = table.Column<string>(nullable: false),
                    AreaOfBusiness = table.Column<string>(nullable: false),
                    RequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                    table.ForeignKey(
                        name: "FK_Experiences_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobInformation",
                columns: table => new
                {
                    JobInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyDetailsId = table.Column<int>(nullable: false),
                    ServiceType = table.Column<string>(nullable: false),
                    JobTitle = table.Column<string>(nullable: false),
                    NoOfVacancy = table.Column<int>(nullable: false),
                    JobCategoryId = table.Column<int>(nullable: false),
                    ApplicationDeadLine = table.Column<DateTime>(nullable: false),
                    ResumeOption = table.Column<string>(nullable: false),
                    SpecialInstruction = table.Column<string>(nullable: false),
                    Photograph = table.Column<bool>(nullable: false),
                    JobContext = table.Column<string>(nullable: false),
                    JobResponsibility = table.Column<string>(nullable: false),
                    JobLocation = table.Column<string>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    Bonus = table.Column<decimal>(nullable: false),
                    RequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobInformation", x => x.JobInformationId);
                    table.ForeignKey(
                        name: "FK_JobInformation_CompanyDetails_CompanyDetailsId",
                        column: x => x.CompanyDetailsId,
                        principalTable: "CompanyDetails",
                        principalColumn: "CompanyDetailsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobInformation_JobCategories_JobCategoryId",
                        column: x => x.JobCategoryId,
                        principalTable: "JobCategories",
                        principalColumn: "JobCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobInformation_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillDetails",
                columns: table => new
                {
                    SkillDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillId = table.Column<int>(nullable: false),
                    RequirementId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillDetails", x => x.SkillDetailsId);
                    table.ForeignKey(
                        name: "FK_SkillDetails_Requirements_RequirementId",
                        column: x => x.RequirementId,
                        principalTable: "Requirements",
                        principalColumn: "RequirementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillDetails_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "SkillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentRequiredStatuses",
                columns: table => new
                {
                    EmploymentRequiredStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentStatusId = table.Column<int>(nullable: false),
                    JobInformationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentRequiredStatuses", x => x.EmploymentRequiredStatusId);
                    table.ForeignKey(
                        name: "FK_EmploymentRequiredStatuses_EmploymentStatuses_EmploymentStatusId",
                        column: x => x.EmploymentStatusId,
                        principalTable: "EmploymentStatuses",
                        principalColumn: "EmploymentStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmploymentRequiredStatuses_JobInformation_JobInformationId",
                        column: x => x.JobInformationId,
                        principalTable: "JobInformation",
                        principalColumn: "JobInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequiredJobLevels",
                columns: table => new
                {
                    RequiredJobLevelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobLevelId = table.Column<int>(nullable: false),
                    JobInformationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequiredJobLevels", x => x.RequiredJobLevelId);
                    table.ForeignKey(
                        name: "FK_RequiredJobLevels_JobInformation_JobInformationId",
                        column: x => x.JobInformationId,
                        principalTable: "JobInformation",
                        principalColumn: "JobInformationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequiredJobLevels_JobLevel_JobLevelId",
                        column: x => x.JobLevelId,
                        principalTable: "JobLevel",
                        principalColumn: "JobLevelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_GenderID",
                table: "PersonalInformation",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_MaritalStatusID",
                table: "PersonalInformation",
                column: "MaritalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_NationalityID",
                table: "PersonalInformation",
                column: "NationalityID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_ReligionID",
                table: "PersonalInformation",
                column: "ReligionID");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_UserID",
                table: "PersonalInformation",
                column: "UserID",
                unique: true,
                filter: "[UserID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CompanyDetailsId",
                table: "Addresses",
                column: "CompanyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ThanaId",
                table: "Addresses",
                column: "ThanaId");

            migrationBuilder.CreateIndex(
                name: "IX_CareerInformation_JobLevelId",
                table: "CareerInformation",
                column: "JobLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_CareerInformation_JobNatureID",
                table: "CareerInformation",
                column: "JobNatureID");

            migrationBuilder.CreateIndex(
                name: "IX_CareerInformation_PersonalInfoID",
                table: "CareerInformation",
                column: "PersonalInfoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CompanyDetailsId",
                table: "Contacts",
                column: "CompanyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeNames_DegreeLevelId",
                table: "DegreeNames",
                column: "DegreeLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_DegreeNameId",
                table: "Degrees",
                column: "DegreeNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Degrees_RequirementId",
                table: "Degrees",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CountryId",
                table: "Districts",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentRequiredStatuses_EmploymentStatusId",
                table: "EmploymentRequiredStatuses",
                column: "EmploymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EmploymentRequiredStatuses_JobInformationId",
                table: "EmploymentRequiredStatuses",
                column: "JobInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_RequirementId",
                table: "Experiences",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryTypeDetails_CompanyDetailsId",
                table: "IndustryTypeDetails",
                column: "CompanyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryTypeDetails_IndustryTypeId",
                table: "IndustryTypeDetails",
                column: "IndustryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_JobCategoryTypeId",
                table: "JobCategories",
                column: "JobCategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInformation_CompanyDetailsId",
                table: "JobInformation",
                column: "CompanyDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInformation_JobCategoryId",
                table: "JobInformation",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JobInformation_RequirementId",
                table: "JobInformation",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredGenders_GenderId",
                table: "RequiredGenders",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredGenders_RequiredPersonId",
                table: "RequiredGenders",
                column: "RequiredPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredJobLevels_JobInformationId",
                table: "RequiredJobLevels",
                column: "JobInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredJobLevels_JobLevelId",
                table: "RequiredJobLevels",
                column: "JobLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_RequiredPeople_GenderID",
                table: "RequiredPeople",
                column: "GenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_RequiredPersonId",
                table: "Requirements",
                column: "RequiredPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillDetails_RequirementId",
                table: "SkillDetails",
                column: "RequirementId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillDetails_SkillId",
                table: "SkillDetails",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Thanas_DistrictId",
                table: "Thanas",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInformation_Gender_GenderID",
                table: "PersonalInformation",
                column: "GenderID",
                principalTable: "Gender",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInformation_MaritalStatus_MaritalStatusID",
                table: "PersonalInformation",
                column: "MaritalStatusID",
                principalTable: "MaritalStatus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInformation_Nationality_NationalityID",
                table: "PersonalInformation",
                column: "NationalityID",
                principalTable: "Nationality",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInformation_Religion_ReligionID",
                table: "PersonalInformation",
                column: "ReligionID",
                principalTable: "Religion",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInformation_AspNetUsers_UserID",
                table: "PersonalInformation",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInformation_Gender_GenderID",
                table: "PersonalInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInformation_MaritalStatus_MaritalStatusID",
                table: "PersonalInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInformation_Nationality_NationalityID",
                table: "PersonalInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInformation_Religion_ReligionID",
                table: "PersonalInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalInformation_AspNetUsers_UserID",
                table: "PersonalInformation");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CareerInformation");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Degrees");

            migrationBuilder.DropTable(
                name: "EmploymentRequiredStatuses");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "FunctionalCategories");

            migrationBuilder.DropTable(
                name: "IndustryTypeDetails");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "PreferredJobAreas");

            migrationBuilder.DropTable(
                name: "Religion");

            migrationBuilder.DropTable(
                name: "RequiredGenders");

            migrationBuilder.DropTable(
                name: "RequiredJobLevels");

            migrationBuilder.DropTable(
                name: "SkillDetails");

            migrationBuilder.DropTable(
                name: "SpecialSkillCategories");

            migrationBuilder.DropTable(
                name: "Thanas");

            migrationBuilder.DropTable(
                name: "JobNature");

            migrationBuilder.DropTable(
                name: "DegreeNames");

            migrationBuilder.DropTable(
                name: "EmploymentStatuses");

            migrationBuilder.DropTable(
                name: "IndustryTypes");

            migrationBuilder.DropTable(
                name: "JobInformation");

            migrationBuilder.DropTable(
                name: "JobLevel");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "DegreeLevels");

            migrationBuilder.DropTable(
                name: "CompanyDetails");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "JobCategoryTypes");

            migrationBuilder.DropTable(
                name: "RequiredPeople");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_GenderID",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_MaritalStatusID",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_NationalityID",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_ReligionID",
                table: "PersonalInformation");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInformation_UserID",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "AlternateEmail",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "GenderID",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "MaritalStatusID",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "MobileNoOne",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "MobileNoThree",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "MobileNoTwo",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "NationalIdNo",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "NationalityID",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "PassportIssueDate",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "PresentAddress",
                table: "PersonalInformation");

            migrationBuilder.DropColumn(
                name: "ReligionID",
                table: "PersonalInformation");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "PersonalInformation",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "PersonalInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "PersonalInformation",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformation_UserId",
                table: "PersonalInformation",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalInformation_AspNetUsers_UserId",
                table: "PersonalInformation",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
