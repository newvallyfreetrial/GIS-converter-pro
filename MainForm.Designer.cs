using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GISUniversalConverterPro.UI;

namespace GISUniversalConverterPro
{
    partial class MainForm
    {
        private IContainer components = null;

        // Menu and Toolbar
        private MenuStrip mainMenuStrip;
        private ToolStrip mainToolStrip;
        private ToolStripButton addFilesToolStripButton;
        private ToolStripButton deleteToolStripButton;
        private ToolStripButton browseOutputToolStripButton;
        private ToolStripButton selectOutputToolStripButton;
        private ToolStripButton convertToolStripButton;
        private ToolStripButton cancelToolStripButton;
        private ToolStripButton openFolderToolStripButton;

        // Layout Panels
        private StaticGradientTableLayoutPanel rootLayoutPanel;
        private GradientRoundedPanel headerPanel;
        private PictureBox headerIconPictureBox;
        private Label titleLabel;
        private Label subtitleLabel;
        private Label engineStatusLabel;
        private TableLayoutPanel mainContentPanel;

        // Left Panel (Settings)
        private RoundedPanel settingsPanel;
        private Label settingsHeaderLabel;
        private Button collapseSettingsButton;
        private Label outputFolderLabel;
        private TextBox outputPathTextBox;
        private Button browseOutputButton;
        private Label outputFormatLabel;
        private ComboBox formatComboBox;
        private Label engineOptionsLabel;
        private CheckBox arcgisEngineCheckBox;
        private Label additionalOptionsLabel;
        private CheckBox ignoreWarningsCheckBox;

        // Right Panel (Files)
        private RoundedPanel filesPanel;
        private Label filesHeaderLabel;
        private ListView filesListView;
        private ColumnHeader fileNameColumnHeader;
        private ColumnHeader sizeColumnHeader;
        private ColumnHeader typeColumnHeader;
        private ColumnHeader statusColumnHeader;
        private Label emptyStateLabel;
        private PictureBox emptyStatePictureBox;
        private FlowLayoutPanel filesActionPanel;
        private Button moveUpButton;
        private Button moveDownButton;
        private Button addFilesActionButton;
        private Button deleteFilesActionButton;
        private Button clearFilesActionButton;

        // Progress Section
        private RoundedPanel progressPanel;
        private Label progressHeaderLabel;
        private Label overallProgressLabel;
        private ProgressBar overallProgressBar;
        private Label currentOperationLabel;
        private Label currentFileLabel;

        // Logs Section
        private RoundedPanel logsPanel;
        private Label logsHeaderLabel;
        private RichTextBox logsRichTextBox;
        private Button clearLogsButton;

        // Status Bar
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ToolStripStatusLabel engineStatusToolStripLabel;
        private ToolStripStatusLabel versionStatusLabel;

        // Menu Items
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem addFilesMenuItem;
        private ToolStripMenuItem browseOutputMenuItem;
        private ToolStripMenuItem openFolderMenuItem;
        private ToolStripMenuItem convertMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem toolsMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private ToolStripMenuItem aboutMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();

            // Initialize all components
            mainMenuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            addFilesMenuItem = new ToolStripMenuItem();
            browseOutputMenuItem = new ToolStripMenuItem();
            openFolderMenuItem = new ToolStripMenuItem();
            convertMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            toolsMenuItem = new ToolStripMenuItem();
            helpMenuItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();

            mainToolStrip = new ToolStrip();
            addFilesToolStripButton = new ToolStripButton();
            deleteToolStripButton = new ToolStripButton();
            browseOutputToolStripButton = new ToolStripButton();
            selectOutputToolStripButton = new ToolStripButton();
            convertToolStripButton = new ToolStripButton();
            cancelToolStripButton = new ToolStripButton();
            openFolderToolStripButton = new ToolStripButton();

            rootLayoutPanel = new StaticGradientTableLayoutPanel();
            headerPanel = new GradientRoundedPanel();
            headerIconPictureBox = new PictureBox();
            titleLabel = new Label();
            subtitleLabel = new Label();
            engineStatusLabel = new Label();

            mainContentPanel = new TableLayoutPanel();
            settingsPanel = new RoundedPanel();
            filesPanel = new RoundedPanel();
            progressPanel = new RoundedPanel();
            logsPanel = new RoundedPanel();

            settingsHeaderLabel = new Label();
            collapseSettingsButton = new Button();
            outputFolderLabel = new Label();
            outputPathTextBox = new TextBox();
            browseOutputButton = new Button();
            outputFormatLabel = new Label();
            formatComboBox = new ComboBox();
            engineOptionsLabel = new Label();
            arcgisEngineCheckBox = new CheckBox();
            additionalOptionsLabel = new Label();
            ignoreWarningsCheckBox = new CheckBox();

            filesHeaderLabel = new Label();
            filesListView = new ListView();
            fileNameColumnHeader = new ColumnHeader();
            sizeColumnHeader = new ColumnHeader();
            typeColumnHeader = new ColumnHeader();
            statusColumnHeader = new ColumnHeader();
            emptyStateLabel = new Label();
            emptyStatePictureBox = new PictureBox();
            filesActionPanel = new FlowLayoutPanel();
            moveUpButton = new Button();
            moveDownButton = new Button();
            addFilesActionButton = new Button();
            deleteFilesActionButton = new Button();
            clearFilesActionButton = new Button();

            progressHeaderLabel = new Label();
            overallProgressLabel = new Label();
            overallProgressBar = new ProgressBar();
            currentOperationLabel = new Label();
            currentFileLabel = new Label();

            logsHeaderLabel = new Label();
            logsRichTextBox = new RichTextBox();
            clearLogsButton = new Button();

            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            engineStatusToolStripLabel = new ToolStripStatusLabel();
            versionStatusLabel = new ToolStripStatusLabel();

            SuspendLayout();

            // Configure Menu Bar
            mainMenuStrip.BackColor = ColorTranslator.FromHtml("#E0F7FA");
            mainMenuStrip.Font = new Font("Segoe UI", 10F);
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, toolsMenuItem, helpMenuItem });
            mainMenuStrip.Dock = DockStyle.Top;
            mainMenuStrip.RightToLeft = RightToLeft.Yes;

            fileMenuItem.Text = "🗂️ ملف";
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 
                addFilesMenuItem, browseOutputMenuItem, openFolderMenuItem, 
                new ToolStripSeparator(), convertMenuItem, new ToolStripSeparator(), exitMenuItem 
            });
            addFilesMenuItem.Text = "➕ إضافة ملفات";
            addFilesMenuItem.Click += addFilesMenuItem_Click;
            browseOutputMenuItem.Text = "📁 تحديد مجلد الإخراج";
            browseOutputMenuItem.Click += browseOutputMenuItem_Click;
            openFolderMenuItem.Text = "🗃️ فتح مجلد الإخراج";
            openFolderMenuItem.Click += openFolderMenuItem_Click;
            convertMenuItem.Text = "⚡ تحويل";
            convertMenuItem.Click += convertMenuItem_Click;
            exitMenuItem.Text = "🚪 خروج";
            exitMenuItem.Click += exitMenuItem_Click;
            toolsMenuItem.Text = "🧰 أدوات";
            helpMenuItem.Text = "❔ مساعدة";
            aboutMenuItem.Text = "ℹ️ حول التطبيق";
            helpMenuItem.DropDownItems.Add(aboutMenuItem);
            aboutMenuItem.Click += aboutMenuItem_Click;

            // Configure Main Toolbar
            mainToolStrip.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            mainToolStrip.Font = new Font("Segoe UI", 9F);
            mainToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            mainToolStrip.AutoSize = true;
            mainToolStrip.Dock = DockStyle.Top;
            mainToolStrip.RightToLeft = RightToLeft.Yes;
            mainToolStrip.Padding = new Padding(8);

            // Toolbar Buttons
            addFilesToolStripButton.Text = "➕ إضافة ملفات";
            addFilesToolStripButton.Click += addFilesToolStripButton_Click;
            deleteToolStripButton.Text = "🗑️ إزالة";
            deleteToolStripButton.Click += deleteToolStripButton_Click;
            browseOutputToolStripButton.Text = "📁 مسح القائمة";
            browseOutputToolStripButton.Click += browseOutputToolStripButton_Click;
            selectOutputToolStripButton.Text = "📂 تحديد مجلد الإخراج";
            selectOutputToolStripButton.Click += selectOutputToolStripButton_Click;
            convertToolStripButton.Text = "▶️ تحويل";
            convertToolStripButton.Click += convertToolStripButton_Click;
            cancelToolStripButton.Text = "⏹️ إلغاء";
            cancelToolStripButton.Click += cancelToolStripButton_Click;
            openFolderToolStripButton.Text = "🗃️ فتح مجلد الإخراج";
            openFolderToolStripButton.Click += openFolderToolStripButton_Click;

            mainToolStrip.Items.AddRange(new ToolStripItem[] {
                addFilesToolStripButton,
                deleteToolStripButton,
                browseOutputToolStripButton,
                selectOutputToolStripButton,
                new ToolStripSeparator(),
                convertToolStripButton,
                cancelToolStripButton,
                openFolderToolStripButton
            });

            // Header Panel
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Height = 100;
            headerPanel.Padding = new Padding(20, 10, 20, 10);
            headerPanel.Margin = new Padding(0);
            headerPanel.CornerRadius = 0;
            headerPanel.StartColor = ColorTranslator.FromHtml("#0891B2");
            headerPanel.EndColor = ColorTranslator.FromHtml("#06B6D4");

            headerIconPictureBox.Width = 48;
            headerIconPictureBox.Height = 48;
            headerIconPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headerIconPictureBox.BackColor = Color.Transparent;
            headerIconPictureBox.Margin = new Padding(0, 0, 16, 0);

            titleLabel.Text = "GIS Universal Converter Pro";
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.Transparent;

            subtitleLabel.Text = "Universal GIS Data Conversion Platform";
            subtitleLabel.Font = new Font("Segoe UI", 10F);
            subtitleLabel.ForeColor = ColorTranslator.FromHtml("#E0F7FA");
            subtitleLabel.AutoSize = true;
            subtitleLabel.BackColor = Color.Transparent;

            engineStatusLabel.Text = "Internal Engine";
            engineStatusLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            engineStatusLabel.ForeColor = Color.White;
            engineStatusLabel.BackColor = ColorTranslator.FromHtml("#1B7B92");
            engineStatusLabel.AutoSize = true;
            engineStatusLabel.Padding = new Padding(8, 4, 8, 4);
            engineStatusLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Layout for header content
            var headerLayout = new TableLayoutPanel();
            headerLayout.Dock = DockStyle.Fill;
            headerLayout.ColumnCount = 3;
            headerLayout.RowCount = 2;
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            headerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            headerLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            headerLayout.BackColor = Color.Transparent;

            headerLayout.Controls.Add(headerIconPictureBox, 0, 0);
            headerLayout.Controls.Add(titleLabel, 1, 0);
            headerLayout.Controls.Add(engineStatusLabel, 2, 0);
            headerLayout.Controls.Add(subtitleLabel, 1, 1);
            headerLayout.SetColumnSpan(subtitleLabel, 1);

            headerPanel.Controls.Add(headerLayout);

            // Main Content Layout
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.ColumnCount = 2;
            mainContentPanel.RowCount = 3;
            mainContentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            mainContentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mainContentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainContentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            mainContentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            mainContentPanel.Padding = new Padding(12);
            mainContentPanel.BackColor = ColorTranslator.FromHtml("#E0F7FA");

            // Settings Panel (Left)
            settingsPanel.BackColor = Color.White;
            settingsPanel.CornerRadius = 8;
            settingsPanel.BorderColor = ColorTranslator.FromHtml("#D6EAF0");
            settingsPanel.Dock = DockStyle.Fill;
            settingsPanel.Padding = new Padding(12);
            settingsPanel.Margin = new Padding(0, 0, 6, 6);

            settingsHeaderLabel.Text = "⚙️ إعدادات التحويل";
            settingsHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            settingsHeaderLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            settingsHeaderLabel.Dock = DockStyle.Top;
            settingsHeaderLabel.Height = 28;

            outputFolderLabel.Text = "📁 مجلد الإخراج";
            outputFolderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            outputFolderLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            outputFolderLabel.Dock = DockStyle.Top;
            outputFolderLabel.Height = 20;

            outputPathTextBox.ReadOnly = true;
            outputPathTextBox.Font = new Font("Segoe UI", 9F);
            outputPathTextBox.Dock = DockStyle.Top;
            outputPathTextBox.Height = 28;
            outputPathTextBox.Margin = new Padding(0, 2, 0, 6);
            outputPathTextBox.Text = "C:\\Output";

            browseOutputButton.Text = "✓ تصفح";
            browseOutputButton.Font = new Font("Segoe UI", 9F);
            browseOutputButton.ForeColor = Color.White;
            browseOutputButton.BackColor = ColorTranslator.FromHtml("#06B6D4");
            browseOutputButton.FlatStyle = FlatStyle.Flat;
            browseOutputButton.Dock = DockStyle.Top;
            browseOutputButton.Height = 32;
            browseOutputButton.Margin = new Padding(0, 0, 0, 8);
            browseOutputButton.Click += browseOutputButton_Click;

            outputFormatLabel.Text = "صيغة الإخراج";
            outputFormatLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            outputFormatLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            outputFormatLabel.Dock = DockStyle.Top;
            outputFormatLabel.Height = 20;

            formatComboBox.Items.AddRange(new[] { "SHP - Shapefile", "GeoJSON", "KML", "GeoPackage" });
            formatComboBox.SelectedIndex = 0;
            formatComboBox.Font = new Font("Segoe UI", 9F);
            formatComboBox.Dock = DockStyle.Top;
            formatComboBox.Height = 28;
            formatComboBox.Margin = new Padding(0, 2, 0, 8);

            engineOptionsLabel.Text = "خيارات المحرك";
            engineOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            engineOptionsLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            engineOptionsLabel.Dock = DockStyle.Top;
            engineOptionsLabel.Height = 20;

            arcgisEngineCheckBox.Text = "استخدام محرك ArcGIS الداخلي";
            arcgisEngineCheckBox.Font = new Font("Segoe UI", 9F);
            arcgisEngineCheckBox.ForeColor = ColorTranslator.FromHtml("#0F172A");
            arcgisEngineCheckBox.Dock = DockStyle.Top;
            arcgisEngineCheckBox.Height = 24;
            arcgisEngineCheckBox.Margin = new Padding(0, 2, 0, 4);

            additionalOptionsLabel.Text = "خيارات إضافية";
            additionalOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            additionalOptionsLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            additionalOptionsLabel.Dock = DockStyle.Top;
            additionalOptionsLabel.Height = 20;

            ignoreWarningsCheckBox.Text = "تجاهل الملفات غير المدعومة";
            ignoreWarningsCheckBox.Font = new Font("Segoe UI", 9F);
            ignoreWarningsCheckBox.ForeColor = ColorTranslator.FromHtml("#0F172A");
            ignoreWarningsCheckBox.Dock = DockStyle.Top;
            ignoreWarningsCheckBox.Height = 24;

            settingsPanel.Controls.Add(ignoreWarningsCheckBox);
            settingsPanel.Controls.Add(additionalOptionsLabel);
            settingsPanel.Controls.Add(arcgisEngineCheckBox);
            settingsPanel.Controls.Add(engineOptionsLabel);
            settingsPanel.Controls.Add(formatComboBox);
            settingsPanel.Controls.Add(outputFormatLabel);
            settingsPanel.Controls.Add(browseOutputButton);
            settingsPanel.Controls.Add(outputPathTextBox);
            settingsPanel.Controls.Add(outputFolderLabel);
            settingsPanel.Controls.Add(settingsHeaderLabel);

            // Files Panel (Right)
            filesPanel.BackColor = Color.White;
            filesPanel.CornerRadius = 8;
            filesPanel.BorderColor = ColorTranslator.FromHtml("#D6EAF0");
            filesPanel.Dock = DockStyle.Fill;
            filesPanel.Padding = new Padding(12);
            filesPanel.Margin = new Padding(6, 0, 0, 6);

            filesHeaderLabel.Text = "📦 ملفات المصدر";
            filesHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            filesHeaderLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            filesHeaderLabel.Dock = DockStyle.Top;
            filesHeaderLabel.Height = 28;

            filesListView.View = View.Details;
            filesListView.FullRowSelect = true;
            filesListView.MultiSelect = true;
            filesListView.BorderStyle = BorderStyle.None;
            filesListView.BackColor = ColorTranslator.FromHtml("#F7FDFE");
            filesListView.Font = new Font("Segoe UI", 9F);
            filesListView.Dock = DockStyle.Fill;
            filesListView.RightToLeft = RightToLeft.Yes;
            filesListView.RightToLeftLayout = true;
            filesListView.Columns.AddRange(new[] { fileNameColumnHeader, sizeColumnHeader, typeColumnHeader, statusColumnHeader });
            fileNameColumnHeader.Text = "اسم الملف";
            fileNameColumnHeader.Width = 250;
            sizeColumnHeader.Text = "الحجم";
            sizeColumnHeader.Width = 100;
            typeColumnHeader.Text = "النوع";
            typeColumnHeader.Width = 80;
            statusColumnHeader.Text = "الحالة";
            statusColumnHeader.Width = 120;

            filesActionPanel.Dock = DockStyle.Bottom;
            filesActionPanel.Height = 48;
            filesActionPanel.FlowDirection = FlowDirection.RightToLeft;
            filesActionPanel.Padding = new Padding(0, 8, 0, 0);

            moveUpButton.Text = "▲ تحريك لأعلى";
            moveUpButton.Font = new Font("Segoe UI", 8F);
            moveUpButton.Size = new Size(110, 32);
            moveUpButton.Click += moveUpButton_Click;

            moveDownButton.Text = "▼ تحريك لأسفل";
            moveDownButton.Font = new Font("Segoe UI", 8F);
            moveDownButton.Size = new Size(110, 32);
            moveDownButton.Click += moveDownButton_Click;

            addFilesActionButton.Text = "➕ إضافة ملفات";
            addFilesActionButton.Font = new Font("Segoe UI", 8F);
            addFilesActionButton.ForeColor = Color.White;
            addFilesActionButton.BackColor = ColorTranslator.FromHtml("#06B6D4");
            addFilesActionButton.FlatStyle = FlatStyle.Flat;
            addFilesActionButton.Size = new Size(110, 32);
            addFilesActionButton.Click += addFilesButton_Click;

            deleteFilesActionButton.Text = "🗑️ إزالة المحدد";
            deleteFilesActionButton.Font = new Font("Segoe UI", 8F);
            deleteFilesActionButton.ForeColor = Color.White;
            deleteFilesActionButton.BackColor = ColorTranslator.FromHtml("#EF4444");
            deleteFilesActionButton.FlatStyle = FlatStyle.Flat;
            deleteFilesActionButton.Size = new Size(110, 32);
            deleteFilesActionButton.Click += deleteFilesActionButton_Click;

            clearFilesActionButton.Text = "🧹 مسح القائمة";
            clearFilesActionButton.Font = new Font("Segoe UI", 8F);
            clearFilesActionButton.ForeColor = Color.White;
            clearFilesActionButton.BackColor = ColorTranslator.FromHtml("#0EA5E9");
            clearFilesActionButton.FlatStyle = FlatStyle.Flat;
            clearFilesActionButton.Size = new Size(110, 32);
            clearFilesActionButton.Click += clearFilesActionButton_Click;

            filesActionPanel.Controls.Add(moveUpButton);
            filesActionPanel.Controls.Add(moveDownButton);
            filesActionPanel.Controls.Add(addFilesActionButton);
            filesActionPanel.Controls.Add(deleteFilesActionButton);
            filesActionPanel.Controls.Add(clearFilesActionButton);

            filesPanel.Controls.Add(filesActionPanel);
            filesPanel.Controls.Add(filesListView);
            filesPanel.Controls.Add(filesHeaderLabel);

            // Progress Panel
            progressPanel.BackColor = Color.White;
            progressPanel.CornerRadius = 8;
            progressPanel.BorderColor = ColorTranslator.FromHtml("#D6EAF0");
            progressPanel.Dock = DockStyle.Fill;
            progressPanel.Padding = new Padding(12);
            progressPanel.Margin = new Padding(0, 0, 6, 6);

            progressHeaderLabel.Text = "📈 حالة التقدم";
            progressHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            progressHeaderLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            progressHeaderLabel.Dock = DockStyle.Top;
            progressHeaderLabel.Height = 24;

            overallProgressLabel.Text = "التقدم الكلي:";
            overallProgressLabel.Font = new Font("Segoe UI", 9F);
            overallProgressLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            overallProgressLabel.Dock = DockStyle.Top;
            overallProgressLabel.Height = 18;

            overallProgressBar.Dock = DockStyle.Top;
            overallProgressBar.Height = 16;
            overallProgressBar.Margin = new Padding(0, 2, 0, 6);

            currentOperationLabel.Text = "العملية الحالية: -";
            currentOperationLabel.Font = new Font("Segoe UI", 8F);
            currentOperationLabel.ForeColor = ColorTranslator.FromHtml("#666");
            currentOperationLabel.Dock = DockStyle.Top;
            currentOperationLabel.Height = 16;

            currentFileLabel.Text = "الملف الحالي: -";
            currentFileLabel.Font = new Font("Segoe UI", 8F);
            currentFileLabel.ForeColor = ColorTranslator.FromHtml("#666");
            currentFileLabel.Dock = DockStyle.Top;
            currentFileLabel.Height = 16;

            progressPanel.Controls.Add(currentFileLabel);
            progressPanel.Controls.Add(currentOperationLabel);
            progressPanel.Controls.Add(overallProgressBar);
            progressPanel.Controls.Add(overallProgressLabel);
            progressPanel.Controls.Add(progressHeaderLabel);

            // Logs Panel
            logsPanel.BackColor = Color.White;
            logsPanel.CornerRadius = 8;
            logsPanel.BorderColor = ColorTranslator.FromHtml("#D6EAF0");
            logsPanel.Dock = DockStyle.Fill;
            logsPanel.Padding = new Padding(12);
            logsPanel.Margin = new Padding(6, 0, 0, 0);

            logsHeaderLabel.Text = "📋 سجل العمليات";
            logsHeaderLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logsHeaderLabel.ForeColor = ColorTranslator.FromHtml("#0F172A");
            logsHeaderLabel.Dock = DockStyle.Top;
            logsHeaderLabel.Height = 24;

            clearLogsButton.Text = "مسح السجل";
            clearLogsButton.Font = new Font("Segoe UI", 8F);
            clearLogsButton.ForeColor = Color.White;
            clearLogsButton.BackColor = ColorTranslator.FromHtml("#EF4444");
            clearLogsButton.FlatStyle = FlatStyle.Flat;
            clearLogsButton.Dock = DockStyle.Top;
            clearLogsButton.Height = 28;
            clearLogsButton.Margin = new Padding(0, 0, 0, 6);
            clearLogsButton.Click += clearLogsButton_Click;

            logsRichTextBox.ReadOnly = true;
            logsRichTextBox.Font = new Font("Segoe UI", 8F);
            logsRichTextBox.BackColor = ColorTranslator.FromHtml("#F7FDFE");
            logsRichTextBox.ForeColor = ColorTranslator.FromHtml("#0F172A");
            logsRichTextBox.BorderStyle = BorderStyle.None;
            logsRichTextBox.Dock = DockStyle.Fill;

            logsPanel.Controls.Add(logsRichTextBox);
            logsPanel.Controls.Add(clearLogsButton);
            logsPanel.Controls.Add(logsHeaderLabel);

            // Add to Main Content Panel
            mainContentPanel.Controls.Add(settingsPanel, 0, 0);
            mainContentPanel.Controls.Add(filesPanel, 1, 0);
            mainContentPanel.SetRowSpan(filesPanel, 1);
            mainContentPanel.Controls.Add(progressPanel, 0, 1);
            mainContentPanel.SetColumnSpan(progressPanel, 2);
            mainContentPanel.Controls.Add(logsPanel, 0, 2);
            mainContentPanel.SetColumnSpan(logsPanel, 2);

            // Status Bar
            statusStrip.BackColor = ColorTranslator.FromHtml("#E0F7FA");
            statusStrip.Dock = DockStyle.Bottom;
            statusStrip.Font = new Font("Segoe UI", 9F);
            statusStrip.RightToLeft = RightToLeft.Yes;
            statusLabel.Text = "Ready Files: 0";
            statusLabel.Spring = false;
            statusLabel.Width = 150;
            engineStatusToolStripLabel.Text = "Internal Engine";
            engineStatusToolStripLabel.Spring = true;
            engineStatusToolStripLabel.TextAlign = ContentAlignment.MiddleCenter;
            versionStatusLabel.Text = "v1.0.0";
            statusStrip.Items.Add(statusLabel);
            statusStrip.Items.Add(new ToolStripSeparator());
            statusStrip.Items.Add(engineStatusToolStripLabel);
            statusStrip.Items.Add(new ToolStripSeparator());
            statusStrip.Items.Add(versionStatusLabel);

            // Main Form
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = ColorTranslator.FromHtml("#E0F7FA");
            ClientSize = new Size(1280, 900);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(1000, 700);
            Name = "MainForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GIS Universal Converter Pro";
            AllowDrop = true;

            Controls.Add(mainContentPanel);
            Controls.Add(statusStrip);
            Controls.Add(mainToolStrip);
            Controls.Add(headerPanel);
            Controls.Add(mainMenuStrip);

            MainMenuStrip = mainMenuStrip;
            DragEnter += MainForm_DragEnter;
            DragDrop += MainForm_DragDrop;

            ResumeLayout(false);
            PerformLayout();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            // Implementation for move up
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            // Implementation for move down
        }
    }
}
