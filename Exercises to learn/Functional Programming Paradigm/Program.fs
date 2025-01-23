// For more information see https://aka.ms/fsharp-console-apps

open System
open Functional_Programming_Paradigm
open Functional_Programming_Paradigm.RecursionAndTailRecursion.RecursionAndTailRecursion
open Functional_Programming_Paradigm.Utils
open Functional_Programming_Paradigm.Utils.Utils
open Functional_Programming_Paradigm._10_tasks.first_class_functions.FirstClassFunctions
open Functional_Programming_Paradigm._10_tasks.higher_order_functions.HigherOrderFunctions
open Functional_Programming_Paradigm._10_tasks.recursion_and_tail_recursion.RecursionAndTailRecursion.RecursionAndTailRecursion
open Functional_Programming_Paradigm._10_tasks.type_inference_and_polymorphism.TypeInferenceAndPolymorphism
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
    
        printf ""

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
        
        // let time, result = Utils.timeFunction plainFib 41
        // printfn $"Not memoized- Time: {time}, Result: {result}"
        // let time2, result2 = Utils.timeFunction memoizedFib 41
        // printfn $"Memoized-     Time: {time2}, Result: {result2}"
        
        //8
        let willFailFunction = fun () -> failwith "1 An error happened, oh no"
        let mightFail = fun x -> if Random().Next(0, 100) > 25 then failwith "2 An error happened, oh no" else x
        
        // try
        //     printfn $"%A{retry willFailFunction 4}"
        // with
        // | ex -> printfn $"%A{ex.Message}"
        //
        // try
        //     printfn $"%A{retry (fun () -> mightFail 3) 50}"
        // with
        // | ex -> printfn $"%A{ex.Message}"
        
        //9
        let listOfFloat = [0.8; 1.2; 2.5; 3.6; 4.3; 5.9;]
        let floorFloat (x: float) = int (Math.Floor x)
        let sumList = fun lst -> List.fold (+) 0 lst
        
        // printfn $"%A{mapReduce floorFloat sumList listOfFloat}"
        
        //10
        // let time3, result3 = timeFunction (fun () -> plainFib 41)
        // printfn $"Time: {time3}, Result:{result3}"
        
        printf ""
    
    open HigherOrderFunctions
    let HigherOrderFunctions =
        //1
        let intList = [0; 1; 2; 3; 4; 5]
        
        let intToString (x: int) : string = string x          
        
        // printfn $"%A{mapList intToString intList}"
        
        //2
        let isEven = fun x -> x % 2 = 0
        
        // printfn $"%A{filterList isEven intList}"
        
        //3
        let sortIntAcc = fun x y -> x - y
        let sortIntDes = fun x y -> y - x
        let sortStringOnSize (s: string) = s.Length
        let wordList = ["bb"; "a"; "dddd"; "ccc"]
        
        // printfn $"%A{sortPrimitiveTypeList sortIntAcc intList}"
        // printfn $"%A{sortPrimitiveTypeList sortIntDes intList}"
        // printfn $"%A{sortList sortStringOnSize wordList}"
        
        //4
        let add5 = fun x -> x + 5
        let square = fun x -> x * x
        let add5Twice = transformFunction add5
        let squareTwice = transformFunction square
        
        // printfn $"%A{add5Twice 0}"
        // printfn $"%A{squareTwice 2}"
        
        //5
        let add5 = add 5
        let result = add5 10
        
        // printfn $"%A{result}"
        
        let add2 = addWithExplicitCurring 2
        let result = add2 4
        
        // printfn $"%A{result}"
        
        //6
        let loggerSquare = logWrapper square
        // let result = loggerSquare 5
        
        // printfn $"Result: %A{result}"
        
        //7
        let sumFunction acc x = acc + x
        let combineToString (acc: string) (x: int) : string = acc + string x
        
        // printfn $"%A{reduce sumFunction 0 intList}"
        // printfn $"%A{foldReduce sumFunction 0 intList}"
        // printfn $"""%A{foldReduce combineToString "" intList}"""
        
        //8
        let double = fun x -> x * 2
        let functions = [add2; add5; square; squareTwice; double;]
        let testValue = 3
        let result = filterFunction functions isEven testValue |> List.map (fun f -> f testValue)
        
        // printfn $"%A{result}"
        
        //9
        let square3Times = repeat square 3
        let add5_5Times = repeat add5 5
        
        // printfn $"%A{square3Times 2}"
        // printfn $"%A{add5_5Times 0}"
        
        //10
        let add5AndSquare = combine add5 square
        
        // printfn $"%A{add5AndSquare 5}"
        
        printf ""
        
    open TypeInferenceAndPolymorphism
    let TypeInferenceAndPolymorphism =
        //1
        // printfn $"%A{identity 1}"
        // printfn "%A" (identity "Hello world")
        
        //2
        let intList = [0; 1; 2; 3; 4; 5;]
        let letterList = ['a'; 'b'; 'c'; 'd';]
        
        // printfn $"%A{reverseList intList}"
        // printfn $"%A{reverseList letterList}"
        
        //3
        // printfn "%A" (swap 1 "a")
        // printfn $"%A{swap intList 2}"
        
        //4
        let mapIntToString = fun x -> string x
        
        // printfn $"%A{transformAll mapIntToString intList}"
        
        //5
        // printfn $"%A{comparePairs (1.2, 2.3) (2.4, 5.3)}"
        // printfn $"%A{comparePairs (5, 2) (2, 5)}"
        // printfn $"%A{comparePairs (5, 3) (2, 5)}"
        
        //6
        // printfn $"%A{mapOption mapIntToString (Some 2)}"
        // printfn $"%A{mapOption mapIntToString None}"
        
        //7
        let intStingList = [(1, "one"); (2, "two"); (3, "three"); (4, "four"); (5, "five");]
        // printfn $"%A{findByKey 3 intStingList}"
        // printfn $"%A{findByKey -2 intStingList}"
        
        //8
        let floatList = [0.0; 1.1; 2.2; 3.3; 4.4; 5.5 ]
        // printfn $"%A{sumAll intList}"
        // printfn $"%A{sumAll floatList}"
        
        //9
        let compareInt (x: int) (y: int) : int =
            if x < y then -1
            elif x > y then 1
            else 0
        // printfn $"%A{compareGeneric 1 2 compareInt}"
        
        //10
        let nestedList = [[1; 2]; [3; 4]]
        // printfn $"%A{flatten nestedList}"
        // printfn $"%A{betterFlatten nestedList}"
        
        printf ""
    
    open RecursionAndTailRecursion
    let RecursionAndTailRecursion =
        //1
        // printfn $"%A{factorial 3}"
        // printfn $"%A{factorial 5}"
        
        //2
        // printfn $"%A{tailFactorial 3}"
        // printfn $"%A{tailFactorial 5}"
        
        //3
        // printfn $"%A{fib 3}"
        // printfn $"%A{fib 6}"
        
        //4
        // printfn $"%A{tailFib 3}"
        // printfn $"%A{tailFib 6}"
        
        //5
        let intList = [0; 1; 2; 3; 4; 5;]
        // printfn $"%A{reverseList intList}"
        
        //6
        // printfn $"%A{tailReverseList intList}"
        
        //7
        // printfn $"%A{tailSumList (generateIntList 100_000)}"
        // printfn $"%A{sumList (generateIntList 100_000)}"
        
        //8
        let tree = Node(1,
                        Node(2, Leaf, Leaf),
                        Node(3,Node(4,Leaf,Leaf),Leaf))
        
        // printfn $"%A{treeDepth tree}"
        
        //9
        // printfn $"%A{tailTreeDepth tree}"
        
        //10
        let nestedList = [[1; 2]; [3;]; [4; 5;];]
        printfn $"%A{nestedList}"
        printfn $"%A{flatten nestedList}"
        
        printf ""
    
    
module CombinedTasks =
    open Functional_Programming_Paradigm.Combined_tasks.PipelineWithAlgebraicDataTypes
    
    let main = 
        // let shapes = [PipelineWithAlgebraicDataTypes.Circle 2
        //               PipelineWithAlgebraicDataTypes.Rectangle (3.5, 3)
        //               PipelineWithAlgebraicDataTypes.Square 4
        //               PipelineWithAlgebraicDataTypes.Rectangle (5, 5)]
        // printfn "%A" (PipelineWithAlgebraicDataTypes.pipeline shapes 20)
    
        printf ""