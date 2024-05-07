namespace GsdTextFormatter
{
    partial class TextFormatterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextFormatterForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SQLINFormatButton = new System.Windows.Forms.Button();
            this.synqFormatButton = new System.Windows.Forms.Button();
            this.csvFormatButton = new System.Windows.Forms.Button();
            this.newlineFormatButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.clipboardCopyButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.clipboardPasteButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.separateSpacesCheck = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.SQLINFormatButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.synqFormatButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.csvFormatButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.newlineFormatButton, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 264);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(782, 52);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // SQLINFormatButton
            // 
            this.SQLINFormatButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SQLINFormatButton.AutoSize = true;
            this.SQLINFormatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLINFormatButton.Location = new System.Drawing.Point(206, 3);
            this.SQLINFormatButton.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.SQLINFormatButton.Name = "SQLINFormatButton";
            this.SQLINFormatButton.Padding = new System.Windows.Forms.Padding(5);
            this.SQLINFormatButton.Size = new System.Drawing.Size(178, 46);
            this.SQLINFormatButton.TabIndex = 3;
            this.SQLINFormatButton.Text = "SQL IN";
            this.SQLINFormatButton.UseVisualStyleBackColor = true;
            this.SQLINFormatButton.Click += new System.EventHandler(this.SQLINFormatButton_Click_1);
            // 
            // synqFormatButton
            // 
            this.synqFormatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.synqFormatButton.AutoSize = true;
            this.synqFormatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.synqFormatButton.Location = new System.Drawing.Point(390, 3);
            this.synqFormatButton.Name = "synqFormatButton";
            this.synqFormatButton.Padding = new System.Windows.Forms.Padding(5);
            this.synqFormatButton.Size = new System.Drawing.Size(200, 46);
            this.synqFormatButton.TabIndex = 1;
            this.synqFormatButton.Text = "SynQ format";
            this.synqFormatButton.UseVisualStyleBackColor = true;
            this.synqFormatButton.Click += new System.EventHandler(this.SynqFormatButton_Click);
            // 
            // csvFormatButton
            // 
            this.csvFormatButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.csvFormatButton.AutoSize = true;
            this.csvFormatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csvFormatButton.Location = new System.Drawing.Point(3, 3);
            this.csvFormatButton.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.csvFormatButton.Name = "csvFormatButton";
            this.csvFormatButton.Padding = new System.Windows.Forms.Padding(5);
            this.csvFormatButton.Size = new System.Drawing.Size(187, 46);
            this.csvFormatButton.TabIndex = 0;
            this.csvFormatButton.Text = "CSV format";
            this.csvFormatButton.UseVisualStyleBackColor = true;
            this.csvFormatButton.Click += new System.EventHandler(this.CsvFormatButton_Click);
            // 
            // newlineFormatButton
            // 
            this.newlineFormatButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.newlineFormatButton.AutoSize = true;
            this.newlineFormatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newlineFormatButton.Location = new System.Drawing.Point(601, 3);
            this.newlineFormatButton.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.newlineFormatButton.Name = "newlineFormatButton";
            this.newlineFormatButton.Padding = new System.Windows.Forms.Padding(5);
            this.newlineFormatButton.Size = new System.Drawing.Size(178, 46);
            this.newlineFormatButton.TabIndex = 2;
            this.newlineFormatButton.Text = "Newline format";
            this.newlineFormatButton.UseVisualStyleBackColor = true;
            this.newlineFormatButton.Click += new System.EventHandler(this.NewlineFormatButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.resultBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.clipboardCopyButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.resultLabel, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 334);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(809, 186);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(96, 56);
            this.resultBox.Margin = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultBox.Size = new System.Drawing.Size(693, 125);
            this.resultBox.TabIndex = 1;
            this.resultBox.TextChanged += new System.EventHandler(this.ResultBox_TextChanged);
            // 
            // clipboardCopyButton
            // 
            this.clipboardCopyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clipboardCopyButton.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.clipboardCopyButton, 2);
            this.clipboardCopyButton.Enabled = false;
            this.clipboardCopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardCopyButton.Location = new System.Drawing.Point(286, 3);
            this.clipboardCopyButton.Name = "clipboardCopyButton";
            this.clipboardCopyButton.Padding = new System.Windows.Forms.Padding(5);
            this.clipboardCopyButton.Size = new System.Drawing.Size(236, 45);
            this.clipboardCopyButton.TabIndex = 0;
            this.clipboardCopyButton.Text = "Copy result to clipboard";
            this.clipboardCopyButton.UseVisualStyleBackColor = true;
            this.clipboardCopyButton.Click += new System.EventHandler(this.ClipboardCopyButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(3, 105);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(80, 26);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Result:";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.clipboardPasteButton, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.inputBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.inputLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(817, 194);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // clipboardPasteButton
            // 
            this.clipboardPasteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clipboardPasteButton.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.clipboardPasteButton, 2);
            this.clipboardPasteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardPasteButton.Location = new System.Drawing.Point(280, 146);
            this.clipboardPasteButton.Name = "clipboardPasteButton";
            this.clipboardPasteButton.Padding = new System.Windows.Forms.Padding(5);
            this.clipboardPasteButton.Size = new System.Drawing.Size(256, 45);
            this.clipboardPasteButton.TabIndex = 1;
            this.clipboardPasteButton.Text = "Paste input from clipboard";
            this.clipboardPasteButton.UseVisualStyleBackColor = true;
            this.clipboardPasteButton.Click += new System.EventHandler(this.ClipboardPasteButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(82, 5);
            this.inputBox.Margin = new System.Windows.Forms.Padding(10, 5, 20, 5);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(715, 133);
            this.inputBox.TabIndex = 0;
            // 
            // inputLabel
            // 
            this.inputLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(3, 58);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(66, 26);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Input:";
            this.inputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.separateSpacesCheck, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 205);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(817, 45);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Options:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // separateSpacesCheck
            // 
            this.separateSpacesCheck.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.separateSpacesCheck.AutoSize = true;
            this.separateSpacesCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separateSpacesCheck.Location = new System.Drawing.Point(129, 8);
            this.separateSpacesCheck.Margin = new System.Windows.Forms.Padding(30, 8, 8, 8);
            this.separateSpacesCheck.Name = "separateSpacesCheck";
            this.separateSpacesCheck.Size = new System.Drawing.Size(218, 29);
            this.separateSpacesCheck.TabIndex = 0;
            this.separateSpacesCheck.Text = "Split input on spaces";
            this.separateSpacesCheck.UseVisualStyleBackColor = true;
            // 
            // TextFormatterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 528);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "TextFormatterForm";
            this.Text = "GSD Text Formatter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button newlineFormatButton;
        private System.Windows.Forms.Button synqFormatButton;
        private System.Windows.Forms.Button clipboardCopyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox separateSpacesCheck;
        private System.Windows.Forms.Button clipboardPasteButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button csvFormatButton;
        private System.Windows.Forms.Button SQLINFormatButton;
    }
}

