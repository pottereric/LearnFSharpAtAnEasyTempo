open FSharp.Data

type usersData = CsvProvider< @"user_data.csv" >


let printOptionalUser(user : usersData.Row option) =
    match user with
    | Some(u) -> u.FirstName
    | None -> "not found"

let printUser (user : usersData.Row) = 
    printfn $"%s{user.FirstName} %s{user.LastName}"

let printFirstUser (myUsers : usersData) =
    myUsers.Rows 
    |> Seq.head
    |> printUser

let printUserThatCompletedCourses (myUsers : usersData) =
    myUsers.Rows
    |> Seq.filter (fun u -> u.TotalHours > 0.0M)
    |> Seq.iter (fun u -> printUser u)

let myUsers = usersData.GetSample()

//printFirstUser myUsers
printUserThatCompletedCourses myUsers

System.Console.ReadKey() |> ignore

