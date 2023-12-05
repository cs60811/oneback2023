
using FluentAssertions;
using OneBackComboTrainingWeb;

namespace OneBackTests;

public class TennisGameTest
{
    TennisGame _tennisGame = new TennisGame("Eva","Eric");

    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void tennis_game_int()
    {
        string result = _tennisGame.RefreshScore(string.Empty);
        result.Should().Be("love all");
    }
    [Test]
    public void tennis_game_add_score()
    {
        string result = _tennisGame.RefreshScore("Eva");
        result.Should().Be("fifteen love");
    }

    private void ThemeShouldBe(string expected)
    {
        //string result = holiday.GetTheme();
        //    .Should().Be(result)
        //result.Should().Be(expected);
    }




}