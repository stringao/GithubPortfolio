using GithubPortfolio.Core.Attributes;
using GithubPortfolio.Core.Strategies.Sections;
using System.ComponentModel;

namespace GithubPortfolio.Core.Enums;

public enum ESection
{
    [SectionStrategy(nameof(HomeSection))]
    [Description("Home")]
    Home,

    [SectionStrategy(nameof(MainSkillsSection))]
    [Description("Main Skills")]
    MainSkills,

    [SectionStrategy(nameof(ProjectsSection))]
    [Description("Projects")]
    Projects,

    [SectionStrategy(nameof(ContactSection))]
    [Description("Contact")]
    Contact
}
