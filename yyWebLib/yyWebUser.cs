namespace yyWebLib
{
    public class yyWebUser
    {
        public int? Id { get; init; }
        public Guid Guid { get; init; }

        public DateTime CreatedAtUtc { get; init; }

        public required yyWebUserStatus Status { get; set; }

        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }

        public List <yyWebUserLoginAttempt> LoginAttempts { get; init; } = [];
        public int LoginAttemptCount { get; set; }
        public int LoginSuccessCount { get; set; }
        public int LoginFailCount { get; set; }
        public DateTime? LastLoginAttemptAtUtc { get; set; }
        public DateTime? LastLoginSuccessAtUtc { get; set; }
        public DateTime? LastLoginFailAtUtc { get; set; }

        public required yyWebUserRole Role { get; set; }

        public string? DisplayName { get; set; }
    }
}
