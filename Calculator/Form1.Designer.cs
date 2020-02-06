namespace Calculator
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.DotButton = new System.Windows.Forms.Button();
            this.EqButton = new System.Windows.Forms.Button();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Font = new System.Drawing.Font("Tandysoft", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputText.Location = new System.Drawing.Point(12, 12);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(460, 24);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Font = new System.Drawing.Font("Tandysoft", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculationResultText.Location = new System.Drawing.Point(12, 35);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(457, 46);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Pleas enter the equation and pres ENTER or =";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonsPanel.Controls.Add(this.DelButton, 2, 0);
            this.ButtonsPanel.Controls.Add(this.DivButton, 3, 0);
            this.ButtonsPanel.Controls.Add(this.Button7, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Button8, 1, 1);
            this.ButtonsPanel.Controls.Add(this.Button9, 2, 1);
            this.ButtonsPanel.Controls.Add(this.MulButton, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Button4, 0, 2);
            this.ButtonsPanel.Controls.Add(this.Button5, 1, 2);
            this.ButtonsPanel.Controls.Add(this.Button6, 2, 2);
            this.ButtonsPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Button1, 0, 3);
            this.ButtonsPanel.Controls.Add(this.Button2, 1, 3);
            this.ButtonsPanel.Controls.Add(this.Button3, 2, 3);
            this.ButtonsPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonsPanel.Controls.Add(this.Button0, 1, 4);
            this.ButtonsPanel.Controls.Add(this.DotButton, 2, 4);
            this.ButtonsPanel.Controls.Add(this.EqButton, 3, 4);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 84);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(460, 385);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.LightCyan;
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEButton.Location = new System.Drawing.Point(3, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(109, 71);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.LightCyan;
            this.DelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DelButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelButton.Location = new System.Drawing.Point(233, 3);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(109, 71);
            this.DelButton.TabIndex = 2;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // DivButton
            // 
            this.DivButton.BackColor = System.Drawing.Color.LightCyan;
            this.DivButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivButton.Location = new System.Drawing.Point(348, 3);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(109, 71);
            this.DivButton.TabIndex = 3;
            this.DivButton.Text = "/";
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // Button7
            // 
            this.Button7.BackColor = System.Drawing.Color.Pink;
            this.Button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button7.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.Location = new System.Drawing.Point(3, 80);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(109, 71);
            this.Button7.TabIndex = 4;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = false;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.BackColor = System.Drawing.Color.Pink;
            this.Button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button8.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8.Location = new System.Drawing.Point(118, 80);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(109, 71);
            this.Button8.TabIndex = 5;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = false;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.BackColor = System.Drawing.Color.Pink;
            this.Button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button9.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9.Location = new System.Drawing.Point(233, 80);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(109, 71);
            this.Button9.TabIndex = 6;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = false;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // MulButton
            // 
            this.MulButton.BackColor = System.Drawing.Color.LightCyan;
            this.MulButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MulButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MulButton.Location = new System.Drawing.Point(348, 80);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(109, 71);
            this.MulButton.TabIndex = 7;
            this.MulButton.Text = "X";
            this.MulButton.UseVisualStyleBackColor = false;
            this.MulButton.Click += new System.EventHandler(this.MulButton_Click);
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.Pink;
            this.Button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button4.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.Location = new System.Drawing.Point(3, 157);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(109, 71);
            this.Button4.TabIndex = 8;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Pink;
            this.Button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button5.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.Location = new System.Drawing.Point(118, 157);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(109, 71);
            this.Button5.TabIndex = 9;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.Pink;
            this.Button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button6.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.Location = new System.Drawing.Point(233, 157);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(109, 71);
            this.Button6.TabIndex = 10;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.LightCyan;
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusButton.Location = new System.Drawing.Point(348, 157);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(109, 71);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Pink;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button1.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(3, 234);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(109, 71);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Pink;
            this.Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button2.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.Location = new System.Drawing.Point(118, 234);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(109, 71);
            this.Button2.TabIndex = 13;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.Pink;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button3.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(233, 234);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(109, 71);
            this.Button3.TabIndex = 14;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.LightCyan;
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusButton.Location = new System.Drawing.Point(348, 234);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(109, 71);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // Button0
            // 
            this.Button0.BackColor = System.Drawing.Color.Pink;
            this.Button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button0.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button0.Location = new System.Drawing.Point(118, 311);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(109, 71);
            this.Button0.TabIndex = 17;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = false;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.Pink;
            this.DotButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DotButton.Font = new System.Drawing.Font("Tandysoft", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotButton.Location = new System.Drawing.Point(233, 311);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(109, 71);
            this.DotButton.TabIndex = 18;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // EqButton
            // 
            this.EqButton.BackColor = System.Drawing.Color.LightCyan;
            this.EqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqButton.Font = new System.Drawing.Font("Tandysoft", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqButton.Location = new System.Drawing.Point(348, 311);
            this.EqButton.Name = "EqButton";
            this.EqButton.Size = new System.Drawing.Size(109, 71);
            this.EqButton.TabIndex = 19;
            this.EqButton.Text = "=";
            this.EqButton.UseVisualStyleBackColor = false;
            this.EqButton.Click += new System.EventHandler(this.EqButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.EqButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button MulButton;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button EqButton;
    }
}

