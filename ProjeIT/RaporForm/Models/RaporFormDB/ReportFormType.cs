using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace RaporForm.Models.RaporFormDB
{
    [Table("RaporFormType")]
    public class ReportFormType
    {
        [Key]
        public int FormId { get; set; }
        [Required]
        public string DN { get; set; }
        public int NurseId { get; set; }
        [Required]
        public string DM { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public bool Gender { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Ethnicity { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public string Educationlevel { get; set; }
        [Required]
        public string Job { get; set; }
        [Required]
        public string EnvironmentalExposure { get; set; }
        [Required]
        public bool HarmfulState { get; set; }
        [Required]
        public string HarmfulType { get; set; }
        [Required]
        public int HarmfulAmount { get; set; }
        [Required]
        public bool HarmfulCurrentState { get; set; }
        [Required]
        public DateTime? HarmfulQuitData { get; set; }
        [Required]
        public string SicknessOrElse { get; set; }
        [Required]
        public DateTime SicknessDiagnosisDate { get; set; }
        [Required]
        public bool SicknessState { get; set; }
        [Required]
        public string SicknessICD10CODE { get; set; }
        [Required]
        public string Kinship { get; set; }
        [Required]
        public string KinshipDiagnosis { get; set; }
        [Required]
        public DateTime KinshipDiagnosisDate { get; set; }
        [Required]
        public string GynecologicalHistoryMenstrualState { get; set; }
        [Required]
        public DateTime GynecologicalLastPsmDate { get; set; }
        [Required]
        public int GynecologicalPregnants { get; set; }
        [Required]
        public int GynecologicalBirth { get; set; }
        [Required]
        public string DrugsDrugName { get; set; }
        [Required]
        public string DrugsDose { get; set; }
        [Required]
        public string DrugsUnit { get; set; }
        [Required]
        public string DrugsUsage { get; set; }
        [Required]
        public string DrugsFrequency { get; set; }
        [Required]
        public bool DrugsCurrentState { get; set; }
        [Required]
        public bool VIHIV12TestState { get; set; }
        [Required]
        public string VIHIV12Result { get; set; }
        [Required]
        public bool VIHepatitATestState { get; set; }
        [Required]
        public string VIHepatitAResult { get; set; }
        [Required]
        public bool VIHepatitBTestState { get; set; }
        [Required]
        public string VIHepatitBResult { get; set; }
        [Required]
        public bool VIHepatitCTestState { get; set; }
        [Required]
        public string VIHepatitCResult { get; set; }
        [Required]
        public bool VISyphilisTestState { get; set; }
        [Required]
        public string VISyphilisResult { get; set; }
        [Required]
        public DateTime SampleCollectionDate { get; set; }
        [Required]
        public TimeSpan SampleCollectionTime { get; set; }
        [Required]
        public string SampleCollectionAnatomicalRegion { get; set; }
        [Required]
        public string SampleCollectionFormOfCollection { get; set; }
        [Required]
        public string OperationProcedure { get; set; }
        [Required]
        public DateTime DiagnosticInformationDate { get; set; }
        [Required]
        public string DiagnosticInformationClinicalDiagnosis { get; set; }
        [Required]
        public string DiagnosticInformationICD10Code { get; set; }
        [Required]
        public string PathologyStatusFormOfCollection { get; set; }
        [Required]
        public string PathologyStatusMicroscopicAnalysis { get; set; }
        [Required]
        public string PathologyStatusPathologyDiagnosis { get; set; }
        public string TumorSite { get; set; }
        public string TumorSize { get; set; }
        public string TumorTNM { get; set; }
        public int TumorStage { get; set; }
        public string TumorType { get; set; }
        public string MetastasisOrgan { get; set; }
        public string MetastasisLymphNodeProc { get; set; }
        public string MetastasisLymphHMetastasis { get; set; }
        public string MetastasisLymphLocation { get; set; }
        public string MetastasisDistantMetastasis { get; set; }
        public string MetastasisDistantMetastasisLocation { get; set; }
        public string CancerCureType { get; set; }
        public DateTime CancerCureStartDate { get; set; }
        public DateTime CancerCureEndDate { get; set; }
        public string CancerCureResult { get; set; }
        public string CancerCureImplementationType { get; set; }
        public string ImmunohistochemistryTestERTestState { get; set; }
        public string ImmunohistochemistryResultER { get; set; }
        public string ImmunohistochemistryTestPRTestState { get; set; }
        public string ImmunohistochemistryResultPR { get; set; }
        public string ImmunohistochemistryTestHER2TestState { get; set; }
        public string ImmunohistochemistryResultHER2 { get; set; }
        public string ImmunohistochemistryTestMLH1TestState { get; set; }
        public string ImmunohistochemistryResultMLH1 { get; set; }
        public string ImmunohistochemistryTestPMS2TestState { get; set; }
        public string ImmunohistochemistryResultPMS2 { get; set; }
        public string ImmunohistochemistryTestMSH2TestState { get; set; }
        public string ImmunohistochemistryResultMSH2 { get; set; }
        public string ImmunohistochemistryTestMSH6TestState { get; set; }
        public string ImmunohistochemistryResultMS6 { get; set; }
        public string AdditionalInformation { get; set; }
        public string Note { get; set; }
    }
}
