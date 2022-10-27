using PinyinNet;

namespace UnitTest.PinyinNet;

public class PinyinNetTester
{
    [Fact]
    public void TestPinyin()
    {
        var actual   = PinyinConvert.GetPinyin("欢迎使用拼音转换工具");
        var expected = "huan|ying|shi|yong|pin|yin|zhuan|huan|gong|ju";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestPinyinFirstLetter()
    {
        var actual   = PinyinConvert.GetPinyinFirstLetter("欢迎使用拼音转换工具");
        var expected = "hysypyzhgj";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestIfInputEmpty()
    {
        var actual   = PinyinConvert.GetPinyin("");
        var expected = "";
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestIfInputNull()
    {
        var actual   = PinyinConvert.GetPinyin(null);
        var expected = "";
        Assert.Equal(expected, actual);
    }
}
