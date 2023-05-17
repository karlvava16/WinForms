using System.Drawing;
using System.Windows.Forms;

namespace Battleship
{
    partial class Menu
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SingleplayerButton = new System.Windows.Forms.Button();
            this.MultiplyaerButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SingleplayerButton
            // 
            resources.ApplyResources(this.SingleplayerButton, "SingleplayerButton");
            this.SingleplayerButton.Name = "SingleplayerButton";
            this.SingleplayerButton.UseVisualStyleBackColor = true;
            this.SingleplayerButton.Click += new System.EventHandler(this.SingleplayerButton_Click);
            // 
            // MultiplyaerButton
            // 
            resources.ApplyResources(this.MultiplyaerButton, "MultiplyaerButton");
            this.MultiplyaerButton.Name = "MultiplyaerButton";
            this.MultiplyaerButton.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.MultiplyaerButton);
            this.Controls.Add(this.SingleplayerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingleplayerButton;
        private System.Windows.Forms.Button MultiplyaerButton;
        private System.Windows.Forms.Label Title;
    }
}

