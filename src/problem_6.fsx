#light
let problem6 =
    let seq = seq { 1..100 }
    let square = fun x -> x * x
    let sumOfSquares = seq |> Seq.sumBy square
    let squareOfSum = seq |> Seq.sum |> square
    squareOfSum - sumOfSquares