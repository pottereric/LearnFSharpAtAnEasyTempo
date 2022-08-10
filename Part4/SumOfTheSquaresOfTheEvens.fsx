let sumTheSquaresOfTheEvens inputList =
    inputList
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map (fun x -> x * x)
    |> List.sum