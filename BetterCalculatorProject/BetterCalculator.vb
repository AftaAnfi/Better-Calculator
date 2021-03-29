Option Explicit On
Option Strict On

'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Better Calculator
'https://github.com/AftaAnfi/Better-Calculator.git

Module BetterCalculator
    Dim readInputString As String
    Dim readInputInteger As Integer
    Dim problem As Boolean = True
    Dim firstnumber As Integer
    Dim secondnumber As Integer
    Dim programloop As Boolean = True
    Dim problem2 As Boolean = True

    Sub Main()
        While programloop

            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")

            Do While problem

                'choose number 1
                Console.WriteLine("Choose a number:")
                readInputString = Console.ReadLine()
                Try

                    If readInputString = "q" Or readInputString = "Q" Then
                        Console.WriteLine($"You entered {readInputString}")
                        Console.WriteLine("Have a nice day!")
                        Console.WriteLine("Press enter to close this window")
                        Console.ReadKey(False)
                        End
                    End If

                    readInputInteger = CInt(readInputString)
                    problem = False
                    Console.WriteLine($"You entered {readInputString}")
                Catch ex As Exception
                    'if not an input number
                    Console.WriteLine($"You entered {readInputString}, please enter a whole number.")
                    problem = True
                End Try
            Loop

            problem = True
            firstnumber = readInputInteger

            Do While problem

                'choose number 1
                Console.WriteLine("Choose a number:")
                readInputString = Console.ReadLine()

                Try

                    If readInputString = "q" Or readInputString = "Q" Then
                        Console.WriteLine($"You entered {readInputString}")
                        Console.WriteLine("Have a nice day!")
                        Console.WriteLine("Press enter to close this window")
                        Console.ReadKey(False)
                        End
                    End If

                    readInputInteger = CInt(readInputString)
                    problem = False
                    Console.WriteLine($"You entered {readInputString}")
                Catch ex As Exception
                    'if not an input number
                    Console.WriteLine($"You entered {readInputString}, please enter a whole number.")
                    problem = True
                End Try
            Loop

            problem = True
            secondnumber = readInputInteger

            Do While problem
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")

                readInputString = Console.ReadLine()

                Select Case readInputString
                    Case "1"
                        Console.WriteLine($"{firstnumber} + {secondnumber} = {firstnumber + secondnumber}")
                        problem = False
                    Case "2"
                        Console.WriteLine($"{firstnumber} - {secondnumber} = {firstnumber - secondnumber}")
                        problem = False
                    Case "3"
                        Console.WriteLine($"{firstnumber} * {secondnumber} = {firstnumber * secondnumber}")
                        problem = False
                    Case "4"
                        Console.WriteLine($"{firstnumber} / {secondnumber} = {firstnumber / secondnumber}")
                        problem = False
                    Case Else
                        Console.WriteLine($"You entered {readInputString}")
                        problem = True
                End Select
            Loop

            problem = True

            'pick what to do with numbers
            Console.WriteLine("Press enter to continue...")
            Console.ReadLine()

        End While

    End Sub

End Module
