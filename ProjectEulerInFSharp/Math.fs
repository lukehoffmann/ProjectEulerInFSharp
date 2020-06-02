namespace ProjectEulerInFSharp

open Extensions

module Math =

    let DividesBy factor n = n % factor = 0L;

    let InfiniteFibonacciSequence () =
        Seq.unfold (fun (current, next) -> Some(current, (next, current + next)))
            (0, 1)

    let PrimesUpTo (n: int64) =
        let mutable s = [2L .. n]
        for i in 3L .. n do
            s <- s |> List.filter (fun n -> n = i || not (n |> DividesBy i))
        s

    let AllProductsOfXDigitNumbers (x) =
        let smallest = pown 10 (x - 1); // e.g. when x is 3 > 10^(3 - 1) = 100
        let biggest = (pown 10 x) - 1; // e.g. when x is 3 > (10^3) - 1 = 999

        [smallest .. biggest] 
        |> List.collect (fun x -> [smallest .. biggest] |> List.map (fun y -> (x * y)))
        |> List.distinct;

    let IsPalindromic (x) =
        x.ToString() = x.ToString().Reverse()
