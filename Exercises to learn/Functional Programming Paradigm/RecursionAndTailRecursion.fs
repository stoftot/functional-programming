module Functional_Programming_Paradigm.RecursionAndTailRecursion

open Microsoft.FSharp.Core

module RecursionAndTailRecursion =
    let rec sumList (list: int list): int =
        match list with
        | [] -> LanguagePrimitives.GenericZero
        | head :: tail -> head + sumList tail
    
    let sumListTail (list: int list) : int =
        let rec loop (list: int list) (acc: int) : int =
            match list with
            | [] -> acc
            | head::tail -> loop tail (acc + head)
        loop list 0
        
    let generateBigList : int list =
        List.init 10_000 id