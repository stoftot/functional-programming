module BookExcersises.Chapter6

open System.Collections.Generic


//6.1
type Fexpr =
    | Const of float
    | X
    | Add of Fexpr * Fexpr
    | Sub of Fexpr * Fexpr
    | Mul of Fexpr * Fexpr
    | Div of Fexpr * Fexpr
    | Sin of Fexpr
    | Cos of Fexpr
    | Log of Fexpr
    | Exp of Fexpr

let rec red (exp: Fexpr) : Fexpr =
    match exp with
    | Add (Const 0.0, e) | Add (e, Const 0.0) -> red e
    | Mul (Const 1.0, e) | Mul (e, Const 1.0) -> red e
    | Mul (Const 0.0, Const _) | Mul (Const _, Const 0.0) -> Const 0
    //base cases
    | Add (e1, e2) -> Add (red e1, red e2)
    | Sub (e1, e2) -> Sub (red e1, red e2)
    | Mul (e1, e2) -> Mul (red e1, red e2)
    | Div (e1, e2) -> Div (red e1, red e2)
    | Sin e -> Sin (red e)
    | Cos e -> Cos (red e)
    | Log e -> Log (red e)
    | Exp e -> Exp (red e)
    | Const _ | X -> exp
    
let recursiveRed (exp: Fexpr) : Fexpr =
    let rec inner oldExp newExp =
        match oldExp with
        | oldExp when oldExp = newExp -> newExp
        | _ -> inner newExp (red newExp)
    inner exp (red exp)
    
//6.2
let rec postFix (exp: Fexpr) : string =
    match exp with
    | Add(x, y) -> $"{postFix x} {postFix y} +"
    | Sub(x, y) -> $"{postFix x} {postFix y} -"
    | Mul(x, y) -> $"{postFix x} {postFix y} *"
    | Div(x, y) -> $"{postFix x} {postFix y} /"
    | Sin x -> $"Sin {postFix x}"
    | Cos x -> $"Cos {postFix x}"
    | Log x -> $"Log {postFix x}"
    | Exp x -> $"Exp {postFix x}"
    | Const f -> $"{f}"
    | X -> "X"
    
    
//6.3
let rec toString (exp: Fexpr) : string =
    match exp with
    | Add(x, y) -> $"{toString x} + {toString y}"
    | Sub (x, y) -> $"{x} - {subAddToString y}"
    | Mul (x, y) -> $"{x} * {subAddToString y}"
    | Div (x, y) -> $"{constXToString x} / {subAddToString y}"
    | Sin x -> $"Sin {constXToString x}"
    | Cos x -> $"Cos {constXToString x}"
    | Log x -> $"Log {constXToString x}"
    | Exp x -> $"Exp {constXToString x}"
    | Const f -> $"{f}"
    | X -> "X"

and subAddToString (exp: Fexpr) : string =
    match exp with
    | Add _ | Sub _ -> $"({toString exp})"
    | _ -> toString exp

and constXToString (exp: Fexpr) : string =
    match exp with
    | Const _ | X -> toString exp
    | _ -> $"({toString exp})"
    
//6.4
type BinTree<'a,'b> =
    | Leaf of 'a
    | Node of BinTree<'a,'b> * 'b * BinTree<'a,'b>
    
let rec leafVals (tree: BinTree<'a,'b>) : Set<'a> =
    match tree with
    | Leaf e -> set [e]
    | Node (x,_,y) -> leafVals x |> Set.union (leafVals y) 
    
let leafValsTail (tree: BinTree<'a,'b>) : Set<'a> =
    let rec inner (stack: BinTree<'a,'b> list) (acc: Set<'a>) =
        match stack with
        | [] -> acc
        | Leaf e :: rest -> inner rest (e |> acc.Add)
        | Node (x,_,y) :: rest -> inner (x :: y :: rest) acc 
    inner [tree] Set.empty
    
let rec nodeVals (tree: BinTree<'a,'b>) : Set<'b> =
    match tree with
    | Node (x,b,y) -> (nodeVals x |> Set.union (nodeVals y)).Add b
    | _ -> Set.empty
  
let nodeValsTail (tree: BinTree<'a,'b>) : Set<'b> =
    let rec inner stack (acc: Set<'b>) =
        match stack with
        | Node (x, b, y) :: rest -> inner (x :: y :: rest) (acc.Add b)
        | Leaf _ :: rest -> inner rest acc 
        | _ -> acc
    inner [tree] Set.empty
    
let rec vals (tree: BinTree<'a,'b>) : Set<'a> * Set<'b> =
    match tree with
    | Node (x, b, y) ->
        let right = vals x
        let left = vals y
        (fst right |> Set.union (fst left),
         (snd right |> Set.union (snd left)).Add b)
    | Leaf a -> set [a], Set.empty
    
let rec valsTail (tree: BinTree<'a,'b>) : Set<'a> * Set<'b> =
    let rec inner stack (acc: Set<'a> * Set<'b>) =
        match stack with
        | Node (x,b,y) :: rest -> inner (x::y::rest) (fst acc, (snd acc).Add b)
        | Leaf a::rest -> inner rest ((fst acc).Add a, snd acc)
        | _ -> acc
    inner [tree] (Set.empty, Set.empty)
    
let rec valsTailMutable (tree: BinTree<'a,'b>) : Set<'a> * Set<'b> =
    let rec inner stack (accA: Set<'a>) (accB: Set<'b>) =
        match stack with
        | Node (x,b,y) :: rest -> inner (x::y::rest) accA (accB.Add b)
        | Leaf a::rest -> inner rest (accA.Add a) accB
        | _ -> accA, accB
    inner [tree] Set.empty Set.empty
    
//6.5
type AncTree =
    | Unspec
    | Info of AncTree * string * AncTree   

let rec maleAnc (tree: AncTree) : string list =
    match tree with
    | Unspec -> []
    | Info(left, name, right) -> 
        let malesFromFather = maleAnc left  // Collect all male ancestors from the father's side
        let rec extractMothersMaleAncestors t =
            match t with
            | Unspec -> []
            | Info(leftSubtree, _, rightSubtree) -> 
                maleAnc leftSubtree @ extractMothersMaleAncestors rightSubtree  // Keep extracting from mother's side
        let malesFromMother = extractMothersMaleAncestors right  // Collect male ancestors recursively from mother's lineage
        name :: (malesFromFather @ malesFromMother)  // Combine results
        
let maleAncBool (tree: AncTree) : string list =
    let rec inner (tree: AncTree) (isMale: bool) =
        match tree with
        | Unspec -> []
        | Info (left, name, right) when isMale ->
            name :: inner left true @ inner right false
        | Info (left, _, right) when isMale = false ->
            inner left true @ inner right false
    inner tree false
    
let maleAncBoolTail (tree: AncTree) : string list =
    let rec inner (stack: (AncTree * bool) list) (acc: string list) =
        match stack with
        | [] -> acc
        | (Unspec,_) :: rest -> inner rest acc
        | (Info(left,name,right), isMale)::rest when isMale ->
            inner ((left, true)::(right, false)::rest) (name::acc)
        | (Info(left,_,right), isMale)::rest when not isMale ->
            inner ((left, true)::(right, false)::rest) acc
    inner [(tree,false)] [] |> List.rev