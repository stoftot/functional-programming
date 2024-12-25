module _10_Beginner_Exercises.Add

open Microsoft.FSharp.Core

module Add =
    let add (a: int) (b: int): int =
        a + b
    
    let addFive (a: int): int =
        add a 5

