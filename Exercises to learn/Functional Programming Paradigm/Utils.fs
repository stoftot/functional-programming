module Functional_Programming_Paradigm.Utils

open System.Diagnostics

module Utils =
    let timeFunction (f: 'a -> 'b) (input: 'a) : System.TimeSpan * 'b =
        let stopwatch = Stopwatch.StartNew() // Start measuring time
        let result = f input                  // Execute the input function
        stopwatch.Stop()                      // Stop measuring time
        let elapsed = stopwatch.Elapsed      // Get the elapsed time
        (elapsed, result)                    // Return the elapsed time and result
