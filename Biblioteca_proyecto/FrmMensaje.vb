Imports System.Runtime.InteropServices
Public Class FrmMensaje

    'Fields
    Private _primaryColor As Color = Color.PeachPuff
    Private _borderSize As Integer = 2
    'Properties
    Public Property PrimaryColor As Color
        Get
            Return _primaryColor
        End Get
        Set(value As Color)
            _primaryColor = value
            Me.BackColor = PrimaryColor 'Form Border Color
            Me.panelTitleBar.BackColor = PrimaryColor 'Title Bar Back Color
        End Set
    End Property
    'Constructors
    Public Sub New(text As String)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = ""
        SetFormSize()
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1) 'Set Default Buttons
    End Sub
    Public Sub New(text As String, caption As String)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1) 'Set Default Buttons
    End Sub
    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, MessageBoxDefaultButton.Button1) 'Set [Default Button 1]
    End Sub
    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, MessageBoxDefaultButton.Button1) 'Set [Default Button 1]
        SetIcon(icon)
    End Sub
    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, defaultButton)
        SetIcon(icon)
    End Sub
    '-> Private Methods
    Private Sub InitializeItems()
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(_borderSize) 'Set border size
        Me.labelMessage.MaximumSize = New Size(550, 0)
        Me.btnClose.DialogResult = DialogResult.Cancel
        Me.Button1.DialogResult = DialogResult.OK
        Me.Button1.Visible = False
        Me.Button2.Visible = False
        Me.Button3.Visible = False
        panelTitleBar.BackColor = Color.PeachPuff
        panelBody.BackColor = Color.FromArgb(30, 67, 90)
        panelButtons.BackColor = Color.FromArgb(20, 57, 80)

    End Sub
    Private Sub SetFormSize()
        Dim widht As Integer = Me.labelMessage.Width + Me.pictureBoxIcon.Width + Me.panelBody.Padding.Left
        Dim height As Integer = Me.panelTitleBar.Height + Me.labelMessage.Height + Me.panelButtons.Height + Me.panelBody.Padding.Top
        Me.Size = New Size(widht, height)
    End Sub
    Private Sub SetButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
        Dim xCenter As Integer = (Me.panelButtons.Width - Button1.Width) / 2
        Dim yCenter As Integer = (Me.panelButtons.Height - Button1.Height) / 2
        Select Case buttons
            Case MessageBoxButtons.OK
                'OK Button
                Button1.Visible = True
                Button1.Location = New Point(xCenter, yCenter)
                Button1.Text = "Ok"
                Button1.DialogResult = DialogResult.OK 'Set DialogResult
                'Set Default Button
                SetDefaultButton(defaultButton)
            Case MessageBoxButtons.OKCancel
                'OK Button
                Button1.Visible = True
                Button1.Location = New Point(xCenter - (Button1.Width / 2) - 5, yCenter)
                Button1.Text = "Impresión"
                Button1.Font = New Font(Button1.Font, FontStyle.Underline)
                Button1.DialogResult = DialogResult.OK 'Set DialogResult
                Button1.BackColor = Color.PeachPuff
                'Cancel Button
                Button2.Visible = True
                Button2.Location = New Point(xCenter + (Button2.Width / 2) + 5, yCenter)
                Button2.Text = "Cancelar"
                Button2.DialogResult = DialogResult.Cancel 'Set DialogResult
                Button2.BackColor = Color.IndianRed
                'Set Default Button
                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If
            Case MessageBoxButtons.YesNo
                'Yes Button
                Button1.Visible = True
                Button1.Location = New Point(xCenter - (Button1.Width / 2) - 5, yCenter)
                Button1.Text = "Sí"
                Button1.DialogResult = DialogResult.Yes 'Set DialogResult
                'No Button
                Button2.Visible = True
                Button2.Location = New Point(xCenter + (Button2.Width / 2) + 5, yCenter)
                Button2.Text = "No"
                Button2.DialogResult = DialogResult.No 'Set DialogResult
                Button2.BackColor = Color.IndianRed
                'Set Default Button
                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If
        End Select
    End Sub
    Private Sub SetDefaultButton(defaultButton As MessageBoxDefaultButton)
        Select Case defaultButton
            Case MessageBoxDefaultButton.Button1 'Focus button 1
                Button1.Select()
                Button1.ForeColor = Color.White
                Button1.Font = New Font(Button1.Font, FontStyle.Underline)
            Case MessageBoxDefaultButton.Button2 'Focus button 2
                Button2.Select()
                Button2.ForeColor = Color.White
                Button2.Font = New Font(Button2.Font, FontStyle.Underline)
            Case MessageBoxDefaultButton.Button3 'Focus button 3
                Button3.Select()
                Button3.ForeColor = Color.White
                Button3.Font = New Font(Button3.Font, FontStyle.Underline)
        End Select
    End Sub
    Private Sub SetIcon(icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Error
                Me.pictureBoxIcon.Image = My.Resources._error
                Me.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson
            Case MessageBoxIcon.Information
                Me.pictureBoxIcon.Image = My.Resources.information
            Case MessageBoxIcon.None
                Me.pictureBoxIcon.Image = My.Resources.chat
        End Select
        Me.pictureBoxIcon.Location = New Point(10, 10)
    End Sub
    '-> Events Methods
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#Region "-> Drag Form"
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As System.IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
    Private Sub labelCaption_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles labelCaption.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
#End Region
End Class