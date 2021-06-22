
namespace Börse
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dollareuroLabel = new System.Windows.Forms.Label();
            this.clientgroupBox = new System.Windows.Forms.GroupBox();
            this.miningClientlabel = new System.Windows.Forms.Label();
            this.revenuegroupBox = new System.Windows.Forms.GroupBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.weekLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.hardwaregroupBox = new System.Windows.Forms.GroupBox();
            this.hardwarecomboBox = new System.Windows.Forms.ComboBox();
            this.powerLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.hardwareNameLabel = new System.Windows.Forms.Label();
            this.refreshWorkerbutton = new System.Windows.Forms.Button();
            this.workerNamegroupBox = new System.Windows.Forms.GroupBox();
            this.workerLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coinNameLabel = new System.Windows.Forms.Label();
            this.pricegroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimelabel = new System.Windows.Forms.Label();
            this.stocklabel1 = new System.Windows.Forms.Label();
            this.stocklabel2 = new System.Windows.Forms.Label();
            this.stocklabel4 = new System.Windows.Forms.Label();
            this.stocklabel3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.clientgroupBox.SuspendLayout();
            this.revenuegroupBox.SuspendLayout();
            this.hardwaregroupBox.SuspendLayout();
            this.workerNamegroupBox.SuspendLayout();
            this.pricegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 329);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dollareuroLabel);
            this.groupBox1.Controls.Add(this.clientgroupBox);
            this.groupBox1.Controls.Add(this.revenuegroupBox);
            this.groupBox1.Controls.Add(this.hardwaregroupBox);
            this.groupBox1.Controls.Add(this.refreshWorkerbutton);
            this.groupBox1.Controls.Add(this.workerNamegroupBox);
            this.groupBox1.Controls.Add(this.coinNameLabel);
            this.groupBox1.Controls.Add(this.pricegroupBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBox1.Size = new System.Drawing.Size(767, 420);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CryptoCoins";
            // 
            // dollareuroLabel
            // 
            this.dollareuroLabel.AutoSize = true;
            this.dollareuroLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollareuroLabel.Location = new System.Drawing.Point(22, 43);
            this.dollareuroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dollareuroLabel.Name = "dollareuroLabel";
            this.dollareuroLabel.Size = new System.Drawing.Size(0, 19);
            this.dollareuroLabel.TabIndex = 14;
            // 
            // clientgroupBox
            // 
            this.clientgroupBox.Controls.Add(this.miningClientlabel);
            this.clientgroupBox.Location = new System.Drawing.Point(516, 239);
            this.clientgroupBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clientgroupBox.Name = "clientgroupBox";
            this.clientgroupBox.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.clientgroupBox.Size = new System.Drawing.Size(200, 76);
            this.clientgroupBox.TabIndex = 13;
            this.clientgroupBox.TabStop = false;
            this.clientgroupBox.Text = "Mining Client";
            // 
            // miningClientlabel
            // 
            this.miningClientlabel.AutoSize = true;
            this.miningClientlabel.Location = new System.Drawing.Point(23, 35);
            this.miningClientlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.miningClientlabel.Name = "miningClientlabel";
            this.miningClientlabel.Size = new System.Drawing.Size(0, 19);
            this.miningClientlabel.TabIndex = 3;
            // 
            // revenuegroupBox
            // 
            this.revenuegroupBox.Controls.Add(this.monthLabel);
            this.revenuegroupBox.Controls.Add(this.weekLabel);
            this.revenuegroupBox.Controls.Add(this.dayLabel);
            this.revenuegroupBox.Location = new System.Drawing.Point(516, 25);
            this.revenuegroupBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.revenuegroupBox.Name = "revenuegroupBox";
            this.revenuegroupBox.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.revenuegroupBox.Size = new System.Drawing.Size(200, 200);
            this.revenuegroupBox.TabIndex = 12;
            this.revenuegroupBox.TabStop = false;
            this.revenuegroupBox.Text = "Revenue";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(23, 147);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(0, 19);
            this.monthLabel.TabIndex = 5;
            // 
            // weekLabel
            // 
            this.weekLabel.AutoSize = true;
            this.weekLabel.Location = new System.Drawing.Point(23, 99);
            this.weekLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weekLabel.Name = "weekLabel";
            this.weekLabel.Size = new System.Drawing.Size(0, 19);
            this.weekLabel.TabIndex = 4;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(23, 48);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(0, 19);
            this.dayLabel.TabIndex = 3;
            // 
            // hardwaregroupBox
            // 
            this.hardwaregroupBox.Controls.Add(this.hardwarecomboBox);
            this.hardwaregroupBox.Controls.Add(this.powerLabel);
            this.hardwaregroupBox.Controls.Add(this.tempLabel);
            this.hardwaregroupBox.Controls.Add(this.hardwareNameLabel);
            this.hardwaregroupBox.Location = new System.Drawing.Point(259, 150);
            this.hardwaregroupBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.hardwaregroupBox.Name = "hardwaregroupBox";
            this.hardwaregroupBox.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.hardwaregroupBox.Size = new System.Drawing.Size(200, 225);
            this.hardwaregroupBox.TabIndex = 11;
            this.hardwaregroupBox.TabStop = false;
            this.hardwaregroupBox.Text = "Hardware";
            // 
            // hardwarecomboBox
            // 
            this.hardwarecomboBox.FormattingEnabled = true;
            this.hardwarecomboBox.Location = new System.Drawing.Point(7, 26);
            this.hardwarecomboBox.Name = "hardwarecomboBox";
            this.hardwarecomboBox.Size = new System.Drawing.Size(188, 27);
            this.hardwarecomboBox.TabIndex = 3;
            this.hardwarecomboBox.SelectedIndexChanged += new System.EventHandler(this.hardwarecomboBox_SelectedIndexChanged);
            // 
            // powerLabel
            // 
            this.powerLabel.AutoSize = true;
            this.powerLabel.Location = new System.Drawing.Point(18, 188);
            this.powerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.powerLabel.Name = "powerLabel";
            this.powerLabel.Size = new System.Drawing.Size(0, 19);
            this.powerLabel.TabIndex = 2;
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(18, 139);
            this.tempLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(0, 19);
            this.tempLabel.TabIndex = 1;
            // 
            // hardwareNameLabel
            // 
            this.hardwareNameLabel.AutoSize = true;
            this.hardwareNameLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardwareNameLabel.Location = new System.Drawing.Point(4, 89);
            this.hardwareNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hardwareNameLabel.Name = "hardwareNameLabel";
            this.hardwareNameLabel.Size = new System.Drawing.Size(0, 16);
            this.hardwareNameLabel.TabIndex = 0;
            // 
            // refreshWorkerbutton
            // 
            this.refreshWorkerbutton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshWorkerbutton.Location = new System.Drawing.Point(580, 329);
            this.refreshWorkerbutton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.refreshWorkerbutton.Name = "refreshWorkerbutton";
            this.refreshWorkerbutton.Size = new System.Drawing.Size(170, 69);
            this.refreshWorkerbutton.TabIndex = 10;
            this.refreshWorkerbutton.Text = "Refresh Worker";
            this.refreshWorkerbutton.UseVisualStyleBackColor = true;
            this.refreshWorkerbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // workerNamegroupBox
            // 
            this.workerNamegroupBox.Controls.Add(this.workerLabel);
            this.workerNamegroupBox.Controls.Add(this.label3);
            this.workerNamegroupBox.Location = new System.Drawing.Point(259, 25);
            this.workerNamegroupBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.workerNamegroupBox.Name = "workerNamegroupBox";
            this.workerNamegroupBox.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.workerNamegroupBox.Size = new System.Drawing.Size(200, 100);
            this.workerNamegroupBox.TabIndex = 9;
            this.workerNamegroupBox.TabStop = false;
            this.workerNamegroupBox.Text = "Worker";
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerLabel.Location = new System.Drawing.Point(20, 41);
            this.workerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(0, 27);
            this.workerLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 0;
            // 
            // coinNameLabel
            // 
            this.coinNameLabel.AutoSize = true;
            this.coinNameLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinNameLabel.Location = new System.Drawing.Point(20, 95);
            this.coinNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coinNameLabel.Name = "coinNameLabel";
            this.coinNameLabel.Size = new System.Drawing.Size(0, 48);
            this.coinNameLabel.TabIndex = 8;
            // 
            // pricegroupBox
            // 
            this.pricegroupBox.Controls.Add(this.label2);
            this.pricegroupBox.Controls.Add(this.label1);
            this.pricegroupBox.Location = new System.Drawing.Point(14, 173);
            this.pricegroupBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pricegroupBox.Name = "pricegroupBox";
            this.pricegroupBox.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pricegroupBox.Size = new System.Drawing.Size(200, 78);
            this.pricegroupBox.TabIndex = 7;
            this.pricegroupBox.TabStop = false;
            this.pricegroupBox.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, -87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 73);
            this.label1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 295);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 27);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "BTC";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimelabel
            // 
            this.dateTimelabel.AutoSize = true;
            this.dateTimelabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimelabel.Location = new System.Drawing.Point(619, 6);
            this.dateTimelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTimelabel.Name = "dateTimelabel";
            this.dateTimelabel.Size = new System.Drawing.Size(47, 13);
            this.dateTimelabel.TabIndex = 5;
            this.dateTimelabel.Text = "DateTime";
            // 
            // stocklabel1
            // 
            this.stocklabel1.AutoSize = true;
            this.stocklabel1.Location = new System.Drawing.Point(20, 4);
            this.stocklabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stocklabel1.Name = "stocklabel1";
            this.stocklabel1.Size = new System.Drawing.Size(30, 13);
            this.stocklabel1.TabIndex = 6;
            this.stocklabel1.Text = "AMD";
            // 
            // stocklabel2
            // 
            this.stocklabel2.AutoSize = true;
            this.stocklabel2.Location = new System.Drawing.Point(120, 4);
            this.stocklabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stocklabel2.Name = "stocklabel2";
            this.stocklabel2.Size = new System.Drawing.Size(30, 13);
            this.stocklabel2.TabIndex = 7;
            this.stocklabel2.Text = "AMD";
            // 
            // stocklabel4
            // 
            this.stocklabel4.AutoSize = true;
            this.stocklabel4.Location = new System.Drawing.Point(320, 4);
            this.stocklabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stocklabel4.Name = "stocklabel4";
            this.stocklabel4.Size = new System.Drawing.Size(30, 13);
            this.stocklabel4.TabIndex = 9;
            this.stocklabel4.Text = "AMD";
            // 
            // stocklabel3
            // 
            this.stocklabel3.AutoSize = true;
            this.stocklabel3.Location = new System.Drawing.Point(220, 4);
            this.stocklabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stocklabel3.Name = "stocklabel3";
            this.stocklabel3.Size = new System.Drawing.Size(30, 13);
            this.stocklabel3.TabIndex = 8;
            this.stocklabel3.Text = "AMD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stocklabel4);
            this.Controls.Add(this.stocklabel3);
            this.Controls.Add(this.stocklabel2);
            this.Controls.Add(this.stocklabel1);
            this.Controls.Add(this.dateTimelabel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.Text = "Polyák András Programja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.clientgroupBox.ResumeLayout(false);
            this.clientgroupBox.PerformLayout();
            this.revenuegroupBox.ResumeLayout(false);
            this.revenuegroupBox.PerformLayout();
            this.hardwaregroupBox.ResumeLayout(false);
            this.hardwaregroupBox.PerformLayout();
            this.workerNamegroupBox.ResumeLayout(false);
            this.workerNamegroupBox.PerformLayout();
            this.pricegroupBox.ResumeLayout(false);
            this.pricegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pricegroupBox;
        private System.Windows.Forms.Label coinNameLabel;
        private System.Windows.Forms.Button refreshWorkerbutton;
        private System.Windows.Forms.GroupBox workerNamegroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox clientgroupBox;
        private System.Windows.Forms.GroupBox revenuegroupBox;
        private System.Windows.Forms.GroupBox hardwaregroupBox;
        private System.Windows.Forms.Label miningClientlabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label weekLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label powerLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label hardwareNameLabel;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.Label dollareuroLabel;
        private System.Windows.Forms.Label dateTimelabel;
        private System.Windows.Forms.Label stocklabel1;
        private System.Windows.Forms.Label stocklabel2;
        private System.Windows.Forms.Label stocklabel4;
        private System.Windows.Forms.Label stocklabel3;
        private System.Windows.Forms.ComboBox hardwarecomboBox;
    }
}

