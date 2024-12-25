module _10_Beginner_Exercises.GenerateInfiniteSequence

open Microsoft.FSharp.Core

module GenerateInfiniteSequence =
    let rec fib (a: int) (b: int): int seq=
        seq {
            yield a
            yield! fib b (a + b)
        }
    
    let fibs = fib 0 1