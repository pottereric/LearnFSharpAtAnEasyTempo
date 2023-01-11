let getVolume r =
    (4/3)*(22/7)*r*r*r

let catagorize r =
    let volume = getVolume(r);
    if(volume < 100) then "small"
    else if(volume < 1000) then "medium"
    else "huge"

List.iter (fun r -> printfn "%s" (catagorize(r))) [1..20]