module _10_Beginner_Exercises.BinaryTree

type Tree<'T> =
    | Leaf
    | Node of 'T * Tree<'T> * Tree<'T>
    
module BinaryTree =
    let rec sumTree (tree: Tree<'T>): 'T =
        match tree with
        | Leaf -> 0
        | Node (value, left, right) ->
                value + sumTree left + sumTree right
            
        