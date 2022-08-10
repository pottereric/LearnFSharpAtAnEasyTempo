[1..9]
|> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
|> List.sum

let solveEuler1 max = 
    [1..max - 1]
    |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum