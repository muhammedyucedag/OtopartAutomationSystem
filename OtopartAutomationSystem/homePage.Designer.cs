
namespace OtopartAutomationSystem
{
    partial class homePage
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
            this.btnregistrationPage = new System.Windows.Forms.Button();
            this.btnparkingLot = new System.Windows.Forms.Button();
            this.btnparkingexitPage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregistrationPage
            // 
            this.btnregistrationPage.Location = new System.Drawing.Point(12, 12);
            this.btnregistrationPage.Name = "btnregistrationPage";
            this.btnregistrationPage.Size = new System.Drawing.Size(151, 131);
            this.btnregistrationPage.TabIndex = 0;
            this.btnregistrationPage.Text = "Araç Otopark Kayıt Sayfası";
            this.btnregistrationPage.UseVisualStyleBackColor = true;
            this.btnregistrationPage.Click += new System.EventHandler(this.btnregistrationPage_Click);
            // 
            // btnparkingLot
            // 
            this.btnparkingLot.Location = new System.Drawing.Point(169, 12);
            this.btnparkingLot.Name = "btnparkingLot";
            this.btnparkingLot.Size = new System.Drawing.Size(151, 131);
            this.btnparkingLot.TabIndex = 1;
            this.btnparkingLot.Text = "Araç Otopark Yerleri";
            this.btnparkingLot.UseVisualStyleBackColor = true;
            this.btnparkingLot.Click += new System.EventHandler(this.btnparkingLot_Click);
            // 
            // btnparkingexitPage
            // 
            this.btnparkingexitPage.Location = new System.Drawing.Point(12, 149);
            this.btnparkingexitPage.Name = "btnparkingexitPage";
            this.btnparkingexitPage.Size = new System.Drawing.Size(151, 131);
            this.btnparkingexitPage.TabIndex = 2;
            this.btnparkingexitPage.Text = "Araç Otopark Çıkış Sayfası";
            this.btnparkingexitPage.UseVisualStyleBackColor = true;
            this.btnparkingexitPage.Click += new System.EventHandler(this.btnparkingexitPage_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(169, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 131);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 293);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnparkingexitPage);
            this.Controls.Add(this.btnparkingLot);
            this.Controls.Add(this.btnregistrationPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "homePage";
            this.Text = "Otopark Otomasyonu AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistrationPage;
        private System.Windows.Forms.Button btnparkingLot;
        private System.Windows.Forms.Button btnparkingexitPage;
        private System.Windows.Forms.Button btnExit;
    }
}

