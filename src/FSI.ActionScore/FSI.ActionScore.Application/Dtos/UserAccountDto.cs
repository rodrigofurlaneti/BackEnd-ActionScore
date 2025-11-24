namespace FSI.ActionScore.Application.Dtos
{
    public sealed class UserAccountDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
