namespace Work_Cache_Esm
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
            this.label_TimeFrom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ItemFrom = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label_StringFrom = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label_WhereFrom = new System.Windows.Forms.Label();
            this.button_Change = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ItemChange = new System.Windows.Forms.TextBox();
            this.textBox_StringSearch = new System.Windows.Forms.TextBox();
            this.textBox_PageSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ItemSearch = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_CACHE = new System.Windows.Forms.Label();
            this.label_OP = new System.Windows.Forms.Label();
            this.textBox_Cache = new System.Windows.Forms.TextBox();
            this.textBox_OP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_TimeFrom
            // 
            this.label_TimeFrom.AutoSize = true;
            this.label_TimeFrom.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TimeFrom.Location = new System.Drawing.Point(104, 121);
            this.label_TimeFrom.Name = "label_TimeFrom";
            this.label_TimeFrom.Size = new System.Drawing.Size(56, 17);
            this.label_TimeFrom.TabIndex = 72;
            this.label_TimeFrom.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(54, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Время";
            // 
            // label_ItemFrom
            // 
            this.label_ItemFrom.AutoSize = true;
            this.label_ItemFrom.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ItemFrom.Location = new System.Drawing.Point(259, 145);
            this.label_ItemFrom.Name = "label_ItemFrom";
            this.label_ItemFrom.Size = new System.Drawing.Size(24, 17);
            this.label_ItemFrom.TabIndex = 70;
            this.label_ItemFrom.Text = "----";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label121.Location = new System.Drawing.Point(190, 145);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(58, 17);
            this.label121.TabIndex = 69;
            this.label121.Text = "Элемент";
            // 
            // label_StringFrom
            // 
            this.label_StringFrom.AutoSize = true;
            this.label_StringFrom.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StringFrom.Location = new System.Drawing.Point(63, 145);
            this.label_StringFrom.Name = "label_StringFrom";
            this.label_StringFrom.Size = new System.Drawing.Size(78, 17);
            this.label_StringFrom.TabIndex = 68;
            this.label_StringFrom.Text = "---- ---- ---- ----";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.Location = new System.Drawing.Point(17, 145);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(49, 17);
            this.label111.TabIndex = 67;
            this.label111.Text = "Строка";
            // 
            // label_WhereFrom
            // 
            this.label_WhereFrom.AutoSize = true;
            this.label_WhereFrom.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WhereFrom.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label_WhereFrom.Location = new System.Drawing.Point(35, 95);
            this.label_WhereFrom.Name = "label_WhereFrom";
            this.label_WhereFrom.Size = new System.Drawing.Size(157, 19);
            this.label_WhereFrom.TabIndex = 66;
            this.label_WhereFrom.Text = "Элемент загружен из ОП";
            this.label_WhereFrom.Click += new System.EventHandler(this.Label_WhereFrom_Click);
            // 
            // button_Change
            // 
            this.button_Change.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Change.Location = new System.Drawing.Point(110, 66);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(66, 26);
            this.button_Change.TabIndex = 65;
            this.button_Change.Text = "Задать";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.Button_Change_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(187, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Элемент";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // textBox_ItemChange
            // 
            this.textBox_ItemChange.Location = new System.Drawing.Point(182, 67);
            this.textBox_ItemChange.Name = "textBox_ItemChange";
            this.textBox_ItemChange.Size = new System.Drawing.Size(66, 20);
            this.textBox_ItemChange.TabIndex = 63;
            // 
            // textBox_StringSearch
            // 
            this.textBox_StringSearch.Location = new System.Drawing.Point(110, 40);
            this.textBox_StringSearch.Name = "textBox_StringSearch";
            this.textBox_StringSearch.Size = new System.Drawing.Size(66, 20);
            this.textBox_StringSearch.TabIndex = 61;
            // 
            // textBox_PageSearch
            // 
            this.textBox_PageSearch.Location = new System.Drawing.Point(38, 41);
            this.textBox_PageSearch.Name = "textBox_PageSearch";
            this.textBox_PageSearch.Size = new System.Drawing.Size(66, 20);
            this.textBox_PageSearch.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(120, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Строка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Сегмент";
            // 
            // textBox_ItemSearch
            // 
            this.textBox_ItemSearch.Location = new System.Drawing.Point(182, 40);
            this.textBox_ItemSearch.Name = "textBox_ItemSearch";
            this.textBox_ItemSearch.Size = new System.Drawing.Size(66, 20);
            this.textBox_ItemSearch.TabIndex = 57;
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Search.Location = new System.Drawing.Point(38, 66);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(66, 26);
            this.button_Search.TabIndex = 56;
            this.button_Search.Text = "Считать";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click_1);
            // 
            // label_CACHE
            // 
            this.label_CACHE.AutoSize = true;
            this.label_CACHE.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CACHE.Location = new System.Drawing.Point(119, 185);
            this.label_CACHE.Name = "label_CACHE";
            this.label_CACHE.Size = new System.Drawing.Size(41, 21);
            this.label_CACHE.TabIndex = 48;
            this.label_CACHE.Text = "Кэш";
            this.label_CACHE.Click += new System.EventHandler(this.Label_CACHE_Click);
            // 
            // label_OP
            // 
            this.label_OP.AutoSize = true;
            this.label_OP.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_OP.Location = new System.Drawing.Point(387, 23);
            this.label_OP.Name = "label_OP";
            this.label_OP.Size = new System.Drawing.Size(30, 21);
            this.label_OP.TabIndex = 47;
            this.label_OP.Text = "ОП\r\n";
            // 
            // textBox_Cache
            // 
            this.textBox_Cache.Location = new System.Drawing.Point(38, 208);
            this.textBox_Cache.Multiline = true;
            this.textBox_Cache.Name = "textBox_Cache";
            this.textBox_Cache.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Cache.Size = new System.Drawing.Size(228, 230);
            this.textBox_Cache.TabIndex = 46;
            // 
            // textBox_OP
            // 
            this.textBox_OP.Location = new System.Drawing.Point(308, 46);
            this.textBox_OP.Multiline = true;
            this.textBox_OP.Name = "textBox_OP";
            this.textBox_OP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_OP.Size = new System.Drawing.Size(204, 392);
            this.textBox_OP.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(524, 452);
            this.Controls.Add(this.label_TimeFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_ItemFrom);
            this.Controls.Add(this.label121);
            this.Controls.Add(this.label_StringFrom);
            this.Controls.Add(this.label111);
            this.Controls.Add(this.label_WhereFrom);
            this.Controls.Add(this.button_Change);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ItemChange);
            this.Controls.Add(this.textBox_StringSearch);
            this.Controls.Add(this.textBox_PageSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ItemSearch);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label_CACHE);
            this.Controls.Add(this.label_OP);
            this.Controls.Add(this.textBox_Cache);
            this.Controls.Add(this.textBox_OP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_TimeFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ItemFrom;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.Label label_StringFrom;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label_WhereFrom;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ItemChange;
        private System.Windows.Forms.TextBox textBox_StringSearch;
        private System.Windows.Forms.TextBox textBox_PageSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ItemSearch;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_CACHE;
        private System.Windows.Forms.Label label_OP;
        private System.Windows.Forms.TextBox textBox_Cache;
        private System.Windows.Forms.TextBox textBox_OP;
    }
}

