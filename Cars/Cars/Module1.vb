Imports ClassLibrary1

Module Module1

    Sub Main()
        Dim myCar As New Cars
        myCar.make = make.Honda
        myCar.model = "MDX"
        Dim myOtherCar As New Cars
        myOtherCar.make = make.MercedesBenz
        myOtherCar.model = "Viano"

        Dim CC As New System.Collections.ArrayList
        CC.Add(myCar)
        CC.Add(myOtherCar)

        'CC.Sort()

        For Each cars In CC
            Dim i As Integer

            Console.WriteLine("We own a {0} {1}.", cars.make, cars.model)



        Next
        Console.ReadLine()
    End Sub

End Module
