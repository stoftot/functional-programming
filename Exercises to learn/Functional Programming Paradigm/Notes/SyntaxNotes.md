Use """ """ for printing functions that take a string as input
Example: printfn $"""%A{foldReduce combineToString "" intList}"""

Use inline when constraining input variables to the operation used in the function e.g
let inline add (a: 'a) (b: 'a) : 'a =
    a + b
If inline wasn't used, 'a would be restricted to being an integer
but by using inline it can be any numeric type

use fst to chose the first value of a tuple, and use snd to chose the second one

use ref [] to create a mutable list
ex.
let myList = ref []
Add element to the beginning
myList.value <- <value> :: myList.value
Add element to the end
myList.value <- myList.value @ <value>

id, the identify function 'T -> 'T

use @ to append something to the end of list
[1; 2; 3;] @ [4] = [1; 2; 3; 4;]
use :: to prepend something to the front of a list
4 :: [1; 2; 3;] = [4; 1; 2; 3;]

Implementation for head :: tail when matching arrays
match arr with
    | [||] -> acc
    | _ -> arr[0] <recursive func> arr[1..]
    
![img.png](img.png)