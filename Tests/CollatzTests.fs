namespace ProjectEulerTests_FSharp

open System.Linq;
open Microsoft.VisualStudio.TestTools.UnitTesting;
open ProjectEulerInCSharp;


[<TestClass>]
type CollatzTests () =

    [<TestMethod>]
    member this.CollatzExampleTest() =
        
        // The following iterative sequence is defined for the set of positive integers:
        //
        //      n → n/2 (n is even)
        //      n → 3n + 1 (n is odd)
        //
        // open the rule above and starting with 13, we generate the following sequence:
        // 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        //
        // It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms.

        let sequence = Collatz.Sequence(13L).ToList();
        Assert.AreEqual(10, sequence.Count);
        Assert.AreEqual(13L, sequence.[0]);
        Assert.AreEqual(40L, sequence.[1]);
        Assert.AreEqual(20L, sequence.[2]);
        Assert.AreEqual(10L, sequence.[3]);
        Assert.AreEqual(5L, sequence.[4]);
        Assert.AreEqual(16L, sequence.[5]);
        Assert.AreEqual(8L, sequence.[6]);
        Assert.AreEqual(4L, sequence.[7]);
        Assert.AreEqual(2L, sequence.[8]);
        Assert.AreEqual(1L, sequence.[9]);
        
    

