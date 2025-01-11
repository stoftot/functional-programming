module Functional_Programming_Paradigm._10_tasks.first_class_functions.FirstClassFunctions

module FirstClassFunctions =
    //1
    let transformList (list: 'a list) (transformer: 'a -> 'b) : 'b list =
        list |> List.map transformer
    
    //2 
    let createArithmeticFunction (operation: string) : int -> int -> int  = 
        match operation with
        | "add" -> (fun a b -> a + b)
        | "subtract" -> (fun a b -> a - b)
        | "multiply" -> (fun a b -> a * b)
        | s -> failwith "not supported operation"
    
    //3    
    let compose (f: 'a -> 'b) (g: 'b -> 'c) =
        fun x -> f (g x)
    
    //4    
    let filterGreaterThan (n: int) : int list -> int list =
        fun list -> list |> List.filter (fun x -> x > n)
    
    //5    
    let findFirst (predicate: 'a -> bool) (lst: 'a list) : 'a Option= 
        lst |> List.tryFind predicate
        
    //6
    let private addFive = fun x -> x + 5
    let private square = fun x -> x * x
    
    let add5ThenSquare : int -> int =
        addFive >> square