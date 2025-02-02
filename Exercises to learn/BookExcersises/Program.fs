//All exercises are taking from the following book
//Functional Programming using F# by Michael R. Hansen and Hans Rischel, ISBN 9781107684065.

open BookExcersises.Chapter1
open BookExcersises.Chapter2
open BookExcersises.Chapter3

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
        
    open Chapter3
    module chapter3 =
        //3.1
        // printfn $"""%A{compareTime (11,59,"AM") (1,15,"PM")}"""
        // printfn $"""%A{compareTime (11,59,"AM") (12,59,"AM")}"""
        // printfn $"""%A{compareTime (11,59,"AM") (11,58,"AM")}"""
        // printfn ""
        
        let time1 = {h = 11; m = 59; f = "AM"}
        let time2 = {h = 11; m = 58; f = "AM"}
        // printfn $"%A{time1 < time2}"
        // printfn $"%A{time1 > time2}"
        // printfn $"%A{time1 = time2}"
        
        //3.2
        // printfn $"%A{add (11,18,1) (1,1,1)}"
        // printfn $"%A{add (11,22,1) (1,1,1)}"
        // printfn $"%A{add (11,17,1) (1,1,1)}"
        // printfn $"%A{subtract (1,1,1) (1,1,1)}"
        // printfn ""
        
        let british1 = {po = 11; sh = 22; pe = 1}
        let british2 = {po = 1; sh = 1; pe = 1}
        
        // printfn $"%A{british1.add british2}"
        // printfn $"%A{british2.subtract british2}"
        
        //3.3
        let z1 = Complex(3.0, 2.0)
        let z2 = Complex(1.0, -4.0)
        
        // printfn $"%A{z1 + z2}"
        // printfn $"%A{z1 - z2}"
        // printfn $"%A{z1 * z2}"
        // printfn $"%A{z1 / z2}"
        
        //3.4
        let line = { a = 2.0; b = 3.0 }
        
        // printfn $"%A{line}"
        // printfn $"%A{line.mirrorX ()}"
        // printfn $"%A{line.mirrorY ()}"
        
        //3.5
        // printfn $"%A{solveQuadratic (1.0, -3.0, 2.0)}"
        // printfn $"%A{solveQuadratic (1.0, -2.0, 1.0)}"
        // printfn $"%A{solveQuadratic (1.0, 1.0, 1.0)}"
        
        //3.6
        // printfn $"%A{compareTime2 (11,59,AM) (1,15,PM)}"
        // printfn $"%A{compareTime2 (11,59,AM) (12,59,AM)}"
        // printfn $"%A{compareTime2 (11,59,AM) (11,58,AM)}"
        
        printf ""