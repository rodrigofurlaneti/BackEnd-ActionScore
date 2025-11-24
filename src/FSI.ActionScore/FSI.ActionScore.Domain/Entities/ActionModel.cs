namespace FSI.ActionScore.Domain.Entities
{
    public sealed class ActionModel
    {
        public int Id { get; set; }                        // PK
        public int ImpactTypeId { get; set; }
        public string Title { get; set; } = null!;         // e.g. "Submit Task"
        public string? Description { get; set; }
        public int Score { get; set; }                     // usually same as ImpactType.Score
        public bool IsActive { get; set; }
        public ImpactType ImpactType { get; set; } = null!;
        public ICollection<ActionRecord> ActionRecords { get; set; } = new List<ActionRecord>();
    }
}
