module BookExcersises.Chapter3

open System

module Chapter3 =
    //3.1
    let compareTime (h1: int, m1: int, f1: string) (h2: int, m2: int, f2: string) : bool =
        if f1 <> f2 then f1 < f2
        else if h1 <> h2 then h1 < h2
        else m1 < m2
    
    [<CustomComparison; StructuralEquality>]
    type Time =
        {h: int; m: int; f: string}
        interface System.IComparable<Time> with
            member this.CompareTo (other: Time): int =
                if this.f <> other.f then compare this.f other.f
                else if this.h <> other.h then compare this.h other.h
                else compare this.m other.m
    
        interface IComparable with
           member this.CompareTo(obj) =
               match obj with
               | :? Time as other -> (this :> System.IComparable<Time>).CompareTo(other)
               | _ -> invalidArg "obj" "Cannot compare values of different types"
    
    //3.2
    let toShillings (po, sh, pe) : int =
        (pe * 20 + sh) * 12 + po
    
    let convert (po, sh, pe) : int * int * int =
        let nPo = po % 12
        let nSh = (sh + (po - nPo) / 12) % 20
        let nPe = float pe + Math.Ceiling (float (sh - nSh) / 20.0)
        nPo, nSh, int nPe 
    
    let add (po1, sh1, pe1) (po2, sh2, pe2) : int * int * int =
        convert (po1 + po2, sh1 + sh2, pe1 + pe2)
        
    let subtract (po1, sh1, pe1) (po2, sh2, pe2) : int * int * int =
        convert (toShillings (po1, sh1, pe1) - toShillings (po2, sh2, pe2), 0, 0)
        
    type British =
        {po: int; sh: int; pe: int}
        member this.add (other) : British =
            let po, sh, pe = add (this.po, this.sh, this.pe) (other.po, other.sh, other.pe)
            {po = po; sh = sh; pe = pe}
            
        member this.subtract (other) : British =
            let po, sh, pe = subtract (this.po, this.sh, this.pe) (other.po, other.sh, other.pe)
            {po = po; sh = sh; pe = pe}
    
    //3.3
    type Complex(a: float, b: float) =
        member this.Re = a
        member this.Im = b
        
        //3.3.1
        static member (+) (z1: Complex, z2: Complex) =
            Complex(z1.Re + z2.Re, z1.Im + z2.Im)

        static member (*) (z1: Complex, z2: Complex) =
            Complex(z1.Re * z2.Re - z1.Im * z2.Im, z1.Im * z2.Re + z1.Re * z2.Im)
            
        //3.3.2
        static member (-) (z1: Complex, z2: Complex) =
            Complex(z1.Re - z2.Re, z1.Im - z2.Im)

        static member (/) (z1: Complex, z2: Complex) =
            let denom = z2.Re*z2.Re + z2.Im*z2.Im
            if denom = 0.0 then failwith "Division by zero"
            else Complex((z1.Re*z2.Re + z1.Im*z2.Im) / denom, (z1.Im*z2.Re - z1.Re*z2.Im) / denom)
        
         override this.ToString() =
            // Display as "a + bi" or "a - bi" depending on the sign of the imaginary part.
            if this.Im >= 0.0 then sprintf "%g + %gi" this.Re this.Im
            else sprintf "%g - %gi" this.Re (-this.Im)
            
    //3.4
    type StraightLine =
        {a: float; b: float}
        
        member this.mirrorX () : StraightLine =
            {a = -this.a; b = -this.b}
        
        member this.mirrorY () : StraightLine =
            {a = -this.a; b = this.b}
            
        override this.ToString () : string =
            if this.b >= 0.0 then $"y = %g{this.a}x + %g{this.b}"
            else $"y = %g{this.a}x %g{this.b}"
            
    //3.5
    type Solution =
        | TwoRoots of float * float
        | OneRoot of float
        | NoRoot
        
    let inline solveQuadratic (a: float, b: float, c: float) : Solution =
        let D = (b * b) - (4.0 * a * c)
        match D with
        | d when d > 0.0 -> 
            let root1 = (-b + sqrt d) / (2.0 * a)
            let root2 = (-b - sqrt d) / (2.0 * a)
            TwoRoots(root1, root2)
        | 0.0 -> 
            let root = -b / (2.0 * a)
            OneRoot(root)
        | _ -> NoRoot
        
    //3.6
    type TimePeriod =
        |AM
        |PM
        
    let compareTime2 (h1: int, m1: int, f1: TimePeriod) (h2: int, m2: int, f2: TimePeriod) : bool =
        if f1 <> f2 then f1 < f2
        else if h1 <> h2 then h1 < h2
        else m1 < m2
        
    //3.7
    type Shape =
        | Circle of float
        | Square of float
        | Triangle of float * float * float
    
    let isShape = function
        | Circle r -> r > 0.0
        | Square a -> a > 0.0
        | Triangle(a,b,c) ->
            a > 0.0 && b > 0.0 && c > 0.0
            && a < b + c && b < c + a && c < a + b
    
    let area (x: Shape) : float =
        match x with
        | x when not (isShape x) -> failwith "not a legal shape" raise
        | Circle r -> Math.PI * r * r
        | Square a -> a * a
        | Triangle(a,b,c) ->
            let s = (a + b + c)/2.0
            sqrt(s*(s-a)*(s-b)*(s-c))