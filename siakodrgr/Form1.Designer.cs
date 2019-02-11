namespace siakodrgr
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButVertex = new System.Windows.Forms.Button();
            this.ButEdge = new System.Windows.Forms.Button();
            this.ButClear = new System.Windows.Forms.Button();
            this.ButMethod = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(155, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 468);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // ButVertex
            // 
            this.ButVertex.Location = new System.Drawing.Point(13, 13);
            this.ButVertex.Name = "ButVertex";
            this.ButVertex.Size = new System.Drawing.Size(75, 35);
            this.ButVertex.TabIndex = 2;
            this.ButVertex.Text = "Вершина";
            this.ButVertex.UseVisualStyleBackColor = true;
            this.ButVertex.Click += new System.EventHandler(this.ButVertex_Click);
            // 
            // ButEdge
            // 
            this.ButEdge.Location = new System.Drawing.Point(13, 54);
            this.ButEdge.Name = "ButEdge";
            this.ButEdge.Size = new System.Drawing.Size(75, 35);
            this.ButEdge.TabIndex = 3;
            this.ButEdge.Text = "Ребро";
            this.ButEdge.UseVisualStyleBackColor = true;
            this.ButEdge.Click += new System.EventHandler(this.ButEdge_Click);
            // 
            // ButClear
            // 
            this.ButClear.Location = new System.Drawing.Point(13, 95);
            this.ButClear.Name = "ButClear";
            this.ButClear.Size = new System.Drawing.Size(75, 35);
            this.ButClear.TabIndex = 4;
            this.ButClear.Text = "Очистить";
            this.ButClear.UseVisualStyleBackColor = true;
            this.ButClear.Click += new System.EventHandler(this.ButClear_Click);
            // 
            // ButMethod
            // 
            this.ButMethod.Location = new System.Drawing.Point(13, 445);
            this.ButMethod.Name = "ButMethod";
            this.ButMethod.Size = new System.Drawing.Size(75, 35);
            this.ButMethod.TabIndex = 5;
            this.ButMethod.Text = "Выполнить";
            this.ButMethod.UseVisualStyleBackColor = true;
            this.ButMethod.Click += new System.EventHandler(this.ButMethod_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(506, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(62, 160);
            this.listBox1.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(574, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(62, 160);
            this.listBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(503, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вершины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Длина";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ButMethod);
            this.Controls.Add(this.ButClear);
            this.Controls.Add(this.ButEdge);
            this.Controls.Add(this.ButVertex);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "РГР по теме \"Нахождение обхвата графа\". Кононенко А.И. МО-210";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButVertex;
        private System.Windows.Forms.Button ButEdge;
        private System.Windows.Forms.Button ButClear;
        private System.Windows.Forms.Button ButMethod;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

