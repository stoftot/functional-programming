module Functional_Programming_Paradigm.TypeInferenceAndPolymorphism

module TypeInferenceAndPolymorphism =
    let findFirst (list: 'a list) (predicate: 'a -> bool): 'a option =
        list |> List.tryFind predicate