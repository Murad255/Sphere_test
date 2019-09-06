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
            this.T_degreeB = new System.Windows.Forms.TrackBar();
            this.valueY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.degree_canA = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.valueQ3 = new System.Windows.Forms.TextBox();
            this.degree_canC = new System.Windows.Forms.Label();
            this.valueQ2 = new System.Windows.Forms.TextBox();
            this.valueQ4 = new System.Windows.Forms.TextBox();
            this.degree_canB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_degreeB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(10, 281);
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
            this.valueX.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.T_degreeB);
            this.groupBox1.Controls.Add(this.valueY);
            this.groupBox1.Controls.Add(this.bSet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.valueX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(783, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 336);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // T_degreeB
            // 
            this.T_degreeB.Location = new System.Drawing.Point(6, 152);
            this.T_degreeB.Maximum = 180;
            this.T_degreeB.Name = "T_degreeB";
            this.T_degreeB.Size = new System.Drawing.Size(177, 45);
            this.T_degreeB.TabIndex = 6;
            this.T_degreeB.Scroll += new System.EventHandler(this.T_degreeB_Scroll);
            // 
            // valueY
            // 
            this.valueY.Location = new System.Drawing.Point(47, 63);
            this.valueY.Multiline = true;
            this.valueY.Name = "valueY";
            this.valueY.Size = new System.Drawing.Size(143, 38);
            this.valueY.TabIndex = 5;
            this.valueY.Text = "0";
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
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(765, 765);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // degree_canA
            // 
            this.degree_canA.AutoSize = true;
            this.degree_canA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degree_canA.Location = new System.Drawing.Point(6, 36);
            this.degree_canA.Name = "degree_canA";
            this.degree_canA.Size = new System.Drawing.Size(36, 24);
            this.degree_canA.TabIndex = 6;
            this.degree_canA.Text = "q2:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.valueQ3);
            this.groupBox2.Controls.Add(this.degree_canC);
            this.groupBox2.Controls.Add(this.valueQ2);
            this.groupBox2.Controls.Add(this.valueQ4);
            this.groupBox2.Controls.Add(this.degree_canB);
            this.groupBox2.Controls.Add(this.degree_canA);
            this.groupBox2.Location = new System.Drawing.Point(793, 610);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 162);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Углы";
            // 
            // valueQ3
            // 
            this.valueQ3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueQ3.Location = new System.Drawing.Point(71, 66);
            this.valueQ3.Multiline = true;
            this.valueQ3.Name = "valueQ3";
            this.valueQ3.Size = new System.Drawing.Size(90, 31);
            this.valueQ3.TabIndex = 11;
            // 
            // degree_canC
            // 
            this.degree_canC.AutoSize = true;
            this.degree_canC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degree_canC.Location = new System.Drawing.Point(6, 110);
            this.degree_canC.Name = "degree_canC";
            this.degree_canC.Size = new System.Drawing.Size(36, 24);
            this.degree_canC.TabIndex = 10;
            this.degree_canC.Text = "q4:";
            // 
            // valueQ2
            // 
            this.valueQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueQ2.Location = new System.Drawing.Point(71, 29);
            this.valueQ2.Multiline = true;
            this.valueQ2.Name = "valueQ2";
            this.valueQ2.Size = new System.Drawing.Size(90, 31);
            this.valueQ2.TabIndex = 9;
            // 
            // valueQ4
            // 
            this.valueQ4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueQ4.Location = new System.Drawing.Point(71, 103);
            this.valueQ4.Multiline = true;
            this.valueQ4.Name = "valueQ4";
            this.valueQ4.Size = new System.Drawing.Size(90, 31);
            this.valueQ4.TabIndex = 7;
            // 
            // degree_canB
            // 
            this.degree_canB.AutoSize = true;
            this.degree_canB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degree_canB.Location = new System.Drawing.Point(6, 73);
            this.degree_canB.Name = "degree_canB";
            this.degree_canB.Size = new System.Drawing.Size(36, 24);
            this.degree_canB.TabIndex = 8;
            this.degree_canB.Text = "q3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 784);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_degreeB)).EndInit();
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
        private System.Windows.Forms.Label degree_canA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox valueQ3;
        private System.Windows.Forms.Label degree_canC;
        private System.Windows.Forms.TextBox valueQ2;
        private System.Windows.Forms.Label degree_canB;
        private System.Windows.Forms.TextBox valueQ4;
        private System.Windows.Forms.TrackBar T_degreeB;
    }
}

