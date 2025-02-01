module BookExcersises.Chapter2

module Chapter2 =
    //2.1
    let f (n: int) : bool =
        match (n % 2, n % 3, n % 5 <> 0) with
        | 0,_,true -> true
        | _,0,true -> true
        | _,_,false -> false
        | _ -> false
        
    //2.2
    let powString (s: string) (n: int) : string =
        let rec inner s n acc =
            if n <= 0 then acc
            else inner s (n-1) acc + s
        inner s n ""
        
    //2.3
    let isIthChar (s: string, i: int, ch: char) : bool =
        s.Chars i = ch
        
    //2.4
    let occFromIth (s: string, i: int, ch: char) : int =
        let subS = s.Substring i 
        let rec inner (arr: char array) (ch: char) (acc: int) : int =
            match arr with
            | [||] -> acc
            | _ ->
                if arr[0] = ch then inner arr[1..] ch (acc + 1)
                else inner arr[1..] ch acc
        inner (subS.ToCharArray ()) ch 0
        
    let betterOccFromIth (s: string, i: int, ch: char) : int =
        s[i..] |> Seq.filter ((=) ch) |> Seq.length
    
    //2.5
    let occInString (s: string, ch: char) : int =
        s |> Seq.filter ((=) ch) |> Seq.length
        
    //2.6
    let notDivisible (d: int, n: int) : bool =
        n % d <> 0
        
    //2.7.1
    let test (a: int, b: int, c: int) : bool =
        let rec inner (a: int, b: int, c: int) : bool =
            if a > b then true
            else if notDivisible (a, c) then inner ((a+1), b, c)
            else false
        inner (a, b, c)
        
    //2.7.2
    let prime (n: int) : bool =
        test (2, (n-1), n)
        
    //2.7.3
    let rec nextPrime (n: int) : int =
        let next = n + 1
        if prime next then next
        else nextPrime next
        
    //2.8
    let rec bin (n: int, k: int) : int =
        match n, k with
            | _,0 -> 1
            | n, k when n = k -> 1
            | _ -> bin (n - 1, k - 1) + bin (n - 1, k)
        
    //2.11
    let VAT (n: int) (x: float) : float =
        x * (1.0 + float n / 100.0)
    
    let unVAT (n: int) (x: float) : float =
        x / float (100 + n) * 100.0
        
    //2.12
    let min (f: int -> int) : int =
        let rec inner f i : int =
            match f i with
            | 0 -> i
            | _ -> inner f (i+1)
        inner f 0
        
    //2.13
    let curry (uncurry: 'a * 'b -> 'c) (a: 'a) (b: 'b) : 'c =
        uncurry (a, b)
    
    let uncurry (curry: 'a -> 'b -> 'c) (a: 'a, b: 'b) :  'c =
        curry a b 