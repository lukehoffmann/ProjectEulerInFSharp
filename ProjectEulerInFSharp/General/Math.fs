namespace ProjectEulerInFSharp

open Extensions

module Math =

    /// <summary>
    /// Unordered factors of the given number, not including one or the number itself.
    /// </summary>
    let FactorsOf (n : int64) =
        let limit = sqrt (float n)
        [2L .. int64 limit]
        |> Seq.filter (fun i -> n.DividesBy i);

    let IsPrime n =
        n > 1L &&
        (FactorsOf n |> Seq.length) = 0

    let PrimesUpTo (n: int64) =
        let mutable s = [2L .. n]
        for i in 3L .. n do
            s <- s |> List.filter (fun n -> n = i || not (n.DividesBy i))
        s

    let AllProductsOfXDigitNumbers (x) =
        let n = pown 10 (x - 1); // e.g. when x is 3 > 10^(3 - 1) = 100
        let m = (pown 10 x) - 1; // e.g. when x is 3 > (10^3) - 1 = 999

        [n .. m] 
        |> List.collect (fun x -> [n .. m] |> List.map (fun y -> (x * y)))
        |> List.distinct;

    let IsPalindromic (n) =
        n.ToString() = n.ToString().Reverse()

    let SmallestMultipleOf (l : int list) =
        // Find the non-redundant factors (remove smaller factors of the larger ones)
        let mutable uniqueFactors = l
        for f1 in l do
            uniqueFactors <- uniqueFactors
                |> List.filter (fun f2 -> f1 <= f2 || not (f1.DividesBy(f2)));

        // start with the highest common factor
        let highest = List.max uniqueFactors

        // add this factor until divisible by all others
        let mutable product = highest;
        while 
            uniqueFactors |> List.exists (fun factor -> not (product.DividesBy(factor)))
            do product <- product + highest;

        product;

    let InfiniteFibonacciSequence () =
        Seq.unfold (fun (current, next) -> Some(current, (next, current + next)))
            (0, 1)
