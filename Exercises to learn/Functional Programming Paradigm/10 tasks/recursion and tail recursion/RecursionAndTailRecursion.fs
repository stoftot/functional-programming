module Functional_Programming_Paradigm._10_tasks.recursion_and_tail_recursion.RecursionAndTailRecursion

module RecursionAndTailRecursion =
    //1
    let rec factorial (n: int) : int =
        if n <= 1
            then n
        else
            n * factorial (n - 1)