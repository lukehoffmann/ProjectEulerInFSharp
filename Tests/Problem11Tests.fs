namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting;
open ProjectEulerInCSharp;

[<TestClass>]
type Problem11Tests () =
    
    [<TestMethod>]
    member this.RightProductTest() =
        
        Assert.AreEqual(08 * 02 * 22 * 97, Problem11.RightProduct(1, 1));
        

    [<TestMethod>]
    member this.DownProductTest() =
        
        Assert.AreEqual(08 * 49 * 81 * 52, Problem11.DownProduct(1, 1));
        

    [<TestMethod>]
    member this.RightDownProductTest() =
        
        Assert.AreEqual(08 * 49 * 31 * 23, Problem11.RightDownProduct(1, 1));
        Assert.AreEqual(39 * 88 * 74 * 92, Problem11.RightDownProduct(7, 17));
        

    [<TestMethod>]
    member this.LeftDownProductTest() =
        
        Assert.AreEqual(97 * 99 * 49 * 52, Problem11.LeftDownProduct(4, 1));