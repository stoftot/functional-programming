module Functional_Programming_Paradigm._10_tasks.strict_and_lazy_evaluation.StrictAndLazyEvaluation

module StrictAndLazyEvaluation =
    //1
    let strictSum (a: int) (b: int) : int =
        printfn "Executing strict sum function ..."
        a + b