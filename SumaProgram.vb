Module Program
    Sub Main()
        Dim numero1 As Double
        Dim numero2 As Double 
        Dim suma As Double

        Console.WriteLine("Ingrese el primer número:")
        numero1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo número:")
        numero2 = Convert.ToDouble(Console.ReadLine())
        suma = numero1 + numero2
        Console.WriteLine("La suma es: " & suma)
    End Sub

End Module
