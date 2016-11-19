Public Class mainActivity

    ''' <summary>
    '''
    ''' Declare the main variables
    ''' Square the radius of circle
    ''' Multiply the squared radius by PI
    '''
    ''' </summary>
    ''' <param name="radius"></param>
    ''' <returns></returns>

    Private Function radiusOfCircle(ByVal radius As Double) As Double


        Dim dblSquareRadius As Double
        Dim dblResult As Double

        dblSquareRadius = radius * radius

        dblResult = dblSquareRadius * Math.PI

        Return dblResult

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim dblArea As Double

        dblArea = radiusOfCircle(CDbl(txtBox1.Text))

        MsgBox("The area of circle for given radius is: " & dblArea.ToString, MsgBoxStyle.Information, "Circumference of Circle")

    End Sub
End Class
