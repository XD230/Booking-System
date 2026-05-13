Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text


Public Class CoverPictureBox
    Inherits PictureBox

    Private _path As String = ""

    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.UserPaint Or
                 ControlStyles.ResizeRedraw, True)
    End Sub

    <DefaultValue("")>
    Public Shadows Property ImageLocation As String
        Get
            Return _path
        End Get
        Set(value As String)
            _path = If(value, "")
            LoadFromPath(_path)
        End Set
    End Property

    Private Sub LoadFromPath(path As String)
        If String.IsNullOrEmpty(path) Then
            Me.Image = Nothing
            Return
        End If

        Try
            If Not IO.File.Exists(path) Then
                Me.Image = Nothing
                Return
            End If

            Using fs As New IO.FileStream(path, IO.FileMode.Open, IO.FileAccess.Read)
                Using tmp As System.Drawing.Image = System.Drawing.Image.FromStream(fs)
                    Me.Image = New Bitmap(tmp)
                End Using
            End Using
        Catch
            Me.Image = Nothing
        End Try
    End Sub

    Protected Overrides Sub OnPaint(pe As PaintEventArgs)
        Dim g = pe.Graphics

        Using bg As New SolidBrush(BackColor)
            g.FillRectangle(bg, ClientRectangle)
        End Using

        If Image Is Nothing Then Return

        g.InterpolationMode = InterpolationMode.HighQualityBicubic
        g.PixelOffsetMode = PixelOffsetMode.HighQuality

        Dim imgW As Single = Image.Width
        Dim imgH As Single = Image.Height
        Dim boxW As Single = ClientSize.Width
        Dim boxH As Single = ClientSize.Height

        Dim scale As Single = Math.Max(boxW / imgW, boxH / imgH)
        Dim drawW As Single = imgW * scale
        Dim drawH As Single = imgH * scale
        Dim drawX As Single = (boxW - drawW) / 2
        Dim drawY As Single = (boxH - drawH) / 2

        g.SetClip(ClientRectangle)
        g.DrawImage(Image, drawX, drawY, drawW, drawH)
    End Sub

End Class


Public Class RoundedPanel
    Inherits Panel

    Private _cornerRadius As Integer = 16
    Private _borderColor As Color = Color.FromArgb(220, 224, 232)
    Private _borderThickness As Integer = 1


    <DefaultValue(16)>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(1)>
    Public Property BorderThickness As Integer
        Get
            Return _borderThickness
        End Get
        Set(value As Integer)
            _borderThickness = value
            Invalidate()
        End Set
    End Property


    Public Sub New()
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.UserPaint, True)
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim r As Integer = Math.Min(_cornerRadius, Math.Min(Width, Height) \ 2)
        Dim rect As New Rectangle(0, 0, Width - 1, Height - 1)

        Using path As GraphicsPath = MakePath(rect, r)
            Using brush As New SolidBrush(BackColor)
                g.FillPath(brush, path)
            End Using

            If _borderThickness > 0 Then
                Using pen As New Pen(_borderColor, _borderThickness)
                    pen.Alignment = PenAlignment.Inset
                    g.DrawPath(pen, path)
                End Using
            End If
        End Using
    End Sub


    Friend Shared Function MakePath(rect As Rectangle, radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()

        If radius <= 0 Then
            path.AddRectangle(rect)
            Return path
        End If

        Dim d As Integer = radius * 2
        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()

        Return path
    End Function

End Class


Public Class RoundedButton
    Inherits Button

    Private _cornerRadius As Integer = 14
    Private _borderColor As Color = Color.Transparent
    Private _borderThickness As Integer = 0
    Private _iconGlyph As String = ""
    Private _iconFont As Font = New Font("Segoe MDL2 Assets", 14.0F)
    Private _iconSpacing As Integer = 12
    Private _iconColor As Color = Color.Empty
    Private _trailingGlyph As String = ""
    Private _trailingGlyphColor As Color = Color.Empty
    Private _trailingGlyphFont As Font = Nothing
    Private _iconPadding As Integer = 32
    Private _trailingPadding As Integer = 32
    Private _edgeAlignContent As Boolean = False


    <DefaultValue(14)>
    Public Property CornerRadius As Integer
        Get
            Return _cornerRadius
        End Get
        Set(value As Integer)
            _cornerRadius = value
            Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(0)>
    Public Property BorderThickness As Integer
        Get
            Return _borderThickness
        End Get
        Set(value As Integer)
            _borderThickness = value
            Invalidate()
        End Set
    End Property

    <DefaultValue("")>
    Public Property IconGlyph As String
        Get
            Return _iconGlyph
        End Get
        Set(value As String)
            _iconGlyph = value
            Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property IconFont As Font
        Get
            Return _iconFont
        End Get
        Set(value As Font)
            _iconFont = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(12)>
    Public Property IconSpacing As Integer
        Get
            Return _iconSpacing
        End Get
        Set(value As Integer)
            _iconSpacing = value
            Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property IconColor As Color
        Get
            Return _iconColor
        End Get
        Set(value As Color)
            _iconColor = value
            Invalidate()
        End Set
    End Property

    <DefaultValue("")>
    Public Property TrailingGlyph As String
        Get
            Return _trailingGlyph
        End Get
        Set(value As String)
            _trailingGlyph = value
            Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property TrailingGlyphColor As Color
        Get
            Return _trailingGlyphColor
        End Get
        Set(value As Color)
            _trailingGlyphColor = value
            Invalidate()
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public Property TrailingGlyphFont As Font
        Get
            Return _trailingGlyphFont
        End Get
        Set(value As Font)
            _trailingGlyphFont = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(32)>
    Public Property IconPadding As Integer
        Get
            Return _iconPadding
        End Get
        Set(value As Integer)
            _iconPadding = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(32)>
    Public Property TrailingPadding As Integer
        Get
            Return _trailingPadding
        End Get
        Set(value As Integer)
            _trailingPadding = value
            Invalidate()
        End Set
    End Property

    <DefaultValue(False)>
    Public Property EdgeAlignContent As Boolean
        Get
            Return _edgeAlignContent
        End Get
        Set(value As Boolean)
            _edgeAlignContent = value
            Invalidate()
        End Set
    End Property


    Public Sub New()
        FlatStyle = FlatStyle.Flat
        FlatAppearance.BorderSize = 0
        DoubleBuffered = True
        SetStyle(ControlStyles.AllPaintingInWmPaint Or
                 ControlStyles.OptimizedDoubleBuffer Or
                 ControlStyles.ResizeRedraw Or
                 ControlStyles.UserPaint, True)
    End Sub


    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit

        Dim r As Integer = Math.Min(_cornerRadius, Math.Min(Width, Height) \ 2)
        Dim rect As New Rectangle(0, 0, Width - 1, Height - 1)

        Using path As GraphicsPath = RoundedPanel.MakePath(rect, r)
            Using brush As New SolidBrush(BackColor)
                g.FillPath(brush, path)
            End Using

            If _borderThickness > 0 Then
                Using pen As New Pen(_borderColor, _borderThickness)
                    pen.Alignment = PenAlignment.Inset
                    g.DrawPath(pen, path)
                End Using
            End If
        End Using

        Dim iconColor As Color = If(_iconColor.IsEmpty, ForeColor, _iconColor)
        Dim trailingColor As Color = If(_trailingGlyphColor.IsEmpty, iconColor, _trailingGlyphColor)
        Dim trailingFont As Font = If(_trailingGlyphFont, _iconFont)

        Dim cy As Single = Height / 2
        Dim textSize As SizeF = g.MeasureString(Text, Font)

        If _edgeAlignContent Then

            If _iconGlyph <> "" Then
                Dim iconSize As SizeF = g.MeasureString(_iconGlyph, _iconFont)
                Using b As New SolidBrush(iconColor)
                    g.DrawString(_iconGlyph, _iconFont, b,
                                 _iconPadding, cy - iconSize.Height / 2)
                End Using
            End If

            If _trailingGlyph <> "" Then
                Dim tSize As SizeF = g.MeasureString(_trailingGlyph, trailingFont)
                Using b As New SolidBrush(trailingColor)
                    g.DrawString(_trailingGlyph, trailingFont, b,
                                 Width - _trailingPadding - tSize.Width,
                                 cy - tSize.Height / 2)
                End Using
            End If

            Using textBrush As New SolidBrush(ForeColor)
                g.DrawString(Text, Font, textBrush,
                             (Width - textSize.Width) / 2,
                             cy - textSize.Height / 2)
            End Using

        Else

            Dim iconSize As SizeF = SizeF.Empty
            If _iconGlyph <> "" Then
                iconSize = g.MeasureString(_iconGlyph, _iconFont)
            End If

            Dim totalWidth As Single = textSize.Width
            If _iconGlyph <> "" Then
                totalWidth += iconSize.Width + _iconSpacing
            End If

            Dim startX As Single = (Width - totalWidth) / 2

            Using textBrush As New SolidBrush(ForeColor)
                If _iconGlyph <> "" Then
                    Using iconBrush As New SolidBrush(iconColor)
                        g.DrawString(_iconGlyph, _iconFont, iconBrush,
                                     startX, cy - iconSize.Height / 2)
                    End Using
                    Dim textX As Single = startX + iconSize.Width + _iconSpacing
                    g.DrawString(Text, Font, textBrush,
                                 textX, cy - textSize.Height / 2)
                Else
                    g.DrawString(Text, Font, textBrush,
                                 (Width - textSize.Width) / 2,
                                 cy - textSize.Height / 2)
                End If
            End Using

        End If
    End Sub

End Class
