namespace ProjectEulerInFSharp

open System

module Extensions =

    type Int32 with
    member this.DividesBy (factor) = this % factor = 0l;
