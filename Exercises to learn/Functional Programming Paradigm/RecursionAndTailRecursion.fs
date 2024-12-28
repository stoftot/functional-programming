module Functional_Programming_Paradigm.RecursionAndTailRecursion

open Microsoft.FSharp.Core

module RecursionAndTailRecursion =
    let rec sumList (list: int list): int =
        match list with
        | [] -> LanguagePrimitives.GenericZero
        | head :: tail -> head + sumList tail
    
    let rec  sumListTail (list: int list) (acc: int) : int =
        match list with
        | [] -> acc
        | head::tail -> sumListTail tail (acc + head)
        
    let generateBigList : int list =
        List.init 10_000 id