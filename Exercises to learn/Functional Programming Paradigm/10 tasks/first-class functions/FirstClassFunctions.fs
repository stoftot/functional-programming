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