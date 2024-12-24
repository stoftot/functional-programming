module _10_Beginner_Exercises.classifyNumber

module ClassifyNumber =
    let classifyNumber (number: int): string =
        match number with
        | 0 -> "zero"
        | _ when number > 0 -> "psitive"
        | _ -> "negative"