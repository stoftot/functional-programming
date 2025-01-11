module Functional_Programming_Paradigm._10_tasks.first_class_functions.FirstClassFunctions

module FirstClassFunctions =
    let transformList (list: 'a list) (transformer: 'a -> 'b) : 'b list =
        list |> List.map transformer
        
    let createArithmeticFunction (operation: string) : int -> int -> int  = 
        match operation with
        | "add" -> (fun a b -> a + b)
        | "subtract" -> (fun a b -> a - b)
        | "multiply" -> (fun a b -> a * b)
        | s -> failwith "not supported operation"
        
    let compose (f: 'a -> 'b) (g: 'b -> 'c) =
        fun x -> f (g x)
        
    let filterGreaterThan (n: int) : int list -> int list =
        fun list -> list |> List.filter (fun x -> x > n)
        
    let findFirst (predicate: 'a -> bool) (lst: 'a list) : 'a Option= 
        lst |> List.tryFind predicate