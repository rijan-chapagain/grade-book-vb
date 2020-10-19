Module Module1

    Sub Main()
        Console.WriteLine("Welcome to VB grade book")

        Dim grade As String
        Dim scoreList As New List(Of Integer)
        Dim score As Decimal
        Dim avg As Decimal
        Dim total As Decimal
        Dim gradeCount As Integer
        Dim index As Integer

        Dim countHd As New List(Of String)
        Dim countD As New List(Of String)
        Dim countC As New List(Of String)
        Dim countP As New List(Of String)
        Dim countF As New List(Of String)

        'Dim util As Util = New Util()

        'Util.UserInput(Grade)
        'Util.PrintOutput(score)

        Console.WriteLine("Please Enter number of Students: ")
        Dim num = Console.ReadLine()

        Console.WriteLine("Now Enter " & num & " Students Grade: ")

        For index = 1 To num

            score = Console.ReadLine()

            scoreList.Add(score)
            Console.WriteLine("Your Score list: {0} ", scoreList.Count)
            Console.WriteLine("Please Enter next Students Grade: ")
        Next

        For Each number As Integer In scoreList
            Console.WriteLine("Your scoreList after for loop are: {0}", number)


            If number >= 80 And number <= 100 Then
                countHd.Add("H.D")

            ElseIf number >= 70 And number <= 79 Then
                countD.Add("D")

            ElseIf number >= 60 And number <= 69 Then
                countC.Add("C")

            ElseIf number >= 50 And number <= 59 Then
                countP.Add("P")

            ElseIf number < 50 Then
                countF.Add("f")
            Else
                Console.WriteLine("Not a valid grade. (has to be betn 0 and 100)")
            End If

        Next

        Console.WriteLine("outside foreach: ")
        Console.WriteLine("Number of H.D Graded students: {0}", countHd.Count)
        Console.WriteLine("Number of D Graded students: {0}", countD.Count)
        Console.WriteLine("Number of C Graded students: {0}", countC.Count)
        Console.WriteLine("Number of P Graded students: {0}", countP.Count)
        Console.WriteLine("Number of Fail Graded students: {0}", countF.Count)


        avg = scoreList.Sum / scoreList.Count
        Console.WriteLine("Average score: {0}", avg)

        Console.ReadLine()
    End Sub

End Module
