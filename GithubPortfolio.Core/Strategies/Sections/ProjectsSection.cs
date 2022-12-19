using GithubPortfolio.Core.Interfaces.Strategies;
using GithubPortfolio.Core.Models;

namespace GithubPortfolio.Core.Strategies.Sections;

public class ProjectsSection : ISectionStrategy
{
    private string _id { get { return "projects"; } }
    public string Id { get { return _id; } }

    public string CreateContent(User user)
    {
        return $"""
                <div class="section" id="{_id}" 
                style="
                margin: 0rem 0;
                gap: 2rem; 
                padding: 4rem 0;">
                    <h2 style="font-size: 2.5rem;"> Projects </h2>
                    <div style="display: flex;
                    justify-content: center;
                    align-items: center;
                    gap: 2rem;">
                   
                    </div>
                </div> 
                """;
    }
}
