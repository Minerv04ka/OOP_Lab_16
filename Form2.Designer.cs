namespace Lab_16
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            groupBox1 = new GroupBox();
            tbArea = new TextBox();
            tbIncome = new TextBox();
            tbPopulation = new TextBox();
            tbRegion = new TextBox();
            tbCountry = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbHasAirport = new CheckBox();
            cbHasPort = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbIncome);
            groupBox1.Controls.Add(tbPopulation);
            groupBox1.Controls.Add(tbRegion);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 263);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Info";
            // 
            // tbArea
            // 
            tbArea.Location = new Point(147, 217);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(157, 23);
            tbArea.TabIndex = 11;
            // 
            // tbIncome
            // 
            tbIncome.Location = new Point(147, 175);
            tbIncome.Name = "tbIncome";
            tbIncome.Size = new Size(157, 23);
            tbIncome.TabIndex = 10;
            // 
            // tbPopulation
            // 
            tbPopulation.Location = new Point(147, 138);
            tbPopulation.Name = "tbPopulation";
            tbPopulation.Size = new Size(157, 23);
            tbPopulation.TabIndex = 9;
            // 
            // tbRegion
            // 
            tbRegion.Location = new Point(147, 104);
            tbRegion.Name = "tbRegion";
            tbRegion.Size = new Size(157, 23);
            tbRegion.TabIndex = 8;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(147, 69);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(157, 23);
            tbCountry.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(147, 33);
            tbName.Name = "tbName";
            tbName.Size = new Size(157, 23);
            tbName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 220);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 5;
            label6.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 178);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Annual Income";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 141);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 107);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Region";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Country";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbHasAirport);
            groupBox2.Controls.Add(cbHasPort);
            groupBox2.Location = new Point(33, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transport";
            // 
            // cbHasAirport
            // 
            cbHasAirport.AutoSize = true;
            cbHasAirport.Location = new Point(24, 66);
            cbHasAirport.Name = "cbHasAirport";
            cbHasAirport.Size = new Size(84, 19);
            cbHasAirport.TabIndex = 1;
            cbHasAirport.Text = "Has airport";
            cbHasAirport.UseVisualStyleBackColor = true;
            // 
            // cbHasPort
            // 
            cbHasPort.AutoSize = true;
            cbHasPort.Location = new Point(24, 32);
            cbHasPort.Name = "cbHasPort";
            cbHasPort.Size = new Size(71, 19);
            cbHasPort.TabIndex = 0;
            cbHasPort.Text = "Has port";
            cbHasPort.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(412, 36);
            button1.Name = "button1";
            button1.Size = new Size(87, 33);
            button1.TabIndex = 2;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(412, 75);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox cbHasAirport;
        private CheckBox cbHasPort;
        private Button button1;
        private Button button2;
        private TextBox tbArea;
        private TextBox tbIncome;
        private TextBox tbPopulation;
        private TextBox tbRegion;
        private TextBox tbCountry;
        private TextBox tbName;
    }
}