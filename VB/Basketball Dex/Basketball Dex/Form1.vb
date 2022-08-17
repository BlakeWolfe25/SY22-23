Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = PointguardPictureBox.Image
        nameLabel.Text = "Point Guard"
        sizeLabel.Text = "A Point Guard is usually a little bit smaller."
        shootingLabel.Text = "A point Gaurd is always a very good shooter."
        speedLabel.Text = "A point Guard is almost always very fast."
        ballLabel.Text = "A Point Guard must have great ball handeling skills."


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Shootingguardpicturebox.Image
        nameLabel.Text = "Shooting Guard"
        sizeLabel.Text = "A Shooting Guard is usually pretty small."
        shootingLabel.Text = "A Shooting Guard is always a great shooter and shoot the ball the most."
        speedLabel.Text = "A Shooting Gaurd is usually pretty fast but not the fastest."
        ballLabel.Text = "A Shooting Gaurd has good ball handeling skills a magority of the time."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = Smallforwardpicturebox.Image
        nameLabel.Text = "Small Forward"
        sizeLabel.Text = "Small Forwards are usally very big when it comes to size."
        shootingLabel.Text = "Small Forwads don't shoot as many threes but are very good at midrange."
        speedLabel.Text = "Small Forwards are usually pretty fast but not the fastest."
        ballLabel.Text = "Small Forwards can have good ball handeling but not usually."
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = Powerforwardpicturebox.Image
        nameLabel.Text = "Power Forward"
        sizeLabel.Text = "A Power Forward is huge and are some of the biggest on the court."
        shootingLabel.Text = "Power Forwards are never good shooters and don't shoot very much."
        speedLabel.Text = "Power Forwards aren't very fast because of how big they are."
        ballLabel.Text = "Power Forwards don't have very great handles because of how lengthy they are."

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.Image = Centerpicturebox.Image
        nameLabel.Text = "Center"
        sizeLabel.Text = "Centers are always the biggest on the court when it comes to size."
        shootingLabel.Text = "Centers are never good at shooting because they play close to the hoop."
        speedLabel.Text = "Centers are pretty slow because of how big they are."
        ballLabel.Text = "Centers don't usually have great ball handeling skills."
    End Sub

End Class