module Functional_Programming_Paradigm._10_tasks.algebraic_data_types.AlgebraicDataTypes

open System

module AlgebraicDataTypes =
    //1
    type Shape<'T> =
        | Circle of 'T
        | Rectangle of 'T * 'T
        
    let inline area (shape: Shape<'T>) : float =
        match shape with
        | Circle r -> Math.PI * float (r * r)
        | Rectangle (h, w) -> float (h * w) 

