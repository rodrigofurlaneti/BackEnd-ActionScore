namespace FSI.ActionScore.Application.Common
{
    public sealed class BaseResponse<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public List<string> Errors { get; set; } = new();
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public static BaseResponse<T> Ok(T data) =>
            new() { Success = true, Data = data };

        public static BaseResponse<T> Fail(params string[] errors) =>
            new() { Success = false, Errors = errors.ToList() };
    }
}
