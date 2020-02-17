namespace VehicleTest
{
    partial class VehicleForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VehicleGridView = new System.Windows.Forms.DataGridView();
            this.btnRightNew = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            this.Heading = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VehicleGridView
            // 
            this.VehicleGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.VehicleGridView.AllowUserToOrderColumns = true;
            this.VehicleGridView.BackgroundColor = System.Drawing.Color.Ivory;
            this.VehicleGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VehicleGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VehicleGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleGridView.Location = new System.Drawing.Point(3, 13);
            this.VehicleGridView.Margin = new System.Windows.Forms.Padding(4);
            this.VehicleGridView.Name = "VehicleGridView";
            this.VehicleGridView.Size = new System.Drawing.Size(871, 199);
            this.VehicleGridView.TabIndex = 0;
            this.VehicleGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRightNew
            // 
            this.btnRightNew.Location = new System.Drawing.Point(511, 229);
            this.btnRightNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnRightNew.Name = "btnRightNew";
            this.btnRightNew.Size = new System.Drawing.Size(176, 28);
            this.btnRightNew.TabIndex = 1;
            this.btnRightNew.Text = "WritetNewData";
            this.btnRightNew.UseVisualStyleBackColor = true;
            this.btnRightNew.Click += new System.EventHandler(this.btnRightNew_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(143, 225);
            this.ReadFile.Margin = new System.Windows.Forms.Padding(4);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(100, 28);
            this.ReadFile.TabIndex = 2;
            this.ReadFile.Text = "ReadFile";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.ReadFile_Click);
            // 
            // Heading
            // 
            this.Heading.Location = new System.Drawing.Point(343, 225);
            this.Heading.Margin = new System.Windows.Forms.Padding(4);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(100, 28);
            this.Heading.TabIndex = 3;
            this.Heading.Text = "Heading";
            this.Heading.UseVisualStyleBackColor = true;
            this.Heading.Click += new System.EventHandler(this.Heading_Click);
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 382);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.btnRightNew);
            this.Controls.Add(this.VehicleGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VehicleForm";
            this.Text = "Vehicles";
            ((System.ComponentModel.ISupportInitialize)(this.VehicleGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VehicleGridView;
        private System.Windows.Forms.Button btnRightNew;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button Heading;
    }
}

