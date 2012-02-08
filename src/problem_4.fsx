#light
open System

let largestPalindromicNumber n =
    let isPalindromic x = 
        let reverse (s:string) = new string(s |> Seq.toArray |> Array.rev)
        let asString = x.ToString()
        asString = reverse(asString)
    let min = int("1" + String.replicate (n-1) "0")
    let max = int(Math.Pow(10.0,float(n))) - 1
    let products = seq { for i in min..max do
                            for j in min..max do
                                yield i * j }

    products |> Seq.filter (fun res -> isPalindromic res) |> Seq.max


largestPalindromicNumber 3
