Module Module2

    Public sumscore, students, x1, x2, x3 As Single

    Sub pause()
        Console.WriteLine()
        Console.Write("===>程式暫停中,請按任意鍵繼續")
        Console.ReadKey()
    End Sub

    '''<summary>
    '''把成績平均
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function average(ByRef sumscore As Single, ByRef students As Single)
        Dim AvgScore As Single


        AvgScore = sumscore / students
        Return AvgScore


    End Function














End Module
