namespace Replacetrix
{
    partial class DefaultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DefaultForm));
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.dataGridMenuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnPaste = new System.Windows.Forms.Button();
            this.PnBottom = new System.Windows.Forms.Panel();
            this.PnMenuBottom = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnReplace = new System.Windows.Forms.Button();
            this.ScConsoles = new System.Windows.Forms.SplitContainer();
            this.TxtInput = new System.Windows.Forms.RichTextBox();
            this.TxtOutput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.dataGridMenuContext.SuspendLayout();
            this.PnBottom.SuspendLayout();
            this.PnMenuBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScConsoles)).BeginInit();
            this.ScConsoles.Panel1.SuspendLayout();
            this.ScConsoles.Panel2.SuspendLayout();
            this.ScConsoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.ContextMenuStrip = this.dataGridMenuContext;
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvData.Location = new System.Drawing.Point(0, 71);
            this.DgvData.Name = "DgvData";
            this.DgvData.RowTemplate.Height = 24;
            this.DgvData.Size = new System.Drawing.Size(1324, 366);
            this.DgvData.TabIndex = 3;
            // 
            // dataGridMenuContext
            // 
            this.dataGridMenuContext.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dataGridMenuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addColumnToolStripMenuItem,
            this.clearGridToolStripMenuItem});
            this.dataGridMenuContext.Name = "dataGridMenuContext";
            this.dataGridMenuContext.Size = new System.Drawing.Size(169, 52);
            // 
            // addColumnToolStripMenuItem
            // 
            this.addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            this.addColumnToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.addColumnToolStripMenuItem.Text = "Add column...";
            this.addColumnToolStripMenuItem.Click += new System.EventHandler(this.addColumnToolStripMenuItem_Click);
            // 
            // clearGridToolStripMenuItem
            // 
            this.clearGridToolStripMenuItem.Name = "clearGridToolStripMenuItem";
            this.clearGridToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.clearGridToolStripMenuItem.Text = "Clear grid";
            this.clearGridToolStripMenuItem.Click += new System.EventHandler(this.clearGridToolStripMenuItem_Click);
            // 
            // BtnPaste
            // 
            this.BtnPaste.Location = new System.Drawing.Point(12, 15);
            this.BtnPaste.Name = "BtnPaste";
            this.BtnPaste.Size = new System.Drawing.Size(75, 37);
            this.BtnPaste.TabIndex = 4;
            this.BtnPaste.Text = "Paste";
            this.BtnPaste.UseVisualStyleBackColor = true;
            this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // PnBottom
            // 
            this.PnBottom.Controls.Add(this.DgvData);
            this.PnBottom.Controls.Add(this.PnMenuBottom);
            this.PnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnBottom.Location = new System.Drawing.Point(0, 282);
            this.PnBottom.Name = "PnBottom";
            this.PnBottom.Size = new System.Drawing.Size(1324, 437);
            this.PnBottom.TabIndex = 5;
            // 
            // PnMenuBottom
            // 
            this.PnMenuBottom.Controls.Add(this.BtnCancel);
            this.PnMenuBottom.Controls.Add(this.BtnReplace);
            this.PnMenuBottom.Controls.Add(this.BtnPaste);
            this.PnMenuBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnMenuBottom.Location = new System.Drawing.Point(0, 0);
            this.PnMenuBottom.Name = "PnMenuBottom";
            this.PnMenuBottom.Size = new System.Drawing.Size(1324, 71);
            this.PnMenuBottom.TabIndex = 4;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Enabled = false;
            this.BtnCancel.Location = new System.Drawing.Point(209, 15);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 37);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnReplace
            // 
            this.BtnReplace.Location = new System.Drawing.Point(113, 15);
            this.BtnReplace.Name = "BtnReplace";
            this.BtnReplace.Size = new System.Drawing.Size(75, 37);
            this.BtnReplace.TabIndex = 5;
            this.BtnReplace.Text = "Replace";
            this.BtnReplace.UseVisualStyleBackColor = true;
            this.BtnReplace.Click += new System.EventHandler(this.BtnReplace_Click);
            // 
            // ScConsoles
            // 
            this.ScConsoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScConsoles.Location = new System.Drawing.Point(0, 0);
            this.ScConsoles.Name = "ScConsoles";
            // 
            // ScConsoles.Panel1
            // 
            this.ScConsoles.Panel1.Controls.Add(this.TxtInput);
            // 
            // ScConsoles.Panel2
            // 
            this.ScConsoles.Panel2.Controls.Add(this.TxtOutput);
            this.ScConsoles.Size = new System.Drawing.Size(1324, 282);
            this.ScConsoles.SplitterDistance = 441;
            this.ScConsoles.TabIndex = 8;
            // 
            // TxtInput
            // 
            this.TxtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtInput.Location = new System.Drawing.Point(0, 0);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(441, 282);
            this.TxtInput.TabIndex = 1;
            this.TxtInput.Text = "";
            // 
            // TxtOutput
            // 
            this.TxtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtOutput.Location = new System.Drawing.Point(0, 0);
            this.TxtOutput.Name = "TxtOutput";
            this.TxtOutput.Size = new System.Drawing.Size(879, 282);
            this.TxtOutput.TabIndex = 0;
            this.TxtOutput.Text = "";
            // 
            // DefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 719);
            this.Controls.Add(this.ScConsoles);
            this.Controls.Add(this.PnBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DefaultForm";
            this.Text = "Replacetrix";
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.dataGridMenuContext.ResumeLayout(false);
            this.PnBottom.ResumeLayout(false);
            this.PnMenuBottom.ResumeLayout(false);
            this.ScConsoles.Panel1.ResumeLayout(false);
            this.ScConsoles.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScConsoles)).EndInit();
            this.ScConsoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Button BtnPaste;
        private System.Windows.Forms.Panel PnBottom;
        private System.Windows.Forms.Panel PnMenuBottom;
        private System.Windows.Forms.SplitContainer ScConsoles;
        private System.Windows.Forms.Button BtnReplace;
        private System.Windows.Forms.ContextMenuStrip dataGridMenuContext;
        private System.Windows.Forms.RichTextBox TxtInput;
        private System.Windows.Forms.RichTextBox TxtOutput;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ToolStripMenuItem addColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearGridToolStripMenuItem;
    }
}

