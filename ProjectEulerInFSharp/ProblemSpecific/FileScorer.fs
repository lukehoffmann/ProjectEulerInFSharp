namespace ProjectEulerInFSharp

open System.IO;
open Extensions

type FileScorer () =
    let dataFilePath = @"D:\Source\ProjectEulerInFSharp\ProjectEulerInFSharp\Data\p022_names.txt"

    let sortedFile =
        File.ReadAllText(dataFilePath)
            .Split(",")
            |> Seq.map (fun s -> s.Replace("\"", ""))
            |> Seq.sort
            |> Seq.toList

    member public this.NameAtPosition n =
        sortedFile.[n - 1]

    member public this.PositionScore (name : string) =
        let name = name.ToUpper()
        (List.findIndex (fun n -> n = name) sortedFile) + 1

    member public this.AlphabeticalScore (name : string) =
        let zero = int 'A' - 1;
        name.ToUpper().Characters()
        |> Seq.map (fun c -> int (char (c.ToUpper())) - zero)
        |> Seq.sum

    member public this.TotalScore (name : string) =
        this.PositionScore name * this.AlphabeticalScore name

    member public this.TotalScoreForAllNames () =
        sortedFile
        |> Seq.map (fun name -> this.PositionScore name * this.AlphabeticalScore name)
        |> Seq.sum

