
namespace CcfoliaDIceAnalyzer
{
    partial class AppWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
            this.ResultForm = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutPutForm = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Disp_CoC6_D100 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Disp_SW_Act2D6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Disp_SG_Roll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultForm
            // 
            this.ResultForm.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResultForm.Location = new System.Drawing.Point(498, 500);
            this.ResultForm.Name = "ResultForm";
            this.ResultForm.Size = new System.Drawing.Size(375, 124);
            this.ResultForm.TabIndex = 0;
            this.ResultForm.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(514, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ココフォリアのロール結果を貼り付ける場所↓";
            // 
            // OutPutForm
            // 
            this.OutPutForm.Font = new System.Drawing.Font("M PLUS 1 Code Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OutPutForm.Location = new System.Drawing.Point(498, 42);
            this.OutPutForm.Name = "OutPutForm";
            this.OutPutForm.ReadOnly = true;
            this.OutPutForm.Size = new System.Drawing.Size(375, 438);
            this.OutPutForm.TabIndex = 2;
            this.OutPutForm.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(675, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "出力↓";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "クトゥルフ";
            // 
            // Disp_CoC6_D100
            // 
            this.Disp_CoC6_D100.Location = new System.Drawing.Point(11, 41);
            this.Disp_CoC6_D100.Name = "Disp_CoC6_D100";
            this.Disp_CoC6_D100.Size = new System.Drawing.Size(97, 23);
            this.Disp_CoC6_D100.TabIndex = 5;
            this.Disp_CoC6_D100.Text = "(6版)1D100";
            this.Disp_CoC6_D100.UseVisualStyleBackColor = true;
            this.Disp_CoC6_D100.Click += new System.EventHandler(this.CoC6_D100);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(495, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 345);
            this.label4.TabIndex = 6;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Disp_SW_Act2D6
            // 
            this.Disp_SW_Act2D6.Location = new System.Drawing.Point(12, 86);
            this.Disp_SW_Act2D6.Name = "Disp_SW_Act2D6";
            this.Disp_SW_Act2D6.Size = new System.Drawing.Size(119, 23);
            this.Disp_SW_Act2D6.TabIndex = 7;
            this.Disp_SW_Act2D6.Text = "(行為判定)2D6";
            this.Disp_SW_Act2D6.UseVisualStyleBackColor = true;
            this.Disp_SW_Act2D6.Click += new System.EventHandler(this.SW_Act2D6);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "SW2.5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "シノビガミ";
            // 
            // Disp_SG_Roll
            // 
            this.Disp_SG_Roll.Location = new System.Drawing.Point(12, 130);
            this.Disp_SG_Roll.Name = "Disp_SG_Roll";
            this.Disp_SG_Roll.Size = new System.Drawing.Size(175, 23);
            this.Disp_SG_Roll.TabIndex = 10;
            this.Disp_SG_Roll.Text = "(行為判定)nSG@s#f>=x";
            this.Disp_SG_Roll.UseVisualStyleBackColor = true;
            this.Disp_SG_Roll.Click += new System.EventHandler(this.SG_Roll);
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 1055);
            this.Controls.Add(this.Disp_SG_Roll);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Disp_SW_Act2D6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Disp_CoC6_D100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OutPutForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResultForm);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "AppWindow";
            this.Text = "ココフォリアのロール結果を集計するアプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResultForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox OutPutForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Disp_CoC6_D100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Disp_SW_Act2D6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Disp_SG_Roll;
    }
}

