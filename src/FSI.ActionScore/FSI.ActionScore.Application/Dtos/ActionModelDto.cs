namespace FSI.ActionScore.Application.Dtos
{
    public sealed class ActionModelDto
    {
        public int Id { get; set; }
        public int ImpactTypeId { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int Score { get; set; }
        public bool IsActive { get; set; }
    }
}
