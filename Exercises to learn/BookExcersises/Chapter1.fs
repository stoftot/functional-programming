module BookExcersises.Chapter1

open System

module Chapter1 =
    //1.1
    let g (n: int) : int =
        n + 4
        
    //1.2
    let h (x: float, y: float) : float =
        Math.Sqrt(x*x + y*y)
       
    //1.4
    let f (n: int) : int =
       let rec inner (n: int) (acc: int) : int =
           if n <= 0 then acc
           else inner (n-1) (acc+n)
       inner n 0
       
    //1.5
    let fib (n: int) : int =
        let rec inner (n: int) (a: int) (b: int) : int =
            if n <= 0 then b
            else inner (n-1) b (a+b)
        inner n 1 0
        
    //1.6
    let sum (m: int, n: int) : int =
        let rec inner (m: int, n: int) (acc: int) =
            if n < 0 then acc
            else inner (m, n-1) (acc + m + n)
        inner (m,n) 0
        
    //1.7
    //float * int
    //int
    //float
    //float * int