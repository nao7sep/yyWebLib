namespace yyWebLib
{
    public class yyWebUserLoginAttempt
    {
        public int? Id { get; init; }
        public Guid Guid { get; init; }

        public yyWebUser? User { get; init; }
        public int? UserId { get; init; }
        public Guid UserGuid { get; init; }

        public DateTime Utc { get; init; }

        public string? IPv6 { get; init; }
        public string? IPv4 { get; init; }
        public string? UserAgent { get; init; }

        public bool IsSuccess { get; init; }
    }
}
