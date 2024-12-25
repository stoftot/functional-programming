module Program

open _10_Beginner_Exercises
open _10_Beginner_Exercises.Add
open _10_Beginner_Exercises.Area
open _10_Beginner_Exercises.BinaryTree
open _10_Beginner_Exercises.SquareList
open _10_Beginner_Exercises.Factorial
open _10_Beginner_Exercises.classifyNumber
open _10_Beginner_Exercises.filterEven
open _10_Beginner_Exercises.pipelinesAndComposition
open _10_Beginner_Exercises.SumAndProduct

[<EntryPoint>]
let main argv =
    // printfn "%A" (SquareList.square [1; 2; 3; 4])
    
    // printfn "%A" (Factorial.factorial 13)
     
    // printfn "%A" (FilterEven.filterEven [1; 2; 3; 4])
    
    // [-1; 0; 1] |> List.iter(fun n -> printfn "%A" (ClassifyNumber.classifyNumber n))
    
    // PipelinesAndComposition.pipelinesAndComposition [1; 2; 3; 4]
    
    // printfn "%A" (SumAndProduct.sumAndProduct 2 3)
    
    // printfn "%A" (Area.area (Circle 5))
    // printfn "%A" (Area.area (Rectangle (5, 5)))
    
    // let tree = Node(1,
    //                 Node(2, Leaf, Leaf),
    //                 Node(3,Node(4,Leaf,Leaf),Leaf))
    // printfn "%A" (BinaryTree.sumTree tree)
    
    let addFive = Add.add 5
    printfn "%A" (addFive 10)
    printfn "%A" (Add.addFive 5)
    
    0 // Return an integer exit code
