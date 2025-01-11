// For more information see https://aka.ms/fsharp-console-apps

open Functional_Programming_Paradigm
open Functional_Programming_Paradigm.Utils
open Functional_Programming_Paradigm._10_tasks.first_class_functions.FirstClassFunctions
open Microsoft.FSharp.Core

module Paradigm =
    open Functional_Programming_Paradigm.AlgebraicDataTypes
    open Functional_Programming_Paradigm.FirstClassFunction
    open Functional_Programming_Paradigm.HigherOrderFunctions
    open Functional_Programming_Paradigm.Monads
    open Functional_Programming_Paradigm.ParserCombinators
    open Functional_Programming_Paradigm.RecursionAndTailRecursion
    open Functional_Programming_Paradigm.StrictAndLazyEvaluation
    open Functional_Programming_Paradigm.TypeInferenceAndPolymorphism
    
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

module TenTasks =
    open FirstClassFunctions
    let FirstClassFunctions =
        let intList = [0; 1; 2; 3; 4; 5;]
        let filterOdd = fun x -> if x % 2 = 0 then Some x else None
        let double = fun x -> x * 2
        
        //1
        // printfn $"%A{transformList intList filterOdd |> List.choose id}"
        // printfn $"%A{transformList intList double}"
        
        let additionFunction = createArithmeticFunction "add"
        let subtractionFunction = createArithmeticFunction "subtract"
        let multiplicationFunction = createArithmeticFunction "multiply"
        
        //2
        // printfn $"%A{additionFunction 3 2}"
        // printfn $"%A{subtractionFunction 3 2}"
        // printfn $"%A{multiplicationFunction 3 2}"
        
        let square = fun x -> x * x
        let addFive = fun x -> x + 5
        
        //3
        // printfn $"%A{compose square addFive 5}"
        // printfn $"%A{compose addFive square 5}"
        
        let filterGreaterThan2 = filterGreaterThan 2
        
        //4
        // printfn $"%A{filterGreaterThan2 intList}"
        
        let isGreaterThan2 = fun x -> x > 2
        let isGreaterThan10 = fun x -> x > 10
        let containsA (str: string) = str.Contains("a")
        let wordList = ["hello"; "hi"; "world"; "go away"; "stay back"]
        
        //5
        // printfn $"%A{(findFirst isGreaterThan2 intList).Value}"
        // printfn $"%A{(findFirst containsA wordList).Value}"
        // printfn $"%A{findFirst isGreaterThan10 intList}"
        
        //6
        // printfn $"%A{add5ThenSquare 5}"
        // printfn $"%A{add5ThenSquare 2}"
        
        //7
        let rec fib self n =
            if n <= 1 then n
            else self (n - 1) + self (n - 2)
        
        let rec plainFib n =
            if n <= 1 then n
            else plainFib (n - 1) + plainFib (n - 2)
        
        let memoizedFib = memoize fib
        
        let time, result = Utils.timeFunction plainFib 41
        printfn $"Not memoized- Time: {time}, Result: {result}"
        let time2, result2 = Utils.timeFunction memoizedFib 41
        printfn $"Memoized-     Time: {time2}, Result: {result2}"
        
        printfn ""

module CombinedTasks =
    open Functional_Programming_Paradigm.Combined_tasks.PipelineWithAlgebraicDataTypes
    
    let main = 
        // let shapes = [PipelineWithAlgebraicDataTypes.Circle 2
        //               PipelineWithAlgebraicDataTypes.Rectangle (3.5, 3)
        //               PipelineWithAlgebraicDataTypes.Square 4
        //               PipelineWithAlgebraicDataTypes.Rectangle (5, 5)]
        // printfn "%A" (PipelineWithAlgebraicDataTypes.pipeline shapes 20)
    
        printfn ""