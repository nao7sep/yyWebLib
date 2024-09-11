namespace yyWebLib
{
    public enum yyWebUserRole
    {
        // Super Admin: Has the highest level of access and control over the entire system.
        // Responsibilities include managing all aspects of the system, including users, settings, security, and configurations.
        SuperAdmin = 100,

        // Admin: Responsible for overseeing general administrative tasks but has slightly fewer privileges than the Super Admin.
        // Admins can manage users, moderate content, and access most system settings, except for critical security and infrastructure settings.
        Admin = 90,

        // Moderator: Focused on content moderation and user interactions. Moderators have permissions to manage user-generated content.
        // They can approve, edit, delete posts, and handle reports of inappropriate content, but cannot manage system-level settings or users.
        Moderator = 70,

        // Author: A content creator role. Authors can write and manage their own content (e.g., posts or articles).
        // However, they may need approval from higher roles (e.g., Moderators or Admins) before publishing.
        Author = 50,

        // Registered User: Regular, authenticated user who has signed up for an account on the system.
        // Registered users have basic access, such as viewing content, commenting, and interacting with certain system features.
        RegisteredUser = 30,

        // Guest: Unauthenticated user with very limited access. Guests can typically browse public content but are restricted from interacting with most features.
        // They are often encouraged to sign up or log in for full access.
        Guest = 10
    }
}
