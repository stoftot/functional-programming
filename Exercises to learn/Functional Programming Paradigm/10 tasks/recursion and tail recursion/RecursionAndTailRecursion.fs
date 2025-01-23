module Functional_Programming_Paradigm._10_tasks.recursion_and_tail_recursion.RecursionAndTailRecursion

open Microsoft.FSharp.Core

module RecursionAndTailRecursion =
    //1
    let rec factorial (n: int) : int =
        if n <= 1
            then n
        else
            n * factorial (n - 1)
            
    //2
    let tailFactorial (n: int64)  : int64 =
        let rec inner (n: int64) (acc: int64) : int64 =
            if n <= 1
                then acc
            else
                inner (n - 1L) (n * acc)
        inner n 1
        
    //3
    let rec fib (n: int) : int =
        if n <= 1
            then 1
        else
            fib (n - 2) + fib (n - 1)
            
    //4
    let tailFib (n: int) : int =
        //a = n-2, b = n-1
        let rec inner (n: int) (a: int) (b: int) : int =
            if n <= 1 then b
            else inner (n - 1) b (a + b)
        inner n 1 1
        
    //5
    let rec reverseList (lst: 'T list) : 'T list =
        match lst with
        | [] -> list.Empty
        | head :: tail -> reverseList tail @ [head]
    
    //6
    let tailReverseList (lst: 'T list) : 'T list =
        let rec inner (lst: 'T list) (acc: 'T list) : 'T list =
            match lst with
            | [] -> acc
            | head :: tail -> inner tail (head :: acc)
        inner lst []
        
    //7
    let inline sumList (lst: 'a list) : 'a =
        let rec helper (lst: 'a list) : 'a =
            match lst with
            | [] -> LanguagePrimitives.GenericZero
            | head :: tail -> head + helper tail
        helper lst
        
    let inline tailSumList (lst: 'a list) : 'a =
        let rec inner (lst: 'a list) (acc: 'a) : 'a =
            match lst with
            | [] -> acc
            | head :: tail -> inner tail (head + acc)
        inner lst LanguagePrimitives.GenericZero
        
    //8
    type Tree<'T> =
        | Leaf
        | Node of 'T * Tree<'T> * Tree<'T>
        
    let rec treeDepth (tree: Tree<'T>): int =
        match tree with
        | Leaf -> 0
        | Node (_, left, right) ->
            let l = treeDepth left + 1
            let r = treeDepth right + 1
            if l > r then l else r
    
    //9
    //a stack is used to keep track of the unfolding tree
    //First the root is added to the stack
    //When a node is hit in the stack, it gets popped,
    //and the left and the right child is added to the top of the stack
    //When a leaf is hit, it gets popped,
    //and the depth is matched against the current max depth
    //When the stack is empty the max depth is returned
    let tailTreeDepth (tree: Tree<'T>) : int =
        let rec inner (stack: (Tree<'T> * int) list) (maxDepth: int) : int =
            match stack with
            | [] -> maxDepth
            | (Leaf, depth) :: rest ->
                inner rest (max maxDepth depth)
            | (Node (_, left, right), depth) :: rest ->
                let newStack = (left, depth + 1) :: (right, depth + 1) :: rest
                inner newStack maxDepth     
        inner [(tree, 0)] 0
        
    //10
    let rec flatten (lst: 'a list list) : 'a list =
        match lst with
        | [] -> []
        | head :: tail -> head @ flatten tail