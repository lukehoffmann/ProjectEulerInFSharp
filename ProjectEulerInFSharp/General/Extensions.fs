namespace ProjectEulerInFSharp

open System
open System.Globalization

module Extensions =

    type Int32 with
    member this.DividesBy (factor) = this % factor = 0l;
    end
    
    type Int64 with
    member this.DividesBy (factor) = this % factor = 0L;
    end

    type String with
    member self.Characters() = 
        StringInfo.ParseCombiningCharacters(self)
        |> Seq.map (fun i -> StringInfo.GetNextTextElement(self, i))
    end

    type Int32 with
    member this.Digits =
        this.ToString().Characters()
        |> Seq.map int
    end

    type Numerics.BigInteger with
    member this.Digits =
        this.ToString().Characters()
        |> Seq.map int
    end

    type String with
    member self.Reverse() = 
        self.Characters()
        |> Seq.fold (fun acc s -> s + acc ) ""
    end