namespace PatternsTemplate
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelPoints = new System.Windows.Forms.TableLayoutPanel();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelDestination = new System.Windows.Forms.Label();
            this.textBoxDeparture = new System.Windows.Forms.TextBox();
            this.comboBoxFlightDestination = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelPersons = new System.Windows.Forms.TableLayoutPanel();
            this.labelAdults = new System.Windows.Forms.Label();
            this.labelChildren = new System.Windows.Forms.Label();
            this.labelBabies = new System.Windows.Forms.Label();
            this.numericUpDownAdults = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownChildren = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBabies = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelClassFlight = new System.Windows.Forms.TableLayoutPanel();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxFlightClass = new System.Windows.Forms.ComboBox();
            this.labelFlight = new System.Windows.Forms.Label();
            this.comboBoxFlightTime = new System.Windows.Forms.ComboBox();
            this.splitContainerCalc = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanelPoints.SuspendLayout();
            this.tableLayoutPanelPersons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBabies)).BeginInit();
            this.tableLayoutPanelClassFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCalc)).BeginInit();
            this.splitContainerCalc.Panel1.SuspendLayout();
            this.splitContainerCalc.Panel2.SuspendLayout();
            this.splitContainerCalc.SuspendLayout();
            this.tableLayoutPanelButtons.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelPoints, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelPersons, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelClassFlight, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.splitContainerCalc, 0, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(624, 442);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanelPoints
            // 
            this.tableLayoutPanelPoints.ColumnCount = 2;
            this.tableLayoutPanelPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPoints.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPoints.Controls.Add(this.labelDeparture, 0, 0);
            this.tableLayoutPanelPoints.Controls.Add(this.labelDestination, 1, 0);
            this.tableLayoutPanelPoints.Controls.Add(this.textBoxDeparture, 0, 1);
            this.tableLayoutPanelPoints.Controls.Add(this.comboBoxFlightDestination, 1, 1);
            this.tableLayoutPanelPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPoints.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelPoints.Name = "tableLayoutPanelPoints";
            this.tableLayoutPanelPoints.RowCount = 2;
            this.tableLayoutPanelPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPoints.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelPoints.Size = new System.Drawing.Size(618, 170);
            this.tableLayoutPanelPoints.TabIndex = 0;
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeparture.Location = new System.Drawing.Point(3, 0);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(303, 85);
            this.labelDeparture.TabIndex = 0;
            this.labelDeparture.Text = "Departure";
            this.labelDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDestination.Location = new System.Drawing.Point(312, 0);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(303, 85);
            this.labelDestination.TabIndex = 1;
            this.labelDestination.Text = "Destination";
            this.labelDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDeparture
            // 
            this.textBoxDeparture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDeparture.Location = new System.Drawing.Point(3, 112);
            this.textBoxDeparture.Name = "textBoxDeparture";
            this.textBoxDeparture.ReadOnly = true;
            this.textBoxDeparture.Size = new System.Drawing.Size(303, 30);
            this.textBoxDeparture.TabIndex = 2;
            this.textBoxDeparture.Text = "Moscow";
            this.textBoxDeparture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxFlightDestination
            // 
            this.comboBoxFlightDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFlightDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlightDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFlightDestination.FormattingEnabled = true;
            this.comboBoxFlightDestination.Location = new System.Drawing.Point(312, 111);
            this.comboBoxFlightDestination.Name = "comboBoxFlightDestination";
            this.comboBoxFlightDestination.Size = new System.Drawing.Size(303, 33);
            this.comboBoxFlightDestination.TabIndex = 3;
            // 
            // tableLayoutPanelPersons
            // 
            this.tableLayoutPanelPersons.ColumnCount = 6;
            this.tableLayoutPanelPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelPersons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelPersons.Controls.Add(this.labelAdults, 0, 0);
            this.tableLayoutPanelPersons.Controls.Add(this.labelChildren, 2, 0);
            this.tableLayoutPanelPersons.Controls.Add(this.labelBabies, 4, 0);
            this.tableLayoutPanelPersons.Controls.Add(this.numericUpDownAdults, 1, 0);
            this.tableLayoutPanelPersons.Controls.Add(this.numericUpDownChildren, 3, 0);
            this.tableLayoutPanelPersons.Controls.Add(this.numericUpDownBabies, 5, 0);
            this.tableLayoutPanelPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPersons.Location = new System.Drawing.Point(3, 179);
            this.tableLayoutPanelPersons.Name = "tableLayoutPanelPersons";
            this.tableLayoutPanelPersons.RowCount = 1;
            this.tableLayoutPanelPersons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPersons.Size = new System.Drawing.Size(618, 82);
            this.tableLayoutPanelPersons.TabIndex = 1;
            // 
            // labelAdults
            // 
            this.labelAdults.AutoSize = true;
            this.labelAdults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAdults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdults.Location = new System.Drawing.Point(3, 0);
            this.labelAdults.Name = "labelAdults";
            this.labelAdults.Size = new System.Drawing.Size(150, 82);
            this.labelAdults.TabIndex = 0;
            this.labelAdults.Text = "Adults";
            this.labelAdults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelChildren
            // 
            this.labelChildren.AutoSize = true;
            this.labelChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChildren.Location = new System.Drawing.Point(208, 0);
            this.labelChildren.Name = "labelChildren";
            this.labelChildren.Size = new System.Drawing.Size(150, 82);
            this.labelChildren.TabIndex = 1;
            this.labelChildren.Text = "Children";
            this.labelChildren.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBabies
            // 
            this.labelBabies.AutoSize = true;
            this.labelBabies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBabies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBabies.Location = new System.Drawing.Point(413, 0);
            this.labelBabies.Name = "labelBabies";
            this.labelBabies.Size = new System.Drawing.Size(150, 82);
            this.labelBabies.TabIndex = 2;
            this.labelBabies.Text = "Babies";
            this.labelBabies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAdults
            // 
            this.numericUpDownAdults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAdults.Location = new System.Drawing.Point(159, 31);
            this.numericUpDownAdults.Name = "numericUpDownAdults";
            this.numericUpDownAdults.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownAdults.TabIndex = 3;
            // 
            // numericUpDownChildren
            // 
            this.numericUpDownChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownChildren.Location = new System.Drawing.Point(364, 31);
            this.numericUpDownChildren.Name = "numericUpDownChildren";
            this.numericUpDownChildren.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownChildren.TabIndex = 4;
            // 
            // numericUpDownBabies
            // 
            this.numericUpDownBabies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownBabies.Location = new System.Drawing.Point(569, 31);
            this.numericUpDownBabies.Name = "numericUpDownBabies";
            this.numericUpDownBabies.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownBabies.TabIndex = 5;
            // 
            // tableLayoutPanelClassFlight
            // 
            this.tableLayoutPanelClassFlight.ColumnCount = 4;
            this.tableLayoutPanelClassFlight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanelClassFlight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanelClassFlight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanelClassFlight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanelClassFlight.Controls.Add(this.labelClass, 0, 0);
            this.tableLayoutPanelClassFlight.Controls.Add(this.comboBoxFlightClass, 1, 0);
            this.tableLayoutPanelClassFlight.Controls.Add(this.labelFlight, 2, 0);
            this.tableLayoutPanelClassFlight.Controls.Add(this.comboBoxFlightTime, 3, 0);
            this.tableLayoutPanelClassFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelClassFlight.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanelClassFlight.Name = "tableLayoutPanelClassFlight";
            this.tableLayoutPanelClassFlight.RowCount = 1;
            this.tableLayoutPanelClassFlight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelClassFlight.Size = new System.Drawing.Size(618, 82);
            this.tableLayoutPanelClassFlight.TabIndex = 2;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClass.Location = new System.Drawing.Point(3, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(129, 82);
            this.labelClass.TabIndex = 0;
            this.labelClass.Text = "Class";
            this.labelClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFlightClass
            // 
            this.comboBoxFlightClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFlightClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFlightClass.FormattingEnabled = true;
            this.comboBoxFlightClass.Items.AddRange(new object[] {
            "Econom",
            "Business"});
            this.comboBoxFlightClass.Location = new System.Drawing.Point(138, 27);
            this.comboBoxFlightClass.Name = "comboBoxFlightClass";
            this.comboBoxFlightClass.Size = new System.Drawing.Size(129, 28);
            this.comboBoxFlightClass.TabIndex = 1;
            // 
            // labelFlight
            // 
            this.labelFlight.AutoSize = true;
            this.labelFlight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFlight.Location = new System.Drawing.Point(273, 0);
            this.labelFlight.Name = "labelFlight";
            this.labelFlight.Size = new System.Drawing.Size(129, 82);
            this.labelFlight.TabIndex = 2;
            this.labelFlight.Text = "Flight";
            this.labelFlight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxFlightTime
            // 
            this.comboBoxFlightTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFlightTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFlightTime.FormattingEnabled = true;
            this.comboBoxFlightTime.Items.AddRange(new object[] {
            "Night",
            "Morning",
            "Afternoon",
            "Evening"});
            this.comboBoxFlightTime.Location = new System.Drawing.Point(408, 27);
            this.comboBoxFlightTime.Name = "comboBoxFlightTime";
            this.comboBoxFlightTime.Size = new System.Drawing.Size(207, 28);
            this.comboBoxFlightTime.TabIndex = 3;
            // 
            // splitContainerCalc
            // 
            this.splitContainerCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerCalc.Location = new System.Drawing.Point(3, 355);
            this.splitContainerCalc.Name = "splitContainerCalc";
            // 
            // splitContainerCalc.Panel1
            // 
            this.splitContainerCalc.Panel1.Controls.Add(this.tableLayoutPanelButtons);
            // 
            // splitContainerCalc.Panel2
            // 
            this.splitContainerCalc.Panel2.Controls.Add(this.panelResult);
            this.splitContainerCalc.Size = new System.Drawing.Size(618, 84);
            this.splitContainerCalc.SplitterDistance = 206;
            this.splitContainerCalc.TabIndex = 3;
            // 
            // tableLayoutPanelButtons
            // 
            this.tableLayoutPanelButtons.ColumnCount = 1;
            this.tableLayoutPanelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelButtons.Controls.Add(this.buttonCalc, 0, 0);
            this.tableLayoutPanelButtons.Controls.Add(this.buttonUndo, 0, 1);
            this.tableLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelButtons.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            this.tableLayoutPanelButtons.RowCount = 2;
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelButtons.Size = new System.Drawing.Size(206, 84);
            this.tableLayoutPanelButtons.TabIndex = 0;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(3, 3);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(200, 36);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUndo.Enabled = false;
            this.buttonUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUndo.Location = new System.Drawing.Point(3, 45);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(200, 36);
            this.buttonUndo.TabIndex = 1;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // panelResult
            // 
            this.panelResult.Controls.Add(this.textBoxResult);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(0, 0);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(408, 84);
            this.panelResult.TabIndex = 0;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(3, 29);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(405, 26);
            this.textBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "Calculate Price of the Flight";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanelPoints.ResumeLayout(false);
            this.tableLayoutPanelPoints.PerformLayout();
            this.tableLayoutPanelPersons.ResumeLayout(false);
            this.tableLayoutPanelPersons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBabies)).EndInit();
            this.tableLayoutPanelClassFlight.ResumeLayout(false);
            this.tableLayoutPanelClassFlight.PerformLayout();
            this.splitContainerCalc.Panel1.ResumeLayout(false);
            this.splitContainerCalc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCalc)).EndInit();
            this.splitContainerCalc.ResumeLayout(false);
            this.tableLayoutPanelButtons.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPoints;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.TextBox textBoxDeparture;
        private System.Windows.Forms.ComboBox comboBoxFlightDestination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPersons;
        private System.Windows.Forms.Label labelAdults;
        private System.Windows.Forms.Label labelChildren;
        private System.Windows.Forms.Label labelBabies;
        private System.Windows.Forms.NumericUpDown numericUpDownAdults;
        private System.Windows.Forms.NumericUpDown numericUpDownChildren;
        private System.Windows.Forms.NumericUpDown numericUpDownBabies;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClassFlight;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxFlightClass;
        private System.Windows.Forms.Label labelFlight;
        private System.Windows.Forms.ComboBox comboBoxFlightTime;
        private System.Windows.Forms.SplitContainer splitContainerCalc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelButtons;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}
