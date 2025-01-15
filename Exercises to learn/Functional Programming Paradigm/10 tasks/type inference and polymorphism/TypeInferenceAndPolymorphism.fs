module Functional_Programming_Paradigm._10_tasks.type_inference_and_polymorphism.TypeInferenceAndPolymorphism

module TypeInferenceAndPolymorphism =
    //1
    let identity (a: 'a) : 'a =
        a
        
    //2
    let reverseList (lst: 'a list) : 'a list =
        lst |> List.rev
        
    //3
    let swap (a: 'a) (b: 'b) : 'b * 'a =
        b, a