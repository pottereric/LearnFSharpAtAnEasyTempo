let IsEvenlyDivisibleByList input list =
    list 
    |> List.forall (fun x -> input % x = 0)

let solve max =
    [1..5000]//System.Int32.MaxValue]
    |> List.find (fun x -> IsEvenlyDivisibleByList x [1..max])