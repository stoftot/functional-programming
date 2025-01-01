module Functional_Programming_Paradigm.StrictAndLazyEvaluation

module StrictAndLazyEvaluation =
    let rec strictFib (n: int) =
        if n <= 1 then n
        else strictFib (n - 1) + strictFib (n - 2)
        
    let lazyFib =
        Seq.unfold (fun (a, b) -> Some(a, (b, a + b))) (0,1)