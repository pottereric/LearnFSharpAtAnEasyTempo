
let GetOutput (num : int) =
    if (num % 15 = 0) then 
        "FizzBuzz"
    else if (num % 3 = 0) then 
        "Fizz"
    else if (num % 5 = 0) then 
        "Buzz"
    else 
        num.ToString()

let PrintOutput(i) =
    printfn $"%s{ GetOutput(i)}"

let FizzBuzz _ = 
    let index = [1..20];
    List.iter PrintOutput index

FizzBuzz()