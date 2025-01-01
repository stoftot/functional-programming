module Functional_Programming_Paradigm.ParserCombinators

open System
open FParsec

module ParserCombinators =
    let private pNumber = pint32
    let private pComma: Parser<char,unit> = pchar ','
    let private pStringToIntList = sepBy pNumber pComma
    
    let parseStringToIntList (list: String) : string * int list =
         match run pStringToIntList list with
            | Success(result, _, _) -> "Parsed", result
            | Failure(errorMsg, _, _) ->  $"Error: {errorMsg}", []