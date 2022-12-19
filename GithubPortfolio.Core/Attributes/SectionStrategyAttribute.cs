using GithubPortfolio.Core.Interfaces.Strategies;
using System.Reflection;

namespace GithubPortfolio.Core.Attributes;

internal class SectionStrategyAttribute: Attribute
{
    private readonly ISectionStrategy _sectionStrategy;

    public SectionStrategyAttribute(string sectionName)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        string namespaceName = "Strategies.Sections";
        Type type = assembly.GetType($"{assembly.GetName().Name}.{namespaceName}.{sectionName}");
        _sectionStrategy = (ISectionStrategy?)Activator.CreateInstance(type);
    }

    public ISectionStrategy SectionStrategy { get { return _sectionStrategy; } }
}
