namespace DetailedView
{
    partial class formDetailed
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.numericAdvance = new System.Windows.Forms.NumericUpDown();
            this.txtType = new System.Windows.Forms.TextBox();
            this.numericRoyality = new System.Windows.Forms.NumericUpDown();
            this.numericSales = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.dateTimeTitle = new System.Windows.Forms.DateTimePicker();
            this.comboPub = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoyality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(432, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(120, 62);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(267, 27);
            this.txtID.TabIndex = 70;
            // 
            // numericAdvance
            // 
            this.numericAdvance.Location = new System.Drawing.Point(490, 217);
            this.numericAdvance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericAdvance.Name = "numericAdvance";
            this.numericAdvance.Size = new System.Drawing.Size(150, 27);
            this.numericAdvance.TabIndex = 69;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(120, 228);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(267, 27);
            this.txtType.TabIndex = 68;
            // 
            // numericRoyality
            // 
            this.numericRoyality.Location = new System.Drawing.Point(490, 114);
            this.numericRoyality.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericRoyality.Name = "numericRoyality";
            this.numericRoyality.Size = new System.Drawing.Size(150, 27);
            this.numericRoyality.TabIndex = 67;
            // 
            // numericSales
            // 
            this.numericSales.Location = new System.Drawing.Point(490, 171);
            this.numericSales.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericSales.Name = "numericSales";
            this.numericSales.Size = new System.Drawing.Size(150, 27);
            this.numericSales.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "ytd_sales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Royalty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Advance";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(49, 231);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 20);
            this.lblType.TabIndex = 62;
            this.lblType.Text = "Type";
            // 
            // numericPrice
            // 
            this.numericPrice.Location = new System.Drawing.Point(492, 60);
            this.numericPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(150, 27);
            this.numericPrice.TabIndex = 61;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(485, 262);
            this.txtNotes.MaxLength = 200;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(279, 75);
            this.txtNotes.TabIndex = 60;
            this.txtNotes.Text = "";
            // 
            // dateTimeTitle
            // 
            this.dateTimeTitle.Location = new System.Drawing.Point(120, 282);
            this.dateTimeTitle.Name = "dateTimeTitle";
            this.dateTimeTitle.Size = new System.Drawing.Size(267, 27);
            this.dateTimeTitle.TabIndex = 59;
            // 
            // comboPub
            // 
            this.comboPub.FormattingEnabled = true;
            this.comboPub.Location = new System.Drawing.Point(121, 171);
            this.comboPub.Name = "comboPub";
            this.comboPub.Size = new System.Drawing.Size(267, 28);
            this.comboPub.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 57;
            this.label8.Text = "Publisher";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 56;
            this.label7.Text = "Pub Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 55;
            this.label6.Text = "Notes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Price";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(50, 116);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 53;
            this.lblTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "ID";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 113);
            this.txtTitle.MaxLength = 80;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(267, 27);
            this.txtTitle.TabIndex = 51;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(303, 362);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.numericAdvance);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.numericRoyality);
            this.Controls.Add(this.numericSales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dateTimeTitle);
            this.Controls.Add(this.comboPub);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoyality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private TextBox txtID;
        private NumericUpDown numericAdvance;
        private TextBox txtType;
        private NumericUpDown numericRoyality;
        private NumericUpDown numericSales;
        private Label label9;
        private Label label4;
        private Label label3;
        private Label lblType;
        private NumericUpDown numericPrice;
        private RichTextBox txtNotes;
        private DateTimePicker dateTimeTitle;
        private ComboBox comboPub;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label lblTitle;
        private Label label2;
        private TextBox txtTitle;
        private Button btnUpdate;
    }
}