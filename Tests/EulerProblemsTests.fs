namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting;
open ProjectEulerInCSharp;
open ProjectEulerInFSharp;

[<TestClass>]
type EulerProblemsTests () = 

    [<TestMethod>]
    member this.Problem1_ExampleTest() =
        Assert.AreEqual(23, Solutions.Problem1Example())

    [<TestMethod>]
    member this.Problem1_SolutionTest() =
        Assert.AreEqual(233168, Solutions.Problem1Solution())

    [<TestMethod>]
    member this.Problem2_Solution() =
        Assert.AreEqual(4613732, Solutions.Problem2Solution())

    [<TestMethod>]
    member this.Problem3_Example() =
        let result = Seq.toList(Solutions.Problem3Example())

        Assert.IsTrue (List.contains 5L result)
        Assert.IsTrue (List.contains 7L result)
        Assert.IsTrue (List.contains 13L result)
        Assert.IsTrue (List.contains 29L result)
        Assert.AreEqual (4, result.Length);

    [<TestMethod>]
    member this.Problem3_Solution() =
        Assert.AreEqual(6857L, Solutions.Problem3Solution());

    [<TestMethod>]
    member this.Problem4_Example() =
        Assert.AreEqual(9009, Solutions.Problem4Example());

    [<TestMethod>]
    member this.Problem4_Solution() =
        Assert.AreEqual(906609, Solutions.Problem4Solution());

    [<TestMethod>]
    member this.Problem5_Example() =
        
        Assert.AreEqual(2520, Solutions.Problem5Example());
        

    [<TestMethod>]
    member this.Problem5_Solution() =
        
        Assert.AreEqual(232792560, Solutions.Problem5Solution());
        

    [<TestMethod>]
    member this.Problem6_Example() =
        
        Assert.AreEqual(2640, EulerProblems.Problem6Example());
        

    [<TestMethod>]
    member this.Problem6_Solution() =
        
        Assert.AreEqual(25164150L, EulerProblems.Problem6Solution());
        

    [<TestMethod>]
    member this.Problem7_Example() =
        
        Assert.AreEqual(13L, EulerProblems.Problem7Example());
        

    [<TestMethod>]
    member this.Problem7_Solution() =
        
        Assert.AreEqual(104743L, EulerProblems.Problem7Solution());
        

    [<TestMethod>]
    member this.Problem8_Example() =
        
        Assert.AreEqual(5832, EulerProblems.Problem8Example());
        

    [<TestMethod>]
    member this.Problem8_Solution() =
        
        Assert.AreEqual(23514624000L, EulerProblems.Problem8Solution());
        

    [<TestMethod>]
    member this.Problem9_Solution() =
        
        Assert.AreEqual(31875000L, EulerProblems.Problem9Solution());
        

    [<TestMethod>]
    member this.Problem10_Solution() =
        
        Assert.AreEqual(142913828922L, EulerProblems.Problem10Solution());
        

    [<TestMethod>]
    member this.Problem11_Example() =
        
        Assert.AreEqual(1788696L, EulerProblems.Problem11Example());
        

    [<TestMethod>]
    member this.Problem11_Solution() =
        
        Assert.AreEqual(70600674L, EulerProblems.Problem11Solution());
        

    [<TestMethod>]
    member this.Problem12_Example() =
        Assert.AreEqual(28L, EulerProblems.Problem12Example());
        

    [<TestMethod>]
    member this.Problem12_Solution() =
        Assert.AreEqual(76576500L, EulerProblems.Problem12Solution());
        

    [<TestMethod>]
    member this.Problem13_Solution() =
        Assert.AreEqual("5537376230", EulerProblems.Problem13Solution());
        

    [<TestMethod>]
    member this.Problem14_Solution() =
        Assert.AreEqual(837799L, EulerProblems.Problem14Solution());

    [<TestMethod>]
    member this.Problem15_Example() =
        // Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
        // there are exactly 6 routes to the bottom right corner.
        Assert.AreEqual(6L, LatticeTraverser.countPaths(2))
        Assert.AreEqual(20L, LatticeTraverser.countPaths(3))

    [<TestMethod>]
    [<Ignore>] // Too Slow
    member this.Problem15_Solution() =
        // How many such routes are there through a 20×20 grid?
        Assert.AreEqual(137846528820L, LatticeTraverser.countPaths(20))
    
    [<TestMethod>]
    member this.Problem16_Example() =
        Assert.AreEqual(26, Solutions.Problem16Example())

    [<TestMethod>]
    member this.Problem16_Solution() =
        Assert.AreEqual(1366, Solutions.Problem16Solution())

    [<TestMethod>]
    member this.Problem17_Solution() =
        Assert.AreEqual(21124, Solutions.Problem17Solution())

    [<TestMethod>]
    member this.Problem20_Solution() =
        Assert.AreEqual(648, Solutions.Problem20Solution())