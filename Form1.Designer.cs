namespace Lab_16
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            bAdd = new ToolStripButton();
            bEdit = new ToolStripButton();
            tsSep1 = new ToolStripSeparator();
            bDelete = new ToolStripButton();
            bClear = new ToolStripButton();
            tsSep2 = new ToolStripSeparator();
            bExit = new ToolStripButton();
            bsTowns = new BindingSource(components);
            gvTowns = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsTowns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvTowns).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { bAdd, bEdit, tsSep1, bDelete, bClear, tsSep2, bExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // bAdd
            // 
            bAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bAdd.Image = (Image)resources.GetObject("bAdd.Image");
            bAdd.ImageTransparentColor = Color.Magenta;
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(23, 22);
            bAdd.Text = "Add";
            bAdd.Click += bAdd_Click;
            // 
            // bEdit
            // 
            bEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bEdit.Image = (Image)resources.GetObject("bEdit.Image");
            bEdit.ImageTransparentColor = Color.Magenta;
            bEdit.Name = "bEdit";
            bEdit.Size = new Size(23, 22);
            bEdit.Text = "Edit";
            bEdit.Click += bEdit_Click;
            // 
            // tsSep1
            // 
            tsSep1.Name = "tsSep1";
            tsSep1.Size = new Size(6, 25);
            // 
            // bDelete
            // 
            bDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bDelete.Image = (Image)resources.GetObject("bDelete.Image");
            bDelete.ImageTransparentColor = Color.Magenta;
            bDelete.Name = "bDelete";
            bDelete.Size = new Size(23, 22);
            bDelete.Text = "Delete";
            bDelete.Click += bDelete_Click;
            // 
            // bClear
            // 
            bClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bClear.Image = (Image)resources.GetObject("bClear.Image");
            bClear.ImageTransparentColor = Color.Magenta;
            bClear.Name = "bClear";
            bClear.Size = new Size(23, 22);
            bClear.Text = "Clear Table";
            bClear.Click += bClear_Click;
            // 
            // tsSep2
            // 
            tsSep2.Name = "tsSep2";
            tsSep2.Size = new Size(6, 25);
            // 
            // bExit
            // 
            bExit.Alignment = ToolStripItemAlignment.Right;
            bExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            bExit.Image = (Image)resources.GetObject("bExit.Image");
            bExit.ImageTransparentColor = Color.Magenta;
            bExit.Margin = new Padding(5, 1, 0, 2);
            bExit.Name = "bExit";
            bExit.Size = new Size(23, 22);
            bExit.Text = "Exit";
            bExit.Click += bExit_Click;
            // 
            // gvTowns
            // 
            gvTowns.AllowUserToAddRows = false;
            gvTowns.AllowUserToDeleteRows = false;
            gvTowns.AutoGenerateColumns = false;
            gvTowns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTowns.DataSource = bsTowns;
            gvTowns.Dock = DockStyle.Fill;
            gvTowns.Location = new Point(0, 25);
            gvTowns.Name = "gvTowns";
            gvTowns.ReadOnly = true;
            gvTowns.Size = new Size(800, 425);
            gvTowns.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvTowns);
            Controls.Add(toolStrip1);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab 16";
            Load += fMain_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsTowns).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvTowns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton bAdd;
        private ToolStripButton bEdit;
        private ToolStripSeparator tsSep1;
        private ToolStripButton bDelete;
        private ToolStripButton bClear;
        private ToolStripSeparator tsSep2;
        private ToolStripButton bExit;
        private BindingSource bsTowns;
        private DataGridView gvTowns;
    }
}
