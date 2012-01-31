let fibs = Seq.unfold( fun (a,b) -> Some( a + b, (b, a + b) ) ) (1,1)
let result = fibs   |> Seq.takeWhile ( fun x -> x <= 4000000) 
                    |> Seq.sumBy ( fun x -> if x % 2 = 0 then x else 0)