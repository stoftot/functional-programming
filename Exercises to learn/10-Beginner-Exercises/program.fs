module Program

open _10_Beginner_Exercises.SquareList
open _10_Beginner_Exercises.Factorial
open _10_Beginner_Exercises.filterEven

[<EntryPoint>]
let main argv =
    //let squaredNumbers = SquareList.square [1; 2; 3; 4]
    //printfn "%A" squaredNumbers
    
    //let factorial = Factorial.factorial 13
    //printfn "%A" factorial
    
    let filterEven = FilterEven.filterEven [1; 2; 3; 4]
    printfn "%A" filterEven
    0 // Return an integer exit code
