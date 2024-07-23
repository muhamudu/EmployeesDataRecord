Imports System

Module EmployeesData
    Sub Main(args As String())
        ' Lists to hold employee data
        Dim employeeNames As New List(Of String)()
        Dim juneSalaries As New List(Of Decimal)()
        Dim julySalaries As New List(Of Decimal)()
        Dim augustSalaries As New List(Of Decimal)()

        ' Loop to enter employee data
        Dim moreEntries As Boolean = True
        While moreEntries
            ' Get employee name
            Console.Write("Enter employee name: ")
            Dim name As String = Console.ReadLine()
            employeeNames.Add(name)

            ' Get salaries for each month
            Console.Write("Enter June salary: ")
            Dim juneSalary As Decimal = Convert.ToDecimal(Console.ReadLine())
            juneSalaries.Add(juneSalary)

            Console.Write("Enter July salary: ")
            Dim julySalary As Decimal = Convert.ToDecimal(Console.ReadLine())
            julySalaries.Add(julySalary)

            Console.Write("Enter August salary: ")
            Dim augustSalary As Decimal = Convert.ToDecimal(Console.ReadLine())
            augustSalaries.Add(augustSalary)

            ' Ask if user wants to enter more entries
            Console.Write("Do you want to add another employee? (yes/no): ")
            moreEntries = Console.ReadLine().ToLower() = "yes"
        End While

        ' Display the recorded employee data
        Console.WriteLine(vbCrLf & "Recorded Employee Salaries:")
        For i As Integer = 0 To employeeNames.Count - 1
            Console.WriteLine("Name: " & employeeNames(i))
            Console.WriteLine("June Salary: " & juneSalaries(i))
            Console.WriteLine("July Salary: " & julySalaries(i))
            Console.WriteLine("August Salary: " & augustSalaries(i))
            Console.WriteLine()
        Next


    End Sub
End Module
