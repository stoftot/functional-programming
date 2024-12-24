module Program

open _10_Beginner_Exercises.SquareList
open _10_Beginner_Exercises.Factorial
open _10_Beginner_Exercises.classifyNumber
open _10_Beginner_Exercises.filterEven

[<EntryPoint>]
let main argv =
    //printfn "%A" (SquareList.square [1; 2; 3; 4])
    
    //printfn "%A" (Factorial.factorial 13)
     
    //printfn "%A" (FilterEven.filterEven [1; 2; 3; 4])
    
    [-1; 0; 1] |> List.iter(fun n -> printfn "%A" (ClassifyNumber.classifyNumber n))
    
    0 // Return an integer exit code
