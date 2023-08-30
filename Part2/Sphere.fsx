let getVolume r =
    (4/3)*(22/7)*r*r*r

let catagorize r =
    let volume = getVolume(r);
    if(volume < 100) then "small"
    else if(volume < 1000) then "medium"
    else "huge"

let GetCatagories _ =
    let inputValues = [1..10]
    let outputs = List.map catagorize inputValues
    List.iter (printfn "%s") outputs

GetCatagories()
