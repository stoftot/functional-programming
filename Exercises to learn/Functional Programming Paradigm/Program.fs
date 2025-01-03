﻿// For more information see https://aka.ms/fsharp-console-apps

open Functional_Programming_Paradigm
open Functional_Programming_Paradigm.AlgebraicDataTypes
open Functional_Programming_Paradigm.Combined_tasks.PipelineWithAlgebraicDataTypes
open Functional_Programming_Paradigm.FirstClassFunction
open Functional_Programming_Paradigm.HigherOrderFunctions
open Functional_Programming_Paradigm.Monads
open Functional_Programming_Paradigm.ParserCombinators
open Functional_Programming_Paradigm.RecursionAndTailRecursion
open Functional_Programming_Paradigm.StrictAndLazyEvaluation
open Functional_Programming_Paradigm.TypeInferenceAndPolymorphism
open Functional_Programming_Paradigm.Utils
open Microsoft.FSharp.Core

module Paradigm =
    let main =
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

        // let (time, result) = Utils.timeFunction RecursionAndTailRecursion.sumList RecursionAndTailRecursion.generateBigList
        // printfn $"Time: {time}, Result: {result}"
        // let (time2, result2) = Utils.timeFunction RecursionAndTailRecursion.sumListTail RecursionAndTailRecursion.generateBigList
        // printfn $"Time: {time2}, Result: {result2}"

        // printfn "%A" (AlgebraicDataTypes.area (AlgebraicDataTypes.Circle 2))
        // printfn "%A" (AlgebraicDataTypes.area (AlgebraicDataTypes.Rectangle (2, 2)))

        // printfn "%A" (StrictAndLazyEvaluation.strictFib 10)
        // printfn "%A" (StrictAndLazyEvaluation.lazyFib |> Seq.take 10 |> Seq.toList)

        // let msg, result = ParserCombinators.parseStringToIntList "1,2,3,4" 
        // let msg2, result2 = ParserCombinators.parseStringToIntList "1,,2"
        //
        // printfn $"msg: {msg}\nresult: {result}\n"
        // printfn $"msg: {msg2}\nresult: {result2}\n"

        // printfn "%A" (Monads.divideChain 10 2)
        // printfn "%A" (Monads.divideChain 6 0)
        // printfn "%A" (Monads.divideChain 6 3)
    
        printfn ""

module CombinedTasks =
    let main = 
        let shapes = [PipelineWithAlgebraicDataTypes.Circle 2
                      PipelineWithAlgebraicDataTypes.Rectangle (3.5, 3)
                      PipelineWithAlgebraicDataTypes.Square 4
                      PipelineWithAlgebraicDataTypes.Rectangle (5, 5)]
        printfn "%A" (PipelineWithAlgebraicDataTypes.pipeline shapes 20)
    
    printfn ""