using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies.Sections;

public class ContactSection : ISectionStrategy
{
    private string _id { get { return "contact"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return "ContactSection";
    }
}
