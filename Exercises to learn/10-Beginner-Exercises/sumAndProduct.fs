module _10_Beginner_Exercises.SumAndProduct

open Microsoft.FSharp.Core

module SumAndProduct =
    let sumAndProduct (a: int)(b: int): (int * int) =
        (a+b, a*b)