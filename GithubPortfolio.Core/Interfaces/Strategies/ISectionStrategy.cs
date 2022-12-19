using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Interfaces.Strategies;

public interface ISectionStrategy
{
    string Id { get; }
    string CreateContent(User user);
}
