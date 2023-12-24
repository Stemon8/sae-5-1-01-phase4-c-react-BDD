using backend.Data;
using backend.Data.Models;
using backend.FormModels;
using backend.Services.Class;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace backend.Specs.Steps;

[Binding]
public class BackendStepDefinitions
{
    private readonly ScenarioContext _scenarioContext;
    private readonly WebApplicationFactory<Program> _factory;

    private readonly EntityContext _context;

    public BackendStepDefinitions(EntityContext context, ScenarioContext scenarioContext, WebApplicationFactory<Program> factory)
    {
        _context = context;
        _scenarioContext = scenarioContext;
        _factory = factory;

        _factory.CreateClient();
    }

    [Given(@"a challenge named ""(.*)""")]
    public void GivenAChallengeNamed(string challenge0)
    {
        _scenarioContext["challengeForm"] = new ChallengeForm
        {
            name = challenge0
        };
    }
        
    [Given(@"a description with contents ""(.*)""")]
    public void GivenADescriptionWithContents(string contents0)
    {
        (_scenarioContext["challengeForm"] as ChallengeForm)!.description = contents0;
    }
        
    [Given(@"a team Guid of ""(.*)""")]
    public void GivenATeamGuidOf(Guid teamGuid0)
    {
        (_scenarioContext["challengeForm"] as ChallengeForm)!.creator_team_id = teamGuid0;
    }
        
    [Given(@"a target Guid of ""(.*)""")]
    public void GivenATargetGuidOf(Guid targetGuid0)
    {
        (_scenarioContext["challengeForm"] as ChallengeForm)!.target_team_id = targetGuid0;
    }
        
    [When(@"when I add the challenge")]
    public void WhenWhenIAddTheChallenge()
    {
        var service = new ChallengeService(_context);
        service.AddChallenge((_scenarioContext["challengeForm"] as ChallengeForm)!);
        _context.SaveChanges();

        _scenarioContext["challengeService"] = service;
    }
        
    [Then(@"the challenge should be added")]
    public void ThenTheChallengeShouldBeAdded()
    {
        var targetTeamId = (_scenarioContext["challengeForm"] as ChallengeForm)!.target_team_id;
        var challenges = (_scenarioContext["challengeService"] as ChallengeService)!.GetChallengesByTargetTeamId(targetTeamId);

        var challenge = challenges.Find(challengeDb => challengeDb.name == (_scenarioContext["challengeForm"] as ChallengeForm)!.name);

        Assert.True(challenge != null);

        _scenarioContext["challenge"] = challenge;
    }
        
    [Then(@"the challenge should have a completion state of false")]
    public void ThenTheChallengeShouldHaveACompletionStateOfFalse()
    {
        Assert.True((_scenarioContext["challenge"] as Challenge)!.completed == false);
    }
}