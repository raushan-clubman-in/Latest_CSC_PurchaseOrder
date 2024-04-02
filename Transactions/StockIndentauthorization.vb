Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class StockIndentAUTHORIZATION
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents dtp_Excisepassdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Grndate As System.Windows.Forms.Label
    Friend WithEvents lbl_Grnno As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassno As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Excisepassno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents grp_Grngroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Grn As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdValueby As System.Windows.Forms.Button
    Friend WithEvents OptPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents OptValue As System.Windows.Forms.RadioButton
    Friend WithEvents txtChangeValue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRoundoff As System.Windows.Forms.Button
    Friend WithEvents OptNearest As System.Windows.Forms.RadioButton
    Friend WithEvents OptNone As System.Windows.Forms.RadioButton
    Friend WithEvents grp_StockGrndetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_StockGrndetails As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_StockGrnprint As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnView As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnClear As System.Windows.Forms.Button
    Friend WithEvents grp_Billingdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_Excisedetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Trucknumber As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Stockindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Trucknumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Stockindate As System.Windows.Forms.Label
    Friend WithEvents ssgrid_billdetails As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents txt_storeDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents txt_storecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_IndentNo As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Indentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_indentnoHelp As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_FREEZE As System.Windows.Forms.Button
    Friend WithEvents txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROMSTORECODE As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromStorename As System.Windows.Forms.TextBox
    Friend WithEvents cmd_fromStorecodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CHK_WAR As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_Billterms As System.Windows.Forms.Label
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents chk_excel As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents dtp_completiondate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_approvedby As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(StockIndentAUTHORIZATION))
        Me.dtp_Excisepassdate = New System.Windows.Forms.DateTimePicker
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_Suppliercode = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.chk_excel = New System.Windows.Forms.CheckBox
        Me.cmd_Print = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_FREEZE = New System.Windows.Forms.Button
        Me.cmd_Add = New System.Windows.Forms.Button
        Me.cmd_View = New System.Windows.Forms.Button
        Me.dtp_Indentdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.lbl_Grndate = New System.Windows.Forms.Label
        Me.lbl_Grnno = New System.Windows.Forms.Label
        Me.grp_Grngroup1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.lbl_Excisepassno = New System.Windows.Forms.Label
        Me.lbl_Excisepassdate = New System.Windows.Forms.Label
        Me.txt_Excisepassno = New System.Windows.Forms.TextBox
        Me.lbl_Grn = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdRoundoff = New System.Windows.Forms.Button
        Me.OptNearest = New System.Windows.Forms.RadioButton
        Me.OptNone = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdValueby = New System.Windows.Forms.Button
        Me.OptPercentage = New System.Windows.Forms.RadioButton
        Me.OptValue = New System.Windows.Forms.RadioButton
        Me.txtChangeValue = New System.Windows.Forms.TextBox
        Me.grp_StockGrndetails = New System.Windows.Forms.GroupBox
        Me.lbl_StockGrndetails = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Cmd_StockGrnprint = New System.Windows.Forms.Button
        Me.Cmd_StockGrnView = New System.Windows.Forms.Button
        Me.Cmd_StockGrnexit = New System.Windows.Forms.Button
        Me.Cmd_StockGrnClear = New System.Windows.Forms.Button
        Me.lbl_FromDocno = New System.Windows.Forms.Label
        Me.txt_FromDocno = New System.Windows.Forms.TextBox
        Me.Cmd_FromDocno = New System.Windows.Forms.Button
        Me.txt_ToDocno = New System.Windows.Forms.TextBox
        Me.Cmd_ToDocno = New System.Windows.Forms.Button
        Me.lbl_ToDocno = New System.Windows.Forms.Label
        Me.grp_Billingdetails = New System.Windows.Forms.GroupBox
        Me.ssgrid_billdetails = New AxFPSpreadADO.AxfpSpread
        Me.Label2 = New System.Windows.Forms.Label
        Me.grp_Excisedetails = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Trucknumber = New System.Windows.Forms.TextBox
        Me.dtp_Stockindate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Trucknumber = New System.Windows.Forms.Label
        Me.lbl_Stockindate = New System.Windows.Forms.Label
        Me.txt_IndentNo = New System.Windows.Forms.TextBox
        Me.txt_storeDesc = New System.Windows.Forms.TextBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.cmd_storecode = New System.Windows.Forms.Button
        Me.txt_storecode = New System.Windows.Forms.TextBox
        Me.cmd_indentnoHelp = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.txt_Totalamount = New System.Windows.Forms.TextBox
        Me.TXT_FROMSTORECODE = New System.Windows.Forms.TextBox
        Me.txt_FromStorename = New System.Windows.Forms.TextBox
        Me.cmd_fromStorecodeHelp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_qty = New System.Windows.Forms.TextBox
        Me.grp_footer = New System.Windows.Forms.GroupBox
        Me.Txt_signature = New System.Windows.Forms.TextBox
        Me.Txt_footer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Chk_item = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CHK_WAR = New System.Windows.Forms.CheckBox
        Me.lbl_Billterms = New System.Windows.Forms.Label
        Me.cbo_type = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.dtp_completiondate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmb_approvedby = New System.Windows.Forms.ComboBox
        Me.frmbut.SuspendLayout()
        Me.grp_Grngroup1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_StockGrndetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grp_Billingdetails.SuspendLayout()
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Excisedetails.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_footer.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_Excisepassdate
        '
        Me.dtp_Excisepassdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Excisepassdate.Location = New System.Drawing.Point(240, 128)
        Me.dtp_Excisepassdate.Name = "dtp_Excisepassdate"
        Me.dtp_Excisepassdate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Excisepassdate.TabIndex = 2
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Location = New System.Drawing.Point(104, 16)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(648, 32)
        Me.txt_Remarks.TabIndex = 14
        Me.txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(16, 16)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(78, 18)
        Me.lbl_Remarks.TabIndex = 43
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(160, 120)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(86, 18)
        Me.lbl_Suppliercode.TabIndex = 28
        Me.lbl_Suppliercode.Text = "INDENT NO :"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Button2)
        Me.frmbut.Controls.Add(Me.chk_excel)
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Controls.Add(Me.cmd_Exit)
        Me.frmbut.Controls.Add(Me.cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_FREEZE)
        Me.frmbut.Controls.Add(Me.cmd_Add)
        Me.frmbut.Controls.Add(Me.cmd_View)
        Me.frmbut.Location = New System.Drawing.Point(16, 520)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(944, 56)
        Me.frmbut.TabIndex = 44
        Me.frmbut.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(696, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 466
        Me.Button2.Text = "validations"
        '
        'chk_excel
        '
        Me.chk_excel.BackColor = System.Drawing.Color.Transparent
        Me.chk_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_excel.Location = New System.Drawing.Point(584, 16)
        Me.chk_excel.Name = "chk_excel"
        Me.chk_excel.Size = New System.Drawing.Size(72, 24)
        Me.chk_excel.TabIndex = 464
        Me.chk_excel.Text = "EXCEL"
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.cmd_Print.Location = New System.Drawing.Point(352, 16)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Print.TabIndex = 384
        Me.cmd_Print.Text = "Print[F10]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.cmd_Exit.Location = New System.Drawing.Point(840, 16)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(96, 32)
        Me.cmd_Exit.TabIndex = 382
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.cmd_Clear.Location = New System.Drawing.Point(8, 16)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 378
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_FREEZE
        '
        Me.Cmd_FREEZE.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FREEZE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_FREEZE.ForeColor = System.Drawing.Color.Black
        Me.Cmd_FREEZE.Location = New System.Drawing.Point(240, 16)
        Me.Cmd_FREEZE.Name = "Cmd_FREEZE"
        Me.Cmd_FREEZE.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_FREEZE.TabIndex = 380
        Me.Cmd_FREEZE.Text = "Void[F8]"
        '
        'cmd_Add
        '
        Me.cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.cmd_Add.Location = New System.Drawing.Point(128, 16)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Add.TabIndex = 379
        Me.cmd_Add.Text = "Add [F7]"
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.Black
        Me.cmd_View.Location = New System.Drawing.Point(472, 16)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.cmd_View.TabIndex = 381
        Me.cmd_View.Text = " View[F9]"
        '
        'dtp_Indentdate
        '
        Me.dtp_Indentdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Indentdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Indentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Indentdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Indentdate.Location = New System.Drawing.Point(704, 112)
        Me.dtp_Indentdate.Name = "dtp_Indentdate"
        Me.dtp_Indentdate.Size = New System.Drawing.Size(104, 26)
        Me.dtp_Indentdate.TabIndex = 1
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(304, 24)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(362, 29)
        Me.lbl_Heading.TabIndex = 21
        Me.lbl_Heading.Text = "PO INDENT AUTHORIZATION"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(616, 32)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(312, 25)
        Me.lbl_Freeze.TabIndex = 47
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_Grndate
        '
        Me.lbl_Grndate.AutoSize = True
        Me.lbl_Grndate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grndate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grndate.Location = New System.Drawing.Point(560, 120)
        Me.lbl_Grndate.Name = "lbl_Grndate"
        Me.lbl_Grndate.Size = New System.Drawing.Size(101, 18)
        Me.lbl_Grndate.TabIndex = 25
        Me.lbl_Grndate.Text = "INDENT DATE :"
        '
        'lbl_Grnno
        '
        Me.lbl_Grnno.AutoSize = True
        Me.lbl_Grnno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grnno.Location = New System.Drawing.Point(144, 152)
        Me.lbl_Grnno.Name = "lbl_Grnno"
        Me.lbl_Grnno.Size = New System.Drawing.Size(104, 18)
        Me.lbl_Grnno.TabIndex = 23
        Me.lbl_Grnno.Text = "DEPARTMENT :"
        '
        'grp_Grngroup1
        '
        Me.grp_Grngroup1.BackColor = System.Drawing.Color.Transparent
        Me.grp_Grngroup1.Controls.Add(Me.TextBox1)
        Me.grp_Grngroup1.Controls.Add(Me.Label12)
        Me.grp_Grngroup1.Controls.Add(Me.Label13)
        Me.grp_Grngroup1.Controls.Add(Me.DateTimePicker1)
        Me.grp_Grngroup1.Controls.Add(Me.Label3)
        Me.grp_Grngroup1.Controls.Add(Me.PictureBox2)
        Me.grp_Grngroup1.Controls.Add(Me.Label16)
        Me.grp_Grngroup1.Location = New System.Drawing.Point(72, 64)
        Me.grp_Grngroup1.Name = "grp_Grngroup1"
        Me.grp_Grngroup1.Size = New System.Drawing.Size(848, 120)
        Me.grp_Grngroup1.TabIndex = 22
        Me.grp_Grngroup1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Wheat
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(184, 16)
        Me.TextBox1.MaxLength = 50
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 26)
        Me.TextBox1.TabIndex = 476
        Me.TextBox1.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(104, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 18)
        Me.Label12.TabIndex = 478
        Me.Label12.Text = "DOC NO :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(504, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 18)
        Me.Label13.TabIndex = 477
        Me.Label13.Text = "DOC DATE :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(632, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 26)
        Me.DateTimePicker1.TabIndex = 475
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 24)
        Me.Label3.TabIndex = 474
        Me.Label3.Text = "F4"
        Me.Label3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(600, 48)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 473
        Me.PictureBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(336, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 24)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "F4"
        Me.Label16.Visible = False
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Storelocation.Location = New System.Drawing.Point(784, 1000)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Storelocation.TabIndex = 8
        '
        'lbl_Excisepassno
        '
        Me.lbl_Excisepassno.AutoSize = True
        Me.lbl_Excisepassno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassno.Location = New System.Drawing.Point(64, 88)
        Me.lbl_Excisepassno.Name = "lbl_Excisepassno"
        Me.lbl_Excisepassno.Size = New System.Drawing.Size(164, 21)
        Me.lbl_Excisepassno.TabIndex = 5
        Me.lbl_Excisepassno.Text = "EXCISE PASS NO       :"
        '
        'lbl_Excisepassdate
        '
        Me.lbl_Excisepassdate.AutoSize = True
        Me.lbl_Excisepassdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassdate.Location = New System.Drawing.Point(64, 128)
        Me.lbl_Excisepassdate.Name = "lbl_Excisepassdate"
        Me.lbl_Excisepassdate.Size = New System.Drawing.Size(168, 21)
        Me.lbl_Excisepassdate.TabIndex = 6
        Me.lbl_Excisepassdate.Text = "EXCISE PASS DATE   :"
        '
        'txt_Excisepassno
        '
        Me.txt_Excisepassno.BackColor = System.Drawing.Color.White
        Me.txt_Excisepassno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Excisepassno.Location = New System.Drawing.Point(240, 88)
        Me.txt_Excisepassno.MaxLength = 15
        Me.txt_Excisepassno.Name = "txt_Excisepassno"
        Me.txt_Excisepassno.Size = New System.Drawing.Size(216, 26)
        Me.txt_Excisepassno.TabIndex = 1
        Me.txt_Excisepassno.Text = ""
        '
        'lbl_Grn
        '
        Me.lbl_Grn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grn.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Grn.Location = New System.Drawing.Point(400, 488)
        Me.lbl_Grn.Name = "lbl_Grn"
        Me.lbl_Grn.Size = New System.Drawing.Size(160, 24)
        Me.lbl_Grn.TabIndex = 45
        Me.lbl_Grn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 1000)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 128)
        Me.GroupBox1.TabIndex = 352
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdRoundoff)
        Me.GroupBox2.Controls.Add(Me.OptNearest)
        Me.GroupBox2.Controls.Add(Me.OptNone)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(264, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 88)
        Me.GroupBox2.TabIndex = 353
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rounded Off"
        '
        'cmdRoundoff
        '
        Me.cmdRoundoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRoundoff.ForeColor = System.Drawing.Color.Blue
        Me.cmdRoundoff.Location = New System.Drawing.Point(136, 16)
        Me.cmdRoundoff.Name = "cmdRoundoff"
        Me.cmdRoundoff.Size = New System.Drawing.Size(56, 39)
        Me.cmdRoundoff.TabIndex = 2
        Me.cmdRoundoff.Text = "Round Off"
        '
        'OptNearest
        '
        Me.OptNearest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNearest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNearest.Location = New System.Drawing.Point(24, 44)
        Me.OptNearest.Name = "OptNearest"
        Me.OptNearest.Size = New System.Drawing.Size(85, 16)
        Me.OptNearest.TabIndex = 2
        Me.OptNearest.Text = "Nearest Rs"
        '
        'OptNone
        '
        Me.OptNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNone.Location = New System.Drawing.Point(24, 18)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.Size = New System.Drawing.Size(88, 16)
        Me.OptNone.TabIndex = 1
        Me.OptNone.Text = "None"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdValueby)
        Me.GroupBox3.Controls.Add(Me.OptPercentage)
        Me.GroupBox3.Controls.Add(Me.OptValue)
        Me.GroupBox3.Controls.Add(Me.txtChangeValue)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 88)
        Me.GroupBox3.TabIndex = 352
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount Amount"
        '
        'cmdValueby
        '
        Me.cmdValueby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdValueby.ForeColor = System.Drawing.Color.Blue
        Me.cmdValueby.Location = New System.Drawing.Point(191, 16)
        Me.cmdValueby.Name = "cmdValueby"
        Me.cmdValueby.Size = New System.Drawing.Size(48, 40)
        Me.cmdValueby.TabIndex = 3
        Me.cmdValueby.Text = "Value Chg"
        '
        'OptPercentage
        '
        Me.OptPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptPercentage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPercentage.Location = New System.Drawing.Point(10, 56)
        Me.OptPercentage.Name = "OptPercentage"
        Me.OptPercentage.Size = New System.Drawing.Size(87, 16)
        Me.OptPercentage.TabIndex = 2
        Me.OptPercentage.Text = "Percentage"
        '
        'OptValue
        '
        Me.OptValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptValue.Location = New System.Drawing.Point(10, 24)
        Me.OptValue.Name = "OptValue"
        Me.OptValue.Size = New System.Drawing.Size(80, 16)
        Me.OptValue.TabIndex = 1
        Me.OptValue.Text = "Value"
        '
        'txtChangeValue
        '
        Me.txtChangeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangeValue.Location = New System.Drawing.Point(100, 56)
        Me.txtChangeValue.MaxLength = 10
        Me.txtChangeValue.Name = "txtChangeValue"
        Me.txtChangeValue.Size = New System.Drawing.Size(92, 20)
        Me.txtChangeValue.TabIndex = 3
        Me.txtChangeValue.Text = ""
        '
        'grp_StockGrndetails
        '
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_StockGrndetails)
        Me.grp_StockGrndetails.Controls.Add(Me.GroupBox5)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_ToDocno)
        Me.grp_StockGrndetails.Location = New System.Drawing.Point(222, 1000)
        Me.grp_StockGrndetails.Name = "grp_StockGrndetails"
        Me.grp_StockGrndetails.Size = New System.Drawing.Size(514, 238)
        Me.grp_StockGrndetails.TabIndex = 361
        Me.grp_StockGrndetails.TabStop = False
        '
        'lbl_StockGrndetails
        '
        Me.lbl_StockGrndetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_StockGrndetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockGrndetails.ForeColor = System.Drawing.Color.White
        Me.lbl_StockGrndetails.Location = New System.Drawing.Point(0, 7)
        Me.lbl_StockGrndetails.Name = "lbl_StockGrndetails"
        Me.lbl_StockGrndetails.Size = New System.Drawing.Size(520, 25)
        Me.lbl_StockGrndetails.TabIndex = 26
        Me.lbl_StockGrndetails.Text = "GRN CHECKLIST"
        Me.lbl_StockGrndetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnprint)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnView)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnexit)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnClear)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        '
        'Cmd_StockGrnprint
        '
        Me.Cmd_StockGrnprint.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnprint.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnprint.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_StockGrnprint.Name = "Cmd_StockGrnprint"
        Me.Cmd_StockGrnprint.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnprint.TabIndex = 25
        Me.Cmd_StockGrnprint.Text = "Print [F10]"
        '
        'Cmd_StockGrnView
        '
        Me.Cmd_StockGrnView.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnView.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnView.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_StockGrnView.Name = "Cmd_StockGrnView"
        Me.Cmd_StockGrnView.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnView.TabIndex = 13
        Me.Cmd_StockGrnView.Text = "View [F9]"
        '
        'Cmd_StockGrnexit
        '
        Me.Cmd_StockGrnexit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnexit.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnexit.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_StockGrnexit.Name = "Cmd_StockGrnexit"
        Me.Cmd_StockGrnexit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnexit.TabIndex = 15
        Me.Cmd_StockGrnexit.Text = "Exit[F11]"
        '
        'Cmd_StockGrnClear
        '
        Me.Cmd_StockGrnClear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnClear.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnClear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_StockGrnClear.Name = "Cmd_StockGrnClear"
        Me.Cmd_StockGrnClear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnClear.TabIndex = 24
        Me.Cmd_StockGrnClear.Text = "Clear[F6]"
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(38, 67)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(135, 22)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM GRN NO :"
        '
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(184, 64)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_FromDocno.TabIndex = 4
        Me.txt_FromDocno.Text = ""
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(392, 64)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(184, 112)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        Me.txt_ToDocno.Text = ""
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(392, 112)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(64, 114)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(109, 22)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO GRN NO :"
        '
        'grp_Billingdetails
        '
        Me.grp_Billingdetails.BackColor = System.Drawing.SystemColors.Control
        Me.grp_Billingdetails.Controls.Add(Me.ssgrid_billdetails)
        Me.grp_Billingdetails.Controls.Add(Me.Label2)
        Me.grp_Billingdetails.Location = New System.Drawing.Point(16, 1000)
        Me.grp_Billingdetails.Name = "grp_Billingdetails"
        Me.grp_Billingdetails.Size = New System.Drawing.Size(664, 310)
        Me.grp_Billingdetails.TabIndex = 364
        Me.grp_Billingdetails.TabStop = False
        '
        'ssgrid_billdetails
        '
        Me.ssgrid_billdetails.ContainingControl = Me
        Me.ssgrid_billdetails.DataSource = Nothing
        Me.ssgrid_billdetails.Location = New System.Drawing.Point(24, 48)
        Me.ssgrid_billdetails.Name = "ssgrid_billdetails"
        Me.ssgrid_billdetails.OcxState = CType(resources.GetObject("ssgrid_billdetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_billdetails.Size = New System.Drawing.Size(608, 248)
        Me.ssgrid_billdetails.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(661, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BILLING DETAILS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grp_Excisedetails
        '
        Me.grp_Excisedetails.Controls.Add(Me.Label5)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassdate)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Excisepassdate)
        Me.grp_Excisedetails.Location = New System.Drawing.Point(216, 1000)
        Me.grp_Excisedetails.Name = "grp_Excisedetails"
        Me.grp_Excisedetails.Size = New System.Drawing.Size(512, 206)
        Me.grp_Excisedetails.TabIndex = 366
        Me.grp_Excisedetails.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(506, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EXCISE DETAILS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Trucknumber
        '
        Me.txt_Trucknumber.BackColor = System.Drawing.Color.White
        Me.txt_Trucknumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Trucknumber.Location = New System.Drawing.Point(240, 168)
        Me.txt_Trucknumber.MaxLength = 15
        Me.txt_Trucknumber.Name = "txt_Trucknumber"
        Me.txt_Trucknumber.Size = New System.Drawing.Size(216, 26)
        Me.txt_Trucknumber.TabIndex = 3
        Me.txt_Trucknumber.Text = ""
        '
        'dtp_Stockindate
        '
        Me.dtp_Stockindate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Stockindate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Stockindate.Location = New System.Drawing.Point(240, 48)
        Me.dtp_Stockindate.Name = "dtp_Stockindate"
        Me.dtp_Stockindate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Stockindate.TabIndex = 0
        '
        'lbl_Trucknumber
        '
        Me.lbl_Trucknumber.AutoSize = True
        Me.lbl_Trucknumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trucknumber.Location = New System.Drawing.Point(64, 168)
        Me.lbl_Trucknumber.Name = "lbl_Trucknumber"
        Me.lbl_Trucknumber.Size = New System.Drawing.Size(162, 21)
        Me.lbl_Trucknumber.TabIndex = 7
        Me.lbl_Trucknumber.Text = "TRUCK NUMBER      :"
        '
        'lbl_Stockindate
        '
        Me.lbl_Stockindate.AutoSize = True
        Me.lbl_Stockindate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stockindate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockindate.Location = New System.Drawing.Point(64, 48)
        Me.lbl_Stockindate.Name = "lbl_Stockindate"
        Me.lbl_Stockindate.Size = New System.Drawing.Size(163, 21)
        Me.lbl_Stockindate.TabIndex = 4
        Me.lbl_Stockindate.Text = "STOCK IN DATE        :"
        '
        'txt_IndentNo
        '
        Me.txt_IndentNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_IndentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IndentNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IndentNo.Location = New System.Drawing.Point(256, 112)
        Me.txt_IndentNo.MaxLength = 50
        Me.txt_IndentNo.Name = "txt_IndentNo"
        Me.txt_IndentNo.Size = New System.Drawing.Size(128, 26)
        Me.txt_IndentNo.TabIndex = 1
        Me.txt_IndentNo.Text = ""
        '
        'txt_storeDesc
        '
        Me.txt_storeDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_storeDesc.Enabled = False
        Me.txt_storeDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storeDesc.Location = New System.Drawing.Point(328, 152)
        Me.txt_storeDesc.MaxLength = 50
        Me.txt_storeDesc.Name = "txt_storeDesc"
        Me.txt_storeDesc.Size = New System.Drawing.Size(208, 26)
        Me.txt_storeDesc.TabIndex = 4
        Me.txt_storeDesc.Text = ""
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(48, 184)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(720, 224)
        Me.ssgrid.TabIndex = 367
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(304, 152)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(24, 26)
        Me.cmd_storecode.TabIndex = 375
        '
        'txt_storecode
        '
        Me.txt_storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_storecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_storecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storecode.Location = New System.Drawing.Point(256, 152)
        Me.txt_storecode.MaxLength = 50
        Me.txt_storecode.Name = "txt_storecode"
        Me.txt_storecode.Size = New System.Drawing.Size(48, 26)
        Me.txt_storecode.TabIndex = 2
        Me.txt_storecode.Text = ""
        '
        'cmd_indentnoHelp
        '
        Me.cmd_indentnoHelp.Image = CType(resources.GetObject("cmd_indentnoHelp.Image"), System.Drawing.Image)
        Me.cmd_indentnoHelp.Location = New System.Drawing.Point(384, 112)
        Me.cmd_indentnoHelp.Name = "cmd_indentnoHelp"
        Me.cmd_indentnoHelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_indentnoHelp.TabIndex = 377
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(487, -88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 88)
        Me.Button1.TabIndex = 383
        Me.Button1.Text = "Print[F10]"
        '
        'txt_Totalamount
        '
        Me.txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamount.Enabled = False
        Me.txt_Totalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamount.Location = New System.Drawing.Point(648, 392)
        Me.txt_Totalamount.MaxLength = 15
        Me.txt_Totalamount.Name = "txt_Totalamount"
        Me.txt_Totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalamount.Size = New System.Drawing.Size(104, 26)
        Me.txt_Totalamount.TabIndex = 384
        Me.txt_Totalamount.Text = ""
        Me.txt_Totalamount.Visible = False
        '
        'TXT_FROMSTORECODE
        '
        Me.TXT_FROMSTORECODE.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROMSTORECODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROMSTORECODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROMSTORECODE.Location = New System.Drawing.Point(680, 152)
        Me.TXT_FROMSTORECODE.MaxLength = 50
        Me.TXT_FROMSTORECODE.Name = "TXT_FROMSTORECODE"
        Me.TXT_FROMSTORECODE.Size = New System.Drawing.Size(48, 26)
        Me.TXT_FROMSTORECODE.TabIndex = 3
        Me.TXT_FROMSTORECODE.Text = ""
        '
        'txt_FromStorename
        '
        Me.txt_FromStorename.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromStorename.Enabled = False
        Me.txt_FromStorename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromStorename.Location = New System.Drawing.Point(752, 152)
        Me.txt_FromStorename.MaxLength = 50
        Me.txt_FromStorename.Name = "txt_FromStorename"
        Me.txt_FromStorename.Size = New System.Drawing.Size(160, 26)
        Me.txt_FromStorename.TabIndex = 392
        Me.txt_FromStorename.Text = ""
        '
        'cmd_fromStorecodeHelp
        '
        Me.cmd_fromStorecodeHelp.Image = CType(resources.GetObject("cmd_fromStorecodeHelp.Image"), System.Drawing.Image)
        Me.cmd_fromStorecodeHelp.Location = New System.Drawing.Point(728, 152)
        Me.cmd_fromStorecodeHelp.Name = "cmd_fromStorecodeHelp"
        Me.cmd_fromStorecodeHelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_fromStorecodeHelp.TabIndex = 393
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 395
        Me.Label1.Text = "ISSUE STORE :"
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.Wheat
        Me.txt_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(664, 392)
        Me.txt_qty.MaxLength = 15
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_qty.Size = New System.Drawing.Size(88, 26)
        Me.txt_qty.TabIndex = 396
        Me.txt_qty.Text = ""
        Me.txt_qty.Visible = False
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.Color.Transparent
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label9)
        Me.grp_footer.Controls.Add(Me.Label7)
        Me.grp_footer.Controls.Add(Me.Label8)
        Me.grp_footer.Location = New System.Drawing.Point(88, 248)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(672, 80)
        Me.grp_footer.TabIndex = 438
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(696, 20)
        Me.Txt_signature.TabIndex = 441
        Me.Txt_signature.Text = ""
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(696, 20)
        Me.Txt_footer.TabIndex = 440
        Me.Txt_footer.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
        Me.Label9.TabIndex = 439
        Me.Label9.Text = "FOOTER SIGN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 438
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 438
        Me.Label8.Text = "FOOTER NAME:"
        '
        'Chk_item
        '
        Me.Chk_item.BackColor = System.Drawing.Color.Transparent
        Me.Chk_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_item.Location = New System.Drawing.Point(56, 576)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(120, 24)
        Me.Chk_item.TabIndex = 463
        Me.Chk_item.Text = "FooterUpdation"
        Me.Chk_item.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label10.Location = New System.Drawing.Point(304, 440)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 23)
        Me.Label10.TabIndex = 465
        Me.Label10.Text = "[F3 DELETE A ROW IN GRID]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txt_Remarks)
        Me.GroupBox4.Controls.Add(Me.lbl_Remarks)
        Me.GroupBox4.Location = New System.Drawing.Point(64, 456)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 64)
        Me.GroupBox4.TabIndex = 466
        Me.GroupBox4.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 24)
        Me.Label20.TabIndex = 477
        Me.Label20.Text = "ALT+ R"
        '
        'CHK_WAR
        '
        Me.CHK_WAR.BackColor = System.Drawing.Color.Transparent
        Me.CHK_WAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_WAR.Location = New System.Drawing.Point(16, 80)
        Me.CHK_WAR.Name = "CHK_WAR"
        Me.CHK_WAR.Size = New System.Drawing.Size(64, 24)
        Me.CHK_WAR.TabIndex = 467
        Me.CHK_WAR.Text = "WAR"
        Me.CHK_WAR.Visible = False
        '
        'lbl_Billterms
        '
        Me.lbl_Billterms.AutoSize = True
        Me.lbl_Billterms.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Billterms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Billterms.Location = New System.Drawing.Point(16, 40)
        Me.lbl_Billterms.Name = "lbl_Billterms"
        Me.lbl_Billterms.Size = New System.Drawing.Size(47, 18)
        Me.lbl_Billterms.TabIndex = 469
        Me.lbl_Billterms.Text = "TYPE :"
        Me.lbl_Billterms.Visible = False
        '
        'cbo_type
        '
        Me.cbo_type.BackColor = System.Drawing.Color.Wheat
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.Items.AddRange(New Object() {"REVENUE", "CAPITAL", "FINISHED GOOD", "INTERMEDIATE GOOD", "RAW MATERIAL", "SERVICE"})
        Me.cbo_type.Location = New System.Drawing.Point(72, 32)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(200, 28)
        Me.cbo_type.TabIndex = 468
        Me.cbo_type.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(776, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 112)
        Me.PictureBox1.TabIndex = 470
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(800, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 16)
        Me.Label4.TabIndex = 471
        Me.Label4.Text = "AUTH. DOC1"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(800, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 16)
        Me.Label6.TabIndex = 473
        Me.Label6.Text = "AUTH. DOC2"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(776, 336)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(208, 104)
        Me.PictureBox3.TabIndex = 472
        Me.PictureBox3.TabStop = False
        '
        'dtp_completiondate
        '
        Me.dtp_completiondate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_completiondate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_completiondate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_completiondate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_completiondate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_completiondate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_completiondate.Location = New System.Drawing.Point(536, 416)
        Me.dtp_completiondate.Name = "dtp_completiondate"
        Me.dtp_completiondate.Size = New System.Drawing.Size(120, 26)
        Me.dtp_completiondate.TabIndex = 482
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(376, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 18)
        Me.Label11.TabIndex = 479
        Me.Label11.Text = "AUTHORIZATION DATE :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(72, 416)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 18)
        Me.Label15.TabIndex = 481
        Me.Label15.Text = "AUTHORISED BY :"
        '
        'cmb_approvedby
        '
        Me.cmb_approvedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_approvedby.Location = New System.Drawing.Point(200, 416)
        Me.cmb_approvedby.Name = "cmb_approvedby"
        Me.cmb_approvedby.Size = New System.Drawing.Size(144, 24)
        Me.cmb_approvedby.TabIndex = 480
        '
        'StockIndentAUTHORIZATION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(998, 604)
        Me.Controls.Add(Me.dtp_completiondate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbl_Billterms)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_FROMSTORECODE)
        Me.Controls.Add(Me.txt_FromStorename)
        Me.Controls.Add(Me.txt_storecode)
        Me.Controls.Add(Me.txt_IndentNo)
        Me.Controls.Add(Me.lbl_Suppliercode)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Grndate)
        Me.Controls.Add(Me.lbl_Grnno)
        Me.Controls.Add(Me.txt_Totalamount)
        Me.Controls.Add(Me.txt_storeDesc)
        Me.Controls.Add(Me.cmb_approvedby)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.CHK_WAR)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Chk_item)
        Me.Controls.Add(Me.cmd_fromStorecodeHelp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmd_indentnoHelp)
        Me.Controls.Add(Me.cmd_storecode)
        Me.Controls.Add(Me.grp_StockGrndetails)
        Me.Controls.Add(Me.grp_Billingdetails)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.grp_Excisedetails)
        Me.Controls.Add(Me.lbl_Grn)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.dtp_Indentdate)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.grp_footer)
        Me.Controls.Add(Me.grp_Grngroup1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "StockIndentAUTHORIZATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTION[STOCK INDENT]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        Me.grp_Grngroup1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.grp_StockGrndetails.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.grp_Billingdetails.ResumeLayout(False)
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Excisedetails.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_footer.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public i, TotalCount, billrow As Integer
    Dim GRNno(), sqlstring, Gr As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode, sstr As String
    Dim docno, transferdocno, doctype, docno1() As String
    Public Listbox As System.Windows.Forms.ListBox
    Dim boolchk, costcentercodestatus, slcodestatus, blnchkupdateclsbal, Dupchk As Boolean
    Dim CATEGORY As String
    Private Sub StockIndentAUTHORIZATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo_type.SelectedIndex = 0
        Call FOOTER()
        grp_footer.Visible = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If gindentno = "Y" Then
            txt_storecode.Show()
            txt_storecode.Focus()
            Me.cmd_Clear_Click(sender, e)
        Else
            txt_IndentNo.Focus()
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FREEZE.Click
        Try
            Call checkValidation() ''-->Check Validation
            Dim insert(0) As String
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_FREEZE.Text, 1, 1) = "V" Then

                If MsgBox("Are you Sure to Freeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                End If

                '''*****************************************Checking if this indent is already Issued or Not **************************'''
                Dim Sqlstring = "Select * from Stockissuedetail  where IndentNo='" & Trim(txt_IndentNo.Text) & "'"
                gconnection.getDataSet(Sqlstring, "INDENTISSUE")
                If gdataset.Tables("INDENTISSUE").Rows.Count > 0 Then
                    MsgBox("Sorry ! This Indent Stock  is Already Issued............")
                    Exit Sub
                End If

                '''***************************************** Checking if this indent is already Issued or Not  **************************'''
                '''***************************************** Void the INDENT in IND_header **************************'''
                Sqlstring = "UPDATE  INVENTORY_INDENTHDR "
                Sqlstring = Sqlstring & " SET Void= 'Y',"
                Sqlstring = Sqlstring & " UPDATEuser='" & Trim(gUsername) & " ',"
                Sqlstring = Sqlstring & " UPdatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                Sqlstring = Sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                insert(0) = Sqlstring
                '''***************************************** Void the INDENT in Complete **********************************'''
                '''***************************************** Void the INDENT in INDENT_details **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        Sqlstring = "UPDATE  INVENTORY_INDENTDET "
                        Sqlstring = Sqlstring & " SET Void= 'Y',"
                        Sqlstring = Sqlstring & " FREEZEuser='" & Trim(gUsername) & " ',"
                        Sqlstring = Sqlstring & " FREEZEDATEtime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        Sqlstring = Sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = Sqlstring
                    End With
                Next i
                '''***************************************** Void the INDENT is Complete **********************************'''
                '''***************************************** Void the INDENT in INDENT_header **************************'''

                '''***************************************** DELETE INDENT FROM INDENTDET **********************************'''
                '''***************************************** DELETE INDENT FROM INDENTDET COMPLETE **********************************'''
                gconnection.MoreTrans(insert)
                Me.cmd_Clear_Click(sender, e)
                cmd_Add.Text = "Add [F7]"

            ElseIf Mid(Me.Cmd_FREEZE.Text, 1, 1) = "U" Then

                If MsgBox("Are you Sure to UnFreeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                End If

                '''***************************************** UnVoid the INDENT in IND_header **************************'''
                Sqlstring = "UPDATE  INVENTORY_INDENTHDR "
                Sqlstring = Sqlstring & " SET Void= 'N',"
                Sqlstring = Sqlstring & " UPDATEuser='" & Trim(gUsername) & " ',"
                Sqlstring = Sqlstring & " UPdatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                Sqlstring = Sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                insert(0) = Sqlstring
                '''***************************************** UnVoid the INDENT in Complete **********************************'''
                '''***************************************** UnVoid the INDENT in INDENT_details **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        Sqlstring = "UPDATE  INVENTORY_INDENTDET "
                        Sqlstring = Sqlstring & " SET Void= 'N',"
                        Sqlstring = Sqlstring & " FREEZEuser='" & Trim(gUsername) & " ',"
                        Sqlstring = Sqlstring & " FREEZEDATEtime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        Sqlstring = Sqlstring & " WHERE INDENT_NO = '" & Trim(txt_IndentNo.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = Sqlstring
                    End With
                Next i
                '''***************************************** UnVoid the INDENT is Complete **********************************'''
                '''***************************************** UnVoid the INDENT in INDENT_header **************************'''
                gconnection.MoreTrans(insert)
                Me.cmd_Clear_Click(sender, e)
                cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************

            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CMD_FREEZE" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Function printoperation()
        Try
            Dim i As Integer
            Dim Sqlstring = Sqlstring & " SELECT 	ISNULL(HDR.INDENT_NO,'') INDENT_NO, ISNULL(HDR.INDENT_DATE,'')  INDENT_DATE,"
            Sqlstring = Sqlstring & " ISNULL(HDR.FROMSTORECODE,'') FROMSTORECODE , ISNULL(HDR.STORELOCATIONCODE,'') STORELOCATIONCODE, ISNULL(HDR.STORELOCATIONNAME,'') STORELOCATIONNAME,"
            Sqlstring = Sqlstring & " ISNULL(HDR.PRODUCT_TYPE,'') PRODUCT_TYPE, ISNULL(HDR.REMARKS,'') REMARKS,ISNULL(HDR.updsign,'') updsign,ISNULL(HDR.updfooter,'') updfooter,"
            Sqlstring = Sqlstring & "	ISNULL(ITEMCODE,'') ITEMCODE, ISNULL(ITEMNAME,'') ITEMNAME, ISNULL(UOM,'') UOM,"
            Sqlstring = Sqlstring & " ISNULL(QTY,0) QTY, ISNULL(RATE,0) RATE, ISNULL(AMOUNT,0) AMOUNT, ISNULL(CLSQTY,0) CLSQTY"
            Sqlstring = Sqlstring & " FROM INVENTORY_INDENTHDR HDR"
            Sqlstring = Sqlstring & " INNER JOIN INVENTORY_INDENTDET AS DET ON HDR.INDENT_NO = DET.INDENT_NO"
            Sqlstring = Sqlstring & " WHERE HDR.INDENT_NO BETWEEN '" & Trim(txt_IndentNo.Text) & "' AND '" & Trim(txt_IndentNo.Text) & "'"

            Dim heading() As String = {"INDENT DETAILS"}
            ReportDetails(Sqlstring, heading, txt_IndentNo.Text, txt_IndentNo.Text)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Printoperation " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_View.Click
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r As New Rpt_Indentbill_
            sqlstring = sqlstring & " SELECT 	ISNULL(INDENT_NO,'') INDENT_NO, ISNULL(INDENT_DATE,'')  INDENT_DATE,"
            sqlstring = sqlstring & " ISNULL(FROMSTORECODE,'') FROMSTORECODE , ISNULL(STORELOCATIONCODE,'') STORELOCATIONCODE, ISNULL(STORELOCATIONNAME,'') STORELOCATIONNAME,"
            sqlstring = sqlstring & " ISNULL(PRODUCT_TYPE,'') PRODUCT_TYPE, ISNULL(REMARKS,'') REMARKS,ISNULL(updsign,'') updsign,ISNULL(updfooter,'') updfooter,"
            sqlstring = sqlstring & "	ISNULL(ITEMCODE,'') ITEMCODE, ISNULL(ITEMNAME,'') ITEMNAME, ISNULL(UOM,'') UOM,"
            sqlstring = sqlstring & " ISNULL(QTY,0) QTY, ISNULL(RATE,0) RATE, ISNULL(AMOUNT,0) AMOUNT, ISNULL(CLSQTY,0) CLSQTY, ISNULL(ADDDATE,'') ADDDATE "
            sqlstring = sqlstring & " FROM VW_INV_IDENTBILL"
            ' Sqlstring = Sqlstring & " INNER JOIN INVENTORY_INDENTDET AS DET ON HDR.INDENT_NO = DET.INDENT_NO"
            sqlstring = sqlstring & " WHERE INDENT_NO BETWEEN '" & Trim(txt_IndentNo.Text) & "' AND '" & Trim(txt_IndentNo.Text) & "'"

            gconnection.getDataSet(sqlstring, "VW_INV_IDENTBILL")

            SSQL = " SELECT STOREDESC FROM STOREMASTER WHERE STORECODE = '" & gdataset.Tables("VW_INV_IDENTBILL").Rows(0).Item("FROMSTORECODE") & "' "
            gconnection.getDataSet(SSQL, "FROMSTORE")
            If gdataset.Tables("FROMSTORE").Rows.Count > 0 Then
                FROMSTORE = gdataset.Tables("FROMSTORE").Rows(0).Item("STOREDESC")
            End If
            If gdataset.Tables("VW_INV_IDENTBILL").Rows.Count > 0 Then
                If chk_excel.Checked = True Then
                    Dim exp
                    exp.Show()
                    Call exp.export(sqlstring, "STOCK INDENT ", "")
                Else
                    rViewer.ssql = sqlstring
                    rViewer.Report = r
                    rViewer.TableName = "VW_INV_IDENTBILL"
                    Dim textobj1 As TextObject
                    textobj1 = r.ReportDefinition.ReportObjects("Text13")
                    textobj1.Text = MyCompanyName
                    Dim textobj As TextObject
                    textobj = r.ReportDefinition.ReportObjects("Text17")
                    textobj.Text = FROMSTORE
                    rViewer.Show()
                End If
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If
            'Else
            'gPrint = False
            'Call printoperation()
            ''End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : View Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Indent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_Freeze_Click(Cmd_FREEZE, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                txt_IndentNo.Text = ""
                txt_IndentNo.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call Cmd_Add_Click(cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call Cmd_View_Click(cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Then
                Call cmd_Exit_Click(cmd_Exit, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Then
                Call cmd_Exit_Click(cmd_Exit, e)
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                Me.ssgrid.Focus()
                Me.ssgrid.SetActiveCell(1, 1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Indent_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub checkValidation()
        Try
            boolchk = False
            '''**************************************** Check DATEVALIDATION *******************************************''
            Call Checkdatevalidate(Format(dtp_Indentdate.Value, "dd-MMM-yyyy"))
            If chkdatevalidate = False Then Exit Sub
            '''**************************************** Check GRN NO. can't be blank *******************************************''
            If Trim(txt_IndentNo.Text) = "" Then
                MessageBox.Show("INDENT NO. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_IndentNo.Focus()
                Exit Sub
            End If
            '''**************************************** Check Storecode can't be blank *******************************************''
            If Trim(TXT_FROMSTORECODE.Text) = "" Then
                MessageBox.Show("Storecode. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_storecode.Focus()
                Exit Sub
            End If
            '''**************************************** Check storedesc can't be blank *******************************************''
            If Trim(txt_FromStorename.Text) = "" Then
                MessageBox.Show("StoreDesc Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_storeDesc.Focus()
                Exit Sub
            End If
            '''**************************************** Check Type can't be blank *******************************************''
            '''If Trim(cbo_type.Text) = "" Then
            '''    MessageBox.Show("Product Type Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '''    cbo_type.Focus()
            '''    Exit Sub
            '''End If
            '''********************************************* Check ssgrid value can't be blank ********************************************'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Item Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 2
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Item Description can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 3
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 4
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 5
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
                ssgrid.Col = 6
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If
            Next
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : checkValidation" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Add.Click
        Try
            Dim Totalamt, totalqty, Avgrate, AvgQuantity As Double
            Dim sqlstring, Itemcode, Insert(0) As String
            Dim FromStorecode, ToStorecode As String
            Dim dblval, dblqty As Double
            Dim i, j As Integer
            FromStorecode = Trim(TXT_FROMSTORECODE.Text)
            ToStorecode = Trim(txt_storecode.Text)
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub

            '''*********************************************************** Calculate TotalQuantity And TotalAmount *******************'''
            '''*********************************************************** Case-1 : Add [F7] *******************************************'''
            If cmd_Add.Text = "Add [F7]" Then
                sqlstring = "INSERT INTO INVENTORY_INDENTHDR(DOCNO,INDENT_NO,INDENT_DATE,fromStoreCode,Storelocationcode,Storelocationname,Product_type, "
                sqlstring = sqlstring & " Remarks,Void,Adduser,Adddatetime,updfooter,updsign)"
                If gindentno = "Y" Then
                    docno1 = Split(Trim(txt_IndentNo.Text), "/")
                    sqlstring = sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"
                Else
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_IndentNo.Text) & "','" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"
                End If
                sqlstring = sqlstring & " '" & Trim(TXT_FROMSTORECODE.Text) & "','" & Trim(txt_storecode.Text) & "',"
                sqlstring = sqlstring & " '" & Trim(txt_storeDesc.Text) & "','" & Trim(cbo_type.Text) & "',"
                sqlstring = sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,'N',"
                sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " '" & Trim(CStr(Txt_footer.Text)) & "','" & Trim(Txt_signature.Text) & "')"
                Insert(0) = sqlstring
                '''******************************************************** Insert into Indentdet **********************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    sqlstring = "INSERT INTO INVENTORY_INDENTDET(INDENT_NO,INDENT_DATE,Itemcode,Itemname,Uom,Qty,Rate,Amount,CLSQTY,"
                    sqlstring = sqlstring & " VOID,Adduser,adddatetime,ind_qty)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"

                    ssgrid.Col = 1
                    Itemcode = Trim(ssgrid.Text)
                    sqlstring = sqlstring & "'" & Trim(Itemcode) & "',"
                    ssgrid.Col = 2
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","

                    sqlstring = sqlstring & "'N',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ")"

                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next i
                gconnection.MoreTrans(Insert)
                cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_View_Click(cmd_View, e)
                    Call cmd_Clear_Click(sender, e)
                Else
                    Call cmd_Clear_Click(sender, e)
                End If
                '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            Else
                If gindentno = "Y" Then
                    docno1 = Split(Trim(txt_IndentNo.Text), "/")
                End If

                Dim sqlstring9 As String
                sqlstring9 = "Select * from stockissuedetail where indentno='" & Trim(txt_IndentNo.Text) & "'"
                gconnection.getDataSet(sqlstring9, "QTY")
                If gdataset.Tables("qty").Rows.Count > 0 Then
                    MsgBox("Sorry already this Indent Issued")
                    Exit Sub
                End If
                ''''*************************************
                sqlstring = "UPDATE INVENTORY_INDENTHDR SET INDENT_DATE='" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "', "
                sqlstring = sqlstring & " fromStorecode='" & Trim(TXT_FROMSTORECODE.Text) & "',"
                sqlstring = sqlstring & " Storelocationcode='" & Trim(txt_storecode.Text) & "',"
                sqlstring = sqlstring & " Storelocationname='" & Trim(txt_storeDesc.Text) & "',"
                sqlstring = sqlstring & " PRODUCT_TYPE ='" & cbo_type.Text & "',"
                sqlstring = sqlstring & " Remarks='" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,Void='N',"
                sqlstring = sqlstring & " Updateuser='" & Trim(gUsername) & "',"
                sqlstring = sqlstring & " updfooter='" & Trim(CStr(Txt_footer.Text)) & "',"
                sqlstring = sqlstring & " updsign='" & Trim(Txt_signature.Text) & "',"
                sqlstring = sqlstring & " Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE INDENT_NO='" & Trim(txt_IndentNo.Text) & "' "
                Insert(0) = sqlstring
                '''********************************************************* DELETE FROM stockissuedetail *****************************************************'''
                sqlstring = "DELETE FROM INVENTORY_INDENTDET WHERE INDENT_NO='" & Trim(txt_IndentNo.Text) & "' "
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                '''******************************************************** INSERT INTO stockissuedetail ******************************************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    sqlstring = "INSERT INTO INVENTORY_INDENTDET(INDENT_NO,INDENT_DATE,Itemcode,Itemname,Uom,Qty,Rate,Amount,CLSQTY,"
                    sqlstring = sqlstring & " VOID,UPDATEUSER,UPdatetime,ind_qty)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"

                    ssgrid.Col = 1
                    Itemcode = Trim(ssgrid.Text)
                    sqlstring = sqlstring & "'" & Trim(Itemcode) & "',"
                    ssgrid.Col = 2
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","

                    sqlstring = sqlstring & "'N',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ")"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next i
                gconnection.MoreTrans(Insert)
                cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    If Trim(txt_IndentNo.Text) <> "" Then
                        txt_FromDocno.Text = Trim(txt_IndentNo.Text)
                        txt_ToDocno.Text = Trim(txt_IndentNo.Text)
                    End If
                    Call Cmd_View_Click(cmd_View, e)
                    Call cmd_Clear_Click(sender, e)
                Else
                    Call cmd_Clear_Click(sender, e)
                End If
            End If
            gconnection.openConnection()
            gcommand = New SqlCommand("CP_inventoryitemmaster_single", gconnection.Myconn)
            gcommand.CommandTimeout = 1000000000
            gcommand.CommandType = CommandType.StoredProcedure
            gcommand.Parameters.Add(New SqlParameter("@FROMSTORECODE", SqlDbType.VarChar)).Value = FromStorecode
            gcommand.Parameters.Add(New SqlParameter("@TOSTORECODE", SqlDbType.VarChar)).Value = ToStorecode
            gcommand.ExecuteNonQuery()
            gconnection.closeConnection()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Calculate()
        Try
            Dim ValQty, ValRate, ValDiscount, VarTotal, clsquantiy As Double
            Dim ValHighratio, ValItemamount, ValDblamount, Calqty, varqty As Double
            Dim Itemcode As String
            Dim i, j As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Then
                i = ssgrid.ActiveRow
                ssgrid.Col = 4
                ssgrid.Row = i
                ValQty = Val(ssgrid.Text)
                ssgrid.Col = 5
                ssgrid.Row = i
                ValRate = Val(ssgrid.Text)
                ValItemamount = Format(Val(ValQty) * Val(ValRate), "0.00")
                If Val(ValItemamount) = 0 Then
                    ssgrid.SetText(6, i, "")
                    ssgrid.SetText(7, i, "")
                Else
                    ssgrid.SetText(6, i, Val(ValItemamount))
                End If
                ssgrid.Col = 2
                ssgrid.Row = i
                Me.txt_Totalamount.Text = 0
                VarTotal = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 6
                    ssgrid.Row = i
                    VarTotal = Val(ssgrid.Text)
                    Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(VarTotal), "0.00")
                Next i
                i = i - 1
                varqty = 0
                Me.txt_qty.Text = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 4
                    ssgrid.Row = i
                    varqty = Val(ssgrid.Text)
                    Me.txt_qty.Text = Format(Val(Me.txt_qty.Text) + Val(varqty), "0.00")
                Next i
                i = i - 1
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Dim i, j, k As Integer
        Dim Rate, clsquantity, AMOUNT, purrate As Double
        Dim Itemcode, Itemdesc As String
        Try
            If e.keyCode = Keys.F1 Then
                Dim frmSrc As New frmSearch
                frmSrc.farPoint = ssgrid
                frmSrc.ShowDialog(Me)
            End If

            If e.keyCode = Keys.Enter Then
                i = ssgrid.ActiveRow
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        Dim temp, TEMP1 As String
                        temp = 0
                        TEMP1 = ""
                        ssgrid.Col = 1
                        ssgrid.Row = i
                        ssgrid.Col = 4
                        ssgrid.Row = i
                        temp = ssgrid.Text
                        ssgrid.Col = 1
                        ssgrid.Row = i
                        If Val(temp) = 0 Then
                            If Trim(ssgrid.Text) = "" Then
                                'Call fillmenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                                Call FillMenuNew()
                            Else
                                Itemcode = Trim(ssgrid.Text)
                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                                sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM ,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.SALERATE,0) AS SALERATE"
                                sqlstring = sqlstring & " FROM INVENTORYITEMMASTER AS I "
                                sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y' AND ISNULL(I.STORECODE,'')='" & Trim(TXT_FROMSTORECODE.Text) & "'"
                                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")
                                If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                                    Call check_Duplicate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                    If Dupchk = True Then
                                        ssgrid.Col = 1
                                        ssgrid.Row = ssgrid.ActiveRow
                                        ssgrid.Text = ""
                                        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                                        ssgrid.Focus()
                                        Exit Sub
                                    End If
                                    Call GridUOM(i) '''---> Fill the UOM feild
                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                                    ssgrid.Col = 3
                                    ssgrid.Row = i
                                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                    'ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                    If gsalerate = "Y" Then
                                        ssgrid.SetText(5, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("SALERATE")))
                                    Else
                                        ssgrid.SetText(5, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("PURCHASERATE")))
                                    End If
                                    If CHK_WAR.Checked = True Then
                                        Dim Avgrate As Double
                                        'Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_Indentdate.Value, "dd MMM yyyy"), Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), Trim(TXT_FROMSTORECODE.Text), "Q")
                                        sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")) & "'"
                                        gconnection.getDataSet(sqlstring, "RATE")
                                        If gdataset.Tables("RATE").Rows.Count > 0 Then
                                            If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                                                ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                                            Else
                                                ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                                            End If
                                            ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                                        End If
                                    Else
                                        'Rate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), Format(dtp_Indentdate.Value, "dd/MMM/yyyy"), TXT_FROMSTORECODE.Text)
                                        'ssgrid.SetText(5, i, Format(Val(Rate), "0.00"))
                                        If Trim(txt_storecode.Text) <> "" Then
                                            clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text)
                                        Else
                                            clsquantity = 0
                                        End If
                                        ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
                                    End If
                                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                    Call GridRowLock(i)
                                    ssgrid.Col = 3
                                    Dim SqlQuery As String
                                    SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE"))) & "' "
                                    gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
                                    If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
                                        Call FillTransUOM(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE"))))
                                    ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
                                        ssgrid.Row = ssgrid.ActiveRow
                                        ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                                        ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                                    Else
                                        ssgrid.Row = ssgrid.ActiveRow
                                        ssgrid.Text = Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM")))
                                    End If
                                    Dim STRITEMUOM As String
                                    ssgrid.Col = 3
                                    ssgrid.Row = ssgrid.ActiveRow
                                    STRITEMUOM = ssgrid.Text
                                    ssgrid.SetText(13, i, clsquantity)
                                    ssgrid.Col = 7
                                    ssgrid.Row = ssgrid.ActiveRow
                                    Dim INDDATE As Date
                                    INDDATE = Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy")
                                    'clsquantity = ClosingQuantity_Date(Itemcode, Trim(TXT_FROMSTORECODE.Text), STRITEMUOM, INDDATE)
                                    ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
                                    If Val(clsquantity) <= 0 Then
                                        MsgBox("Item Has No Stock", MsgBoxStyle.Information, MyCompanyName)
                                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                        ssgrid.Text = ""
                                        ssgrid.Focus()
                                        Exit Sub
                                    End If
                                    'Rate = CalAverageRate_new(Itemcode, Format(dtp_Indentdate.Value, "dd/MMM/yyyy"), TXT_FROMSTORECODE.Text, STRITEMUOM)
                                    'ssgrid.SetText = (5, i, Format(Val(Rate), "0.00"))
                                    'ssgrid.SetText(5, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("PURCHASERATE")))

                                    'ssgrid.Col = 2
                                    'ssgrid.Row = ssgrid.ActiveRow
                                    'ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                                    'ssgrid.Col = 3
                                    Dim grndate1 As DateTime
                                    Dim curuom As String
                                    Dim currate, prate As Double
                                    SqlQuery = "select max(grndate) as grndate,itemcode from grn_details WHERE Itemcode ='" & Trim(Itemcode) & "' AND grndate <='" & Format(CDate(dtp_Indentdate.Text), "yyyy-MM-dd") & "' group by itemcode"
                                    gconnection.getDataSet(SqlQuery, "temp")
                                    If gdataset.Tables("temp").Rows.Count > 0 Then
                                        grndate1 = gdataset.Tables("temp").Rows(0).Item("grndate")
                                        'grndate1 = Format(CDate(grndate1), "yyyy/MM/dd")
                                        ssgrid.Col = 3
                                        ssgrid.Row = ssgrid.ActiveRow
                                        curuom = Trim(ssgrid.Text)
                                        SqlQuery = "select rate from grn_details WHERE grndate = '" & Format(CDate(grndate1), "yyyy-MM-dd") & "' and Itemcode ='" & Trim(Itemcode) & "' and uom = '" & Trim(curuom) & "'"
                                        gconnection.getDataSet(SqlQuery, "temp1")
                                        If gdataset.Tables("temp1").Rows.Count > 0 Then
                                            currate = gdataset.Tables("temp1").Rows(0).Item("rate")
                                            ssgrid.Col = 5
                                            ssgrid.Row = ssgrid.ActiveRow
                                            ssgrid.Text = Format(Val(currate), "0.00")
                                            'ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
                                        Else
                                            SqlQuery = "select rate = rate * b.convvalue from inventory_transconversion b, grn_details where itemcode = '" & Trim(Itemcode) & "' and grn_details.grndate = '" & Format(CDate(grndate1), "yyyy-MM-dd") & "' and b. baseuom = '" & Trim(curuom) & "' and b.transuom = grn_details.uom "
                                            gconnection.getDataSet(SqlQuery, "temp2")
                                            If gdataset.Tables("temp2").Rows.Count > 0 Then
                                                prate = gdataset.Tables("temp2").Rows(0).Item("rate")
                                                ssgrid.Col = 5
                                                ssgrid.Row = ssgrid.ActiveRow
                                                ssgrid.Text = Format(Val(prate), "0.00")
                                                'ssgrid.Text = "0.00"
                                                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                                                ssgrid.Focus()
                                            End If
                                        End If
                                    Else
                                        ssgrid.Col = 5
                                        ssgrid.Row = ssgrid.ActiveRow
                                        ssgrid.Text = Format(Val(purrate), "0.00")
                                    End If

                                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                    ssgrid.Focus()
                                Else
                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                    ssgrid.Text = ""
                                    ssgrid.Focus()
                                    Exit Sub
                                End If
                            End If
                        Else
                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                            Call SelectText()
                        End If
                    Else
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                    ssgrid.Col = 2
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Trim(ssgrid.Text) = "" Then
                            Call FillMenuNew() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                        Else
                            Itemdesc = Trim(ssgrid.Text)
                            ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                            '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                            sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM ,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE"
                            sqlstring = sqlstring & " FROM INVENTORYITEMMASTER AS I"
                            sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y' AND ISNULL(I.STORECODE,'')='" & Trim(TXT_FROMSTORECODE.Text) & "'"
                            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")
                            If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                                Call GridUOM(i) '''---> Fill the UOM feild
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                                ssgrid.Col = 3
                                ssgrid.Row = i
                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                                'Rate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                                ' Rate = CalAverageRate_new(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), dtp_Indentdate.Text, TXT_FROMSTORECODE.Text)
                                Rate = gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("PURCHASERATE")
                                ssgrid.SetText(5, i, Format(Val(Rate), "0.00"))
                                'clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), GetMainStore())
                                If Trim(txt_storecode.Text) <> "" Then
                                    clsquantity = ClosingQuantity(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")), TXT_FROMSTORECODE.Text)
                                Else
                                    clsquantity = 0
                                End If
                                'lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                                If Val(clsquantity) <= 0 Then
                                    MsgBox("Item Has No Stock", MsgBoxStyle.Information, MyCompanyName)
                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                    ssgrid.Text = ""
                                    ssgrid.Focus()
                                    Exit Sub
                                End If
                                ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
                                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                                Call GridRowLock(i)
                            Else
                                MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                                ssgrid.Text = ""
                                ssgrid.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 4 Then

                    Dim sqlrol, rolitem As String
                    Dim mqty, CQty, ROLQty As Double
                    mqty = 0 : CQty = 0 : ROLQty = 0

                    ssgrid.Col = 7
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    CQty = Val(ssgrid.Text)

                    ssgrid.Col = 1
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    rolitem = Trim(ssgrid.Text)

                    sqlrol = "select isnull(minqty,0) as minqty, isnull(reorderlevel,0) as reorderlevel from inventoryitemmaster where itemcode ='" & Trim(rolitem) & "' and storecode ='" & TXT_FROMSTORECODE.Text & "'"
                    gconnection.getDataSet(sqlrol, "INVENTORYROL")
                    If gdataset.Tables("inventoryrol").Rows.Count > 0 Then
                        mqty = gdataset.Tables("inventoryrol").Rows(0).Item("minqty")
                        ROLQty = gdataset.Tables("inventoryrol").Rows(0).Item("reorderlevel")
                    End If

                    If ROLQty <> 0 Then
                        If CQty < mqty Then
                            If CQty >= ROLQty Then
                                MsgBox("Your Stock Reached ReorderLevel Qty")
                            End If
                        End If
                    End If

                    If mqty <> 0 Then
                        If CQty >= mqty Then
                            MsgBox("Your Stock Reached Minimumlevel Qty")
                        End If
                    End If

                    ssgrid.Col = 4
                    i = ssgrid.ActiveRow
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        If Val(ssgrid.Text) = 0 Then
                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                        ElseIf Val(ssgrid.Text) > CQty Then
                            MsgBox("ISSUING QTY CANNOT BE GREATER THAN CLOSING QTY")
                            ssgrid.Text = 0
                            ssgrid.Focus()
                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                            Exit Sub
                        Else
                            Call Calculate() '''CALC TOTAL AMOUNT
                            ssgrid.Col = 5
                            Rate = ssgrid.Text
                            ssgrid.Col = 4
                            ssgrid.Row = ssgrid.ActiveRow + 1
                            ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 5 Then
                ElseIf ssgrid.ActiveCol = 6 Then

                ElseIf ssgrid.ActiveCol = 7 Then

                End If
            ElseIf e.keyCode = Keys.F4 Then
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        ssgrid.Col = 1
                        ssgrid.Row = ssgrid.ActiveRow
                        search = Trim(ssgrid.Text)
                        Call fillmenu()
                    End If
                ElseIf ssgrid.ActiveCol = 2 Then
                End If
            ElseIf e.keyCode = Keys.F3 Then
                ssgrid.Col = ssgrid.ActiveCol
                i = ssgrid.ActiveRow
                ssgrid.Row = i
                If ssgrid.Lock = False Then
                    With ssgrid
                        .Row = .ActiveRow
                        .ClearRange(1, .ActiveRow, 11, .ActiveRow, True)
                        .DeleteRows(.ActiveRow, 1)
                        Call Calculate()
                        .SetActiveCell(1, ssgrid.ActiveRow)
                        .Focus()
                    End With
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FillMenuNew()
        Try
            Dim Avgrate, clsquantity, PURCHASERATE As Double
            Dim K As Integer
            Dim vform As New ListOperattion1
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            If gsalerate = "Y" Then
                gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(CLSTOCK,0) AS CLSTOCK,ISNULL(CLVALUE,0) AS CLVALUE,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(SALERATE,0) AS PURCHASERATE, "
                gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
                If Trim(vsearch) = " " Then
                    M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "'"
                Else
                    M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND " & "I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
                End If
            Else
                gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(CLSTOCK,0) AS CLSTOCK,ISNULL(CLVALUE,0) AS CLVALUE,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(PURCHASERATE,0) AS PURCHASERATE, "
                gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
                If Trim(vsearch) = " " Then
                    M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "'"
                Else
                    M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND " & "I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
                End If
            End If

            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | CLSTOCK   | CLVALUE   | STOCKUOM | PURCHASERATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 4
            vform.Keypos3 = 5
            vform.keypos4 = 6
            vform.Keypos5 = 7
            vform.Keypos6 = 8
            vform.Keypos7 = 9
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                ' Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)
                Call check_Duplicate(vform.keyfield)
                If Dupchk = True Then
                    ssgrid.Col = 1
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.Text = ""
                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    ssgrid.Focus()
                    Exit Sub
                End If

                Dim SqlQuery As String
                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)
                ssgrid.Col = 3
                SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(vform.keyfield) & "'"
                gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
                If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
                    Call FillTransUOM(Trim(vform.keyfield))
                ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                    ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                Else
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.Text = Trim(vform.keyfield2)
                End If
                'ssgrid.Col = 5
                'ssgrid.Row = ssgrid.ActiveRow

                'If CHK_WAR.Checked = True Then
                '    Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_Indentdate.Value, "dd MMM yyyy"), Trim(vform.keyfield), Trim(TXT_FROMSTORECODE.Text), "Q")
                '    sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(vform.keyfield) & "'"
                '    gconnection.getDataSet(sqlstring, "RATE")
                '    If gdataset.Tables("RATE").Rows.Count > 0 Then
                '        If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                '            ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                '        Else
                '            ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                '        End If
                '        ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                '    End If
                'Else
                '    ' Avgrate = CalAverageRate_new(Trim(vform.keyfield))
                '    ssgrid.Text = Trim(vform.keyfield5)
                'End If
                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
                Dim STRITEMUOM As String
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                STRITEMUOM = ssgrid.Text
                ssgrid.SetText(13, i, clsquantity)
                ssgrid.Col = 7
                ssgrid.Row = ssgrid.ActiveRow
                Dim INDDATE As Date
                INDDATE = Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy")
                'clsquantity = ClosingQuantity_Date(Trim(vform.keyfield), Trim(TXT_FROMSTORECODE.Text), STRITEMUOM, INDDATE)
                ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
                If Val(clsquantity) <= 0 Then
                    MsgBox("Item Has No Stock", MsgBoxStyle.Information, MyCompanyName)
                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                    ssgrid.Text = ""
                    ssgrid.Focus()
                    Exit Sub
                End If
                'Avgrate = CalAverageRate_new(Trim(vform.keyfield), INDDATE, Trim(TXT_FROMSTORECODE.Text), STRITEMUOM)
                'ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(Avgrate), "0.000"))

                '***************** Venu 23August2011
                Dim grndate1 As DateTime
                Dim curuom As String
                Dim currate, prate As Double
                SqlQuery = "select max(grndate) as grndate,itemcode from grn_details WHERE Itemcode ='" & Trim(vform.keyfield) & "' AND grndate <='" & Format(CDate(dtp_Indentdate.Text), "yyyy-MM-dd") & "' group by itemcode"
                gconnection.getDataSet(SqlQuery, "temp")
                If gdataset.Tables("temp").Rows.Count > 0 Then
                    grndate1 = gdataset.Tables("temp").Rows(0).Item("grndate")
                    'grndate1 = Format(CDate(grndate1), "yyyy/MM/dd")
                    ssgrid.Col = 3
                    ssgrid.Row = ssgrid.ActiveRow
                    curuom = Trim(ssgrid.Text)
                    If gsalerate = "Y" Then
                        SqlQuery = "select isnull(salerate,0) as rate from grn_details WHERE grndate = '" & Format(CDate(grndate1), "yyyy-MM-dd") & "' and Itemcode ='" & Trim(vform.keyfield) & "' and uom = '" & Trim(curuom) & "'"
                    Else
                        SqlQuery = "select isnull(rate,0) as rate from grn_details WHERE grndate = '" & Format(CDate(grndate1), "yyyy-MM-dd") & "' and Itemcode ='" & Trim(vform.keyfield) & "' and uom = '" & Trim(curuom) & "'"
                    End If
                    gconnection.getDataSet(SqlQuery, "temp1")
                    If gdataset.Tables("temp1").Rows.Count > 0 Then
                        currate = gdataset.Tables("temp1").Rows(0).Item("rate")
                        ssgrid.Col = 5
                        ssgrid.Row = ssgrid.ActiveRow
                        ssgrid.Text = Format(Val(currate), "0.00")
                        'ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
                    Else
                        If gsalerate = "Y" Then
                            SqlQuery = "select rate = salerate * b.convvalue from inventory_transconversion b, grn_details where itemcode = '" & Trim(vform.keyfield) & "' and grn_details.grndate = '" & Format(CDate(grndate1), "yyyy-MM-dd") & "' and b. baseuom = '" & Trim(curuom) & "' and b.transuom = grn_details.uom "
                        Else
                            SqlQuery = "select rate = rate * b.convvalue from inventory_transconversion b, grn_details where itemcode = '" & Trim(vform.keyfield) & "' and grn_details.grndate = '" & Format(CDate(grndate1), "yyyy-MM-dd") & "' and b. baseuom = '" & Trim(curuom) & "' and b.transuom = grn_details.uom "
                        End If
                        gconnection.getDataSet(SqlQuery, "temp2")
                        If gdataset.Tables("temp2").Rows.Count > 0 Then
                            prate = gdataset.Tables("temp2").Rows(0).Item("rate")
                            ssgrid.Col = 5
                            ssgrid.Row = ssgrid.ActiveRow
                            ssgrid.Text = Format(Val(prate), "0.00")
                            'ssgrid.Text = "0.00"
                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                            ssgrid.Focus()
                        End If
                    End If
                Else
                    ssgrid.Col = 5
                    ssgrid.Row = ssgrid.ActiveRow
                    ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
                End If
                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield4)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try


    End Sub
    Private Sub FillTransUOM(ByVal itemcode As String)
        gSQLString = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK WHERE Itemcode ='" & itemcode & "' "
        If Trim(search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " AND  Tranuom LIKE '" & Trim(search) & "%'"
        End If
        Dim vform1 As New ListOperattion1
        vform1.Field = "TRANUOM"
        vform1.vFormatstring = "     TRANS UOM                                                                                                   "
        vform1.vCaption = " PURCHASE UOMMASTER HELP"
        vform1.KeyPos = 0
        vform1.ShowDialog(Me)
        If Trim(vform1.keyfield & "") <> "" Then
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform1.keyfield & "")
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        End If
        vform1.Close()
        vform1 = Nothing

    End Sub

    Function SelectText() '''-->Select text in cell
        SendKeys.Send("Space")
        SendKeys.Send("{Home}")
        SendKeys.Send("+{End}")
    End Function
    Private Function GridRowLock(ByVal rnum As Integer)

        With ssgrid
            .Row = rnum

            .Col = 2
            .Lock = True

            .Col = 3
            .Lock = True

            .Col = 5
            .Lock = True

            .Col = 6
            .Lock = True

            .Col = 7
            .Lock = True
        End With

    End Function
    Private Function GridLock()
        Dim i As Integer

        With ssgrid
            For i = 1 To .DataRowCnt
                .Row = i
                '.Col = 1
                '.Lock = True

                .Col = 2
                .Lock = True

                .Col = 3
                .Lock = True

                .Col = 5
                .Lock = True

                .Col = 6
                .Lock = True

                .Col = 7
                .Lock = True
            Next i
        End With
    End Function
    Private Function GridRowUnLock()
        Dim i As Integer
        With ssgrid
            For i = 1 To .DataRowCnt
                .Row = i

                .Col = 2
                .Lock = False

                .Col = 3
                .Lock = False

                .Col = 5
                .Lock = False

                .Col = 6
                .Lock = False
            Next i
        End With

    End Function
    Private Function check_Duplicate(ByVal Itemcode As String)
        Dim i As Integer
        Dupchk = False
        ssgrid.Col = 1
        For i = 1 To ssgrid.DataRowCnt
            ssgrid.Row = i
            If i <> ssgrid.ActiveRow Then
                If Trim(ssgrid.Text) = Itemcode Then
                    MsgBox("Item Already exists", MsgBoxStyle.Critical, "Duplicate")
                    Dupchk = True
                End If
            End If
        Next
    End Function
    Private Function fillmenu()
        Dim Avgrate, clsquantity As Double
        Dim K As Integer
        Dim vform As New ListOperattion1
        chkClsQty = True
        Dupchk = False
        chkStorecode = Trim(txt_storecode.Text & "")
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = gSQLString & " ISNULL(clstock,0) AS clstock ,ISNULL(PURCHASERATE,0) AS PURCHASERATE  FROM INVENTORYITEMMASTER AS I "

        If Trim(vsearch) = " " Then
            M_WhereCondition = "WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' "
        Else
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
        End If
        vform.Field = "ITEMNAME,ITEMCODE"
        vform.vFormatstring = "   ITEMCODE   |                         ITEMNAME                         | STOCKUOM     | Clstock   |BASERATE  "
        vform.vCaption = "INVENTORY ITEM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        vform.keypos4 = 4
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Call check_Duplicate(Trim(vform.keyfield))
            If Dupchk = True Then
                Exit Function
            End If
            'Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
            ssgrid.Col = 1
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield)
            ssgrid.Col = 2
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield2)
            ssgrid.Col = 5
            ssgrid.Row = ssgrid.ActiveRow
            If CHK_WAR.Checked = True Then
                'Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_Indentdate.Value, "dd MMM yyyy"), Trim(vform.keyfield), Trim(TXT_FROMSTORECODE.Text), "Q")
                sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(vform.keyfield) & "'"
                gconnection.getDataSet(sqlstring, "RATE")
                If gdataset.Tables("RATE").Rows.Count > 0 Then
                    If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                        ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                    Else
                        ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                    End If
                    ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                End If
            Else
                'Avgrate = CalAverageRate_new(Trim(vform.keyfield), Format(dtp_Indentdate.Value, "dd/MMM/yyyy"), TXT_FROMSTORECODE.Text, Trim(vform.keyfield2))
                ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(Avgrate), "0.00"))
            End If
            clsquantity = ClosingQuantity(Trim(vform.keyfield), TXT_FROMSTORECODE.Text)
            If clsquantity <= 0 Then
                MsgBox("Please Note Stock is Zero", MsgBoxStyle.Information, "Inventory")
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                ssgrid.Focus()
            End If
            ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            Exit Function
        End If
        vform.Close()
        vform = Nothing
    End Function
    Private Sub GridUOM(ByVal i As Integer)
        Try
            Dim Z As Integer
            sqlstring = "SELECT ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMASTER WHERE ISNULL(FREEZE,'') <> 'Y'"
            gconnection.getDataSet(sqlstring, "UOMMASTER1")
            If gdataset.Tables("UOMMASTER1").Rows.Count > 0 Then
                For Z = 0 To gdataset.Tables("UOMMASTER1").Rows.Count - 1
                    ssgrid.Col = 3
                    ssgrid.Row = i
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("UOMMASTER1").Rows(Z).Item("UOMDESC"))
                    ssgrid.Text = Trim(gdataset.Tables("UOMMASTER1").Rows(Z).Item("UOMDESC"))
                    ssgrid.Lock = True
                Next Z
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM STOREMASTER   "
        M_WhereCondition = " where freeze <> 'Y' AND STORESTATUS<>'M' "
        Dim vform As New ListOperattion1
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
        vform.vCaption = "DEPARTMENT MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_storecode.Text = Trim(vform.keyfield & "")
            txt_storeDesc.Text = Trim(vform.keyfield1 & "")
            cbo_type.Focus()
        End If
        If gindentno = "Y" Then
            doctype = Trim(txt_storecode.Text)
            Call autogenerate()
            TXT_FROMSTORECODE.Focus()
        Else
            TXT_FROMSTORECODE.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_IndentNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_IndentNo.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If cmd_indentnoHelp.Enabled = True Then
                    search = Trim(txt_IndentNo.Text)
                    Call cmd_indentnoHelp_Click(cmd_indentnoHelp, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_IndentNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_IndentNo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_IndentNo.Text) = "" Then
                    Call cmd_indentnoHelp_Click(cmd_indentnoHelp, e)
                Else
                    txt_IndentNo_Validated(txt_IndentNo, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_indentnoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_indentnoHelp.Click
        Try
            gSQLString = "SELECT indent_no,indent_date FROM inventory_indenthdr"
            M_WhereCondition = "  "
            Dim vform As New List_Operation
            vform.Field = "INDENT_NO,INDENT_DATE"
            vform.vFormatstring = "       INDENT_NO                  |     INDENT_DATE                                                           "
            vform.vCaption = "STOCK INDENT HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_IndentNo.Text = Trim(vform.keyfield & "")
                ssgrid.ClearRange(1, 1, -1, -1, True)
                Call txt_IndentNo_Validated(txt_IndentNo, e)
                dtp_Indentdate.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_IndentNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IndentNo.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks As String
        Dim vTypeseqno, Clsquantity, vGroupseqno As Double
        Try
            If Trim(txt_IndentNo.Text) <> "" Then
                sqlstring = " SELECT ISNULL(H.INDENT_NO,'') AS INDENT_NO,H.INDENT_DATE AS INDENT_DATE,ISNULL(FROMSTORECODE,'') FROMSTORECODE , ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.PRODUCT_TYPE,'') AS PRODUCT_TYPE,"
                sqlstring = sqlstring & " ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(H.VOID,'') AS VOID,"
                sqlstring = sqlstring & " ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATETIME,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME , isnull(updfooter,'') as updfooter,isnull(updsign,'') as updsign "
                sqlstring = sqlstring & " FROM INVENTORY_INDENTHDR AS H "
                sqlstring = sqlstring & " WHERE INDENT_NO='" & txt_IndentNo.Text & "'"
                gconnection.getDataSet(sqlstring, "INDENTHDR")
                '''************************************************* SELECT RECORD FROM INDENTHDR *********************************************''''                
                If gdataset.Tables("INDENTHDR").Rows.Count > 0 Then
                    cmd_Add.Text = "Update[F7]"
                    Me.txt_IndentNo.ReadOnly = True
                    'VSTRDOCNO = Trim(txt_Docno.Text)
                    txt_IndentNo.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_NO") & "")
                    dtp_Indentdate.Value = Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_DATE")), "dd-MM-yyyy")
                    TXT_FROMSTORECODE.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("fromStoreCode") & "")
                    Call TXT_FROMSTORECODE_Validated(txt_IndentNo.Text, e)
                    txt_storecode.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONCODE"))
                    txt_storeDesc.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONNAME"))
                    cbo_type.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("PRODUCT_TYPE"))
                    remarks = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    Txt_footer.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("updfooter"))
                    Txt_signature.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("updsign"))
                    If gdataset.Tables("INDENTHDR").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("UPDATETIME")), "dd-MMM-yyyy")
                        Me.Cmd_FREEZE.Enabled = True
                        Me.cmd_Add.Enabled = False
                        Me.Cmd_FREEZE.Text = "UnVoid[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_FREEZE.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_FREEZE.Text = "Void[F8]"
                    End If
                    '''************************************************* SELECT RECORD FROM INDENTDETAILS *********************************************''''                
                    Dim strsql As String
                    Dim STRITEMCODE, STRITEMUOM As String
                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT , ISNULL(CLSQTY,0) CLSQTY"
                    sqlstring = sqlstring & " FROM INVENTORY_INDENTDET WHERE  INDENT_NO ='" & Trim(txt_IndentNo.Text) & "' ORDER BY AUTOID"
                    gconnection.getDataSet(sqlstring, "INDENTDETAILS")
                    If gdataset.Tables("INDENTDETAILS").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("INDENTDETAILS").Rows.Count
                            Call GridUOM(i) '''---> FILL GRID UOM
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                            STRITEMUOM = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("AMOUNT")), "0.00"))

                            Dim INDDATE As Date
                            INDDATE = Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy")

                            'Clsquantity = ClosingQuantity_Date(STRITEMCODE, Trim(TXT_FROMSTORECODE.Text), STRITEMUOM, INDDATE)
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("clsqty")), "0.00"))
                            j = j + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    ssgrid.SetActiveCell(1, 1)
                    Call Calculate()
                Else
                    dtp_Indentdate.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMenuItem()
        Dim Avgrate, clsquantity As Double
        Dim K As Integer
        Dim vform As New ListOperattion1
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 

        gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER AS I "

        If Trim(vsearch) = " " Then
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' "
        Else
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND I.ITEMNAME LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
        End If
        vform.Field = "I.ITEMNAME,I.ITEMCODE"
        vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | STOCKUOM    "
        vform.vCaption = "INVENTORY ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            ssgrid.Col = 1
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield)
            ssgrid.Col = 2
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Col = 5
            ssgrid.Row = ssgrid.ActiveRow

            If CHK_WAR.Checked = True Then
                'Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_Indentdate.Value, "dd MMM yyyy"), Trim(vform.keyfield), Trim(TXT_FROMSTORECODE.Text), "Q")
                sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(vform.keyfield) & "'"
                gconnection.getDataSet(sqlstring, "RATE")
                If gdataset.Tables("RATE").Rows.Count > 0 Then
                    If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                        ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                    Else
                        ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                    End If
                    ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                End If
            Else
                'Avgrate = CalAverageRate_new(Trim(vform.keyfield), Format(dtp_Indentdate.Value, "dd/MMM/yyyy"), TXT_FROMSTORECODE.Text)
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                clsquantity = ClosingQuantity(Trim(vform.keyfield), TXT_FROMSTORECODE.Text)
                ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
            End If
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            Exit Sub
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub FillMenuItemNew()
        Dim Avgrate, clsquantity As Double
        Dim K As Integer
        Dim vform As New ListOperattion1
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 

        gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
        gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER AS I "

        If Trim(vsearch) = " " Then
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' "
        Else
            M_WhereCondition = " WHERE I.STORECODE = '" & Trim(TXT_FROMSTORECODE.Text) & "' AND I.ITEMNAME LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
        End If
        vform.Field = "I.ITEMNAME,I.ITEMCODE"
        vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | STOCKUOM    "
        vform.vCaption = "INVENTORY ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            ssgrid.Col = 1
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield)
            ssgrid.Col = 2
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Col = 5
            ssgrid.Row = ssgrid.ActiveRow
            If CHK_WAR.Checked = True Then
                'Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_Indentdate.Value, "dd MMM yyyy"), Trim(vform.keyfield), Trim(TXT_FROMSTORECODE.Text), "Q")
                sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(vform.keyfield) & "'"
                gconnection.getDataSet(sqlstring, "RATE")
                If gdataset.Tables("RATE").Rows.Count > 0 Then
                    If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                        ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                    Else
                        ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                    End If
                    ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                End If
            Else
                'Avgrate = CalAverageRate_new(Trim(vform.keyfield), Format(dtp_Indentdate.Value, "dd/MMM/yyyy"), TXT_FROMSTORECODE.Text)
                ssgrid.Text = Format(Val(Avgrate), "0.00")
                clsquantity = ClosingQuantity(Trim(vform.keyfield), TXT_FROMSTORECODE.Text)
                ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(clsquantity), "0.000"))
            End If
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            Exit Sub
        End If
        vform.Close()
        vform = Nothing
    End Sub


    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub dtp_Indentdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Indentdate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_storecode.Focus()
        End If
    End Sub

    Private Sub cbo_type_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            ssgrid.Focus()
        End If
    End Sub
    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE '%" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
            gconnection.getDataSet(SQLSTRING, "USER")
            If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                    With gdataset.Tables("USER").Rows(i)
                        chstr = abcdMINUS(.Item("RIGHTS"))
                    End With
                Next
            End If
            Me.cmd_Add.Enabled = False
            Me.Cmd_FREEZE.Enabled = False
            Me.cmd_View.Enabled = False
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            If Len(chstr) > 0 Then
                Dim Right() As Char
                Right = chstr.ToCharArray
                For x = 0 To Right.Length - 1
                    If Right(x) = "A" Then
                        Me.cmd_Add.Enabled = True
                        Me.Cmd_FREEZE.Enabled = True
                        Me.cmd_View.Enabled = True
                        Exit Sub
                    End If
                    If UCase(Mid(Me.cmd_Add.Text, 1, 1)) = "A" Then
                        If Right(x) = "S" Then
                            Me.cmd_Add.Enabled = True
                        End If
                    Else
                        If Right(x) = "M" Then
                            Me.cmd_Add.Enabled = True
                        End If
                    End If
                    If Right(x) = "D" Then
                        Me.Cmd_FREEZE.Enabled = True
                    End If
                    If Right(x) = "V" Then
                        Me.cmd_View.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        Try
            Dim temp, temp1 As String
            temp = Trim(TXT_FROMSTORECODE.Text)
            temp1 = Trim(txt_FromStorename.Text)
            Call clearform(Me)
            TXT_FROMSTORECODE.Text = temp
            txt_FromStorename.Text = temp1
            txt_IndentNo.ReadOnly = False
            Call FOOTER()
            grp_footer.Visible = False
            Me.lbl_Freeze.Visible = False
            Me.dtp_Indentdate.Value = Format(Now, "dd/MM/yyyy")
            Me.lbl_Freeze.Text = "Record Void  On "
            Call GridRowUnLock()
            txt_Remarks.Text = ""
            ssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_FREEZE.Text = "Void [F8]"
            cmd_Add.Text = "Add [F7]"
            ssgrid.SetActiveCell(1, 1)
            cmd_Add.Enabled = True
            Cmd_FREEZE.Enabled = True
            Me.Cmd_FREEZE.Enabled = True
            If gindentno = "Y" Then
                txt_storecode.Focus()
            Else
                txt_IndentNo.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Show()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub autogenerate()
        Try
            Dim sqlstring, financalyear As String
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            docno = doctype
            sqlstring = "SELECT MAX(SUBSTRING(DOCNO,1,5)) FROM INVENTORY_INDENTHDR WHERE storelocationcode ='" & docno & "'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_IndentNo.Text = docno & "/00001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_IndentNo.Text = docno & "/" & Format(gdreader(0) + 1, "00000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_IndentNo.Text = docno & "/00001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_storecode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_storecode.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_storecode.Text = "" Then
                Call cmd_storecode_Click(cmd_storecode, e)
                TXT_FROMSTORECODE.Focus()
            Else
                sqlstring = " SELECT DISTINCT(storecode),storedesc FROM STOREMASTER "
                sqlstring = sqlstring & " WHERE STORECODE = '" & txt_storecode.Text & "' AND freeze <> 'Y' AND STORESTATUS<>'M' "
                gconnection.getDataSet(sqlstring, "STOREMASTER1")
                If gdataset.Tables("STOREMASTER1").Rows.Count > 0 Then
                    txt_storeDesc.Text = gdataset.Tables("STOREMASTER1").Rows(0).Item("STOREDESC")
                    TXT_FROMSTORECODE.Focus()
                Else
                    txt_storecode.Text = ""
                    txt_IndentNo.Text = ""
                    txt_storecode.Focus()
                End If
            End If
            If gindentno = "Y" Then
                If Trim(txt_storecode.Text) <> "" Then
                    doctype = Trim(txt_storecode.Text)
                    Call autogenerate()
                    TXT_FROMSTORECODE.Focus()
                Else
                    txt_storecode.Focus()
                End If
            Else
                TXT_FROMSTORECODE.Focus()
            End If
        End If
    End Sub
    Public Function ReportDetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMNO As String, ByVal TONO As String)
        Dim DBLDOCTOTAL, DBLGROUPTOTAL, DBLGRANDTOTAL, TOTQTY As Double
        Dim dbltaxamount As Double
        Dim FROMSTORE, STROEDESC, DOCDETAILS, SSql As String
        Dim STOREBOOL, DOCBOOL As Boolean
        Dim I, J, K, CC, ItemCnt As Integer
        Dim dr As DataRow
        Dim dc As DataColumn
        Dim pageno As Integer
        Dim pagesize As Integer
        Dim gconnection As New GlobalClass

        Try
            ItemCnt = 0
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            DBLGRANDTOTAL = 0
            TOTQTY = 0
            gconnection.getDataSet(SQLSTRING, "INDENT")

            If gdataset.Tables("INDENT").Rows.Count > 0 Then
                SSql = " SELECT STOREDESC FROM STOREMASTER WHERE STORECODE = '" & gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE") & "' "
                gconnection.getDataSet(SSql, "FROMSTORE")
                If gdataset.Tables("FROMSTORE").Rows.Count > 0 Then
                    FROMSTORE = gdataset.Tables("FROMSTORE").Rows(0).Item("STOREDESC")
                End If
            Else
                MsgBox("NO DATA FOUND", MsgBoxStyle.Critical, "INVENTORY")
                Exit Function
            End If

            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine(Space(50) & Chr(14) & Chr(15) & "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 5
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(18) & Chr(27) & "E")
            Filewrite.WriteLine(Space(39 - Len(Trim(Mid(MyCompanyName, 1, 30))) / 2) & Mid(MyCompanyName, 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine(Space(39 - Len(Trim(Mid(PAGEHEAD(0), 1, 30))) / 2) & Trim(Mid(PAGEHEAD(0), 1, 30)))
            pagesize = pagesize + 1

            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine(Space(43) & "INDENT NO   : " & Space(12 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("INDENT_NO"))), 1, 12))) & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("INDENT_NO"))), 1, 12))
            Filewrite.WriteLine(Space(43) & "INDENT DATE : " & Space(12 - Len(Mid(Format(CDate(gdataset.Tables("INDENT").Rows(K).Item("INDENT_DATE")), "dd/MM/yyyy"), 1, 12))) & Mid(Format(CDate(gdataset.Tables("INDENT").Rows(K).Item("INDENT_DATE")), "dd/MM/yyyy"), 1, 12))
            pagesize = pagesize + 2
            Filewrite.WriteLine()
            pagesize = pagesize + 1

            Filewrite.WriteLine(" FROM : -" & Space(34) & "TO : -" & Chr(27) & "F")
            Filewrite.Write(Chr(27) & "E" & " DEPT CODE : " & Chr(27) & "F" & Trim(gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE")))
            Filewrite.Write(Space(30 - Len(Trim(gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE")))))
            Filewrite.WriteLine(Chr(27) & "E" & " DEPT CODE : " & Chr(27) & "F" & Trim(gdataset.Tables("INDENT").Rows(0).Item("STORELOCATIONCODE")))

            Filewrite.Write(Chr(27) & "E" & " DEPT NAME : " & Chr(27) & "F" & FROMSTORE & Space(30 - Len(FROMSTORE)))
            Filewrite.WriteLine(Chr(27) & "E" & " DEPT NAME : " & Chr(27) & "F" & Trim(gdataset.Tables("INDENT").Rows(0).Item("STORELOCATIONNAME")))
            Filewrite.WriteLine()
            pagesize = pagesize + 4

            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 4
            Filewrite.WriteLine("SNO CODE     ITEM NAME                 UOM         QTY       RATE        AMOUNT ")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "-"))
            pagesize = pagesize + 1

            If gdataset.Tables("INDENT").Rows.Count > 0 Then
                For K = 0 To gdataset.Tables("INDENT").Rows.Count - 1
                    If pagesize > 58 Then
                        Filewrite.WriteLine(StrDup(82, "-"))
                        Filewrite.WriteLine(Chr(12))
                        pagesize = 0

                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()

                        Filewrite.WriteLine(StrDup(80, "-"))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine("SNO CODE       ITEM NAME                 UOM         QTY       RATE        AMOUNT ")

                        pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(80, "-"))
                        pagesize = pagesize + 1
                        pageno = pageno + 1
                    End If

                    SSql = Space(3 - Len(Trim(Mid(CStr(K + 1), 1, 3)))) & Trim(Mid(CStr(K + 1), 1, 3)) & Space(1)
                    SSql = SSql & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMCODE"))), 1, 8) & Space(8 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMCODE"))), 1, 8))) & Space(1)
                    SSql = SSql & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMNAME"))), 1, 25) & Space(25 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("ITEMNAME"))), 1, 25))) & Space(1)
                    SSql = SSql & Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("UOM"))), 1, 5) & Space(5 - Len(Mid(Trim(CStr(gdataset.Tables("INDENT").Rows(K).Item("UOM"))), 1, 5))) & Space(1)
                    SSql = SSql & Space(10 - Len(Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("QTY")), "0.000"), 1, 10))) & Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("QTY")), "0.000"), 1, 10) & Space(1)
                    SSql = SSql & Space(10 - Len(Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("RATE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("RATE")), "0.00"), 1, 10) & Space(1)
                    SSql = SSql & Space(12 - Len(Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("AMOUNT")), "##,##0.00"), 1, 12))) & Mid(Format(Val(gdataset.Tables("INDENT").Rows(K).Item("AMOUNT")), "##,##0.00"), 1, 12)

                    DBLGRANDTOTAL = DBLGRANDTOTAL + Val(gdataset.Tables("INDENT").Rows(K).Item("AMOUNT"))
                    TOTQTY = TOTQTY + Val(gdataset.Tables("INDENT").Rows(K).Item("QTY"))
                    Filewrite.WriteLine(SSql)

                    pagesize = pagesize + 1
                    ItemCnt = ItemCnt + 1

                Next K
                CC = 0
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.WriteLine(Chr(27) & "E" & Space(31) & "TOTAL :" & Space(15 - Len(Format(TOTQTY, "0.000"))) & Format(TOTQTY, "##,##0.00") & Space(12) & Space(12 - Len(Format(DBLGRANDTOTAL, "##,##0.00"))) & Format(DBLGRANDTOTAL, "##,##0.00") & Chr(27) & "F")
                Filewrite.WriteLine(StrDup(79, "-"))
                Filewrite.WriteLine("")
                Filewrite.WriteLine(Space(0) & " Remarks:" & Trim(gdataset.Tables("INDENT").Rows(0).Item("remarks")))
                pagesize = pagesize + 3
                If pagesize < 50 Then
                    For I = 0 To (50 - pagesize)
                        Filewrite.WriteLine()
                    Next
                End If

                If gdataset.Tables("INDENT").Rows(0).Item("updfooter") <> "" And gdataset.Tables("INDENT").Rows(0).Item("FROMSTORECODE") <> "DRR" Then
                    Filewrite.WriteLine(Chr(27) & "E" & Trim(gdataset.Tables("INDENT").Rows(0).Item("updfooter")) & Chr(27) & "F")
                    Filewrite.WriteLine(Chr(12))
                Else
                    Filewrite.WriteLine(Chr(27) & "E" & " Indent By         Supervisor          Initials of Issues         Received by " & Chr(27) & "F")
                    Filewrite.WriteLine(Chr(12))
                End If
            Else
                MessageBox.Show("NO RECORD TO BE DISPLAYED", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        ''''Try
        ''''    gPrint = True
        ''''    Call printoperation()
        ''''Catch ex As Exception
        ''''    MessageBox.Show("Plz Check Error : Print Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ''''    Exit Sub
        ''''End Try

        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r
            sqlstring = sqlstring & " SELECT 	ISNULL(INDENT_NO,'') INDENT_NO, ISNULL(INDENT_DATE,'')  INDENT_DATE,"
            sqlstring = sqlstring & " ISNULL(FROMSTORECODE,'') FROMSTORECODE , ISNULL(STORELOCATIONCODE,'') STORELOCATIONCODE, ISNULL(STORELOCATIONNAME,'') STORELOCATIONNAME,"
            sqlstring = sqlstring & " ISNULL(PRODUCT_TYPE,'') PRODUCT_TYPE, ISNULL(REMARKS,'') REMARKS,ISNULL(updsign,'') updsign,ISNULL(updfooter,'') updfooter,"
            sqlstring = sqlstring & "	ISNULL(ITEMCODE,'') ITEMCODE, ISNULL(ITEMNAME,'') ITEMNAME, ISNULL(UOM,'') UOM,"
            sqlstring = sqlstring & " ISNULL(QTY,0) QTY, ISNULL(RATE,0) RATE, ISNULL(AMOUNT,0) AMOUNT, ISNULL(CLSQTY,0) CLSQTY"
            sqlstring = sqlstring & " FROM VW_INV_IDENTBILL"
            ' Sqlstring = Sqlstring & " INNER JOIN INVENTORY_INDENTDET AS DET ON HDR.INDENT_NO = DET.INDENT_NO"
            sqlstring = sqlstring & " WHERE INDENT_NO BETWEEN '" & Trim(txt_IndentNo.Text) & "' AND '" & Trim(txt_IndentNo.Text) & "'"

            gconnection.getDataSet(sqlstring, "VW_INV_IDENTBILL")

            SSQL = " SELECT STOREDESC FROM STOREMASTER WHERE STORECODE = '" & gdataset.Tables("VW_INV_IDENTBILL").Rows(0).Item("FROMSTORECODE") & "' "
            gconnection.getDataSet(SSQL, "FROMSTORE")
            If gdataset.Tables("FROMSTORE").Rows.Count > 0 Then
                FROMSTORE = gdataset.Tables("FROMSTORE").Rows(0).Item("STOREDESC")
            End If
            If gdataset.Tables("VW_INV_IDENTBILL").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VW_INV_IDENTBILL"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text21")
                textobj2.Text = gUsername
                Dim textobj As TextObject
                textobj = r.ReportDefinition.ReportObjects("Text17")
                textobj.Text = FROMSTORE
                rViewer.Show()
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : View Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub TXT_FROMSTORECODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FROMSTORECODE.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(TXT_FROMSTORECODE.Text) = "" Then
                Call cmd_fromStorecodeHelp_Click(TXT_FROMSTORECODE.Text, e)
            Else
                Call TXT_FROMSTORECODE_Validated(TXT_FROMSTORECODE.Text, e)
            End If
        End If
    End Sub

    Private Sub cmd_fromStorecodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_fromStorecodeHelp.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' and STORESTATUS='M'"
        Dim vform As New ListOperattion1
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
        vform.vCaption = "INVENTORY STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_FROMSTORECODE.Text = Trim(vform.keyfield & "")
            txt_FromStorename.Text = Trim(vform.keyfield1 & "")
        Else
            Call TXT_FROMSTORECODE_Validated(TXT_FROMSTORECODE.Text, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub TXT_FROMSTORECODE_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.Validated
        If Trim(TXT_FROMSTORECODE.Text) <> "" Then
            sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(TXT_FROMSTORECODE.Text) & "' AND ISNULL(Freeze,'') <> 'Y' and STORESTATUS='M'"
            gconnection.getDataSet(sqlstring, "storemaster")
            If gdataset.Tables("storemaster").Rows.Count > 0 Then
                TXT_FROMSTORECODE.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
                txt_FromStorename.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
                ssgrid.Focus()
                ssgrid.SetActiveCell(1, 1)
            Else
                TXT_FROMSTORECODE.Text = ""
                TXT_FROMSTORECODE.Focus()
            End If
        End If
    End Sub

    Private Sub txt_IndentNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IndentNo.GotFocus
        txt_IndentNo.BackColor = Color.Gold
        Label16.Visible = True
    End Sub

    Private Sub txt_IndentNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_IndentNo.LostFocus
        txt_IndentNo.BackColor = Color.Wheat
        Label16.Visible = False
    End Sub

    Private Sub txt_storecode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_storecode.GotFocus
        txt_storecode.BackColor = Color.Gold
    End Sub

    Private Sub txt_storecode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_storecode.LostFocus
        txt_storecode.BackColor = Color.Wheat
    End Sub
    Private Sub TXT_FROMSTORECODE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.GotFocus
        TXT_FROMSTORECODE.BackColor = Color.Gold
    End Sub

    Private Sub TXT_FROMSTORECODE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.LostFocus
        TXT_FROMSTORECODE.BackColor = Color.Wheat
    End Sub

    Private Sub dtp_Indentdate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Indentdate.GotFocus
        dtp_Indentdate.BackColor = Color.Gold
    End Sub

    Private Sub dtp_Indentdate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Indentdate.LostFocus
        dtp_Indentdate.BackColor = Color.Wheat
    End Sub

    Private Sub ssgrid_EnterRow(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_EnterRowEvent) Handles ssgrid.EnterRow
        MsgBox("enter row")
    End Sub

    Private Sub Chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_item.CheckedChanged
        If Chk_item.Checked = True Then
            grp_footer.Visible = True
            Txt_footer.Focus()
        Else
            grp_footer.Visible = False
        End If
    End Sub

    Private Sub Txt_footer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_footer.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(Txt_footer.Text) <> "" Then
                Txt_signature.Focus()
            Else
                Txt_footer.Focus()
            End If
        End If
    End Sub
    Private Sub Txt_signature_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_signature.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Chk_item.Focus()
        End If
    End Sub
    Public Function FOOTER()
        sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign FROM INVENTORY_INDENTHDR WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM INVENTORY_INDENTHDR )"
        gconnection.getDataSet(sqlstring, "INVENTORY_INDENTHDR")
        If gdataset.Tables("INVENTORY_INDENTHDR").Rows.Count > 0 Then
            Txt_footer.Text = Trim(gdataset.Tables("INVENTORY_INDENTHDR").Rows(0).Item("UPDFOOTER"))
            Txt_signature.Text = Trim(gdataset.Tables("INVENTORY_INDENTHDR").Rows(0).Item("UPdsign"))
        End If
    End Function

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub

    Private Sub txt_IndentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_IndentNo.TextChanged

    End Sub

    Private Sub TXT_FROMSTORECODE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_FROMSTORECODE.TextChanged

    End Sub

    Private Sub ssgrid_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles ssgrid.Invalidated

    End Sub

    Private Sub lbl_Heading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Heading.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim REP As New report_det
        REP.Show()
        With REP.ssgrid
            .Row = 1
            .Text = "1. IN AUTHORISATION USER CAN MODIFY INDENT IN TERMS OF QTY AND ITEM QTY!>INDENT QTY OR NEW ITEM CANNOT BE ADDED YES HE CAN DELETE SOME ITEM."
            .Row = 2
            .Text = "2. AUTHORISATION DOC IS MANDATORY ."
            .Row = 3
            .Text = "3. ONE INDENT HE CAN CONSIDER AS MANY TIME HE WANT BUT TOTAL OF ALL AUTHORISATION CAN NOT BE MORE THAN INDENT."
            .Row = 4
            .Text = "4. AUTO NO TO BE GENERATED FOR DOC."
            .Row = 5
            .Text = "5. DOC DATE WILL BE ALWAYS SERVER DATE."
            '.Row = 6
            '.Text = "6. TOT AMT IS THE DEPRECIATED VALUE AS ON TO DATE"
            '.Row = 7
            '.Text = "7. TOT AMT IS THE DEPRECIATED VALUE AS ON TO DATE"
        End With
        System.Diagnostics.Process.Start(AppPath & "\STUDY\POAUTHORISATION.XLS")
    End Sub
End Class
