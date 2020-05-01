namespace ProjectEulerTests_FSharp

open Microsoft.VisualStudio.TestTools.UnitTesting;
open ProjectEulerInCSharp;

[<TestClass>]
type EulerProblemsTests () = 

    [<TestMethod>]
    member this.Problem1_ExampleTest() =
        
        Assert.AreEqual(23, EulerProblems.Problem1Example());
        

    [<TestMethod>]
    member this.Problem1_SolutionTest() =
        
        Assert.AreEqual(233168, EulerProblems.Problem1Solution());
        

    [<TestMethod>]
    member this.Problem2_Solution() =
        
        Assert.AreEqual(4613732, EulerProblems.Problem2Solution());
        

    [<TestMethod>]
    member this.Problem3_Example() =
        
        let result = EulerProblems.Problem3Example();

        Assert.AreEqual(4, result.Count);
        Assert.IsTrue(result.Contains(5L));
        Assert.IsTrue(result.Contains(7L));
        Assert.IsTrue(result.Contains(13L));
        Assert.IsTrue(result.Contains(29L));
        

    [<TestMethod>]
    member this.Problem3_Solution() =
        
        Assert.AreEqual(6857L, EulerProblems.Problem3Solution());
        

    [<TestMethod>]
    member this.Problem4_Example() =
        
        Assert.AreEqual(9009, EulerProblems.Problem4Example());
        

    [<TestMethod>]
    member this.Problem4_Solution() =
        
        Assert.AreEqual(906609, EulerProblems.Problem4Solution());
        

    [<TestMethod>]
    member this.Problem5_Example() =
        
        Assert.AreEqual(2520, EulerProblems.Problem5Example());
        

    [<TestMethod>]
    member this.Problem5_Solution() =
        
        Assert.AreEqual(232792560, EulerProblems.Problem5Solution());
        

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
        
    

