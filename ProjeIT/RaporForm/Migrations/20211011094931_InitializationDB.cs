using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RaporForm.Migrations
{
    public partial class InitializationDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    EmployeType = table.Column<int>(type: "int", nullable: false),
                    EmployeTypeImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaporFormType",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NurseId = table.Column<int>(type: "int", nullable: false),
                    DM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ethnicity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Educationlevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnvironmentalExposure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarmfulState = table.Column<bool>(type: "bit", nullable: false),
                    HarmfulType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HarmfulAmount = table.Column<int>(type: "int", nullable: false),
                    HarmfulCurrentState = table.Column<bool>(type: "bit", nullable: false),
                    HarmfulQuitData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SicknessOrElse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SicknessDiagnosisDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SicknessState = table.Column<bool>(type: "bit", nullable: false),
                    SicknessICD10CODE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kinship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KinshipDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KinshipDiagnosisDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GynecologicalHistoryMenstrualState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GynecologicalLastPsmDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GynecologicalPregnants = table.Column<int>(type: "int", nullable: false),
                    GynecologicalBirth = table.Column<int>(type: "int", nullable: false),
                    DrugsDrugName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugsDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugsUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugsUsage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugsFrequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugsCurrentState = table.Column<bool>(type: "bit", nullable: false),
                    VIHIV12TestState = table.Column<bool>(type: "bit", nullable: false),
                    VIHIV12Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIHepatitATestState = table.Column<bool>(type: "bit", nullable: false),
                    VIHepatitAResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIHepatitBTestState = table.Column<bool>(type: "bit", nullable: false),
                    VIHepatitBResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIHepatitCTestState = table.Column<bool>(type: "bit", nullable: false),
                    VIHepatitCResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VISyphilisTestState = table.Column<bool>(type: "bit", nullable: false),
                    VISyphilisResult = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SampleCollectionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SampleCollectionTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    SampleCollectionAnatomicalRegion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SampleCollectionFormOfCollection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperationProcedure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosticInformationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiagnosticInformationClinicalDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosticInformationICD10Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathologyStatusFormOfCollection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathologyStatusMicroscopicAnalysis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathologyStatusPathologyDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TumorSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TumorSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TumorTNM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TumorStage = table.Column<int>(type: "int", nullable: false),
                    TumorType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetastasisOrgan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetastasisLymphNodeProc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetastasisLymphHMetastasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetastasisLymphLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetastasisDistantMetastasis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetastasisDistantMetastasisLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancerCureType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancerCureStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancerCureEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CancerCureResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CancerCureImplementationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestERTestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultER = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestPRTestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultPR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestHER2TestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultHER2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestMLH1TestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultMLH1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestPMS2TestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultPMS2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestMSH2TestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultMSH2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryTestMSH6TestState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImmunohistochemistryResultMS6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaporFormType", x => x.FormId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employe");

            migrationBuilder.DropTable(
                name: "RaporFormType");
        }
    }
}
