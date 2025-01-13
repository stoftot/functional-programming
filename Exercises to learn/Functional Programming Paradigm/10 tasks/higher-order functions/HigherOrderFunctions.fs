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
    