using Microsoft.AspNetCore.Mvc.Testing;

namespace backend.Specs.Steps;

[Binding]
public class BackendStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private WebApplicationFactory<Program> _factory;

    public BackendStepDefinitions(ScenarioContext scenarioContext, WebApplicationFactory<Program> factory)
    {
        _scenarioContext = scenarioContext;
        _factory = factory;
    }
    [Given(@"a challenge named ""(.*)""")]
    public void GivenAChallengeNamed(string challenge0)
    {
        _scenarioContext.Pending();
    }
        
    [Given(@"a description with contents ""(.*)""")]
    public void GivenADescriptionWithContents(string contents0)
    {
        _scenarioContext.Pending();
    }
        
    [Given(@"a team Guid of ""(.*)""")]
    public void GivenATeamGuidOf(string teamGuid0)
    {
        _scenarioContext.Pending();
    }
        
    [Given(@"a target Guid of ""(.*)""")]
    public void GivenATargetGuidOf(string targetGuid0)
    {
        _scenarioContext.Pending();
    }
        
    [When(@"when I add the challenge")]
    public void WhenWhenIAddTheChallenge()
    {
        _scenarioContext.Pending();
    }
        
    [Then(@"the challenge should be added")]
    public void ThenTheChallengeShouldBeAdded()
    {
        _scenarioContext.Pending();
    }
        
    [Then(@"the challenge should have a completion state of false")]
    public void ThenTheChallengeShouldHaveACompletionStateOfFalse()
    {
        _scenarioContext.Pending();
    }
}