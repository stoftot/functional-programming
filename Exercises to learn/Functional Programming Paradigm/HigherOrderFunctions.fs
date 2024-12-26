module Functional_Programming_Paradigm.HigherOrderFunctions

module HigherOrderFunctions =
    let filterMap (list: 'a list) (filter: 'a -> bool) (map: 'a -> 'b) : 'b list =
        list |> List.filter filter
        |> List.map map
