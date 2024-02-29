Public Class Form1

    Public conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Oscar Lopez -  s1\Desktop\Oscar Lopez - S1\Empresa\Empresa\bin\Debug\empleados.accdb")
    Public com As New OleDb.OleDbCommand

    Function ConectarDB()
        Try
            conex.Open()
            com.Connection = conex
            com.CommandType = CommandType.Text
            Console.WriteLine("Conexion con la base de datos")
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox("Error al conectar la base de datos.")
                End
            Else
                MsgBox(Err.Description)
            End If

        End Try
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
    End Sub




    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idEmpleado As String = textBoxID.Text
        Dim CantidadCaracteres As Integer = 10


        If (idEmpleado.Length >= CantidadCaracteres) Then

            Dim Nombre As String = textBoxNombre.Text
            Dim Apellido As String = textBoxApellido.Text
            Dim Edad As String = textBoxEdad.Text
            Dim Cargo As String = textBoxCargo.Text
            Dim telefonoEmpleado As String = textBoxTelefono.Text
            Dim DireccionEmpleado As String = textBoxDireccion.Text






            Dim sql As String



            sql = String.Format("INSERT INTO Empleados(id_empleado,Nombre,Apellido,Edad,Cargo,Telefono,Direccion) VALUES({0},'{1}','{2}',{3},'{4}','{5}','{6 }')", CDbl(idEmpleado), Nombre, Apellido, Val(Edad), Cargo, telefonoEmpleado, DireccionEmpleado)


            Console.WriteLine(sql & "  SQL EJECUTADA.")




            com.CommandText = sql

            Try
                com.ExecuteNonQuery()
                MessageBox.Show("Registro guardado en SQL")
            Catch ex As Exception
                MsgBox("Error: " & Err.Number & " Descripcion: " & Err.Description)
            End Try


        Else
            MsgBox("¡El campo Id no puede quedar vacio!")

        End If


    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        textBoxID.Clear()
        textBoxNombre.Clear()
        textBoxApellido.Clear()
        textBoxEdad.Clear()
        textBoxCargo.Clear()
        textBoxDireccion.Clear()
        textBoxTelefono.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim estaVaciotextBoxID As Boolean = (textBoxID.Text = "")

        If estaVaciotextBoxID Then
            MsgBox("¡Se necesita un ID!")
            textBoxID.Select()
            Return
        End If

        Dim empleadoID As String = textBoxID.Text


        Console.WriteLine("boton modificar, valor del ID: " & empleadoID)

        Dim NombreEmpleado As String = textBoxNombre.Text
        Dim ApellidoEmpleado As String = textBoxApellido.Text
        Dim EdadEmpleado As String = textBoxEdad.Text
        Dim CargoEmpleado As String = textBoxCargo.Text
        Dim sqlActualizar As String = String.Format("UPDATE Empleados SET Nombre = '{0}', Apellido = '{1}', Edad = {2}, Cargo = '{3}' WHERE Id_empleado = {4} ", NombreEmpleado, ApellidoEmpleado, EdadEmpleado, CargoEmpleado, empleadoID)

        Console.WriteLine(sqlActualizar)



        com.CommandText = sqlActualizar


        Try
            Dim id0 As Integer
            id0 = com.ExecuteNonQuery()
            If id0 = 0 Then
                MsgBox("¡No se pudo actualizar el registro!")
            Else
                MsgBox("Registro actualizado ID " & empleadoID)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try


    End Sub
End Class
