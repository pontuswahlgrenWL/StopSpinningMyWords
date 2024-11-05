using StopSpinningMyWords;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void SendOneWordLessThanFiveChars_ShouldReturnSameWord()
    {
        Assert.Equal("hey", Kata.SpinWords("hey"));
    }

    [Fact]
    public void SendOneWordMoreThanFourChars_ShouldReturnReversedWord()
    {
        Assert.Equal("regnol", Kata.SpinWords("longer"));
    }

    [Fact]
    public void SendTwoWordsWhereOneIsLongerThanFourChars_ShouldReturnLongerWordReversed()
    {
        Assert.Equal("hey regnol", Kata.SpinWords("hey longer"));
    }

    [Fact]
    public void SendFourWordsWhereTwoAreLongerThanFourChars_ShouldReturnLongerWordReversed()
    {
        Assert.Equal("hey hi regnol ratset", Kata.SpinWords("hey hi longer testar"));
    }
}