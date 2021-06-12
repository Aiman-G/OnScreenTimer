' Wrttien by Ghannami ; Aymen.omg@gmail.com

' A simple timer for Microsoft PowerPoint  presentation
'


Public Class Form1

    Dim secondes As Integer
    Dim minutes As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        lblSec.BackColor = System.Drawing.Color.Transparent
        lblMin.BackColor = System.Drawing.Color.Transparent

        'set controlbox flase
        Me.ControlBox = False
        ' set timer interval to 1 second /1000ms
        Timer1.Interval = 1000


        ' Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Show()
        TopmostTimer.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        secondes += 1
        If secondes = 60 Then
            minutes += 1
            secondes = 0
        End If
        lblSec.Text = CStr(secondes) + ":"
        lblMin.Text = CStr(minutes)
    End Sub

    Private Sub TopmostTimer_Tick(sender As Object, e As EventArgs) Handles TopmostTimer.Tick

        Me.TopMost = True

    End Sub



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Enabled = True
    End Sub






    'Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
    '    Dim grapics As Graphics = Me.CreateGraphics()

    '    grapics.FillEllipse(System.Drawing.Brushes.Blue, 0, 0, Me.ClientSize.Width - 5,
    '        Me.ClientSize.Height - 5)
    'End Sub
End Class
