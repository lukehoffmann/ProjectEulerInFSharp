namespace ProjectEulerInFSharp

module NumberLetterCounter =

    open Extensions

    let private AsOneDigit n =
        match n with
            | 4 | 5 | 9 -> 4 // "zero", "four", "five", "nine"
            | 3 | 7 | 8 -> 5 // "three", "seven", "eight"
            | 1 | 2 | 6 -> 3 // "one", "two", "six"
            |_ -> 0

    let private AsTeen n =
        match n with
            | 0 -> 3 // ten,
            | 1 -> 6 // eleven,
            | 2 -> 6 // twelve,
            | 3 -> 8 // thirteen,
            | 4 -> 8 // fourteen,
            | 5 -> 7 // fifteen,
            | 6 -> 7 // sixteen,
            | 7 -> 9 // seventeen,
            | 8 -> 8 // eighteen,
            | 9 -> 8 // nineteen
            |_ -> 0

    let private AsTens n =
        match n with
            | 2 -> 6 // "twenty"
            | 3 -> 6 // "thirty"
            | 4 -> 5 // "forty"
            | 5 -> 5 // "fifty"
            | 6 -> 5 // "sixty"
            | 7 -> 7 // "seventy"
            | 8 -> 6 // "eighty"
            | 9 -> 6 // "ninety"
            |_ -> 0

    let LettersNeededToSpell (n : int) =
        // get the digits in reverse
        let d = n.Digits |> Seq.toList |> List.rev
        let units     = d.[0]
        let tens      = if d.Length < 2 then 0 else d.[1]
        let hundreds  = if d.Length < 3 then 0 else d.[2]
        let thousands = if d.Length < 4 then 0 else d.[3]

        if n <= 0 || n > 1000 then
            0 // not counting zeros or larger numbers
        else if thousands > 0 then
            11 // "one thousand"
        else
            if hundreds = 0 then 0 else AsOneDigit hundreds + 7      // "X hundred"
            + if (hundreds > 0 && (tens + units > 0)) then 3 else 0 // "and"
            + match tens with
                | 0 -> AsOneDigit units                               // "Z"
                | 1 -> AsTeen units                                  // "Zteen"
                | _ -> AsTens tens + AsOneDigit units                   // "Yty Z"