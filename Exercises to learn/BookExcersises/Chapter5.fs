module BookExcersises.Chapter5

//5.1
let ownFilter (p: 'a -> bool) (lst: 'a list) : 'a list =
     List.foldBack (fun x acc -> if p x then x :: acc else acc) lst []
     
//5.2
let revrev5 (lst: int list list) : int list list =
        List.fold (fun acc sublist -> (List.rev sublist) :: acc) [] lst

//5.3
let sum5 (p: int -> bool) (lst: int list) : int =
        lst |> List.fold (fun acc x -> if p x then acc + x else acc) 0
        
//5.4
let downto1 (f: int -> 'a -> 'a) (n: int) (e: 'a) : 'a =
    let rec inner n e =
        match n with
        | n when n > 0 -> inner (n - 1) (f n e)
        | n when n <= 0 -> e
    inner n e

let fac (n: int) : int =
    downto1 (fun x y -> x * y) n 1
    
let range (f: int -> 'a) (n: int) : 'a list =
    downto1 (fun n acc -> f n :: acc) n []
    
//5.6
//..1
let domain (set: Set<'a * 'b>) : Set<'a> =
    set |> Set.map fst

//..2 
let rangeS (set: Set<'a * 'b>) : Set<'b> =
    set |> Set.map snd

//..3 
let apply (set: Set<'a * 'b>) (a: 'a) : Set<'b> =
    set |> Set.filter (fun (x, _) -> x = a)
    |> rangeS

//..4
let symmetric (set: Set<'a * 'a>)  : Set<'a * 'a> =
    set |> Set.map (fun (x,y) -> y,x)
    |> Set.union set 
    
//..5 
let reComp (set1: Set<'a * 'b>) (set2: Set<'b * 'c>) : Set<'a * 'c> =
    set1 |> Set.fold (fun acc (a,b) ->
           apply set2 b
           |> Set.map (fun b -> (a,b))
           |> Set.union acc) Set.empty
    
let reComp2(set1: Set<'a * 'b>) (set2: Set<'b * 'c>)  =
    set1 |> Set.fold (fun acc (a,b) ->
        set2 |> Set.filter (fun (b', _) -> b = b')
             |> Set.map (fun (_,c) -> (a,c))
             |> Set.union acc
        ) Set.empty
    
//..6       
let transitive (relation: Set<'a * 'a>) : Set<'a * 'a> =
    let pairs = relation
    let worklist = relation // Start with the initial relation as the worklist

    let rec closure (currentSet: Set<'a * 'a>) (worklist: Set<'a * 'a>) =
        match Set.isEmpty worklist with
        | true -> currentSet  // If nothing new was added, return the final set
        | false ->
            // Else compute new closures for new pairs
            let newPairs =
                worklist
                |> Set.fold (fun acc (a, b) ->
                    pairs
                    |> Set.fold (fun acc' (b', c) ->
                        //make sure the pair docent already exists to stop infinite loops
                        if b = b' && not (Set.contains (a, c) currentSet) then
                            Set.add (a, c) acc'
                        else
                            acc'
                    ) acc
                ) Set.empty

            let updatedSet = Set.union currentSet newPairs
            closure updatedSet newPairs  // Recur with only newly discovered pairs

    closure relation worklist
    
//5.7
let rec allSubsets (n: int) (k: int) : Set<Set<int>> =
    if k = 0 then Set.singleton Set.empty
    elif k > n then Set.empty
    else
        let withoutN = allSubsets (n - 1) k
        let withN = 
            allSubsets (n - 1) (k - 1) // Get subsets of size k-1 from n-1 elements
            |> Set.map (Set.add n) // Then add n to each of them
        
        Set.union withoutN withN
    
