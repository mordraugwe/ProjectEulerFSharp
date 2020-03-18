namespace ProjectEuler

module Common = 
    let fibonacci n = 
        let getTailRec index prev current =
            fun x y z -> if index > 0 then getTailRec x-1 prev+current prev
                         else current 
        
        getTailRec n 1 0
        

    let fibonacciBelow n =
        0

    
