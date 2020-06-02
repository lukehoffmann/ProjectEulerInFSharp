namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting;
open ProjectEulerInFSharp

[<TestClass>]
type NumberLetterCountingTests () =

    [<TestMethod>]
    member this.OneDigit() =
        Assert.AreEqual(3, NumberLetterCounter.LettersNeededToSpell(1));
        Assert.AreEqual(3, NumberLetterCounter.LettersNeededToSpell(2));
        Assert.AreEqual(5, NumberLetterCounter.LettersNeededToSpell(3));
        Assert.AreEqual(4, NumberLetterCounter.LettersNeededToSpell(4));
        Assert.AreEqual(4, NumberLetterCounter.LettersNeededToSpell(5));
        Assert.AreEqual(3, NumberLetterCounter.LettersNeededToSpell(6));
        Assert.AreEqual(5, NumberLetterCounter.LettersNeededToSpell(7));
        Assert.AreEqual(5, NumberLetterCounter.LettersNeededToSpell(8));
        Assert.AreEqual(4, NumberLetterCounter.LettersNeededToSpell(9));

    [<TestMethod>]
    member this.Teens() =
        Assert.AreEqual(3, NumberLetterCounter.LettersNeededToSpell(10));
        Assert.AreEqual(6, NumberLetterCounter.LettersNeededToSpell(11));
        Assert.AreEqual(6, NumberLetterCounter.LettersNeededToSpell(12));
        Assert.AreEqual(8, NumberLetterCounter.LettersNeededToSpell(13));
        Assert.AreEqual(8, NumberLetterCounter.LettersNeededToSpell(14));
        Assert.AreEqual(7, NumberLetterCounter.LettersNeededToSpell(15));
        Assert.AreEqual(7, NumberLetterCounter.LettersNeededToSpell(16));
        Assert.AreEqual(9, NumberLetterCounter.LettersNeededToSpell(17));
        Assert.AreEqual(8, NumberLetterCounter.LettersNeededToSpell(18));
        Assert.AreEqual(8, NumberLetterCounter.LettersNeededToSpell(19));

    [<TestMethod>]
    member this.TwoDigit() =
        Assert.AreEqual(5, NumberLetterCounter.LettersNeededToSpell(7));
        Assert.AreEqual(10, NumberLetterCounter.LettersNeededToSpell(25));
        Assert.AreEqual(10, NumberLetterCounter.LettersNeededToSpell(99));
        Assert.AreEqual(8, NumberLetterCounter.LettersNeededToSpell(14));
        Assert.AreEqual(5, NumberLetterCounter.LettersNeededToSpell(40));

    [<TestMethod>]
    member this.CountLetters() =
        Assert.AreEqual(0, NumberLetterCounter.LettersNeededToSpell(0));
        Assert.AreEqual(10, NumberLetterCounter.LettersNeededToSpell(100));
        Assert.AreEqual(10, NumberLetterCounter.LettersNeededToSpell(200));
        Assert.AreEqual(12, NumberLetterCounter.LettersNeededToSpell(300));
        Assert.AreEqual(11, NumberLetterCounter.LettersNeededToSpell(1000));
        Assert.AreEqual(25, NumberLetterCounter.LettersNeededToSpell(372)); // three hundred and seventy two