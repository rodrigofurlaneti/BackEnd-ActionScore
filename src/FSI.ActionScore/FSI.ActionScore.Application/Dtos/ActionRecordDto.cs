namespace FSI.ActionScore.Application.Dtos
{
    public sealed class ActionRecordDto
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int? ActionModelId { get; set; }
        public int ImpactTypeId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
