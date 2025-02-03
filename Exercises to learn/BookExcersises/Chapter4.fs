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
        
    //4.8
    let split (lst: 'a list) : 'a list * 'a list =
        let rec inner lst even odd  =
            match lst with
            | [x] -> [x], []
            | e::o::tail -> inner tail (even @ [e]) (odd @ [o]) 
            | _ -> (even, odd)
        inner lst [] []
    
    //4.9
    let zip (lst1: 'a list) (lst2: 'b list) : ('a * 'b) list =
        List.zip lst1 lst2
           
    //4.10
    let rec prefix (lst1: 'a list) (lst2: 'a list) : bool =
        match lst1, lst2 with
        | [], _ -> true
        | x::xt, y::yt when x = y -> prefix xt yt
        | _, _ -> false
        
    //4.11.1
    let count (lst: int list) (x: int) : int =
        let rec inner lst x acc =
            match lst with
            | head::tail when head = x -> inner tail x (acc + 1)
            | head::tail when head < x -> inner tail x acc
            | _ -> acc
        inner lst x 0
        
    //4.11.2
    let insert (lst: int list) (x: int) : int list =
        let rec inner lst x acc =
            match lst with
            | y::tail when x > y -> inner tail x (y :: acc)
            | y::tail when x <= y -> (y :: x :: acc |> List.rev) @ tail
            | _ -> x :: acc |> List.rev
        inner lst x []
        
    //4.11.3
    let intersect (lst1: int list) (lst2: int list) : int list =
        let rec inner lst1 lst2 acc =
            match lst1, lst2 with
            | x::tail1, y::tail2 when x = y -> inner tail1 tail2 (x :: acc)
            | x::tail1, y::_ when x < y -> inner tail1 lst2 acc
            | x::_, y::tail2 when y < x -> inner lst1 tail2 acc
            | _ -> acc
        inner lst1 lst2 [] |> List.rev
        
    //4.11.4
    let plus (lst1: int list) (lst2: int list) : int list =
        let rec inner lst1 lst2 acc =
            match lst1, lst2 with
            | x::tail1, y::_ when x <= y -> inner tail1 lst2 (x :: acc)
            | x::_, y::tail2 when y < x -> inner lst1 tail2 (y :: acc)
            | [], _-> (acc |> List.rev) @ lst2
            | _, [] -> (acc |> List.rev) @ lst1
            | _ -> acc |> List.rev
        inner lst1 lst2 []
    
    //4.11.5
    let minus (lst1: int list) (lst2: int list) : int list =
        let rec inner lst1 lst2 acc =
            match lst1, lst2 with
            | x::xt, y::yt when x = y -> inner xt yt acc
            | x::xt, y::_ when x < y -> inner xt lst2 (x::acc)
            | x::_, y::yt when y < x -> inner lst1 yt acc
            | _, [] -> (List.rev acc) @ lst1
            | _ -> List.rev acc
        inner lst1 lst2 []
        
    //4.12
    let sum (p: int -> bool) (lst: int list) : int =
        lst |> List.fold (fun acc x -> if p x then acc + x else acc) 0
        
    //4.13.1
    //List.min exists
    let min (lst: int list) : int =
        lst |> List.fold (fun acc x -> if x < acc then x else acc) lst.Head
        
    //4.13.2
    let delete (lst: int list) (x: int) : int list =
        let rec inner lst acc  =
            match lst with
            | [] -> List.rev acc
            | y::yt when x = y -> (List.rev acc) @ yt
            | y::yt when x <> y -> inner yt (y :: acc)
            | _ -> List.rev acc
        inner lst []
        
    //4.13.3
    //There is a built-in sort List.sort
    let merge (left: int list) (right: int list) : int list =
        let rec mergeAcc left right acc =
            match left, right with
            | [], ys -> List.rev acc @ ys
            | xs, [] -> List.rev acc @ xs
            | x::xs, y::_ when x <= y -> mergeAcc xs right (x::acc)
            | _, y::ys -> mergeAcc left ys (y::acc)
        mergeAcc left right []
    
    let rec mergeSort (lst: int list) : int list =
        match lst with
        | [] | [_] -> lst  // Base cases: empty or single-element list
        | _ ->
            let left, right = List.splitAt (lst.Length/2) lst
            merge (mergeSort left) (mergeSort right)

    //4.14
    let minList (lst: int list) : int option =
        match lst with
        | x::_ -> lst |> List.fold (fun acc x -> if acc.IsSome && x < acc.Value then Some x
                                                 else acc) (Some x)
        | _ -> None
        
    //4.15
    let revrev (lst: int list list) : int list list =
        List.fold (fun acc sublist -> (List.rev sublist) :: acc) [] lst

        