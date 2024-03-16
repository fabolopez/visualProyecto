Public Class Form1

    Public conex As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= empleados.accdb")
    Public com As New OleDb.OleDbCommand
    Dim CantidadCaracteres As Integer = 10

    Private Sub ConectarDB()
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
    End Sub




    Private Sub limpiarTextBoxs()
        textBoxID.Clear()
        textBoxNombre.Clear()
        textBoxApellido.Clear()
        textBoxEdad.Clear()
        textBoxCargo.Clear()
        textBoxDireccion.Clear()
        textBoxTelefono.Clear()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarDB()
    End Sub




    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim idEmpleado As String = textBoxID.Text



        If (idEmpleado.Length >= CantidadCaracteres) Then

            Dim Nombre As String = textBoxNombre.Text
            Dim Apellido As String = textBoxApellido.Text
            Dim Edad As String = textBoxEdad.Text
            Dim Cargo As String = textBoxCargo.Text
            Dim telefonoEmpleado As String = textBoxTelefono.Text
            Dim DireccionEmpleado As String = textBoxDireccion.Text
            Dim sql As String



            sql = String.Format("INSERT INTO Empleados(id_empleado,Nombre,Apellido,Edad,Cargo,Telefono,Direccion) VALUES('{0}','{1}','{2}',{3},'{4}','{5}','{6 }')", CDbl(idEmpleado), Nombre, Apellido, Edad, Cargo, telefonoEmpleado, DireccionEmpleado)


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
        limpiarTextBoxs()
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
        Dim telefonoEmpleado As String = textBoxTelefono.Text
        Dim direccionEmpleado As String = textBoxDireccion.Text
        Dim sqlActualizar As String = String.Format("UPDATE Empleados SET Nombre = '{0}', Apellido = '{1}', Edad = {2}, Cargo = '{3}', telefono = {4}, direccion = '{5}' WHERE Id_empleado = {6} ",
                                                    NombreEmpleado, ApellidoEmpleado, EdadEmpleado, CargoEmpleado, telefonoEmpleado, direccionEmpleado, empleadoID)



        Console.WriteLine(sqlActualizar)



        com.CommandText = sqlActualizar


        Try
            Dim id0 As Integer
            id0 = com.ExecuteNonQuery()
            If id0 = 0 Then
                MsgBox(Err.Description)
            Else
                MsgBox("Registro actualizado ID " & empleadoID)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idABuscar As String = textBoxID.Text
        Dim sqlBuscar As String


        If (idABuscar.Length > CantidadCaracteres) Then
            sqlBuscar = String.Format("SELECT * FROM Empleados WHERE Id_empleado = {0}", idABuscar)
            Dim adapt As New OleDb.OleDbDataAdapter(sqlBuscar, conex)
            Dim ds As New DataSet
            adapt.Fill(ds)

            If (ds.Tables(0).Rows.Count = 0) Then
                MsgBox("No encontre ese registro")

            Else

                textBoxNombre.Text = ds.Tables(0).Rows(0)("Nombre").ToString()
                textBoxApellido.Text = ds.Tables(0).Rows(0)("Apellido").ToString()
                textBoxEdad.Text = ds.Tables(0).Rows(0)("Edad").ToString()
                textBoxCargo.Text = ds.Tables(0).Rows(0)("Cargo").ToString()
                textBoxTelefono.Text = ds.Tables(0).Rows(0)("telefono").ToString()
                textBoxDireccion.Text = ds.Tables(0).Rows(0)("direccion").ToString()
                ds.Dispose()
            End If

        Else
                MsgBox("¡Se require una ID para realizar la consulta!")
        End If







    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim idABorrar As String = textBoxID.Text

        If (idABorrar.Length >= CantidadCaracteres) Then
            Dim sqlExistente As String = String.Format("SELECT * FROM Empleados WHERE Id_empleado = {0}", idABorrar)

            Dim adaptador As New OleDb.OleDbDataAdapter(sqlExistente, conex)
            Dim datosEncontrado As New DataSet
            adaptador.Fill(datosEncontrado)

            If datosEncontrado.Tables(0).Rows.Count = 0 Then
                MsgBox("No existe informacion del ID: " & idABorrar)

            Else
                Dim respuesta As DialogResult

                respuesta = MsgBox("¿Quiere eliminar el registro ID : " & idABorrar & "", MessageBoxButtons.YesNo)

                If respuesta = System.Windows.Forms.DialogResult.Yes Then

                    Dim sqlBorrar As String = "DELETE FROM Empleados WHERE Id_empleado = " & idABorrar & " "
                    com.CommandText = sqlBorrar

                    Try
                        Dim res As Integer = com.ExecuteNonQuery()

                        If res >= 1 Then
                            limpiarTextBoxs()
                            MsgBox(idABorrar & " fue eliminado correctamente de la base de datos")
                        Else
                            MsgBox("No se pudo eliminar, error.")
                        End If

                    Catch ex As Exception
                        MsgBox(Err.Description)
                    End Try
                End If
            End If


        End If


    End Sub
End Class
