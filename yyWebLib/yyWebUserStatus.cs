namespace yyWebLib
{
    public enum yyWebUserStatus
    {
        // The account is active and the user has full access.
        Active = 1,

        // The account is awaiting email verification or other checks.
        PendingVerification = 2,

        // The account is temporarily suspended, possibly due to violations or pending actions.
        Suspended = 3,

        // The account has been deactivated by the user or admin, but could potentially be reactivated.
        // When an employee leaves the company, deactivation is typically the most suitable action.
        Deactivated = 4,

        // The account is permanently banned, usually due to serious violations.
        Banned = 5
    }
}
