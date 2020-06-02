namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting
open ProjectEulerInFSharp

[<TestClass>]
type FileScorerTests () =

    // Using a 46K text file containing over five-thousand first names, begin by
    // sorting it into alphabetical order. Then working out the alphabetical value
    //for each name, multiply this value by its alphabetical position in the list to obtain a name score.

    // For example, when the list is sorted into alphabetical order, COLIN,
    // which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
    // So, COLIN would obtain a score of 938 × 53 = 49714.
    [<TestMethod>]
    member this.ColinPosition () =
        let names = new FileScorer()
        Assert.AreEqual("COLIN", names.NameAtPosition(938));

    [<TestMethod>]
    member this.ColinPositionScore () =
        let names = new FileScorer()
        Assert.AreEqual(938, names.PositionScore("Colin"));

    [<TestMethod>]
    member this.LetterScore () =
        let names = new FileScorer()
        Assert.AreEqual(1, names.AlphabeticalScore("A"));
        Assert.AreEqual(1, names.AlphabeticalScore("a"));
        Assert.AreEqual(26, names.AlphabeticalScore("Z"));
        Assert.AreEqual(26, names.AlphabeticalScore("z"));

    [<TestMethod>]
    member this.ColinAlphabeticalScore () =
        let names = new FileScorer()
        let colinScore = names.AlphabeticalScore("Colin")
        Assert.AreEqual(53, colinScore);

    [<TestMethod>]
    member this.ColinTotalScore () =
        let names = new FileScorer()
        let colinScore = names.TotalScore("Colin")
        Assert.AreEqual(49714, colinScore);

    // What is the total of all the name scores in the file?