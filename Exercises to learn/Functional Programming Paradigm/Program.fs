// For more information see https://aka.ms/fsharp-console-apps

open Functional_Programming_Paradigm.FirstClassFunction

let f (x: int) = x + 2
printfn "%A" (FirstClassFunction.applyTwice f 2)
printfn "%A" (FirstClassFunction.applyTwice (fun x -> x * 2) 2)
printfn "%A" (FirstClassFunction.applyTwice (fun x -> x + " ha") "b")