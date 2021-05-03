
namespace ArchivMensch
{
    partial class FindPage
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SelectionBoxOne = new System.Windows.Forms.ComboBox();
            this.SelecetionBoxTwo = new System.Windows.Forms.ComboBox();
            this.SignLabel = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(596, 341);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(192, 97);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SelectionBoxOne
            // 
            this.SelectionBoxOne.FormattingEnabled = true;
            this.SelectionBoxOne.Items.AddRange(new object[] {
            "Student",
            "Guardian",
            "Class"});
            this.SelectionBoxOne.Location = new System.Drawing.Point(13, 13);
            this.SelectionBoxOne.Name = "SelectionBoxOne";
            this.SelectionBoxOne.Size = new System.Drawing.Size(121, 21);
            this.SelectionBoxOne.TabIndex = 1;
            // 
            // SelecetionBoxTwo
            // 
            this.SelecetionBoxTwo.FormattingEnabled = true;
            this.SelecetionBoxTwo.Items.AddRange(new object[] {
            "Student",
            "Guardian",
            "Class"});
            this.SelecetionBoxTwo.Location = new System.Drawing.Point(264, 12);
            this.SelecetionBoxTwo.Name = "SelecetionBoxTwo";
            this.SelecetionBoxTwo.Size = new System.Drawing.Size(121, 21);
            this.SelecetionBoxTwo.TabIndex = 2;
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignLabel.Location = new System.Drawing.Point(140, 14);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(118, 17);
            this.SignLabel.TabIndex = 3;
            this.SignLabel.Text = "Relation Between";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(12, 40);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(578, 398);
            this.DataGrid.TabIndex = 4;
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Location = new System.Drawing.Point(596, 238);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(192, 97);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.SelecetionBoxTwo);
            this.Controls.Add(this.SelectionBoxOne);
            this.Controls.Add(this.CloseButton);
            this.Name = "FindPage";
            this.Text = "FindPagecs";
            this.Load += new System.EventHandler(this.FindPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ComboBox SelectionBoxOne;
        private System.Windows.Forms.ComboBox SelecetionBoxTwo;
        private System.Windows.Forms.Label SignLabel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button FindButton;
    }
}