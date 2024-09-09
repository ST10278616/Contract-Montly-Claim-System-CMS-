namespace Contract_Montly_Claim_System__CMS_.Models
{
    public class Claim
    {
       
            public int Id { get; set; }
            public required string LecturerName { get; set; }
            public double HoursWorked { get; set; }
            public double HourlyRate { get; set; }
            public double ClaimAmount { get; set; }
            public required string Status { get; set; } // "Pending", "Approved", "Rejected", etc.
            public DateTime SubmittedDate { get; set; }
            public required string SupportingDocument { get; set; }
        }
    }
