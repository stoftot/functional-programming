module Functional_Programming_Paradigm._10_tasks.higher_order_functions.HigherOrderFunctions

module HigherOrderFunctions =
    //1
    let mapList (map: 'a -> 'b) (lst: 'a list) : 'b list =
        lst |> List.map map
    
    //2
    let filterList (predicate: 'a -> bool) (lst: 'a list) : 'a list =
        lst |> List.filter predicate
        
    //3
    let sortPrimitiveTypeList (comparator: 'a -> 'a -> int) (lst: 'a list) : 'a list =
        lst |> List.sortWith comparator
    
    let sortList (comparator: 'a -> 'b) (lst: 'a list) : 'a list =
        lst |> List.sortBy comparator
         
    //4
    let transformFunction (f: 'a -> 'a) : 'a -> 'a =
        fun x -> f(f x)
        
    //5
    let add (x: int) (y: int) : int =
        x + y
        
    let addWithExplicitCurring =
        fun x -> fun y -> x + y
    
    //6
    let logWrapper (f: 'a -> 'b) : 'a -> 'b =
        fun x ->
            printfn $"Input: %A{x}"
            let result = f x
            printfn $"Output: %A{result}"
            result
            
    //7
    let reduce (accumulator: 'b -> 'a -> 'b ) (initialValue: 'b) (lst: 'a list) : 'b =
        let rec loop acc remainingList =
            match remainingList with
            | [] -> acc
            | x :: xs -> loop (accumulator acc x) xs
        loop initialValue lst
        
    let foldReduce (accumulator: 'b -> 'a -> 'b) (initialValue: 'b) (lst: 'a list) : 'b =
        List.fold accumulator initialValue lst
        
    //8
    let filterFunction (functions: ('a -> 'b) list) (predicate: 'b -> bool) (testValue: 'a): ('a -> 'b) list =
        functions |> List.filter (fun f-> predicate(f testValue))
        
        