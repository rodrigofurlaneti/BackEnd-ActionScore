namespace FSI.ActionScore.Domain.Entities
{
    public sealed class ActionRecord
    {
        public int Id { get; set; }                // PK
        public int UserAccountId { get; set; }
        public int? ActionModelId { get; set; }
        public int ImpactTypeId { get; set; }

        public string? Title { get; set; }         // livre pelo usuário
        public string? Description { get; set; }
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }

        public UserAccount UserAccount { get; set; } = null!;
        public ActionModel? ActionModel { get; set; }
        public ImpactType ImpactType { get; set; } = null!;
    }
}
