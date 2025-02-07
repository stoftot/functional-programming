//All exercises are from the following book
//Functional Programming using F# by Michael R. Hansen and Hans Rischel, ISBN 9781107684065.

open BookExcersises.Chapter1
open BookExcersises.Chapter2
open BookExcersises.Chapter3
open BookExcersises.Chapter4
open BookExcersises.Chapter5

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
        printfn $"%A{bin (2, 1)}"
        printfn $"%A{bin (4, 3)}"
        
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
        let z1 = Complex(-3.3, 10.3)
        let z2 = Complex(-3.2, -2.0)
        
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
        
    open Chapter4
    module chapter4 =
        //4.1
        // printfn $"%A{upto 10}"
        
        //4.2
        // printfn $"%A{downTo1 10}"
        
        //4.3
        // printfn $"%A{evenN 3}"
        
        //4.4
        // printfn $"%A{altsum [2; -1; 3]}"
        // printfn $"%A{altsum [5; 2; 8; 3]}"
        // printfn $"%A{altsum []}"            
        // printfn $"%A{altsum [10]}"
        
        //4.5
        // printfn $"%A{rmodd (List.init 10 id)}"
        
        //4.6
        // printfn $"%A{removeEvenInts (List.init 10 id)}"
        
        //4.7
        // let intList = [1;1;2;3;4;4;5;5;5;]
        // printfn $"%A{multiplicity 1 intList}"
        // printfn $"%A{multiplicity 2 intList}"
        // printfn $"%A{multiplicity 5 intList}"
        
        //4.8
        // printfn $"%A{split (List.init 10 id)}"
        
        //4.9
        // let letterList = ['a';'b';'c';'d';'e';]
        // printfn $"%A{zip letterList (List.init 5 id)}"
        // printfn $"%A{zip letterList (List.init 6 id)}"
        
        //4.10
        // printfn $"%A{prefix (List.init 5 id) (List.init 5 id)}"
        // printfn $"%A{prefix (List.init 5 id) (List.init 6 id)}"
        // printfn $"%A{prefix (List.init 6 id) (List.init 5 id)}"
        // printfn $"%A{prefix (List.init 5 id) (List.init 6 id |> List.rev)}"
        
        //4.11.1
        let weaklyAscending = [-3; -1; -1; 0; 3; 3; 3; 6; 7;]
        let weaklyAscending2 = [-20; -1; 0; 3; 3; 6; 10]
        // printfn $"%A{count weaklyAscending -1}"
        // printfn $"%A{count weaklyAscending 3}"
        
        //4.11.2
        // printfn $"%A{insert weaklyAscending 2}"
        // printfn $"%A{insert weaklyAscending 4}"
        // printfn $"%A{insert weaklyAscending 10}"
        // printfn $"%A{insert weaklyAscending -5}"
        // printfn $"%A{insert weaklyAscending -2}"
        // printfn $"%A{insert [] -2}"
        
        //4.11.3
        // printfn $"%A{intersect weaklyAscending weaklyAscending2}"
        // printfn $"%A{intersect weaklyAscending2 weaklyAscending}"
        // printfn $"%A{intersect weaklyAscending []}"
        
        //4.11.4
        // printfn $"%A{plus [-1; 0; 4; 6;] [-10; -3; 2; 10;]}"
        
        //4.11.5
        // printfn $"%A{minus weaklyAscending weaklyAscending2}"
        
        //4.12
        // printfn $"%A{sum (fun x -> x >= 0) (List.init 5 id)}"
        // printfn $"%A{sum (fun x -> x > 0) [-5; -3; -2; 0; 2; 5]}"
        
        //4.13.1
        // printfn $"%A{min [-3; 0; -5; -10; 20; -30]}"
        // printfn $"%A{min [-3; 0; -5; -100; 20; -30]}"
        
        //4.13.2
        // printfn $"%A{delete [0;1;2;2;3;] 2}"
        // printfn $"%A{delete [0;1;2;2;3;] 5}"
        
        //4.13.3
        // printfn $"%A{mergeSort (List.init 5 id)}"
        // printfn $"%A{mergeSort [5; -1; 4; 3; 3; 2; 6; -3]}"
        
        //4.14
        // printfn $"%A{minList []}"
        // printfn $"%A{minList [100; -20; -3; -4; -30; -50; 2000]}"
        
        //4.15
        // printfn $"%A{revrev [[];[1;2];[3;4;5]]}"
        
        printf ""
        
    module chapter5 =
        //5.1
        // printfn $"%A{ownFilter (fun x -> x % 2 = 0) (List.init 5 id)}"
        
        //5.2
        // printfn $"%A{revrev5 [[];[1;2];[3;4;5]]}"
        
        //5.3
        // printfn $"%A{sum5 (fun x -> x >= 0) (List.init 5 id)}"
        // printfn $"%A{sum5 (fun x -> x > 0) [-5; -3; -2; 0; 2; 5]}"
        
        //5.4
        // printfn $"%A{fac 5}"
        // printfn $"%A{range fac 5}"
        
        //5.6
        let r = set [("Alice", "Math"); ("Bob", "Physics"); ("Alice", "Physics")]
        // printfn $"%A{domain r}"
        // printfn $"%A{rangeS r}"
        // printfn $"""%A{apply r "Bob"}"""
        // printfn $"%A{symmetric (set [(1,2); (3,4)])}"
        // printfn $"%A{reComp (set [(1,2);(0,2);(6,7)]) (set [(2,3);(7,8)])}"
        // printfn $"%A{reComp2 (set [(1,2);(0,2);(6,7)]) (set [(2,3);(7,8)])}"
            
        // transitive (set [(1,2); (2,3); (3,4)])
        // |> Seq.map string
        // |> String.concat " | "
        // |> printfn "[ %s ]"
        //
        // transitive (set [(1,2); (2,3); (3,5);(5,2)])
        // |> Seq.map string
        // |> String.concat " | "
        // |> printfn "[ %s ]"
        
        //5.7
        // printfn $"%A{allSubsets 4 3}"
            
        printf ""