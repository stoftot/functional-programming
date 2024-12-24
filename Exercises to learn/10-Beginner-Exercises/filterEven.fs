module _10_Beginner_Exercises.filterEven

module FilterEven =
    let filterEven (numbers: int list): int list =
        numbers |> List.filter(fun n -> n % 2 = 0)