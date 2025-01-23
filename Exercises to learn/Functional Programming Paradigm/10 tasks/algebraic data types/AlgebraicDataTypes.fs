module Functional_Programming_Paradigm._10_tasks.algebraic_data_types.AlgebraicDataTypes

open System

module AlgebraicDataTypes =
    //1
    type Shape<'T> =
        | Circle of 'T
        | Rectangle of 'T * 'T
        
    let inline area (shape: Shape<'T>) : float =
        match shape with
        | Circle r -> Math.PI * float (r * r)
        | Rectangle (h, w) -> float (h * w)
        
    //2
    type Person =
        {Name: string
         Age: int}
    
    let displayPerson (person: Person) : unit =
        printfn $"Name: %A{person.Name}"
        printfn $"Age: %A{person.Age}"
        
    //3
    type HttpStatus =
        | Success of int
        | Redirect of int
        | ClientError of int
        | ServerError of int
        
    let displayHttpStatus (status: HttpStatus) : unit =
        match status with
        | Success i -> printfn $"Success: status code %A{i}"
        | Redirect i -> printfn $"Redirect: status code %A{i}"
        | ClientError i -> printfn $"ClientError: status code %A{i}"
        | ServerError i -> printfn $"ServerError: status code %A{i}"