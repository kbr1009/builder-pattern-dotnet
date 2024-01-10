// ビルダーパターンの練習
using builder_pattern_dotnet;

var b = UserBuilder.Instance
    .SetName("小林怜雄")
    .SetBirth(new DateTime(1998, 10, 9))
    .SetNickname("コバレオ")
    .Build();

Console.WriteLine(b.Name);
Console.WriteLine(b.Birth);
Console.WriteLine(b.Nickname);
