namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting;
open ProjectEulerInCSharp;

[<TestClass>]
type Problem13Tests () =
    
    [<TestMethod>]
    member this.AddTwoNumbersAsStrings_NoCarrying() =
        
        Assert.AreEqual("5432", Problem13.AddNumbersAsStrings("1111", "4321"));
        Assert.AreEqual("5555", Problem13.AddNumbersAsStrings("1234", "4321"));
        Assert.AreEqual("3348", Problem13.AddNumbersAsStrings("1111", "1234", "1000", "3"));
        

    [<TestMethod>]
    member this.AddTwoNumbersAsStrings_WithCarrying() =
        
        Assert.AreEqual("10000", Problem13.AddNumbersAsStrings("1", "9999"));
        
    

