
namespace ASSEA
{
     partial class FormNotification
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
               this.Notification_TextBox = new System.Windows.Forms.TextBox();
               this.Later_Button = new System.Windows.Forms.PictureBox();
               this.Yes_Button = new System.Windows.Forms.PictureBox();
               this.No_Button = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.Later_Button)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Yes_Button)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.No_Button)).BeginInit();
               this.SuspendLayout();
               // 
               // Notification_TextBox
               // 
               this.Notification_TextBox.BackColor = System.Drawing.SystemColors.HighlightText;
               this.Notification_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.Notification_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Notification_TextBox.Location = new System.Drawing.Point(82, 57);
               this.Notification_TextBox.Multiline = true;
               this.Notification_TextBox.Name = "Notification_TextBox";
               this.Notification_TextBox.ReadOnly = true;
               this.Notification_TextBox.Size = new System.Drawing.Size(703, 125);
               this.Notification_TextBox.TabIndex = 0;
               this.Notification_TextBox.TabStop = false;
               this.Notification_TextBox.Text = "Notification Text";
               this.Notification_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // Later_Button
               // 
               this.Later_Button.Image = global::ASSEA.Properties.Resources.button_later;
               this.Later_Button.Location = new System.Drawing.Point(358, 202);
               this.Later_Button.Name = "Later_Button";
               this.Later_Button.Size = new System.Drawing.Size(207, 100);
               this.Later_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Later_Button.TabIndex = 3;
               this.Later_Button.TabStop = false;
               this.Later_Button.Click += new System.EventHandler(this.laterButton_OnClick);
               // 
               // Yes_Button
               // 
               this.Yes_Button.Image = global::ASSEA.Properties.Resources.button_yes;
               this.Yes_Button.Location = new System.Drawing.Point(82, 202);
               this.Yes_Button.Name = "Yes_Button";
               this.Yes_Button.Size = new System.Drawing.Size(193, 100);
               this.Yes_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.Yes_Button.TabIndex = 2;
               this.Yes_Button.TabStop = false;
               this.Yes_Button.Click += new System.EventHandler(this.yesButton_OnClick);
               // 
               // No_Button
               // 
               this.No_Button.Image = global::ASSEA.Properties.Resources.button_no;
               this.No_Button.Location = new System.Drawing.Point(647, 202);
               this.No_Button.Name = "No_Button";
               this.No_Button.Size = new System.Drawing.Size(191, 100);
               this.No_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.No_Button.TabIndex = 1;
               this.No_Button.TabStop = false;
               this.No_Button.Click += new System.EventHandler(this.noButton_OnClick);
               // 
               // FormNotification
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.SystemColors.Window;
               this.ClientSize = new System.Drawing.Size(912, 328);
               this.Controls.Add(this.Later_Button);
               this.Controls.Add(this.Yes_Button);
               this.Controls.Add(this.No_Button);
               this.Controls.Add(this.Notification_TextBox);
               this.Location = new System.Drawing.Point(150, 12);
               this.Name = "FormNotification";
               this.ShowIcon = false;
               this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
               this.Text = "Notification";
               ((System.ComponentModel.ISupportInitialize)(this.Later_Button)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Yes_Button)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.No_Button)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.TextBox Notification_TextBox;
          private System.Windows.Forms.PictureBox No_Button;
          private System.Windows.Forms.PictureBox Yes_Button;
          private System.Windows.Forms.PictureBox Later_Button;
     }
}