module Functional_Programming_Paradigm.FirstClassFunction

//'a defines the input and output type,
//making the function work with any type of input
//as long as it is the same the function uses
module FirstClassFunction =
    let applyTwice (f: 'a -> 'a) (x: 'a): 'a =
        f (f x)