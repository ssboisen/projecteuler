﻿#light
{1..999} |> Seq.sumBy (fun n -> if n % 3 = 0 || n % 5 = 0 then n else 0)