namespace NIRs_Virtual_Serial_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comPort = new System.IO.Ports.SerialPort(this.components);
            this.button_connect_comPort = new System.Windows.Forms.Button();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.label_ports = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commanedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_configuration = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Test = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_service = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_port = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_connectPort = new System.Windows.Forms.Panel();
            this.button_disconnectComPort = new System.Windows.Forms.Button();
            this.sensorSelect = new System.Windows.Forms.Panel();
            this.checkBox_O1 = new System.Windows.Forms.CheckBox();
            this.checkBox_T5 = new System.Windows.Forms.CheckBox();
            this.checkBox_T3 = new System.Windows.Forms.CheckBox();
            this.checkBox_F7 = new System.Windows.Forms.CheckBox();
            this.checkBox_O2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Fp1 = new System.Windows.Forms.CheckBox();
            this.checkBox_T6 = new System.Windows.Forms.CheckBox();
            this.checkBox_Fp2 = new System.Windows.Forms.CheckBox();
            this.checkBox_F8 = new System.Windows.Forms.CheckBox();
            this.checkBox_T4 = new System.Windows.Forms.CheckBox();
            this.panel_configuration = new System.Windows.Forms.Panel();
            this.label_Channel0 = new System.Windows.Forms.Label();
            this.label_pwmIrValue = new System.Windows.Forms.Label();
            this.label_pwmRedValue = new System.Windows.Forms.Label();
            this.textBox_pwmIrValue = new System.Windows.Forms.TextBox();
            this.textBox_pwmRedValue = new System.Windows.Forms.TextBox();
            this.comboBox_testDuration = new System.Windows.Forms.ComboBox();
            this.button_sensorSelectChange = new System.Windows.Forms.Button();
            this.button_sensorSelectConfirm = new System.Windows.Forms.Button();
            this.label_configurationHeader = new System.Windows.Forms.Label();
            this.comboBox_sampleRate = new System.Windows.Forms.ComboBox();
            this.label_testDuration = new System.Windows.Forms.Label();
            this.label_sampleRate = new System.Windows.Forms.Label();
            this.label_Calibrate = new System.Windows.Forms.Label();
            this.button_runLedCalibration = new System.Windows.Forms.Button();
            this.label_sensorSelect = new System.Windows.Forms.Label();
            this.panel_mainMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_deviceSetup = new System.Windows.Forms.Button();
            this.button_newTest = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_test = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_startTest = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.progressBar_sensor5 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor4 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor3 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor2 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor1 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor10 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor9 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor8 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor7 = new System.Windows.Forms.ProgressBar();
            this.progressBar_sensor6 = new System.Windows.Forms.ProgressBar();
            this.textBox_patientName = new System.Windows.Forms.TextBox();
            this.label_testHeader = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_connectPort.SuspendLayout();
            this.sensorSelect.SuspendLayout();
            this.panel_configuration.SuspendLayout();
            this.panel_mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // comPort
            // 
            this.comPort.BaudRate = 115200;
            this.comPort.ReadBufferSize = 1000000;
            // 
            // button_connect_comPort
            // 
            this.button_connect_comPort.Location = new System.Drawing.Point(314, 206);
            this.button_connect_comPort.Name = "button_connect_comPort";
            this.button_connect_comPort.Size = new System.Drawing.Size(94, 38);
            this.button_connect_comPort.TabIndex = 0;
            this.button_connect_comPort.Text = "Connect";
            this.button_connect_comPort.UseVisualStyleBackColor = true;
            this.button_connect_comPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(280, 161);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(159, 24);
            this.comboBox_ports.TabIndex = 3;
            this.comboBox_ports.DropDown += new System.EventHandler(this.comboBox_ports_DropDown);
            this.comboBox_ports.SelectedIndexChanged += new System.EventHandler(this.comboBox_ports_SelectedIndexChanged);
            // 
            // label_ports
            // 
            this.label_ports.AutoSize = true;
            this.label_ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ports.Location = new System.Drawing.Point(274, 112);
            this.label_ports.Name = "label_ports";
            this.label_ports.Size = new System.Drawing.Size(165, 32);
            this.label_ports.TabIndex = 4;
            this.label_ports.Text = "Select Port";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commanedToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(844, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commanedToolStripMenuItem
            // 
            this.commanedToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.commanedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_configuration,
            this.ToolStripMenuItem_Test,
            this.ToolStripMenuItem_service});
            this.commanedToolStripMenuItem.Name = "commanedToolStripMenuItem";
            this.commanedToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.commanedToolStripMenuItem.Text = "MODE SELECT";
            // 
            // ToolStripMenuItem_configuration
            // 
            this.ToolStripMenuItem_configuration.Name = "ToolStripMenuItem_configuration";
            this.ToolStripMenuItem_configuration.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItem_configuration.Text = "Configuation ";
            this.ToolStripMenuItem_configuration.Click += new System.EventHandler(this.ToolStripMenuItem_configuration_Click);
            // 
            // ToolStripMenuItem_Test
            // 
            this.ToolStripMenuItem_Test.Name = "ToolStripMenuItem_Test";
            this.ToolStripMenuItem_Test.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItem_Test.Text = "Patient Mode";
            this.ToolStripMenuItem_Test.Click += new System.EventHandler(this.ToolStripMenuItem_Test_Click);
            // 
            // ToolStripMenuItem_service
            // 
            this.ToolStripMenuItem_service.Name = "ToolStripMenuItem_service";
            this.ToolStripMenuItem_service.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItem_service.Text = "Service Mode";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(164, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(133, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_port});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_port
            // 
            this.toolStripStatusLabel_port.Name = "toolStripStatusLabel_port";
            this.toolStripStatusLabel_port.Size = new System.Drawing.Size(148, 20);
            this.toolStripStatusLabel_port.Text = "Device Disconnected";
            this.toolStripStatusLabel_port.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_connectPort
            // 
            this.panel_connectPort.BackColor = System.Drawing.Color.Lavender;
            this.panel_connectPort.Controls.Add(this.button_connect_comPort);
            this.panel_connectPort.Controls.Add(this.comboBox_ports);
            this.panel_connectPort.Controls.Add(this.label_ports);
            this.panel_connectPort.Controls.Add(this.button_disconnectComPort);
            this.panel_connectPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_connectPort.Location = new System.Drawing.Point(0, 0);
            this.panel_connectPort.Name = "panel_connectPort";
            this.panel_connectPort.Size = new System.Drawing.Size(844, 578);
            this.panel_connectPort.TabIndex = 11;
            // 
            // button_disconnectComPort
            // 
            this.button_disconnectComPort.Location = new System.Drawing.Point(314, 206);
            this.button_disconnectComPort.Name = "button_disconnectComPort";
            this.button_disconnectComPort.Size = new System.Drawing.Size(94, 38);
            this.button_disconnectComPort.TabIndex = 5;
            this.button_disconnectComPort.Text = "Disconnect";
            this.button_disconnectComPort.UseVisualStyleBackColor = true;
            this.button_disconnectComPort.Visible = false;
            this.button_disconnectComPort.Click += new System.EventHandler(this.button_disconnectComPort_Click);
            // 
            // sensorSelect
            // 
            this.sensorSelect.BackColor = System.Drawing.Color.White;
            this.sensorSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sensorSelect.BackgroundImage")));
            this.sensorSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sensorSelect.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sensorSelect.Controls.Add(this.checkBox_O1);
            this.sensorSelect.Controls.Add(this.checkBox_T5);
            this.sensorSelect.Controls.Add(this.checkBox_T3);
            this.sensorSelect.Controls.Add(this.checkBox_F7);
            this.sensorSelect.Controls.Add(this.checkBox_O2);
            this.sensorSelect.Controls.Add(this.checkBox_Fp1);
            this.sensorSelect.Controls.Add(this.checkBox_T6);
            this.sensorSelect.Controls.Add(this.checkBox_Fp2);
            this.sensorSelect.Controls.Add(this.checkBox_F8);
            this.sensorSelect.Controls.Add(this.checkBox_T4);
            this.sensorSelect.Enabled = false;
            this.sensorSelect.Location = new System.Drawing.Point(556, 163);
            this.sensorSelect.Name = "sensorSelect";
            this.sensorSelect.Size = new System.Drawing.Size(252, 247);
            this.sensorSelect.TabIndex = 9;
            // 
            // checkBox_O1
            // 
            this.checkBox_O1.AutoSize = true;
            this.checkBox_O1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_O1.Location = new System.Drawing.Point(89, 196);
            this.checkBox_O1.Name = "checkBox_O1";
            this.checkBox_O1.Size = new System.Drawing.Size(18, 17);
            this.checkBox_O1.TabIndex = 29;
            this.checkBox_O1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_O1.UseVisualStyleBackColor = false;
            this.checkBox_O1.CheckedChanged += new System.EventHandler(this.checkBox_O1_CheckedChanged);
            // 
            // checkBox_T5
            // 
            this.checkBox_T5.AutoSize = true;
            this.checkBox_T5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_T5.Location = new System.Drawing.Point(59, 165);
            this.checkBox_T5.Name = "checkBox_T5";
            this.checkBox_T5.Size = new System.Drawing.Size(18, 17);
            this.checkBox_T5.TabIndex = 28;
            this.checkBox_T5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_T5.UseVisualStyleBackColor = false;
            this.checkBox_T5.CheckedChanged += new System.EventHandler(this.checkBox_T5_CheckedChanged);
            // 
            // checkBox_T3
            // 
            this.checkBox_T3.AutoSize = true;
            this.checkBox_T3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_T3.Location = new System.Drawing.Point(43, 119);
            this.checkBox_T3.Name = "checkBox_T3";
            this.checkBox_T3.Size = new System.Drawing.Size(18, 17);
            this.checkBox_T3.TabIndex = 27;
            this.checkBox_T3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_T3.UseVisualStyleBackColor = false;
            this.checkBox_T3.CheckedChanged += new System.EventHandler(this.checkBox_T3_CheckedChanged);
            // 
            // checkBox_F7
            // 
            this.checkBox_F7.AutoSize = true;
            this.checkBox_F7.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_F7.Location = new System.Drawing.Point(59, 81);
            this.checkBox_F7.Name = "checkBox_F7";
            this.checkBox_F7.Size = new System.Drawing.Size(18, 17);
            this.checkBox_F7.TabIndex = 26;
            this.checkBox_F7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_F7.UseVisualStyleBackColor = false;
            this.checkBox_F7.CheckedChanged += new System.EventHandler(this.checkBox_F7_CheckedChanged);
            // 
            // checkBox_O2
            // 
            this.checkBox_O2.AutoSize = true;
            this.checkBox_O2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_O2.Location = new System.Drawing.Point(143, 195);
            this.checkBox_O2.Name = "checkBox_O2";
            this.checkBox_O2.Size = new System.Drawing.Size(18, 17);
            this.checkBox_O2.TabIndex = 24;
            this.checkBox_O2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_O2.UseVisualStyleBackColor = false;
            this.checkBox_O2.CheckedChanged += new System.EventHandler(this.checkBox_O2_CheckedChanged);
            // 
            // checkBox_Fp1
            // 
            this.checkBox_Fp1.AutoSize = true;
            this.checkBox_Fp1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Fp1.Location = new System.Drawing.Point(89, 46);
            this.checkBox_Fp1.Name = "checkBox_Fp1";
            this.checkBox_Fp1.Size = new System.Drawing.Size(18, 17);
            this.checkBox_Fp1.TabIndex = 25;
            this.checkBox_Fp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Fp1.UseVisualStyleBackColor = false;
            this.checkBox_Fp1.CheckedChanged += new System.EventHandler(this.checkBox_Fp1_CheckedChanged);
            // 
            // checkBox_T6
            // 
            this.checkBox_T6.AutoSize = true;
            this.checkBox_T6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_T6.Location = new System.Drawing.Point(172, 164);
            this.checkBox_T6.Name = "checkBox_T6";
            this.checkBox_T6.Size = new System.Drawing.Size(18, 17);
            this.checkBox_T6.TabIndex = 23;
            this.checkBox_T6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_T6.UseVisualStyleBackColor = false;
            this.checkBox_T6.CheckedChanged += new System.EventHandler(this.checkBox_T6_CheckedChanged);
            // 
            // checkBox_Fp2
            // 
            this.checkBox_Fp2.AutoSize = true;
            this.checkBox_Fp2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Fp2.Location = new System.Drawing.Point(143, 46);
            this.checkBox_Fp2.Name = "checkBox_Fp2";
            this.checkBox_Fp2.Size = new System.Drawing.Size(18, 17);
            this.checkBox_Fp2.TabIndex = 22;
            this.checkBox_Fp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Fp2.UseVisualStyleBackColor = false;
            this.checkBox_Fp2.CheckedChanged += new System.EventHandler(this.checkBox_Fp2_CheckedChanged);
            // 
            // checkBox_F8
            // 
            this.checkBox_F8.AutoSize = true;
            this.checkBox_F8.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_F8.Location = new System.Drawing.Point(175, 81);
            this.checkBox_F8.Name = "checkBox_F8";
            this.checkBox_F8.Size = new System.Drawing.Size(18, 17);
            this.checkBox_F8.TabIndex = 21;
            this.checkBox_F8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_F8.UseVisualStyleBackColor = false;
            this.checkBox_F8.CheckedChanged += new System.EventHandler(this.checkBox_F8_CheckedChanged);
            // 
            // checkBox_T4
            // 
            this.checkBox_T4.AutoSize = true;
            this.checkBox_T4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_T4.Location = new System.Drawing.Point(188, 119);
            this.checkBox_T4.Name = "checkBox_T4";
            this.checkBox_T4.Size = new System.Drawing.Size(18, 17);
            this.checkBox_T4.TabIndex = 20;
            this.checkBox_T4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_T4.UseVisualStyleBackColor = false;
            this.checkBox_T4.CheckedChanged += new System.EventHandler(this.checkBox_T4_CheckedChanged);
            // 
            // panel_configuration
            // 
            this.panel_configuration.Controls.Add(this.label_Channel0);
            this.panel_configuration.Controls.Add(this.label_pwmIrValue);
            this.panel_configuration.Controls.Add(this.label_pwmRedValue);
            this.panel_configuration.Controls.Add(this.textBox_pwmIrValue);
            this.panel_configuration.Controls.Add(this.textBox_pwmRedValue);
            this.panel_configuration.Controls.Add(this.comboBox_testDuration);
            this.panel_configuration.Controls.Add(this.button_sensorSelectChange);
            this.panel_configuration.Controls.Add(this.button_sensorSelectConfirm);
            this.panel_configuration.Controls.Add(this.label_configurationHeader);
            this.panel_configuration.Controls.Add(this.comboBox_sampleRate);
            this.panel_configuration.Controls.Add(this.label_testDuration);
            this.panel_configuration.Controls.Add(this.label_sampleRate);
            this.panel_configuration.Controls.Add(this.label_Calibrate);
            this.panel_configuration.Controls.Add(this.button_runLedCalibration);
            this.panel_configuration.Controls.Add(this.sensorSelect);
            this.panel_configuration.Controls.Add(this.label_sensorSelect);
            this.panel_configuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.panel_configuration.Location = new System.Drawing.Point(0, 0);
            this.panel_configuration.Name = "panel_configuration";
            this.panel_configuration.Size = new System.Drawing.Size(844, 578);
            this.panel_configuration.TabIndex = 6;
            // 
            // label_Channel0
            // 
            this.label_Channel0.AutoSize = true;
            this.label_Channel0.Location = new System.Drawing.Point(127, 160);
            this.label_Channel0.Name = "label_Channel0";
            this.label_Channel0.Size = new System.Drawing.Size(111, 25);
            this.label_Channel0.TabIndex = 30;
            this.label_Channel0.Text = "Channel 0";
            // 
            // label_pwmIrValue
            // 
            this.label_pwmIrValue.AutoSize = true;
            this.label_pwmIrValue.Location = new System.Drawing.Point(36, 234);
            this.label_pwmIrValue.Name = "label_pwmIrValue";
            this.label_pwmIrValue.Size = new System.Drawing.Size(32, 25);
            this.label_pwmIrValue.TabIndex = 28;
            this.label_pwmIrValue.Text = "IR";
            // 
            // label_pwmRedValue
            // 
            this.label_pwmRedValue.AutoSize = true;
            this.label_pwmRedValue.Location = new System.Drawing.Point(35, 195);
            this.label_pwmRedValue.Name = "label_pwmRedValue";
            this.label_pwmRedValue.Size = new System.Drawing.Size(50, 25);
            this.label_pwmRedValue.TabIndex = 27;
            this.label_pwmRedValue.Text = "Red";
            // 
            // textBox_pwmIrValue
            // 
            this.textBox_pwmIrValue.Location = new System.Drawing.Point(132, 231);
            this.textBox_pwmIrValue.Name = "textBox_pwmIrValue";
            this.textBox_pwmIrValue.Size = new System.Drawing.Size(100, 30);
            this.textBox_pwmIrValue.TabIndex = 26;
            // 
            // textBox_pwmRedValue
            // 
            this.textBox_pwmRedValue.Location = new System.Drawing.Point(132, 195);
            this.textBox_pwmRedValue.Name = "textBox_pwmRedValue";
            this.textBox_pwmRedValue.Size = new System.Drawing.Size(100, 30);
            this.textBox_pwmRedValue.TabIndex = 25;
            // 
            // comboBox_testDuration
            // 
            this.comboBox_testDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_testDuration.FormattingEnabled = true;
            this.comboBox_testDuration.Items.AddRange(new object[] {
            "30 Seconds",
            "60 Seconds",
            "90 Seconds",
            "120 Seconds",
            "150 Seconds",
            "180 Seconds",
            "210 Seconds",
            "240 Seconds",
            "270 Seconds",
            "300 Seconds"});
            this.comboBox_testDuration.Location = new System.Drawing.Point(31, 475);
            this.comboBox_testDuration.Name = "comboBox_testDuration";
            this.comboBox_testDuration.Size = new System.Drawing.Size(154, 30);
            this.comboBox_testDuration.TabIndex = 24;
            this.comboBox_testDuration.Text = "10 Seconds";
            this.comboBox_testDuration.SelectedIndexChanged += new System.EventHandler(this.comboBox_testDuration_SelectedIndexChanged);
            // 
            // button_sensorSelectChange
            // 
            this.button_sensorSelectChange.Location = new System.Drawing.Point(591, 118);
            this.button_sensorSelectChange.Name = "button_sensorSelectChange";
            this.button_sensorSelectChange.Size = new System.Drawing.Size(160, 38);
            this.button_sensorSelectChange.TabIndex = 20;
            this.button_sensorSelectChange.Text = "Change Selection";
            this.button_sensorSelectChange.UseVisualStyleBackColor = true;
            this.button_sensorSelectChange.Click += new System.EventHandler(this.button_sensorSelectChange_Click);
            // 
            // button_sensorSelectConfirm
            // 
            this.button_sensorSelectConfirm.Location = new System.Drawing.Point(589, 119);
            this.button_sensorSelectConfirm.Name = "button_sensorSelectConfirm";
            this.button_sensorSelectConfirm.Size = new System.Drawing.Size(159, 38);
            this.button_sensorSelectConfirm.TabIndex = 21;
            this.button_sensorSelectConfirm.Text = "Confirm Selection";
            this.button_sensorSelectConfirm.UseVisualStyleBackColor = true;
            this.button_sensorSelectConfirm.Visible = false;
            this.button_sensorSelectConfirm.Click += new System.EventHandler(this.button_sensorSelectConfirm_Click);
            // 
            // label_configurationHeader
            // 
            this.label_configurationHeader.AutoSize = true;
            this.label_configurationHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label_configurationHeader.Location = new System.Drawing.Point(200, 18);
            this.label_configurationHeader.Name = "label_configurationHeader";
            this.label_configurationHeader.Size = new System.Drawing.Size(419, 38);
            this.label_configurationHeader.TabIndex = 18;
            this.label_configurationHeader.Text = "CONFIGURATION MODE";
            // 
            // comboBox_sampleRate
            // 
            this.comboBox_sampleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_sampleRate.FormattingEnabled = true;
            this.comboBox_sampleRate.Items.AddRange(new object[] {
            "1",
            "2.5",
            "5",
            "10",
            "25",
            "50",
            "100",
            "250",
            "500",
            "1000"});
            this.comboBox_sampleRate.Location = new System.Drawing.Point(35, 397);
            this.comboBox_sampleRate.Name = "comboBox_sampleRate";
            this.comboBox_sampleRate.Size = new System.Drawing.Size(150, 30);
            this.comboBox_sampleRate.TabIndex = 16;
            this.comboBox_sampleRate.Text = "1 kHz";
            this.comboBox_sampleRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_sampleRate_SelectedIndexChanged);
            // 
            // label_testDuration
            // 
            this.label_testDuration.AutoSize = true;
            this.label_testDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_testDuration.Location = new System.Drawing.Point(31, 449);
            this.label_testDuration.Name = "label_testDuration";
            this.label_testDuration.Size = new System.Drawing.Size(124, 20);
            this.label_testDuration.TabIndex = 15;
            this.label_testDuration.Text = "Test Duration";
            // 
            // label_sampleRate
            // 
            this.label_sampleRate.AutoSize = true;
            this.label_sampleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_sampleRate.Location = new System.Drawing.Point(31, 373);
            this.label_sampleRate.Name = "label_sampleRate";
            this.label_sampleRate.Size = new System.Drawing.Size(116, 20);
            this.label_sampleRate.TabIndex = 14;
            this.label_sampleRate.Text = "Sample Rate";
            // 
            // label_Calibrate
            // 
            this.label_Calibrate.AutoSize = true;
            this.label_Calibrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_Calibrate.Location = new System.Drawing.Point(37, 59);
            this.label_Calibrate.Name = "label_Calibrate";
            this.label_Calibrate.Size = new System.Drawing.Size(128, 20);
            this.label_Calibrate.TabIndex = 13;
            this.label_Calibrate.Text = "Calibrate LED";
            // 
            // button_runLedCalibration
            // 
            this.button_runLedCalibration.Location = new System.Drawing.Point(41, 82);
            this.button_runLedCalibration.Name = "button_runLedCalibration";
            this.button_runLedCalibration.Size = new System.Drawing.Size(124, 53);
            this.button_runLedCalibration.TabIndex = 12;
            this.button_runLedCalibration.Text = "Calibrate";
            this.button_runLedCalibration.UseVisualStyleBackColor = true;
            this.button_runLedCalibration.Click += new System.EventHandler(this.button_runLedCalibration_Click);
            // 
            // label_sensorSelect
            // 
            this.label_sensorSelect.AutoSize = true;
            this.label_sensorSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sensorSelect.Location = new System.Drawing.Point(566, 90);
            this.label_sensorSelect.Name = "label_sensorSelect";
            this.label_sensorSelect.Size = new System.Drawing.Size(226, 25);
            this.label_sensorSelect.TabIndex = 10;
            this.label_sensorSelect.Text = "Sensor Disable Select";
            // 
            // panel_mainMenu
            // 
            this.panel_mainMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_mainMenu.Controls.Add(this.panel1);
            this.panel_mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_mainMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_mainMenu.Name = "panel_mainMenu";
            this.panel_mainMenu.Size = new System.Drawing.Size(844, 578);
            this.panel_mainMenu.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_deviceSetup);
            this.panel1.Controls.Add(this.button_newTest);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(189, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 236);
            this.panel1.TabIndex = 4;
            // 
            // button_deviceSetup
            // 
            this.button_deviceSetup.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_deviceSetup.Location = new System.Drawing.Point(106, 177);
            this.button_deviceSetup.Name = "button_deviceSetup";
            this.button_deviceSetup.Size = new System.Drawing.Size(107, 36);
            this.button_deviceSetup.TabIndex = 0;
            this.button_deviceSetup.Text = "Device Setup";
            this.button_deviceSetup.UseVisualStyleBackColor = false;
            this.button_deviceSetup.Click += new System.EventHandler(this.button_deviceSetup_Click);
            // 
            // button_newTest
            // 
            this.button_newTest.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_newTest.Location = new System.Drawing.Point(103, 129);
            this.button_newTest.Name = "button_newTest";
            this.button_newTest.Size = new System.Drawing.Size(110, 36);
            this.button_newTest.TabIndex = 1;
            this.button_newTest.Text = "New Test";
            this.button_newTest.UseVisualStyleBackColor = false;
            this.button_newTest.Click += new System.EventHandler(this.button_newTest_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::NIRs_Virtual_Serial_GUI.Properties.Resources.analysis_menu;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 221);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel_test
            // 
            this.panel_test.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_test.Controls.Add(this.label10);
            this.panel_test.Controls.Add(this.label9);
            this.panel_test.Controls.Add(this.label8);
            this.panel_test.Controls.Add(this.label7);
            this.panel_test.Controls.Add(this.label6);
            this.panel_test.Controls.Add(this.label5);
            this.panel_test.Controls.Add(this.label4);
            this.panel_test.Controls.Add(this.label3);
            this.panel_test.Controls.Add(this.label2);
            this.panel_test.Controls.Add(this.label1);
            this.panel_test.Controls.Add(this.button_startTest);
            this.panel_test.Controls.Add(this.label_name);
            this.panel_test.Controls.Add(this.progressBar_sensor5);
            this.panel_test.Controls.Add(this.progressBar_sensor4);
            this.panel_test.Controls.Add(this.progressBar_sensor3);
            this.panel_test.Controls.Add(this.progressBar_sensor2);
            this.panel_test.Controls.Add(this.progressBar_sensor1);
            this.panel_test.Controls.Add(this.progressBar_sensor10);
            this.panel_test.Controls.Add(this.progressBar_sensor9);
            this.panel_test.Controls.Add(this.progressBar_sensor8);
            this.panel_test.Controls.Add(this.progressBar_sensor7);
            this.panel_test.Controls.Add(this.progressBar_sensor6);
            this.panel_test.Controls.Add(this.textBox_patientName);
            this.panel_test.Controls.Add(this.label_testHeader);
            this.panel_test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_test.Location = new System.Drawing.Point(0, 0);
            this.panel_test.Name = "panel_test";
            this.panel_test.Size = new System.Drawing.Size(844, 578);
            this.panel_test.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Sensor 10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Sensor 9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Sensor 8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Sensor 7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "Sensor 6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Sensor 5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Sensor 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Sensor 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Sensor 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sensor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_startTest
            // 
            this.button_startTest.Location = new System.Drawing.Point(542, 140);
            this.button_startTest.Name = "button_startTest";
            this.button_startTest.Size = new System.Drawing.Size(123, 32);
            this.button_startTest.TabIndex = 34;
            this.button_startTest.Text = "Start Test";
            this.button_startTest.UseVisualStyleBackColor = true;
            this.button_startTest.Click += new System.EventHandler(this.button_startTest_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(46, 138);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(45, 17);
            this.label_name.TabIndex = 33;
            this.label_name.Text = "Name";
            // 
            // progressBar_sensor5
            // 
            this.progressBar_sensor5.Location = new System.Drawing.Point(38, 303);
            this.progressBar_sensor5.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor5.Maximum = 35000;
            this.progressBar_sensor5.Minimum = 20000;
            this.progressBar_sensor5.Name = "progressBar_sensor5";
            this.progressBar_sensor5.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor5.TabIndex = 32;
            this.progressBar_sensor5.Value = 20000;
            // 
            // progressBar_sensor4
            // 
            this.progressBar_sensor4.Location = new System.Drawing.Point(446, 250);
            this.progressBar_sensor4.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor4.Maximum = 35000;
            this.progressBar_sensor4.Minimum = 20000;
            this.progressBar_sensor4.Name = "progressBar_sensor4";
            this.progressBar_sensor4.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor4.TabIndex = 31;
            this.progressBar_sensor4.Value = 20000;
            // 
            // progressBar_sensor3
            // 
            this.progressBar_sensor3.Location = new System.Drawing.Point(38, 250);
            this.progressBar_sensor3.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor3.Maximum = 35000;
            this.progressBar_sensor3.Minimum = 20000;
            this.progressBar_sensor3.Name = "progressBar_sensor3";
            this.progressBar_sensor3.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor3.TabIndex = 30;
            this.progressBar_sensor3.Value = 20000;
            // 
            // progressBar_sensor2
            // 
            this.progressBar_sensor2.Location = new System.Drawing.Point(446, 199);
            this.progressBar_sensor2.MarqueeAnimationSpeed = 10;
            this.progressBar_sensor2.Maximum = 35000;
            this.progressBar_sensor2.Minimum = 20000;
            this.progressBar_sensor2.Name = "progressBar_sensor2";
            this.progressBar_sensor2.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor2.TabIndex = 29;
            this.progressBar_sensor2.Value = 20000;
            // 
            // progressBar_sensor1
            // 
            this.progressBar_sensor1.Location = new System.Drawing.Point(38, 199);
            this.progressBar_sensor1.MarqueeAnimationSpeed = 10;
            this.progressBar_sensor1.Maximum = 35000;
            this.progressBar_sensor1.Minimum = 20000;
            this.progressBar_sensor1.Name = "progressBar_sensor1";
            this.progressBar_sensor1.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor1.TabIndex = 28;
            this.progressBar_sensor1.Value = 20000;
            // 
            // progressBar_sensor10
            // 
            this.progressBar_sensor10.Location = new System.Drawing.Point(446, 401);
            this.progressBar_sensor10.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor10.Maximum = 35000;
            this.progressBar_sensor10.Minimum = 20000;
            this.progressBar_sensor10.Name = "progressBar_sensor10";
            this.progressBar_sensor10.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor10.TabIndex = 27;
            this.progressBar_sensor10.Value = 20000;
            // 
            // progressBar_sensor9
            // 
            this.progressBar_sensor9.Location = new System.Drawing.Point(38, 401);
            this.progressBar_sensor9.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor9.Maximum = 35000;
            this.progressBar_sensor9.Minimum = 20000;
            this.progressBar_sensor9.Name = "progressBar_sensor9";
            this.progressBar_sensor9.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor9.TabIndex = 26;
            this.progressBar_sensor9.Value = 20000;
            // 
            // progressBar_sensor8
            // 
            this.progressBar_sensor8.Location = new System.Drawing.Point(446, 351);
            this.progressBar_sensor8.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor8.Maximum = 35000;
            this.progressBar_sensor8.Minimum = 20000;
            this.progressBar_sensor8.Name = "progressBar_sensor8";
            this.progressBar_sensor8.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor8.TabIndex = 25;
            this.progressBar_sensor8.Value = 20000;
            // 
            // progressBar_sensor7
            // 
            this.progressBar_sensor7.Location = new System.Drawing.Point(38, 352);
            this.progressBar_sensor7.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor7.Maximum = 35000;
            this.progressBar_sensor7.Minimum = 20000;
            this.progressBar_sensor7.Name = "progressBar_sensor7";
            this.progressBar_sensor7.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor7.TabIndex = 24;
            this.progressBar_sensor7.Value = 20000;
            // 
            // progressBar_sensor6
            // 
            this.progressBar_sensor6.Location = new System.Drawing.Point(446, 303);
            this.progressBar_sensor6.MarqueeAnimationSpeed = 1000;
            this.progressBar_sensor6.Maximum = 35000;
            this.progressBar_sensor6.Minimum = 20000;
            this.progressBar_sensor6.Name = "progressBar_sensor6";
            this.progressBar_sensor6.Size = new System.Drawing.Size(386, 26);
            this.progressBar_sensor6.TabIndex = 23;
            this.progressBar_sensor6.Value = 20000;
            // 
            // textBox_patientName
            // 
            this.textBox_patientName.Location = new System.Drawing.Point(120, 134);
            this.textBox_patientName.Name = "textBox_patientName";
            this.textBox_patientName.Size = new System.Drawing.Size(100, 22);
            this.textBox_patientName.TabIndex = 21;
            this.textBox_patientName.TextChanged += new System.EventHandler(this.textBox_patientName_TextChanged);
            // 
            // label_testHeader
            // 
            this.label_testHeader.AutoSize = true;
            this.label_testHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label_testHeader.Location = new System.Drawing.Point(191, 64);
            this.label_testHeader.Name = "label_testHeader";
            this.label_testHeader.Size = new System.Drawing.Size(272, 39);
            this.label_testHeader.TabIndex = 20;
            this.label_testHeader.Text = "PATIENT TEST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(844, 578);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_test);
            this.Controls.Add(this.panel_configuration);
            this.Controls.Add(this.panel_connectPort);
            this.Controls.Add(this.panel_mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "NIRs Device GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_connectPort.ResumeLayout(false);
            this.panel_connectPort.PerformLayout();
            this.sensorSelect.ResumeLayout(false);
            this.sensorSelect.PerformLayout();
            this.panel_configuration.ResumeLayout(false);
            this.panel_configuration.PerformLayout();
            this.panel_mainMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_test.ResumeLayout(false);
            this.panel_test.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort comPort;
        private System.Windows.Forms.Button button_connect_comPort;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.Label label_ports;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commanedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_configuration;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Test;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_service;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_port;
        private System.Windows.Forms.Panel panel_connectPort;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.Button button_disconnectComPort;
        private System.Windows.Forms.Panel panel_configuration;
        private System.Windows.Forms.Label label_sensorSelect;
        private System.Windows.Forms.Panel sensorSelect;
        private System.Windows.Forms.CheckBox checkBox_O1;
        private System.Windows.Forms.CheckBox checkBox_T5;
        private System.Windows.Forms.CheckBox checkBox_T3;
        private System.Windows.Forms.CheckBox checkBox_F7;
        private System.Windows.Forms.CheckBox checkBox_Fp1;
        private System.Windows.Forms.CheckBox checkBox_O2;
        private System.Windows.Forms.CheckBox checkBox_T6;
        private System.Windows.Forms.CheckBox checkBox_Fp2;
        private System.Windows.Forms.CheckBox checkBox_F8;
        private System.Windows.Forms.CheckBox checkBox_T4;
        private System.Windows.Forms.Panel panel_mainMenu;
        private System.Windows.Forms.Button button_newTest;
        private System.Windows.Forms.Button button_deviceSetup;
        private System.Windows.Forms.Label label_configurationHeader;
        private System.Windows.Forms.ComboBox comboBox_sampleRate;
        private System.Windows.Forms.Label label_testDuration;
        private System.Windows.Forms.Label label_sampleRate;
        private System.Windows.Forms.Label label_Calibrate;
        private System.Windows.Forms.Button button_runLedCalibration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_test;
        private System.Windows.Forms.Label label_testHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_sensorSelectConfirm;
        private System.Windows.Forms.Button button_sensorSelectChange;
        private System.Windows.Forms.ProgressBar progressBar_sensor5;
        private System.Windows.Forms.ProgressBar progressBar_sensor4;
        private System.Windows.Forms.ProgressBar progressBar_sensor3;
        private System.Windows.Forms.ProgressBar progressBar_sensor2;
        private System.Windows.Forms.ProgressBar progressBar_sensor1;
        private System.Windows.Forms.ProgressBar progressBar_sensor10;
        private System.Windows.Forms.ProgressBar progressBar_sensor9;
        private System.Windows.Forms.ProgressBar progressBar_sensor8;
        private System.Windows.Forms.ProgressBar progressBar_sensor7;
        private System.Windows.Forms.ProgressBar progressBar_sensor6;
        private System.Windows.Forms.TextBox textBox_patientName;
        private System.Windows.Forms.Button button_startTest;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox comboBox_testDuration;
        private System.Windows.Forms.TextBox textBox_pwmRedValue;
        private System.Windows.Forms.TextBox textBox_pwmIrValue;
        private System.Windows.Forms.Label label_Channel0;
        private System.Windows.Forms.Label label_pwmIrValue;
        private System.Windows.Forms.Label label_pwmRedValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

