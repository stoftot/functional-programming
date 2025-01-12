module Functional_Programming_Paradigm._10_tasks.higher_order_functions.HigherOrderFunctions

module HigherOrderFunctions =
    //1
    let mapList (map: 'a -> 'b) (lst: 'a list) : 'b list =
        lst |> List.map map
    
    //2
    let filterList (predicate: 'a -> bool) (lst: 'a list) : 'a list =
        lst |> List.filter predicate