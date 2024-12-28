// For more information see https://aka.ms/fsharp-console-apps

open Functional_Programming_Paradigm
open Functional_Programming_Paradigm.FirstClassFunction
open Functional_Programming_Paradigm.HigherOrderFunctions
open Functional_Programming_Paradigm.RecursionAndTailRecursion
open Functional_Programming_Paradigm.TypeInferenceAndPolymorphism
open Functional_Programming_Paradigm.Utils
open Microsoft.FSharp.Core

// let f1 (x: int) = x + 2
// printfn "%A" (FirstClassFunction.applyTwice f1 2)
// printfn "%A" (FirstClassFunction.applyTwice (fun x -> x * 2) 2)
// printfn "%A" (FirstClassFunction.applyTwice (fun x -> x + " ha") "b")

// let filter (x: int): bool = x % 2 = 0
// let map (x: int): int = x * 2
// let list = [1; 2; 3; 4]
// printf "%A" (HigherOrderFunctions.filterMap list filter map)

// let predicate (x: string) : bool = x.Contains 'e'
// let predicate2 (x: string) : bool = x.Contains 'q'
// let words = [ "hi"; "boo"; "hello"; "nik"; "hey" ]
// printfn "%A" (TypeInferenceAndPolymorphism.findFirst words predicate)
// printfn "%A" (TypeInferenceAndPolymorphism.findFirst words predicate2)

let (time, result) = Utils.timeFunction RecursionAndTailRecursion.sumList RecursionAndTailRecursion.generateBigList
printfn $"Time: %A{time}, Result: %d{result}"
let (time2, result2) = 
    Utils.timeFunction 
        (fun (list, acc) -> RecursionAndTailRecursion.sumListTail list acc) 
        (RecursionAndTailRecursion.generateBigList, 0)
printfn $"Time: %A{time2}, Result: %d{result2}"
