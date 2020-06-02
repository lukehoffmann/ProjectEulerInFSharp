namespace ProjectEulerInFSharp

module LatticeTraverser =

    let rec countPathsRec (x, y, size) =
        if (x = size && y = size) then 1L
        else if (x > size || y > size) then 0L
        else countPathsRec(x + 1, y, size) + countPathsRec(x, y + 1, size)

    let countPaths (size)  =
        2L * countPathsRec (1, 0, size)