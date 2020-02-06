open System

let problem1 n =
    
    let mutable numbers = []
    
    for i in 1..n do
        if i % 3 = 0 || i % 5 = 0 
            then numbers <- [i] |> List.append numbers

    numbers |> List.sum