module _10_Beginner_Exercises.pipelinesAndComposition

module PipelinesAndComposition =
    let pipelinesAndComposition (numbers: int list) =
        //incremnet by 1
        numbers |> List.map(fun n -> n + 1)
        //filter divisbel by 5
        |> List.filter(fun n -> n % 5 <> 0)
        //square
        |> List.map(fun n -> n * n)
        //print list
        |> List.iter(printf "%A : ") 