namespace Sphere_test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valueX = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valueY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.canA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valueA = new System.Windows.Forms.TextBox();
            this.valueB = new System.Windows.Forms.TextBox();
            this.canB = new System.Windows.Forms.Label();
            this.valueC = new System.Windows.Forms.TextBox();
            this.canC = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(9, 133);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(181, 49);
            this.bSet.TabIndex = 0;
            this.bSet.Text = "Применить значение";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X =";
            // 
            // valueX
            // 
            this.valueX.Location = new System.Drawing.Point(47, 19);
            this.valueX.Multiline = true;
            this.valueX.Name = "valueX";
            this.valueX.Size = new System.Drawing.Size(143, 38);
            this.valueX.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valueY);
            this.groupBox1.Controls.Add(this.bSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.valueX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(560, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // valueY
            // 
            this.valueY.Location = new System.Drawing.Point(47, 63);
            this.valueY.Multiline = true;
            this.valueY.Name = "valueY";
            this.valueY.Size = new System.Drawing.Size(143, 38);
            this.valueY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y =";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 505);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // canA
            // 
            this.canA.AutoSize = true;
            this.canA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canA.Location = new System.Drawing.Point(6, 36);
            this.canA.Name = "canA";
            this.canA.Size = new System.Drawing.Size(59, 24);
            this.canA.TabIndex = 6;
            this.canA.Text = "canA:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valueC);
            this.groupBox2.Controls.Add(this.canC);
            this.groupBox2.Controls.Add(this.valueB);
            this.groupBox2.Controls.Add(this.canB);
            this.groupBox2.Controls.Add(this.valueA);
            this.groupBox2.Controls.Add(this.canA);
            this.groupBox2.Location = new System.Drawing.Point(560, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 162);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Углы";
            // 
            // valueA
            // 
            this.valueA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueA.Location = new System.Drawing.Point(71, 36);
            this.valueA.Multiline = true;
            this.valueA.Name = "valueA";
            this.valueA.Size = new System.Drawing.Size(90, 31);
            this.valueA.TabIndex = 7;
            // 
            // valueB
            // 
            this.valueB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueB.Location = new System.Drawing.Point(71, 73);
            this.valueB.Multiline = true;
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(90, 31);
            this.valueB.TabIndex = 9;
            // 
            // canB
            // 
            this.canB.AutoSize = true;
            this.canB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canB.Location = new System.Drawing.Point(6, 73);
            this.canB.Name = "canB";
            this.canB.Size = new System.Drawing.Size(58, 24);
            this.canB.TabIndex = 8;
            this.canB.Text = "canB:";
            // 
            // valueC
            // 
            this.valueC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueC.Location = new System.Drawing.Point(71, 110);
            this.valueC.Multiline = true;
            this.valueC.Name = "valueC";
            this.valueC.Size = new System.Drawing.Size(90, 31);
            this.valueC.TabIndex = 11;
            // 
            // canC
            // 
            this.canC.AutoSize = true;
            this.canC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canC.Location = new System.Drawing.Point(6, 110);
            this.canC.Name = "canC";
            this.canC.Size = new System.Drawing.Size(59, 24);
            this.canC.TabIndex = 10;
            this.canC.Text = "canC:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox valueY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label canA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valueC;
        private System.Windows.Forms.Label canC;
        private System.Windows.Forms.TextBox valueB;
        private System.Windows.Forms.Label canB;
        private System.Windows.Forms.TextBox valueA;
    }
}

