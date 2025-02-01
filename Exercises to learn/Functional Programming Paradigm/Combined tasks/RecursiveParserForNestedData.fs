module Functional_Programming_Paradigm.Combined_tasks.RecursiveParserForNestedData

open FParsec

// module RecursiveParserForNestedData =
//     type NestedList =
//         | Value of int
//         | List of NestedList
//     
//     let rec parseNestedList, parseValue =
//         createParserForwardedToRef<NestedList, unit>()
//         let parseValue = pint32 |>> Value
//         let parseList = between (pchar '[') (pchar ']') (sepBy parseNestedList (pchar ','))
//         do parseNestedList := parseValue <|> (parseList |>> List)
    