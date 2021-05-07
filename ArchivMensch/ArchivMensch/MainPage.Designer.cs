
namespace ArchivMensch
{
    partial class MainPage
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
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DirectQueryButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ViewModeBox = new System.Windows.Forms.ComboBox();
            this.ViewOptions = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Location = new System.Drawing.Point(13, 13);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(633, 425);
            this.DataGrid.TabIndex = 3;
            this.DataGrid.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataGrid_RowValidating);
            // 
            // DirectQueryButton
            // 
            this.DirectQueryButton.Location = new System.Drawing.Point(652, 385);
            this.DirectQueryButton.Name = "DirectQueryButton";
            this.DirectQueryButton.Size = new System.Drawing.Size(136, 53);
            this.DirectQueryButton.TabIndex = 4;
            this.DirectQueryButton.Text = "Direct Query";
            this.DirectQueryButton.UseVisualStyleBackColor = true;
            this.DirectQueryButton.Click += new System.EventHandler(this.DirectQueryButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(652, 13);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(136, 53);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(652, 72);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(136, 53);
            this.ChangeButton.TabIndex = 6;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(652, 131);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(136, 53);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(652, 326);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(136, 53);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ViewModeBox
            // 
            this.ViewModeBox.FormattingEnabled = true;
            this.ViewModeBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ViewModeBox.Items.AddRange(new object[] {
            "Student",
            "Guardian",
            "Teacher",
            "Class",
            "Course"});
            this.ViewModeBox.Location = new System.Drawing.Point(652, 299);
            this.ViewModeBox.Name = "ViewModeBox";
            this.ViewModeBox.Size = new System.Drawing.Size(136, 21);
            this.ViewModeBox.TabIndex = 9;
            this.ViewModeBox.SelectedIndexChanged += new System.EventHandler(this.ViewModeBox_SelectedIndexChanged);
            // 
            // ViewOptions
            // 
            this.ViewOptions.AutoSize = true;
            this.ViewOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewOptions.Location = new System.Drawing.Point(652, 279);
            this.ViewOptions.Name = "ViewOptions";
            this.ViewOptions.Size = new System.Drawing.Size(90, 17);
            this.ViewOptions.TabIndex = 10;
            this.ViewOptions.Text = "View Options";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(652, 190);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(136, 53);
            this.FindButton.TabIndex = 11;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.ViewOptions);
            this.Controls.Add(this.ViewModeBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DirectQueryButton);
            this.Controls.Add(this.DataGrid);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.Button DirectQueryButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ComboBox ViewModeBox;
        private System.Windows.Forms.Label ViewOptions;
        private System.Windows.Forms.Button FindButton;
    }
}

