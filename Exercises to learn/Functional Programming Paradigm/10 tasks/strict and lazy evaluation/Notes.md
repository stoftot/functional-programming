Definition:
Strict Evaluation (Eager Evaluation):
- Definition: Expressions are evaluated immediately when they are bound to a variable.
- Pros: Predictable execution, easier debugging.
- Cons: Can be inefficient if unnecessary computations are performed.
- F# Support: By default, F# uses strict evaluation, meaning values are computed right away.

Lazy Evaluation:
- Definition: Expressions are evaluated only when needed, i.e., computation is deferred until the value is actually used.
- Pros: Can improve performance by avoiding unnecessary computations, useful for infinite sequences.
- Cons: Higher memory usage due to deferred computations, harder to reason about execution order.
- F# Support: F# provides lazy evaluation using:
  - lazy keyword to create lazy values.
    - let lazyValue = lazy (printfn "Calculating..."; 42)
  - Lazy.Value to force evaluation.
    - let result = lazyValue.Value  // Triggers evaluation
  - seq {} for lazily evaluated sequences (also known as generators).
    - let numbers = seq { printfn "Generating..."; yield 1; yield 2 } <br>
      let first = Seq.head numbers  // Triggers computation

Task:
Additional Notes:
Core Concepts: These tasks focus on understanding when 
and how computation happens with strict and lazy evaluation strategies in F#.

Real-World Use Cases: Tasks such as lazy file readers, infinite data streams, 
and prime number generators demonstrate practical applications.

Comparative Analysis: Tasks encourage comparing strict and lazy evaluation 
to appreciate their trade-offs in terms of performance, memory usage, and control over execution.