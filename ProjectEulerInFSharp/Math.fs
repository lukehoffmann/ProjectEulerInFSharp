namespace ProjectEulerInFSharp

module Math =

    let rec FibonacciRecurser (a, b) =
        seq {
            yield a
            yield! FibonacciRecurser (b, b + a)
        }

    let InfiniteFibonacciSequence () = FibonacciRecurser (1, 2)
