Public Class Frm_Patients

    Private Sub Frm_Patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GB_Patients.Parent = Me
        Me.GB_Patients.BackColor = Color.Transparent
    End Sub
End Class