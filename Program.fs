let x = function x-> f>100000

let productlist = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let costlyPrroduct= productlist|> List.filter x

costlyPrroduct |> List.iter (printfn "%d")






let calFedIncomeTax salary =
    if salary <= 49020.0 then
        salary * 0.15
    else
        0.0 // No tax for salaries over $49,020

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

let fedIncomeTaxes = List.map calFedIncomeTax salaries

printfn "Salaries: %A" salaries
printfn "Fed Income Taxes: %A" fedIncomeTaxes






let sal = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let filteredAndAdjustedSal =
    sal
    |> List.filter (fun sal -> sal < 49020)
    |> List.map (fun sal -> sal + 20000)

printfn "Original Sal: %A" sal
printfn "Filtered and Adjusted Sal: %A" filteredAndAdjustedSal





let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]

let filteredSalaries =
    salaries
    |> List.filter (fun salary -> salary >= 50000 && salary <= 100000)

let sumOfFilteredSalaries =
    filteredSalaries
    |> List.fold (+) 0

printfn "Original Salaries: %A" salaries
printfn "Filtered Salaries between $50,000 and $100,000: %A" filteredSalaries
printfn "Sum of Filtered Salaries: %d" sumOfFilteredSalaries