namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting
open ProjectEulerInCSharp

[<TestClass>]
type ExtensionTests () =

    [<TestMethod>]
    member this.DigitAtPosition () =

        let testString = "983475908732";

        Assert.AreEqual(7, testString.DigitAtPosition(4));
        Assert.AreEqual(0, testString.DigitAtPosition(7));
        Assert.AreEqual(8, testString.DigitAtPosition(1));
        Assert.AreEqual(5, testString.DigitAtPosition(5));
        Assert.AreEqual(9, testString.DigitAtPosition(6));
        Assert.AreEqual(7, testString.DigitAtPosition(9));

    [<TestMethod>]
    member this.IsPalindromic() =

        Assert.IsTrue(909l.IsPalindromic());
        Assert.IsTrue(9009l.IsPalindromic());
        Assert.IsFalse(90099l.IsPalindromic());

    [<TestMethod>]
    member this.IsPrimeTest() =

        Assert.IsTrue(2l.IsPrime(), "2 is prime");
        Assert.IsTrue(3l.IsPrime(), "3 is prime");
        Assert.IsFalse(4l.IsPrime(), "4 is prime");
        Assert.IsTrue(5l.IsPrime(), "5 is prime");
        Assert.IsFalse(6l.IsPrime(), "6 is prime");
        Assert.IsTrue(7l.IsPrime(), "7 is prime");
        Assert.IsFalse(8l.IsPrime(), "8 is prime");
        Assert.IsFalse(9l.IsPrime(), "9 is prime");
        Assert.IsFalse(10l.IsPrime(), "10 is prime");
        Assert.IsTrue(11l.IsPrime(), "11 is prime");
        Assert.IsFalse(12l.IsPrime(), "12 is prime");
        Assert.IsTrue(13l.IsPrime(), "13 is prime");
        Assert.IsFalse(14l.IsPrime(), "14 is prime");