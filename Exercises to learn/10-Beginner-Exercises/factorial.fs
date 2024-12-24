module _10_Beginner_Exercises.Factorial

open Microsoft.FSharp.Core

module Factorial =
    let rec private factorialHelper (number: int) (value: int64) : int64 =
        if number > 1 then
            factorialHelper (number - 1) (value * int64 number)
        else
            (value * int64 number)

    let factorial (number: int) : int64 = factorialHelper number 1
