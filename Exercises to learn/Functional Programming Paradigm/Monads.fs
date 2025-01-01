module Functional_Programming_Paradigm.Monads

module Monads =
    let safeDivide (a: float) (b: float) : float option =
        if b = 0 then None
        else Some (a/b)
    
    let divideChain (a: float) (b: float) : float option =
        safeDivide a b
        |> Option.bind (fun result -> safeDivide result 5)