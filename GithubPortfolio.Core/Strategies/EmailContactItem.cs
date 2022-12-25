using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies;

public class EmailContactItem : IContentStrategy
{
    private string _id { get { return "email"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        user.Email = VerifyEmail(user);
        return string.IsNullOrEmpty(user.Location) ? string.Empty : $"""
                <div class="contact-item" id="{_id}">
                    <span> My Email is <a href="mailto:{user.Email}">{user.Email}</a>, contact-me! </span>
                </div>
            """;
    }

    private string VerifyEmail(User user)
    {
        if (user.Email is null)
        {
            if (user.Username.ToLower() == "stringao")
            {
                return "ricardo.oliveira@msn.com";
            }
            return $"{user.Username}@email.com";
        }
        return user.Email;
    }
}
