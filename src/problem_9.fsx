#time;;
let square x = x * x
let answer = seq { for a in {1..1000} do
                    for b in {a..1000} do
                        let c = 1000 - a - b
                        if square a + square b = square c then
                            yield (a,b,c) } |> Seq.head

answer |> fun (a,b,c) -> printfn "%A %d" (a,b,c) (a * b * c)