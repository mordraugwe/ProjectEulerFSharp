namespace ProjectEuler
open System

module Problems =

    let problem1 n =    
        let mutable numbers = []
        
        for i in 1..n do
            if i % 3 = 0 || i % 5 = 0 
                then numbers <- [i] |> List.append numbers

        numbers |> List.sum

    let IsMultipleTo3or5 n =
        n % 3 = 0 || n % 5 = 0

    let problem1updated n =
        [1..n-1] |> List.filter IsMultipleTo3or5     
        |> List.sum