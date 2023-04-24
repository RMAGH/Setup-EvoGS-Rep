namespace Setup_EvoGS_Rep
{
    partial class Main
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
            Rep_Lb = new Label();
            Rep_CB = new ComboBox();
            Infos_LP = new TableLayoutPanel();
            Drive_Lb = new Label();
            Drive_CB = new ComboBox();
            User_Lb = new Label();
            Password_Lb = new Label();
            User_TxB = new TextBox();
            Password_TxB = new TextBox();
            Setup_Bt = new Button();
            Infos_LP.SuspendLayout();
            SuspendLayout();
            // 
            // Rep_Lb
            // 
            Rep_Lb.Anchor = AnchorStyles.Left;
            Rep_Lb.AutoSize = true;
            Rep_Lb.Location = new Point(3, 61);
            Rep_Lb.Name = "Rep_Lb";
            Rep_Lb.Size = new Size(66, 15);
            Rep_Lb.TabIndex = 0;
            Rep_Lb.Text = "Repository:";
            Rep_Lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Rep_CB
            // 
            Rep_CB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Rep_CB.Enabled = false;
            Rep_CB.FormattingEnabled = true;
            Rep_CB.Location = new Point(126, 57);
            Rep_CB.Name = "Rep_CB";
            Rep_CB.Size = new Size(168, 23);
            Rep_CB.TabIndex = 1;
            Rep_CB.TextUpdate += Rep_CB_TextUpdate;
            // 
            // Infos_LP
            // 
            Infos_LP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Infos_LP.ColumnCount = 2;
            Infos_LP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.66667F));
            Infos_LP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.3333321F));
            Infos_LP.Controls.Add(Rep_Lb, 0, 1);
            Infos_LP.Controls.Add(Drive_Lb, 0, 0);
            Infos_LP.Controls.Add(Drive_CB, 1, 0);
            Infos_LP.Controls.Add(Rep_CB, 1, 1);
            Infos_LP.Controls.Add(User_Lb, 0, 2);
            Infos_LP.Controls.Add(Password_Lb, 0, 3);
            Infos_LP.Controls.Add(User_TxB, 1, 2);
            Infos_LP.Controls.Add(Password_TxB, 1, 3);
            Infos_LP.Location = new Point(12, 12);
            Infos_LP.Name = "Infos_LP";
            Infos_LP.RowCount = 4;
            Infos_LP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Infos_LP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Infos_LP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Infos_LP.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            Infos_LP.Size = new Size(297, 185);
            Infos_LP.TabIndex = 3;
            // 
            // Drive_Lb
            // 
            Drive_Lb.Anchor = AnchorStyles.Left;
            Drive_Lb.AutoSize = true;
            Drive_Lb.Location = new Point(3, 15);
            Drive_Lb.Name = "Drive_Lb";
            Drive_Lb.Size = new Size(37, 15);
            Drive_Lb.TabIndex = 0;
            Drive_Lb.Text = "Drive:";
            Drive_Lb.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Drive_CB
            // 
            Drive_CB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Drive_CB.FormattingEnabled = true;
            Drive_CB.Location = new Point(126, 11);
            Drive_CB.Name = "Drive_CB";
            Drive_CB.Size = new Size(168, 23);
            Drive_CB.TabIndex = 2;
            Drive_CB.TextUpdate += Drive_CB_TextUpdate;
            // 
            // User_Lb
            // 
            User_Lb.Anchor = AnchorStyles.Left;
            User_Lb.AutoSize = true;
            User_Lb.Location = new Point(3, 107);
            User_Lb.Name = "User_Lb";
            User_Lb.Size = new Size(33, 15);
            User_Lb.TabIndex = 3;
            User_Lb.Text = "User:";
            // 
            // Password_Lb
            // 
            Password_Lb.Anchor = AnchorStyles.Left;
            Password_Lb.AutoSize = true;
            Password_Lb.Location = new Point(3, 154);
            Password_Lb.Name = "Password_Lb";
            Password_Lb.Size = new Size(60, 15);
            Password_Lb.TabIndex = 4;
            Password_Lb.Text = "Password:";
            // 
            // User_TxB
            // 
            User_TxB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            User_TxB.Enabled = false;
            User_TxB.Location = new Point(126, 103);
            User_TxB.Name = "User_TxB";
            User_TxB.Size = new Size(168, 23);
            User_TxB.TabIndex = 5;
            User_TxB.TextChanged += Update_Setup_Button;
            // 
            // Password_TxB
            // 
            Password_TxB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Password_TxB.Enabled = false;
            Password_TxB.Location = new Point(126, 150);
            Password_TxB.Name = "Password_TxB";
            Password_TxB.Size = new Size(168, 23);
            Password_TxB.TabIndex = 6;
            Password_TxB.TextChanged += Update_Setup_Button;
            // 
            // Setup_Bt
            // 
            Setup_Bt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Setup_Bt.BackColor = SystemColors.Control;
            Setup_Bt.Enabled = false;
            Setup_Bt.Location = new Point(12, 211);
            Setup_Bt.Name = "Setup_Bt";
            Setup_Bt.Size = new Size(297, 32);
            Setup_Bt.TabIndex = 4;
            Setup_Bt.Text = "Setup";
            Setup_Bt.UseVisualStyleBackColor = false;
            Setup_Bt.Click += Setup_Bt_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 255);
            Controls.Add(Setup_Bt);
            Controls.Add(Infos_LP);
            Name = "Main";
            Text = "Setup EvoGS Repositories";
            Load += Main_Load;
            Infos_LP.ResumeLayout(false);
            Infos_LP.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label Rep_Lb;
        private ComboBox Rep_CB;
        private TableLayoutPanel Infos_LP;
        private Label Drive_Lb;
        private ComboBox Drive_CB;
        private Label User_Lb;
        private Label Password_Lb;
        private TextBox User_TxB;
        private TextBox Password_TxB;
        private Button Setup_Bt;
    }
}