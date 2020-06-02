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
    
    type Numerics.BigInteger with
    member this.Digits =
        let s = this.ToString();
        StringInfo.ParseCombiningCharacters(s)
        |> Seq.map (fun i -> StringInfo.GetNextTextElement(s, i))
        |> Seq.map int
    end

    type String with
    member self.Reverse() = 
        StringInfo.ParseCombiningCharacters(self)
        |> Seq.map (fun i -> StringInfo.GetNextTextElement(self, i))
        |> Seq.fold (fun acc s -> s + acc ) ""
    end