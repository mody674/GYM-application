Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim connectionstring As String = "Data Source=.;Initial Catalog=members;Integrated Security=True"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersDataSet.العملاء' table. You can move, or remove it, as needed.
        Me.العملاءTableAdapter.Fill(Me.MembersDataSet.العملاء)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles insert.Click
        Dim insertQuery As String = "INSERT INTO العملاء(id,Name,Gender,Phone) VALUES (@id,@name,@gender,@phone)"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                command.Parameters.AddWithValue("@name", TextBox2.Text)
                command.Parameters.AddWithValue("@gender", TextBox3.Text)
                command.Parameters.AddWithValue("@phone", TextBox4.Text)
                connection.Open()
                MessageBox.Show("Data inserted successfully!")
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim deleteQuery As String = "delete from العملاء where id=@id"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(deleteQuery, connection)
                command.Parameters.AddWithValue("@id", CInt(TextBox1.Text))
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("successfully Deleted")
                connection.Close()
            End Using
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim selectQuery As String = "SELECT * FROM العملاء"
        Using connection As New SqlConnection(connectionstring)
            Using command As New SqlCommand(selectQuery, connection)
                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)
                    DataGridView1.DataSource = dataTable
                End Using
                connection.Close()
            End Using
        End Using
    End Sub
End Class

