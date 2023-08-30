let testUrl1 = "https://projecteuler.net/problem=2"
let testUrl2 = "www.kcdc.info/agenda"
let testUrl3 = "https://www.google.com/search?q=bbq"
let testUrl4 = "http://www.aol.com"

let removeHttpsIfNeccessary (url : string) =
    if (url.StartsWith("https://")) then url.Substring(8)
    else url

let removeHttpIfNeccessary (url : string) =
    if (url.StartsWith("http://")) then url.Substring(7)
    else url
    
let removeQueryString (url : string) =
    if(url.Contains('?')) then
        let index = url.IndexOf('?')
        url.Substring(0, index)
    else
        url

let cleanUrl url =
    url
    |> removeHttpIfNeccessary
    |> removeHttpsIfNeccessary
    |> removeQueryString
