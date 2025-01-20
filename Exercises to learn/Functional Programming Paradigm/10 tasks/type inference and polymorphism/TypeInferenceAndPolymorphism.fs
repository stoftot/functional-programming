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
        
    //4
    let transformAll (map: 'a -> 'b) (lst: 'a list) : 'b list =
        lst |> List.map map
        
    //5
    let inline comparePairs (pair1: 'a * 'b) (pair2: 'c * 'd) : int =
        let a, b = pair1
        let c, d = pair2
        let sum1 = a + b
        let sum2 = c + d
        compare sum1 sum2
        
    //6
    let mapOption (f: 'a -> 'b) (value: Option<'a>) : Option<'b> =
        if value.IsSome
            then Some (f value.Value)
        else
            None
            
    //7
    let findByKey (key: 'a) (lst: ('a * 'b) list) : Option<'b> =
        lst
        |> List.tryFind (fun (k, _) -> k = key)
        |> Option.map snd
        
    //8
    let inline sumAll (lst: 'a list) : 'a =
        lst |> List.sum
        
    //9
    let compareGeneric (x: 'a) (y: 'a) (comp: 'a -> 'a -> int) : int =
        comp x y
        
    //10
    let flatten (lst: 'a list list) : 'a list =
        let newList = ref []
        lst
        |> List.map (fun lst -> lst |> List.map (fun e -> newList.Value <- newList.Value @ [e]))
        |> ignore
        newList.Value
    
    let betterFlatten (lst: 'T list list) : 'T list =
        lst |> List.collect id

        