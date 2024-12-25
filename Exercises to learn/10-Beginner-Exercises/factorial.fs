module _10_Beginner_Exercises.Factorial

open Microsoft.FSharp.Core

//recursion
module Factorial =
    let rec factorial (number: int) : int64 =
        if number > 1 then
            int64 number * factorial (number - 1)
        else
            number
