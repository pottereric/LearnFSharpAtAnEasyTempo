// Declare a record type


type Person = { Name : string; Age : int }

// Create a value via record expression
let paul = { Name = "Paul"; Age = 28 }

// 'Copy and update' record expression
let paulsTwin = { paul with Name = "Jim" }

printfn $"%s{paul.Name} - %d{paul.Age}";
printfn $"%s{paulsTwin.Name} - %d{paulsTwin.Age}";