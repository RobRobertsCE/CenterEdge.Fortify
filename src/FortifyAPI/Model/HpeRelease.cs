namespace FortifyAPI.Model
{
    public class HpeRelease
    {
        public int releaseId { get; set; }
        public string releaseName { get; set; }
        public object releaseDescription { get; set; }
        public string releaseCreatedDate { get; set; }
        public int applicationId { get; set; }
        public string applicationName { get; set; }
        public int currentAnalysisStatusTypeId { get; set; }
        public string currentAnalysisStatusType { get; set; }
        public int rating { get; set; }
        public int critical { get; set; }
        public int high { get; set; }
        public int medium { get; set; }
        public int low { get; set; }
        public int currentStaticScanId { get; set; }
        public object currentDynamicScanId { get; set; }
        public object currentMobileScanId { get; set; }
        public string staticAnalysisStatusType { get; set; }
        public object dynamicAnalysisStatusType { get; set; }
        public object mobileAnalysisStatusType { get; set; }
        public int staticAnalysisStatusTypeId { get; set; }
        public object dynamicAnalysisStatusTypeId { get; set; }
        public object mobileAnalysisStatusTypeId { get; set; }
        public string staticScanDate { get; set; }
        public object dynamicScanDate { get; set; }
        public object mobileScanDate { get; set; }
        public int issueCount { get; set; }
        public bool isPassed { get; set; }
        public object passFailReasonTypeId { get; set; }
        public object passFailReasonType { get; set; }
        public int sdlcStatusTypeId { get; set; }
        public string sdlcStatusType { get; set; }
    }

    public class HpeReleasesResponse
    {
        public HpeRelease[] items { get; set; }
        public int totalCount { get; set; }
    }
}
