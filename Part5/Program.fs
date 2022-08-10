open FSharp.Data

type usersData = CsvProvider< @"user_data.csv" >

let myUsers = usersData.GetSample()
let first = myUsers.Rows |> Seq.head

printfn $"%s{first.FirstName} %s{first.LastName}"

System.Console.ReadKey() |> ignore

