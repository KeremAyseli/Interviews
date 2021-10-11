using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RaporForm
{
    public class RaporFormTaslak
    {
        [Key]
        public string DN { get; set; }
        public int NurseId { get; set; }
        public string DM { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Gender { get; set; }
        public double Height { get; set; }
        public string Country { get; set; }
        public string Ethnicity { get; set; }
        public double Weight { get; set; }
        public string educationlevel { get; set; }
        public string Job { get; set; }
        public string EnvironmentalExposure { get; set; }
        public bool HarmfulState { get; set; }
        public string HarmfulType { get; set; }
        public int HarmfulAmount { get; set; }
        public bool HarmfulCurrentState { get; set; }
        public DateTime? HarmfulQuitData { get; set; }
        public string SicknessOrElse { get; set; }
        public DateTime SicknessDiagnosisDate { get; set; }
        public bool SicknessState { get; set; }
        public string SicknessICD10CODE { get; set; }
        public string Kinship { get; set; }
        public string KinshipDiagnosis { get; set; }
        public DateTime KinshipDiagnosisDate { get; set; }
        public string GynecologicalHistoryMenstrualState { get; set; }
        public DateTime GynecologicalLastPsmDate { get; set; }
        public int GynecologicalPregnants { get; set; }
        public int GynecologicalBirth { get; set; }
        public string DrugsDrugName { get; set; }
        public string DrugsDose { get; set; }
        public string DrugsUnit { get; set; }
        public string DrugsUsage { get; set; }
        public string DrugsFrequency { get; set; }
        public bool DrugsCurrentState { get; set; }
        public bool VIHIV12TestState { get; set; }
        public string VIHIV12Result { get; set; }
        public bool VIHepatitATestState { get; set; }
        public string VIHepatitAResult { get; set; }
        public bool VIHepatitBTestState { get; set; }
        public string VIHepatitBResult { get; set; }
        public bool VIHepatitCTestState { get; set; }
        public string VIHepatitCResult { get; set; }
        public bool VISyphilisTestState { get; set; }
        public string VISyphilisResult { get; set; }
        public DateTime SampleCollectionDate { get; set; }
        public TimeSpan SampleCollectionTime { get; set; }
        public string SampleCollectionAnatomicalRegion { get; set; }
        public string SampleCollectionFormOfCollection { get; set; }
        public string OperationProcedure { get; set; }
        public DateTime DiagnosticInformationDate { get; set; }
        public string DiagnosticInformationClinicalDiagnosis { get; set; }
        public string DiagnosticInformationICD10Code { get; set; }
        public string PathologyStatusFormOfCollection { get; set; }
        public string PathologyStatusMicroscopicAnalysis { get; set; }
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
