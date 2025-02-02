module BookExcersises.Chapter4

module Chapter4 =
    //4.1
    let upto (n: int) : int list =
        //cant use id because that would start the list at zero
        List.init n (fun x -> x + 1)
        
    //4.2
    let downTo1 (n: int) : int list =
        [ for i in n .. -1 .. 1 -> i ]
        
    //4.3
    let evenN (n: int) : int list =
        [ for i in 0 .. n-1 -> i * 2 ]
        
    //4.4
    let rec altsum lst=
        match lst with
        | x0::x1::xs -> x0 - x1 + altsum xs
        | _ -> List.sum lst
        
    //4.5
    let rmodd (lst: 'a list) : 'a list =
        let rec inner lst acc =
            match lst with
            | [x] -> [x]
            | x::_::xs -> inner xs (acc @ [x])
            | _ -> acc
        inner lst []
        
    //4.6
    let removeEvenInts (lst: int list) : int list =
        lst |> List.filter (fun x -> x % 2 <> 0)
        
    //4.7
    let multiplicity (x: 'a) (lst: 'a list) : int =
        lst |> List.fold (fun acc y -> if y = x then acc + 1 else acc) 0

