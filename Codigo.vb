Imports System

Module Program
	Sub Main()
		Dim op As Integer

		Console.WriteLine("MENU")
		Console.WriteLine("1 - Suma")
		Console.WriteLine("2 - Resta")
		Console.WriteLine("3 - Multiplicacion")
		Console.WriteLine("4 - Division")
		op = Console.ReadLine()

		OperacionSeleccionada(op)

	End Sub
	Sub OperacionSeleccionada(opcion As Integer)
		Dim n1, n2, Resultado As Integer
		Console.WriteLine("Ingrese el primer numero ")
		n1 = Console.ReadLine()

		Console.WriteLine("Ingrese el segundo numero ")
		n1 = Console.ReadLine()

		If (opcion = 1) Then
			Resultado = n1 + n2
			Console.WriteLine("Resultado" & Resultado)
		ElseIf (opcion = 2) Then
			Resultado = n1 - n2
			Console.WriteLine("Resultado" & Resultado)
		ElseIf (opcion = 3) Then
			Resultado = n1 * n2
			Console.WriteLine("Resultado" & Resultado)
		ElseIf (opcion = 4) Then
			Resultado = n1 / n2
			Console.WriteLine("Resultado" & Resultado)
		Else
			Console.WriteLine("Opcion Invalida")

		End If
	End Sub
