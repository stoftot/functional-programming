//All exercises are taking from the following book
//Functional Programming using F# by Michael R. Hansen and Hans Rischel, ISBN 9781107684065.

open BookExcersises.Chapter1
open BookExcersises.Chapter2

module main =
    
    open Chapter1
    module chapter1 =
        //1.1
        // printfn $"%A{g 4}"
        
        //1.2
        // printfn $"%A{h (3,3)}"
        
        //1.4
        // printfn $"%A{f 5}"
        
        //1.5
        // printfn $"%A{fib 0}"
        // printfn $"%A{fib 1}"
        // printfn $"%A{fib 2}"
        // printfn $"%A{fib 3}"
        // printfn $"%A{fib 7}"
        
        //1.6
        // printfn $"%A{sum (3,2)}"
        
        printf ""
        
    open Chapter2
    module chapter2 =
        //2.1
        // printfn $"%A{f 24}"
        // printfn $"%A{f 27}"
        // printfn $"%A{f 29}"
        // printfn $"%A{f 30}"
        
        //2.2
        // printfn $"""%A{powString "hi " 3}"""
        
        //2.3
        // printfn $"""%A{isIthChar ("hello", 1, 'e') }"""
        // printfn $"""%A{isIthChar ("hello", 0, 'e') }"""
        
        //2.4
        // printfn $"""%A{occFromIth ("hello", 3, 'l')}"""
        // printfn $"""%A{occFromIth ("hello", 2, 'l')}"""
        // printfn $"""%A{occFromIth ("hello", 2, 'e')}"""
        
        //2.5
        // printfn $"""%A{occInString ("hello", 'l') }"""
        // printfn $"""%A{occInString ("hello", 'L') }"""
        
        //2.6
        // printfn $"%A{notDivisible (2, 5)}"
        // printfn $"%A{notDivisible (3, 9)}"
        
        //2.7.1
        // printfn $"%A{test (3, 6, 22)}"
        // printfn $"%A{test (3, 6, 20)}"
        
        //2.7.2
        // printfn $"%A{prime 4}"
        // printfn $"%A{prime 7}"
        
        //2.7.3
        // printfn $"%A{nextPrime 4}"
        // printfn $"%A{nextPrime 7}"
        
        //2.8
        // printfn $"%A{bin (2, 1)}"
        // printfn $"%A{bin (4, 2)}"
        
        //2.11
        // printfn $"%A{VAT 25 100}"
        // printfn $"%A{unVAT 25 (VAT 25 100)}"
        
        //2.12
        // printfn $"%A{min (fun x -> x - 25)}"
        
        //2.13
        // printfn $"%A{curry (fun (x, y) -> x + y) 5 3}"
        // printfn $"%A{uncurry (fun x y -> x + y) (5, 3)}"
        
        printf ""