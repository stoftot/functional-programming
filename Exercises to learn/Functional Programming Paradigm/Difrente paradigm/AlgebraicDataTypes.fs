module Functional_Programming_Paradigm.AlgebraicDataTypes

open System

module AlgebraicDataTypes =
    type shape =
        | Circle of float
        | Rectangle of float * float
        
    let area (shape: shape) : float =
        match shape with
        | Circle r -> Math.PI * r * r
        | Rectangle (w, h) -> h * w