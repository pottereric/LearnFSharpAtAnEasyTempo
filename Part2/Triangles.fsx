let Identify(a, b, c) =
    if(a = 90 || b = 90 || c = 90) then
        "right"
    else if(a > 90 || b > 90 || c > 90) then
        "obtuse"
    else 
        "acute"