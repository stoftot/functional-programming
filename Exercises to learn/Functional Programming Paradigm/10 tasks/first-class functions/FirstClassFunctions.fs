module Functional_Programming_Paradigm._10_tasks.first_class_functions.FirstClassFunctions

module FirstClassFunctions =
    let TransformList (list: 'a list) (transformer: 'a -> 'b) : 'b list =
        list |> List.map transformer