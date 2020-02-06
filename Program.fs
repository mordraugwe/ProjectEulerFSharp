// Learn more about F# at http://fsharp.org
namespace ProjectEuler

open System
open Problems

module Program =

    [<EntryPoint>]
    let main argv =
        
        let problem1solution = problem1updated 1000

        printfn "problem 1 solution : [%i]" problem1solution

        0 // return an integer exit code
