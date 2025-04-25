Public Class Form1
    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        btnOn.Height = HomeBtn.Height
        btnOn.Top = HomeBtn.Top
        HomePanel.Visible = True
        CoursesPanel.Visible = False
        SloutionPanel.Visible = False
    End Sub

    Private Sub SolutionBtn_Click(sender As Object, e As EventArgs) Handles SolutionBtn.Click
        btnOn.Height = SolutionBtn.Height
        btnOn.Top = SolutionBtn.Top
        HomePanel.Visible = False
        CoursesPanel.Visible = False
        SloutionPanel.Visible = True
    End Sub

    Private Sub CourseBtn_Click(sender As Object, e As EventArgs) Handles CourseBtn.Click
        btnOn.Height = CourseBtn.Height
        btnOn.Top = CourseBtn.Top
        HomePanel.Visible = False
        CoursesPanel.Visible = True
        SloutionPanel.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("https://twitter.com/AdeebTechLab")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("https://www.tiktok.com/@adeebtechnologylab?lang=en")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://www.linkedin.com/in/adeebtechnologylab/")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://www.linkedin.com/in/adeebtechnologylab/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("mailto:AdeebTechnologyLab@gmail.com")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/AdeebTechnologyLab")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://adeebtechlab.blogspot.com/")
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pVDUlBhnVwaZNKvoMTOE0tS")
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pW5V-yDyC5cy803bttuStuy")
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXK2ULiKOTyxn1EsDmWbe7X")
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUpnW7jyQpINQgqq1HtOqt8")
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXea1K_5lQMADrjiOA-s9iD")
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pVDTQDuZHaTqp-UAaYQv7n8")
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pWzshzBAkmya5xg1awbQOPa")
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pVZmOZlFBi6q8SRzMknZFt0")
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUSTlL0A2_XpTPuClCYNArB")
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pVPM2RxXZZt_i56_jMU2Bze")
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXQn3UbzmIImEQSnKkMfEI-")
    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUIyChwAkqdJdj_bEKKqG6B")
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXXB0vHxSC0aVlCIBN5pTDI")
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUzj2L6WXEegGHoerGuX94H")
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXv7LN0YdG-xCBP54eoedUn")
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXjtq64Bu4Qa_g0V9K3LJBl")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pWnwn0hSRLrBB6arZiMrdpK")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUKxB8g_3npZSowAPOyG62i")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUx-0I_xU66wpE_7SqWygc3")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXiXkq959ql0ObiBdCUIDcI")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pVeruihPqreaCywHvfkNTaQ")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUCMAWV03IfhbOlctwXqqNy")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pUmbtCBwA_CA8aX-0-M1THG")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pU9XHMLe8UIUYIE82IXt6Hz")
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pXKxiVZTv91OlN81gyBpgZQ")
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pULOQRYV7WHYVFXrfkW-0RX")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pWoEJbho8mCQJjQo0RJKaP0")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pWt9tK5cUKXedFPdGcKi1ek")
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pW7wpZz5VcM2vvVaEKZdDax")
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/@SalmanAdeebVLOGS/videos")
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        System.Diagnostics.Process.Start("https://www.youtube.com/playlist?list=PLOkWSy5Ba4pVqWFOfHxwD98XLnW-o6XxS")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

End Class
