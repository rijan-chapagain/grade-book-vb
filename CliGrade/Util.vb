Public Class Util

    Public Sub New()

    End Sub

    Public Sub UserInput(ByVal Grade)

        Console.WriteLine("Please Enter your Grade: ")
        Grade = Console.ReadLine()
        Console.WriteLine("Your Grade is successfully readed. i.e: ")
        'Return Grade
    End Sub

    Public Sub PrintOutput(ByVal Grade)
        Console.WriteLine("Your Grade is successfully readed. i.e: ", Grade)
    End Sub


End Class
