namespace ProjectEulerInFSharp

open Extensions

module Math =

    let DividesBy factor n = n % factor = 0L;

    let InfiniteFibonacciSequence () =
        Seq.unfold (fun (current, next) -> Some(current, (next, current + next)))
            (0, 1)

    let PrimesUpTo (n: int64) =
        let mutable s = Seq.toList [2L .. n]
        for i in 3L .. n do
            s <- s |> List.filter (fun n -> n = i || not (n |> DividesBy i))
        s