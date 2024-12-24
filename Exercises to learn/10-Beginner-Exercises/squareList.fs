module _10_Beginner_Exercises.SquareList

open Microsoft.FSharp.Core

module SquareList =
    let square (numbers: int list): int list =
        numbers |> List.map(fun n -> n * n)
        