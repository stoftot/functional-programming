module Functional_Programming_Paradigm.Combined_tasks.PipelineWithAlgebraicDataTypes

open System
open Microsoft.FSharp.Core

module PipelineWithAlgebraicDataTypes = 
    type shape = 
        | Circle of float
        | Rectangle of float * float
        | Square of float
    
    let private area shape : float =
        match shape with
        | Circle r -> Math.PI * r * r
        | Rectangle (h, w) -> h * w
        | Square h -> h * h
    
    let private rectFilter (shape: shape) (threshold: float) : bool =
        match shape with
        | Rectangle (h, w) -> not ((h * w) > threshold) 
        | _ -> true

    let pipeline (shapes: shape list) (rectThreshold: float) : (shape * float) list =
        shapes |> List.filter (fun s -> rectFilter s rectThreshold) 
        |> List.map (fun s -> s, area s)