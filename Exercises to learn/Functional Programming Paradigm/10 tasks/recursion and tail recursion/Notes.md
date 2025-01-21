Difference:
Recursion vs Tail Recursion in Functional Programming

Recursion (General Definition):
- A function is considered recursive if it calls itself within its definition 
to solve smaller instances of a problem.
- Recursion often builds up a "call stack," 
which stores intermediate results until the base case is reached.
- Once the base case is hit, the function returns values back up the stack, 
resolving pending operations.

Problem: This type of recursion can lead to a stack 
overflow for large inputs due to the growing call stack.


Tail Recursion:
- Tail recursion is a special case of recursion where the recursive call 
is the last operation in the function.
- This allows the compiler or runtime to optimize the call by 
reusing the current function's stack frame instead of adding a new one. 
This optimization is called Tail Call Optimization (TCO).
- In F#, when the function is properly tail-recursive, 
it avoids stack overflow by converting recursion into iteration internally.

Benefits of Tail Recursion:
- No stack overflow issues for large inputs.
- Optimized performance by the compiler due to reuse of stack frames.
- Generally preferred when writing recursive functions in functional programming.
![img.png](img.png)

Tasks:
Additional Details:
Each task should provide practical insight into recursion and its tail-recursive counterpart.

Tasks like comparing efficiency (Tasks 7 and 9) 
can be extended to visualize memory or time usage differences.

Nested structures (Tasks 8 and 10) highlight more complex use cases of recursion in functional programming.