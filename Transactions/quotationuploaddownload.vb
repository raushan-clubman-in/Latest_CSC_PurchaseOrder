Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class quotationuploaddownload
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & ggusername & ";pwd=" & ggpassword & ";Initial Catalog= " & gDatabase & ";"
    Dim strPhotoFilePath_auth1, strPhotoFilePath_auth2 As String
    Friend WithEvents dtp_Indentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMD_BROWSE As System.Windows.Forms.Button
    Friend WithEvents txt_IndentNo As System.Windows.Forms.TextBox
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROMSTORECODE As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromStorename As System.Windows.Forms.TextBox
    Friend WithEvents txt_storecode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents lbl_Grndate As System.Windows.Forms.Label
    Friend WithEvents lbl_Grnno As System.Windows.Forms.Label
    Friend WithEvents txt_storeDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_fromStorecodeHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents grp_Grngroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents spssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents chk_excel As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_dwnld As System.Windows.Forms.Button
    Friend WithEvents cmd_upld As System.Windows.Forms.Button
    Friend WithEvents cmd_indentnoHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents TXT_DOCNO As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP_QTODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_qutnohelp As System.Windows.Forms.Button
    Friend WithEvents TXT_QUOTNO As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Billterms As System.Windows.Forms.Label
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents dtp_docdate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quotationuploaddownload))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_FROMSTORECODE = New System.Windows.Forms.TextBox()
        Me.txt_FromStorename = New System.Windows.Forms.TextBox()
        Me.txt_storecode = New System.Windows.Forms.TextBox()
        Me.lbl_Suppliercode = New System.Windows.Forms.Label()
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.lbl_Grndate = New System.Windows.Forms.Label()
        Me.lbl_Grnno = New System.Windows.Forms.Label()
        Me.txt_storeDesc = New System.Windows.Forms.TextBox()
        Me.cmd_fromStorecodeHelp = New System.Windows.Forms.Button()
        Me.cmd_storecode = New System.Windows.Forms.Button()
        Me.grp_Grngroup1 = New System.Windows.Forms.GroupBox()
        Me.dtp_Indentdate = New System.Windows.Forms.DateTimePicker()
        Me.txt_IndentNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_QTODATE = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_qutnohelp = New System.Windows.Forms.Button()
        Me.TXT_QUOTNO = New System.Windows.Forms.TextBox()
        Me.lbl_Billterms = New System.Windows.Forms.Label()
        Me.TXT_DOCNO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtp_docdate = New System.Windows.Forms.DateTimePicker()
        Me.cmd_indentnoHelp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.spssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.frmbut = New System.Windows.Forms.GroupBox()
        Me.CMD_BROWSE = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.cmd_auth = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.cmd_Print = New System.Windows.Forms.Button()
        Me.cmd_Exit = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_dwnld = New System.Windows.Forms.Button()
        Me.cmd_upld = New System.Windows.Forms.Button()
        Me.chk_excel = New System.Windows.Forms.CheckBox()
        Me.grp_Grngroup1.SuspendLayout()
        CType(Me.spssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbut.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 21)
        Me.Label1.TabIndex = 487
        Me.Label1.Text = "ISSUE STORE"
        Me.Label1.Visible = False
        '
        'TXT_FROMSTORECODE
        '
        Me.TXT_FROMSTORECODE.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROMSTORECODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROMSTORECODE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROMSTORECODE.Location = New System.Drawing.Point(192, 197)
        Me.TXT_FROMSTORECODE.MaxLength = 50
        Me.TXT_FROMSTORECODE.Name = "TXT_FROMSTORECODE"
        Me.TXT_FROMSTORECODE.ReadOnly = True
        Me.TXT_FROMSTORECODE.Size = New System.Drawing.Size(77, 28)
        Me.TXT_FROMSTORECODE.TabIndex = 477
        Me.TXT_FROMSTORECODE.Visible = False
        '
        'txt_FromStorename
        '
        Me.txt_FromStorename.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromStorename.Enabled = False
        Me.txt_FromStorename.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromStorename.Location = New System.Drawing.Point(312, 197)
        Me.txt_FromStorename.MaxLength = 50
        Me.txt_FromStorename.Name = "txt_FromStorename"
        Me.txt_FromStorename.ReadOnly = True
        Me.txt_FromStorename.Size = New System.Drawing.Size(333, 28)
        Me.txt_FromStorename.TabIndex = 485
        Me.txt_FromStorename.Visible = False
        '
        'txt_storecode
        '
        Me.txt_storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_storecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_storecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storecode.Location = New System.Drawing.Point(194, 146)
        Me.txt_storecode.MaxLength = 50
        Me.txt_storecode.Name = "txt_storecode"
        Me.txt_storecode.ReadOnly = True
        Me.txt_storecode.Size = New System.Drawing.Size(76, 28)
        Me.txt_storecode.TabIndex = 476
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(42, 104)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(109, 21)
        Me.lbl_Suppliercode.TabIndex = 483
        Me.lbl_Suppliercode.Text = "INDENT NO"
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(259, 9)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(453, 27)
        Me.lbl_Heading.TabIndex = 479
        Me.lbl_Heading.Text = "QUOTATION UPLOAD AND DOWNLOAD"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Grndate
        '
        Me.lbl_Grndate.AutoSize = True
        Me.lbl_Grndate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grndate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grndate.Location = New System.Drawing.Point(543, 104)
        Me.lbl_Grndate.Name = "lbl_Grndate"
        Me.lbl_Grndate.Size = New System.Drawing.Size(130, 21)
        Me.lbl_Grndate.TabIndex = 482
        Me.lbl_Grndate.Text = "INDENT DATE"
        '
        'lbl_Grnno
        '
        Me.lbl_Grnno.AutoSize = True
        Me.lbl_Grnno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grnno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grnno.Location = New System.Drawing.Point(16, 149)
        Me.lbl_Grnno.Name = "lbl_Grnno"
        Me.lbl_Grnno.Size = New System.Drawing.Size(134, 21)
        Me.lbl_Grnno.TabIndex = 481
        Me.lbl_Grnno.Text = "DEPARTMENT"
        '
        'txt_storeDesc
        '
        Me.txt_storeDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_storeDesc.Enabled = False
        Me.txt_storeDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storeDesc.Location = New System.Drawing.Point(312, 146)
        Me.txt_storeDesc.MaxLength = 50
        Me.txt_storeDesc.Name = "txt_storeDesc"
        Me.txt_storeDesc.ReadOnly = True
        Me.txt_storeDesc.Size = New System.Drawing.Size(333, 28)
        Me.txt_storeDesc.TabIndex = 478
        '
        'cmd_fromStorecodeHelp
        '
        Me.cmd_fromStorecodeHelp.Enabled = False
        Me.cmd_fromStorecodeHelp.Image = CType(resources.GetObject("cmd_fromStorecodeHelp.Image"), System.Drawing.Image)
        Me.cmd_fromStorecodeHelp.Location = New System.Drawing.Point(274, 139)
        Me.cmd_fromStorecodeHelp.Name = "cmd_fromStorecodeHelp"
        Me.cmd_fromStorecodeHelp.Size = New System.Drawing.Size(38, 38)
        Me.cmd_fromStorecodeHelp.TabIndex = 486
        Me.cmd_fromStorecodeHelp.Visible = False
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Enabled = False
        Me.cmd_storecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(274, 197)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(38, 38)
        Me.cmd_storecode.TabIndex = 484
        Me.cmd_storecode.Visible = False
        '
        'grp_Grngroup1
        '
        Me.grp_Grngroup1.BackColor = System.Drawing.Color.Transparent
        Me.grp_Grngroup1.Controls.Add(Me.dtp_Indentdate)
        Me.grp_Grngroup1.Controls.Add(Me.txt_IndentNo)
        Me.grp_Grngroup1.Controls.Add(Me.Label4)
        Me.grp_Grngroup1.Controls.Add(Me.DTP_QTODATE)
        Me.grp_Grngroup1.Controls.Add(Me.Label1)
        Me.grp_Grngroup1.Controls.Add(Me.txt_FromStorename)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Suppliercode)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Grndate)
        Me.grp_Grngroup1.Controls.Add(Me.TXT_FROMSTORECODE)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_qutnohelp)
        Me.grp_Grngroup1.Controls.Add(Me.TXT_QUOTNO)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Billterms)
        Me.grp_Grngroup1.Controls.Add(Me.TXT_DOCNO)
        Me.grp_Grngroup1.Controls.Add(Me.Label12)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_fromStorecodeHelp)
        Me.grp_Grngroup1.Controls.Add(Me.Label13)
        Me.grp_Grngroup1.Controls.Add(Me.dtp_docdate)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_indentnoHelp)
        Me.grp_Grngroup1.Controls.Add(Me.txt_storecode)
        Me.grp_Grngroup1.Controls.Add(Me.Label3)
        Me.grp_Grngroup1.Controls.Add(Me.Label16)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Grnno)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_storecode)
        Me.grp_Grngroup1.Controls.Add(Me.txt_storeDesc)
        Me.grp_Grngroup1.Location = New System.Drawing.Point(12, 152)
        Me.grp_Grngroup1.Name = "grp_Grngroup1"
        Me.grp_Grngroup1.Size = New System.Drawing.Size(923, 242)
        Me.grp_Grngroup1.TabIndex = 480
        Me.grp_Grngroup1.TabStop = False
        '
        'dtp_Indentdate
        '
        Me.dtp_Indentdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Indentdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Indentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Indentdate.Enabled = False
        Me.dtp_Indentdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Indentdate.Location = New System.Drawing.Point(692, 102)
        Me.dtp_Indentdate.Name = "dtp_Indentdate"
        Me.dtp_Indentdate.Size = New System.Drawing.Size(166, 28)
        Me.dtp_Indentdate.TabIndex = 528
        '
        'txt_IndentNo
        '
        Me.txt_IndentNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_IndentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IndentNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IndentNo.Location = New System.Drawing.Point(195, 99)
        Me.txt_IndentNo.MaxLength = 50
        Me.txt_IndentNo.Name = "txt_IndentNo"
        Me.txt_IndentNo.ReadOnly = True
        Me.txt_IndentNo.Size = New System.Drawing.Size(205, 28)
        Me.txt_IndentNo.TabIndex = 527
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(562, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 526
        Me.Label4.Text = "QUO. DATE"
        '
        'DTP_QTODATE
        '
        Me.DTP_QTODATE.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_QTODATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTP_QTODATE.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DTP_QTODATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_QTODATE.Enabled = False
        Me.DTP_QTODATE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_QTODATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_QTODATE.Location = New System.Drawing.Point(692, 15)
        Me.DTP_QTODATE.Name = "DTP_QTODATE"
        Me.DTP_QTODATE.Size = New System.Drawing.Size(164, 28)
        Me.DTP_QTODATE.TabIndex = 525
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(17, 415)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1046, 457)
        Me.GroupBox1.TabIndex = 529
        Me.GroupBox1.TabStop = False
        '
        'cmd_qutnohelp
        '
        Me.cmd_qutnohelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_qutnohelp.Image = CType(resources.GetObject("cmd_qutnohelp.Image"), System.Drawing.Image)
        Me.cmd_qutnohelp.Location = New System.Drawing.Point(411, 9)
        Me.cmd_qutnohelp.Name = "cmd_qutnohelp"
        Me.cmd_qutnohelp.Size = New System.Drawing.Size(39, 38)
        Me.cmd_qutnohelp.TabIndex = 524
        '
        'TXT_QUOTNO
        '
        Me.TXT_QUOTNO.BackColor = System.Drawing.Color.Wheat
        Me.TXT_QUOTNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_QUOTNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QUOTNO.Location = New System.Drawing.Point(195, 13)
        Me.TXT_QUOTNO.MaxLength = 50
        Me.TXT_QUOTNO.Name = "TXT_QUOTNO"
        Me.TXT_QUOTNO.Size = New System.Drawing.Size(205, 28)
        Me.TXT_QUOTNO.TabIndex = 523
        '
        'lbl_Billterms
        '
        Me.lbl_Billterms.AutoSize = True
        Me.lbl_Billterms.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Billterms.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Billterms.Location = New System.Drawing.Point(2, 16)
        Me.lbl_Billterms.Name = "lbl_Billterms"
        Me.lbl_Billterms.Size = New System.Drawing.Size(148, 21)
        Me.lbl_Billterms.TabIndex = 522
        Me.lbl_Billterms.Text = "QUOTATION NO"
        '
        'TXT_DOCNO
        '
        Me.TXT_DOCNO.BackColor = System.Drawing.Color.Wheat
        Me.TXT_DOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DOCNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DOCNO.Location = New System.Drawing.Point(194, 58)
        Me.TXT_DOCNO.MaxLength = 50
        Me.TXT_DOCNO.Name = "TXT_DOCNO"
        Me.TXT_DOCNO.ReadOnly = True
        Me.TXT_DOCNO.Size = New System.Drawing.Size(204, 28)
        Me.TXT_DOCNO.TabIndex = 506
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(67, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 21)
        Me.Label12.TabIndex = 508
        Me.Label12.Text = "DOC NO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(564, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 21)
        Me.Label13.TabIndex = 507
        Me.Label13.Text = "DOC. DATE"
        '
        'dtp_docdate
        '
        Me.dtp_docdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_docdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_docdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_docdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_docdate.Enabled = False
        Me.dtp_docdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_docdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_docdate.Location = New System.Drawing.Point(692, 57)
        Me.dtp_docdate.Name = "dtp_docdate"
        Me.dtp_docdate.Size = New System.Drawing.Size(166, 28)
        Me.dtp_docdate.TabIndex = 505
        '
        'cmd_indentnoHelp
        '
        Me.cmd_indentnoHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_indentnoHelp.Image = CType(resources.GetObject("cmd_indentnoHelp.Image"), System.Drawing.Image)
        Me.cmd_indentnoHelp.Location = New System.Drawing.Point(405, 95)
        Me.cmd_indentnoHelp.Name = "cmd_indentnoHelp"
        Me.cmd_indentnoHelp.Size = New System.Drawing.Size(38, 38)
        Me.cmd_indentnoHelp.TabIndex = 504
        Me.cmd_indentnoHelp.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(312, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 35)
        Me.Label3.TabIndex = 474
        Me.Label3.Text = "F4"
        Me.Label3.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(451, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 35)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "F4"
        Me.Label16.Visible = False
        '
        'spssgrid
        '
        Me.spssgrid.DataSource = Nothing
        Me.spssgrid.Location = New System.Drawing.Point(23, 423)
        Me.spssgrid.Name = "spssgrid"
        Me.spssgrid.OcxState = CType(resources.GetObject("spssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spssgrid.Size = New System.Drawing.Size(1023, 435)
        Me.spssgrid.TabIndex = 527
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CMD_BROWSE)
        Me.frmbut.Controls.Add(Me.cmd_export)
        Me.frmbut.Controls.Add(Me.cmd_auth)
        Me.frmbut.Controls.Add(Me.cmd_View)
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Controls.Add(Me.cmd_Exit)
        Me.frmbut.Controls.Add(Me.cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_dwnld)
        Me.frmbut.Controls.Add(Me.cmd_upld)
        Me.frmbut.Location = New System.Drawing.Point(1069, 158)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(227, 700)
        Me.frmbut.TabIndex = 528
        Me.frmbut.TabStop = False
        '
        'CMD_BROWSE
        '
        Me.CMD_BROWSE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_BROWSE.Location = New System.Drawing.Point(11, 602)
        Me.CMD_BROWSE.Name = "CMD_BROWSE"
        Me.CMD_BROWSE.Size = New System.Drawing.Size(207, 76)
        Me.CMD_BROWSE.TabIndex = 509
        Me.CMD_BROWSE.Text = "Browse"
        Me.CMD_BROWSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_BROWSE.UseVisualStyleBackColor = True
        Me.CMD_BROWSE.Visible = False
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Image = Global.SmartCard.My.Resources.Resources.excel
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(5, 419)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(214, 82)
        Me.cmd_export.TabIndex = 508
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'cmd_auth
        '
        Me.cmd_auth.BackColor = System.Drawing.Color.Transparent
        Me.cmd_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_auth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_auth.ForeColor = System.Drawing.Color.Black
        Me.cmd_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_auth.Location = New System.Drawing.Point(6, 510)
        Me.cmd_auth.Name = "cmd_auth"
        Me.cmd_auth.Size = New System.Drawing.Size(215, 82)
        Me.cmd_auth.TabIndex = 507
        Me.cmd_auth.Text = "Authorize"
        Me.cmd_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_auth.UseVisualStyleBackColor = False
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.cmd_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.Black
        Me.cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.Location = New System.Drawing.Point(6, 237)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(215, 82)
        Me.cmd_View.TabIndex = 506
        Me.cmd_View.Text = " View[F9]"
        Me.cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_View.UseVisualStyleBackColor = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Print.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.cmd_Print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.cmd_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Print.Location = New System.Drawing.Point(6, 327)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(215, 82)
        Me.cmd_Print.TabIndex = 384
        Me.cmd_Print.Text = "Print[F10]"
        Me.cmd_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Print.UseVisualStyleBackColor = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Exit.Location = New System.Drawing.Point(6, 599)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(215, 82)
        Me.cmd_Exit.TabIndex = 382
        Me.cmd_Exit.Text = "Exit[F11]"
        Me.cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Exit.UseVisualStyleBackColor = False
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(6, 19)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(215, 82)
        Me.cmd_Clear.TabIndex = 378
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_dwnld
        '
        Me.Cmd_dwnld.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_dwnld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_dwnld.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_dwnld.ForeColor = System.Drawing.Color.Black
        Me.Cmd_dwnld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_dwnld.Location = New System.Drawing.Point(5, 164)
        Me.Cmd_dwnld.Name = "Cmd_dwnld"
        Me.Cmd_dwnld.Size = New System.Drawing.Size(214, 82)
        Me.Cmd_dwnld.TabIndex = 380
        Me.Cmd_dwnld.Text = "DOWNLOAD[F8]"
        Me.Cmd_dwnld.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_dwnld.UseVisualStyleBackColor = False
        Me.Cmd_dwnld.Visible = False
        '
        'cmd_upld
        '
        Me.cmd_upld.BackColor = System.Drawing.Color.Transparent
        Me.cmd_upld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_upld.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_upld.ForeColor = System.Drawing.Color.Black
        Me.cmd_upld.Image = Global.SmartCard.My.Resources.Resources.save
        Me.cmd_upld.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_upld.Location = New System.Drawing.Point(6, 113)
        Me.cmd_upld.Name = "cmd_upld"
        Me.cmd_upld.Size = New System.Drawing.Size(215, 81)
        Me.cmd_upld.TabIndex = 379
        Me.cmd_upld.Text = "UPLOAD [F7]"
        Me.cmd_upld.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_upld.UseVisualStyleBackColor = False
        '
        'chk_excel
        '
        Me.chk_excel.BackColor = System.Drawing.Color.Transparent
        Me.chk_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_excel.Location = New System.Drawing.Point(1084, 845)
        Me.chk_excel.Name = "chk_excel"
        Me.chk_excel.Size = New System.Drawing.Size(115, 35)
        Me.chk_excel.TabIndex = 464
        Me.chk_excel.Text = "EXCEL"
        Me.chk_excel.UseVisualStyleBackColor = False
        Me.chk_excel.Visible = False
        '
        'quotationuploaddownload
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.Bisque
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources.Chs_Background_form_new
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1307, 917)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.spssgrid)
        Me.Controls.Add(Me.chk_excel)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.grp_Grngroup1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "quotationuploaddownload"
        Me.Text = "quotationuploaddownload"
        Me.grp_Grngroup1.ResumeLayout(False)
        Me.grp_Grngroup1.PerformLayout()
        CType(Me.spssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbut.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub cmd_qutnohelp_Click(sender As Object, e As EventArgs) Handles cmd_qutnohelp.Click
        Try
            gSQLString = "SELECT DISTINCT quotNo,indentno,indentdate,docdetails,docdate FROM po_quationinvitation WHERE "
            M_WhereCondition = " ISNULL(VOID,'')<>'Y' "
            Dim vform As New ListOperattion1
            vform.Field = "QUOTNO,INDENTNO,INDENTDATE,DOCDETAILS,DOCDATE"
            vform.vFormatstring = "   QUOTNO |    INDENTNO                  |     INDENTDATE  |  DOCDETAILS | DOCDATE                                                         "
            vform.vCaption = "QUOTATION NO HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_QUOTNO.Text = Trim(vform.keyfield & "")
                ' spssgrid.ClearRange(1, 1, -1, -1, True)
                spssgrid.ClearRange(1, 1, -1, -1, True)
                Call TXT_QUOTNO_Validated(TXT_QUOTNO, e)
                'dtp_Indentdate.Focus()
                ' cmd_Add.Text = "Update [F7]"
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_QUOTNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_QUOTNO.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(TXT_QUOTNO.Text) = "" Then
                    Call cmd_qutnohelp_Click(cmd_qutnohelp, e)
                Else
                    TXT_QUOTNO_Validated(TXT_QUOTNO, e)
                    spssgrid.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grnno Key Press " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_QUOTNO_Validated(sender As Object, e As EventArgs) Handles TXT_QUOTNO.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks, SSQL, SSQL1 As String
        Dim vTypeseqno, Clsquantity, vGroupseqno, Totqty, TOTAMT As Double

        If Trim(TXT_QUOTNO.Text) <> "" Then
            Dim VSTRDOCNO As String
            Try
                sqlstring = "SELECT ISNULL(INDENTNO,'') AS INDENTNO,ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(QUOdate,'') AS  QUOdate,ISNULL(invitedby,'') AS invitedby,ISNULL(invitdate,'') AS invitdate,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM po_quationinvitation AS H WHERE quotNo='" & Trim(TXT_QUOTNO.Text) & "'"

                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    'Cmd_Add.Text = "Update[F7]"
                    'Me.TXT_DOCNO.ReadOnly = True
                    VSTRDOCNO = Trim(TXT_DOCNO.Text)
                    txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTNO") & "")
                    TXT_DOCNO.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    DTP_QTODATE.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("QUOdate")), "dd-MM-yyyy")
                    dtp_Indentdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    dtp_docdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_storecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    txt_storeDesc.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    remarks = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))


                    sqlstring = " SELECT ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
                    sqlstring = sqlstring & "ISNULL(SELECTSUPPLIER,'') AS SELECTSUPPLIER ,isnull(approved,'') as approved FROM po_quationinvitation"
                    sqlstring = sqlstring & " WHERE QUOTNO =  '" & Trim(TXT_QUOTNO.Text) & "' AND INDENTNO='" & Trim(txt_IndentNo.Text) & "' and isnull(selectsupplier,'')='Y'"
                    gconnection.getDataSet(sqlstring, "supplier")
                    Dim selct As String
                    Dim k As Integer
                    If gdataset.Tables("supplier").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("supplier").Rows.Count
                            spssgrid.SetText(1, i, Trim(gdataset.Tables("supplier").Rows(k).Item("SUPPLIERCODE")))
                            ' STRITEMCODE = Trim(gdataset.Tables("supplier").Rows(j).Item("ITEMCODE"))
                            spssgrid.SetText(2, i, Trim(gdataset.Tables("supplier").Rows(k).Item("SUPPLIERNAME")))
                            spssgrid.Col = 4
                            spssgrid.Row = i
                            selct = ""
                            selct = Trim(gdataset.Tables("supplier").Rows(k).Item("approved"))
                            If selct = "Y" Then
                                spssgrid.SetText(4, i, "YES")
                            ElseIf selct = "N" Then
                                spssgrid.SetText(4, i, "NO")
                            End If
                            spssgrid.Col = 3
                            spssgrid.Row = i
                            sqlstring = "SELECT quotation as memimage FROM po_quationinvitation WHERE quotno='" & Trim(TXT_QUOTNO.Text) & "' and suppliercode='" & Trim(gdataset.Tables("supplier").Rows(k).Item("SUPPLIERCODE")) & "'" '  and type0='chld' "
                            LoadFoto_chld(sqlstring, i)
                            k = k + 1

                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.cmd_upld.Enabled = False
                            Me.Cmd_dwnld.Enabled = False
                        End If
                    End If
                    ' TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                    spssgrid.SetActiveCell(1, 1)
                    TXT_QUOTNO.ReadOnly = True
                    txt_IndentNo.ReadOnly = True
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub


    Private Sub quotationuploaddownload_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                '  txt_Docno.Text = ""
                'txt_Docno.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_dwnld_Click(Cmd_dwnld, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call cmd_upld_Click(cmd_upld, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 And cmd_View.Enabled = True Then
                Call cmd_View_Click(cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F10 And cmd_Print.Enabled = True Then
                Call cmd_Print_Click(cmd_Print, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                'If grp_Stockissue.Top = 176 Then
                '    grp_Stockissue.Top = 1000
                '    Cmd_View.Focus()
                '    Exit Sub
                'Else
                Call cmd_Exit_Click(cmd_Exit, e)
                ' Exit Sub
            End If
            'If e.Alt = True And e.KeyCode = Keys.R Then
            '    Me.txt_Remarks.Focus()
            '    Exit Sub
            If e.Alt = True And e.KeyCode = Keys.A Then
                '  Me.txt_Totalamount.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.S Then
                Me.spssgrid.Focus()
                Me.spssgrid.SetActiveCell(1, 1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub quotationuploaddownload_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        'spssgrid.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width * 17.67) / 100, (Screen.PrimaryScreen.WorkingArea.Height * 36.19) / 100)
        Resize_Form()
        GroupBox1.Controls.Add(spssgrid)
        spssgrid.Location = New Point(5, 13)
        TXT_QUOTNO.Select()
        gPrint = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.cmd_upld.Enabled = False
                Me.Cmd_dwnld.Enabled = False
            End If
        End If
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'Quotation Verification%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        ' Me.Cmd_Add.Enabled = False
        'Me.Cmd_Freeze.Enabled = False
        Me.cmd_View.Enabled = False
        Me.cmd_Print.Enabled = False
        Me.cmd_export.Enabled = False
        Me.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    'Me.Cmd_Add.Enabled = True
                    'Me.Cmd_Freeze.Enabled = True
                    Me.cmd_View.Enabled = True
                    Me.cmd_auth.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.cmd_Print.Enabled = True
                    Exit Sub
                End If

                If Right(x) = "D" Then
                    'Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                    'Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.cmd_auth.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmd_Print.Enabled = True
                End If
            Next
        End If


    End Sub
    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Try
            Call clearform(Me)
            '  Call FillStore() '''-->Fill Store Desc
            'Call FillMainstore() '''-->Fill Main Store
            Me.dtp_docdate.Value = Format(Now, "dd/MM/yyyy")
            Me.dtp_Indentdate.Value = Format(Now, "dd/MM/yyyy")
            Me.DTP_QTODATE.Value = Format(Now, "dd/MM/yyyy")
            '   Call FOOTER()
            '   grp_footer.Visible = False
            TXT_DOCNO.Text = ""
            TXT_QUOTNO.Text = ""
            ' Call autogenerate()
            txt_IndentNo.Text = ""
            txt_IndentNo.ReadOnly = False

            '  Me.lbl_Freeze.Text = "Record Void  On "
            TXT_QUOTNO.ReadOnly = False
            '  cmb_approvedby.SelectedIndex = 0
            Dim I As Integer
            For I = 0 To spssgrid.DataRowCnt - 1
                With spssgrid
                    'VFilePath = ""
                    .Row = I + 1
                    .Col = 3
                    .Text = ""
                    .TypePictPicture = Nothing
                    'MessageBox.Show(VFilePath)
                    'VFilePath = AppPath & "\Reports\" & Trim(.Text) & ".JPG"
                    VFilePath = Trim(.Text)
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                End With
            Next

            spssgrid.ClearRange(1, 1, -1, -1, True)



            txt_storecode.Text = ""
            txt_storeDesc.Text = ""


            'grp_Stockissue.Top = 1000
            cmd_upld.Enabled = True

            TXT_DOCNO.Enabled = True
            TXT_DOCNO.ReadOnly = False
            txt_IndentNo.ReadOnly = False

            Me.Cmd_dwnld.Enabled = True
            TXT_FROMSTORECODE.ReadOnly = True
            TXT_FROMSTORECODE.Enabled = True
            'txt_Tostorecode.Enabled = True
            'dtp_Indentdate.Enabled = True

            spssgrid.Focus()
            spssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.cmd_upld.Enabled = False
                    Me.Cmd_dwnld.Enabled = False
                End If
            End If
            Show()
            TXT_QUOTNO.Select()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_upld_Click(sender As Object, e As EventArgs) Handles cmd_upld.Click

        Try
            Dim sqlstring As String
            sqlstring = " SELECT auth_docno FROM PO_HDR WHERE auth_docno='" & TXT_DOCNO.Text & "' AND ISNULL(freeze,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "docVAL")
            If gdataset.Tables("docVAL").Rows.Count > 0 Then
                MessageBox.Show("This document Has Been Processed,You Cannot do any modification")
                Exit Sub
            End If

            Dim i As Integer
            Dim SUPP, INSERT(0) As String
            For i = 1 To spssgrid.DataRowCnt
                With spssgrid
                    .Row = i
                    .Col = 1
                    SUPP = Trim(.Text)
                    sqlstring = " Update po_quationinvitation  set quotation =@memimage Where  suppliercode='" & Trim(.Text) & "' and quotNo='" & TXT_QUOTNO.Text.Replace("'", "") & "'" ' and type0='chld'"
                    .Row = i
                    .Col = 3
                    If (.Text) <> "" Then
                        Call SaveFoto(Trim(.Text), Trim(TXT_QUOTNO.Text.Replace("'", "")), sqlstring)
                    End If
                    .Row = i
                    .Col = 4
                    ' If (.Text) <> "" Then
                    Dim SELET, REMARKS As String
                    If .Text = "YES" Then
                        SELET = "Y"
                    Else
                        SELET = "N"
                    End If
                    .Col = 5
                    If .Text = "" Then
                        REMARKS = ""
                    Else
                        REMARKS = .Text
                    End If
                    sqlstring = " Update po_quationinvitation  set approved ='" & SELET & "',REMARKS='" & REMARKS & "' Where  suppliercode='" & SUPP & "' and quotNo='" & TXT_QUOTNO.Text.Replace("'", "") & "'"
                    ReDim Preserve INSERT(INSERT.Length)
                    INSERT(INSERT.Length - 1) = sqlstring
                    ' cmd_Clear_Click(sender, e)
                    'End If

                End With
            Next
            gconnection.MoreTrans(INSERT)
            'End If

            Me.cmd_Clear_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub
    Public Function SaveFoto(ByVal FilePath As String, ByVal Mcode As String, ByVal Qurstr As String)
        Try
            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            'Dim cmd As New SqlCommand("update membermaster set " & fieldname & _
            '" = @memimage where mcode = '" & Mcode & "' ", cn)
            Dim cmd As New SqlCommand(Qurstr, cn)
            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub LoadFoto_chld(ByVal quystr As String, ByVal row As Integer)
        Try
            Dim cn As New SqlConnection(strcn)
            ' Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                With spssgrid
                    .Col = 3
                    .Row = row
                    spssgrid.TypePictPicture = Image.FromStream(stmMEMimage)
                    vOutfile = Mid("Pho" & (Rnd() * 800000), 1, 8)
                    VFilePath = AppPath & "\Reports\" & vOutfile & ".JPG"
                    If File.Exists(VFilePath) = True Then
                        File.Delete(VFilePath)
                    End If
                    Dim myBitmap As Bitmap = CType(Bitmap.FromStream(stmMEMimage), Bitmap)
                    myBitmap.Save(VFilePath)
                    myBitmap.Dispose()
                    .Col = 3
                    .Row = row
                    .Text = VFilePath
                    '.Col = 10
                    '.Text = vOutfile
                End With
            Else
                'PIC.Image = Nothing
                'Return Nothing
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub spssgrid_ClickEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_ClickEvent) Handles spssgrid.ClickEvent
        Try
            With spssgrid
                If spssgrid.ActiveCol = 3 Then
                    Dim file As New OpenFileDialog
                    file.Filter = " Jpg(*.Jpg) | *.jpg"
                    If Trim(TXT_QUOTNO.Text) <> "" Then
                        If file.ShowDialog = DialogResult.OK Then
                            .Col = 3
                            .Row = .ActiveRow
                            spssgrid.TypePictPicture = New Bitmap(file.FileName)
                            strPhotoFilePath_auth1 = file.FileName
                            .Col = 3
                            .Row = .ActiveRow
                            .Text = file.FileName
                        End If

                    End If
                    'ElseIf ssgrid1.ActiveCol = 1 Then
                    '    Call loadSalutation(I + 1)
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmd_Exit_Click(sender As Object, e As EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub cmd_indentnoHelp_Click(sender As Object, e As EventArgs) Handles cmd_indentnoHelp.Click

    End Sub

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r As New Rpt_Quoinvit
            'sqlstring = "SELECT TOP 100 PERCENT docdetails, docdate, storelocationname, "
            'sqlstring = sqlstring & " opstorelocationname, itemcode,storelocationcode,opstorelocationcode, "
            'sqlstring = sqlstring & " itemname, uom,qty, rate, amount ,clsqty, indentno , indentdate,remarks,UPDFOOTER,UPDSIGN,ADDDATE"
            'sqlstring = sqlstring & " FROM VW_PO_STOCKINDENTAUTH_BILL "
            sqlstring = "SELECT * from  po_quationinvitation "
            sqlstring = sqlstring & " WHERE quotno = '" & Trim(TXT_QUOTNO.Text) & "' and indentno= '" & Trim(txt_IndentNo.Text) & "'"
            sqlstring = sqlstring & " ORDER BY quotno"

            gconnection.getDataSet(sqlstring, "VW_INV_ISSUEBILL")
            If gdataset.Tables("VW_INV_ISSUEBILL").Rows.Count > 0 Then
                If chk_excel.Checked = True Then
                    Dim exp As New exportexcel
                    exp.Show()
                    Call exp.export(sqlstring, "STOCK ISSUE ", "")
                Else
                    rViewer.ssql = sqlstring
                    rViewer.Report = r
                    rViewer.TableName = "VW_INV_ISSUEBILL"
                    Dim textobj1 As TextObject
                    textobj1 = r.ReportDefinition.ReportObjects("Text13")
                    textobj1.Text = MyCompanyName

                    Dim TXTOBJ2 As TextObject
                    TXTOBJ2 = r.ReportDefinition.ReportObjects("Text3")
                    TXTOBJ2.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode

                    Dim txtobj3 As TextObject
                    txtobj3 = r.ReportDefinition.ReportObjects("Text11")
                    ' txtobj3.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                    If gFax = "" Then
                        txtobj3.Text = "Tel:" & GPHONE & " , Email:" & gEmail & "" & ", Web:" & gWebsite
                    Else
                        txtobj3.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & "" & ", Web:" & gWebsite
                    End If
                    Dim txtobj4 As TextObject
                    txtobj4 = r.ReportDefinition.ReportObjects("Text15")
                    '  txtobj4.Text = "GSTIN :" & gServiceTax & " , Tin No.:" & gTinNo
                    If gTinNo = "" Then
                        txtobj4.Text = "GSTIN :" & gServiceTax & " "
                    Else
                        txtobj4.Text = "GSTIN :" & gServiceTax & " , Tin No.:" & gTinNo
                    End If
                    rViewer.Show()
                End If
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_Print_Click(sender As Object, e As EventArgs) Handles cmd_Print.Click
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r As New Rpt_Quoinvit
            'sqlstring = "SELECT TOP 100 PERCENT docdetails, docdate, storelocationname, "
            'sqlstring = sqlstring & " opstorelocationname, itemcode,storelocationcode,opstorelocationcode, "
            'sqlstring = sqlstring & " itemname, uom,qty, rate, amount ,clsqty, indentno , indentdate,remarks,UPDFOOTER,UPDSIGN,ADDDATE"
            'sqlstring = sqlstring & " FROM VW_PO_STOCKINDENTAUTH_BILL "
            sqlstring = "SELECT * from  po_quationinvitation "
            sqlstring = sqlstring & " WHERE quotno = '" & Trim(TXT_QUOTNO.Text) & "' and indentno= '" & Trim(txt_IndentNo.Text) & "'"
            sqlstring = sqlstring & " ORDER BY quotno"

            gconnection.getDataSet(sqlstring, "VW_INV_ISSUEBILL")
            If gdataset.Tables("VW_INV_ISSUEBILL").Rows.Count > 0 Then
                If chk_excel.Checked = True Then
                    Dim exp As New exportexcel
                    exp.Show()
                    Call exp.export(sqlstring, "STOCK ISSUE ", "")
                Else
                    rViewer.ssql = sqlstring
                    rViewer.Report = r
                    rViewer.TableName = "VW_INV_ISSUEBILL"
                    Dim textobj1 As TextObject
                    textobj1 = r.ReportDefinition.ReportObjects("Text13")
                    textobj1.Text = MyCompanyName
                    rViewer.Show()
                End If
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_export_Click(sender As Object, e As EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "vw_po_quationinvitation"
        sqlstring = "select * from vw_po_quationinvitation"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

    Private Sub cmd_auth_Click(sender As Object, e As EventArgs) Handles cmd_auth.Click
        Dim SSQLSTR, SSQLSTR2 As String
        Dim USERT As Integer
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 1
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 2
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 3
        End If
        If USERT = 1 Then
            SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE po_quationinvitation set  ", "quotno", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE po_quationinvitation set  ", "quotno", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE po_quationinvitation set  ", "quotno", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Cmd_dwnld_Click(sender As Object, e As EventArgs) Handles Cmd_dwnld.Click

    End Sub

    Private Sub cmd_storecode_Click(sender As Object, e As EventArgs) Handles cmd_storecode.Click

    End Sub

    Private Sub cmd_fromStorecodeHelp_Click(sender As Object, e As EventArgs) Handles cmd_fromStorecodeHelp.Click

    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 768
        K = 1024
        Me.ResizeRedraw = True
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Width = U
        Me.Height = T


        With Me
            For i_i = 0 To .Controls.Count - 1
                ' MsgBox(Controls(i_i).Name)
                If TypeOf .Controls(i_i) Is Form Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "frmbut" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            ' L = L - 5
                        End If
                    End If

                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is Label Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                End If
            Next i_i
        End With
    End Sub

    Private Sub CMD_BROWSE_Click(sender As Object, e As EventArgs) Handles CMD_BROWSE.Click
        Dim FRM As New ReportDesigner
        If TXT_DOCNO.Text.Length > 0 Then
            tables = " FROM po_quationinvitation WHERE DOCDETAILS ='" & TXT_QUOTNO.Text & "' "
        Else
            tables = "FROM po_quationinvitation"
        End If
        Gheader = "QUOTATION INVITATION DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"DOCDETAILS", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"INDENTNO", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"REMARKS", "5"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"SUPPLIERCODE", "9"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"SUPPLIERNAME", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"SELECTSUPPLIER", "12"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"QUOTATION", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"QUOTNO", "12 "}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"INVITEDBY", "6 "}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"INVITDATE", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"QUODATE", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POTOTAL", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOT_VAT", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOT_TAX", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOT_DISCOUNT", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ADVANCE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"overalldisc", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POTRANSPORT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POCF", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POTRANSPORT", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PODELIVERYAMT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PAYMENTTERMS", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POREMARKS", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DELIVERYTERMS", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ADDRESS", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"CITY", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"STATE", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"MOBILENO", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PINCODE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"EMAIL", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ITEMCODE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ITEMNAME", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QTY", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"RATE", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DISCOUNT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"VATAMT", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"VAT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOTAL", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DISCAMT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"AMOUNT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poed", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pocst", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pomodvat", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poptax", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pooctra", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poinsurance", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"polst", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ''
        'ROW = New String() {"POADVPERC", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TINNO", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PANNO", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"posalet", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"podespmode", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"podocsthrough", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)

        Dim CHK As New DataGridViewCheckBoxColumn()
        'Dim CHK As New VIEWHDR
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)
    End Sub
End Class
