module _10_Beginner_Exercises.Area

open System
open Microsoft.FSharp.Core


type Shape =
    | Circle of int
    | Rectangle of int * int

module Area =
    let area (shape: Shape): float =
        match shape with
        | Circle r -> Math.PI * float (r * r)
        | Rectangle (h, W) -> float(h * W)

