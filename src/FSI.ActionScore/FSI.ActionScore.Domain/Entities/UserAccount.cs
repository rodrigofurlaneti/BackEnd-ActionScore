namespace FSI.ActionScore.Domain.Entities
{
    public sealed class UserAccount
    {
        public int Id { get; set; }                        // PK
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }

        public ICollection<ActionRecord> ActionRecords { get; set; } = new List<ActionRecord>();
    }
}
