namespace FSI.ActionScore.Domain.Entities
{
    public sealed class ImpactType
    {
        public int Id { get; set; }                // PK
        public string Name { get; set; } = null!;  // Naive, Perspicacious, etc.
        public string? Description { get; set; }
        public int Score { get; set; }             // -2, -1, 1, 2

        public ICollection<ActionModel> ActionModels { get; set; } = new List<ActionModel>();
        public ICollection<ActionRecord> ActionRecords { get; set; } = new List<ActionRecord>();
    }
}
