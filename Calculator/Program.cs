

//Task1- Calculator proqrami duzeltmek ( ancaq toplama, vurma, bolme, cixma emelleri olacaq).
//Service layer olacaq. Service layerde calculatoru yazacaqsiz.
//Qeyd : Calculation classi, ICalculation interface, Calculate methodunuz olacaq.
//Bunlardan istifade edib projecti yazin.

using Calculator.Interfaces;

Calculation calculator = new();
Console.WriteLine(calculator.Add(2,3));
